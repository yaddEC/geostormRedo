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
                    if (Raylib.IsKeyPressed(KeyboardKey.KEY_F))
                    {
                        Raylib.ToggleFullscreen();
                    }
                }
                game.Update(gameInputs);

                //----------------------------------------------------------------------------------

                // Draw
                //----------------------------------------------------------------------------------
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.BLACK);

                game.Render(graphics);
                controller.Draw();

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