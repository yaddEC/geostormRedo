using Raylib_cs;

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

                gameInputs.ScreenSize.X = Raylib.GetScreenWidth();
                gameInputs.ScreenSize.Y = Raylib.GetScreenHeight();
                gameInputs.Deltatime = dt;

                // Feed the input events to our ImGui controller, which passes them through to ImGui.
                controller.Update(dt);
                game.Update(gameInputs);

                //----------------------------------------------------------------------------------

                // Draw
                //----------------------------------------------------------------------------------
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.LIGHTGRAY);

                //Raylib.DrawTriangle()

                game.Draw(graphics);
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