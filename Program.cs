using Raylib_cs;
using System.Numerics;

namespace GeoStorm
{
    class Program
    {
        static unsafe void Main(string[] args)
        {
            const int screenWidth = 1280;
            const int screenHeight = 720;

            // Initialization
            //--------------------------------------------------------------------------------------
            Raylib.SetConfigFlags(ConfigFlags.FLAG_MSAA_4X_HINT | ConfigFlags.FLAG_VSYNC_HINT | ConfigFlags.FLAG_WINDOW_RESIZABLE);
            Raylib.InitWindow(screenWidth, screenHeight, "ImGui demo");
            Raylib.SetTargetFPS(60);

            Raylib.InitAudioDevice();

            ImguiController controller = new ImguiController();
            //Camera2D camera;

            GameInputs gameInputs = new GameInputs();
            gameInputs.ScreenSize.X = Raylib.GetScreenWidth();
            gameInputs.ScreenSize.Y = Raylib.GetScreenHeight();
            

            Graphics graphics = new Graphics();
            Game game = new Game(gameInputs);
            SoundEngine sound = new SoundEngine();
            sound.Load();
            game.AddEventListener(sound);


            controller.Load(screenWidth, screenHeight);
            //--------------------------------------------------------------------------------------

            // Main game loop
            while (!Raylib.WindowShouldClose())
            {

                // Update
                //----------------------------------------------------------------------------------
                float dt = Raylib.GetFrameTime();
                // Feed the input events to our ImGui controller, which passes them through to ImGui.
                controller.Update(dt);
          
                // Get game inputs
                {
                    gameInputs.Deltatime = dt;
                    gameInputs.MoveAxis = new Vector2();
                    gameInputs.Shoot = false;
                    gameInputs.ShootTarget = Raylib.GetMousePosition();
                    if (Raylib.IsMouseButtonDown(MouseButton.MOUSE_BUTTON_LEFT))
                    {
                        gameInputs.Shoot = true;
                    }
                    if (Raylib.IsKeyDown(KeyboardKey.KEY_D))
                    {
                        gameInputs.MoveAxis.X += 1;
                    }
                    if (Raylib.IsKeyDown(KeyboardKey.KEY_A))
                    {
                        gameInputs.MoveAxis.X -= 1;
                    }
                    if (Raylib.IsKeyDown(KeyboardKey.KEY_S))
                    {
                        gameInputs.MoveAxis.Y += 1;
                    }
                    if (Raylib.IsKeyDown(KeyboardKey.KEY_W))
                    {
                        gameInputs.MoveAxis.Y -= 1;
                    }
<<<<<<< HEAD
                    if (Raylib.IsKeyPressed(KeyboardKey.KEY_F))
                    {
                        Raylib.ToggleFullscreen();
                    }
=======

>>>>>>> 032f8b7 (add enemy fonction)
                }
                game.Update(gameInputs);

                //----------------------------------------------------------------------------------

                // Draw
                //----------------------------------------------------------------------------------
                
                Raylib.BeginDrawing();
                
                Raylib.ClearBackground(Color.BLACK);
                if (game.data.Enemies.Count == 0)
                    Raylib.DrawText("you win", screenHeight / 2, screenWidth / 5, 200, Color.GOLD);
                if (game.data.Player.IsDead)
                   Raylib.DrawText("GAME OVER", screenHeight / 15, screenWidth / 5, 200, Color.RED);
                if (!game.data.Player.IsDead)
                {
                    Raylib.DrawText($"Score :{game.score}", 0, 0, 20, Color.WHITE);
                    Raylib.DrawText($"Life :{game.data.Player.Life}", 0, 20, 20, Color.WHITE);
                    Raylib.DrawText($"weapon level :{game.data.Player.weapon.level}", 0, 35, 20, Color.WHITE);
                    game.Render(graphics);
                    controller.Draw();
                }


                Raylib.EndDrawing();
                //----------------------------------------------------------------------------------
            }

            // De-Initialization
            //--------------------------------------------------------------------------------------
            controller.Dispose();
            Raylib.CloseAudioDevice();
            Raylib.CloseWindow();
            //--------------------------------------------------------------------------------------
        }
    }
}