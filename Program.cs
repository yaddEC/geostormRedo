using Raylib_cs;

    namespace ImGuiDemo
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
                    //----------------------------------------------------------------------------------

                    // Draw
                    //----------------------------------------------------------------------------------
                    Raylib.BeginDrawing();
                    Raylib.ClearBackground(Color.BLACK);

                    Raylib.DrawText("Hello, world!", screenWidth/2, screenHeight/2, 20, Color.BLACK);

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