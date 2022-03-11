using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using Raylib_cs;

namespace GeoStorm
{
    class GameInputs
    {
        public Vector2  ScreenSize;  
        public Vector2  MoveAxis = new Vector2 ( 0, 0 );
        public Vector2  ShootAxis;
        public Vector2  ShootTarget;

        public float    Deltatime;
        public bool     shoot;
        public GameInputs()
        {
           
        }

        public void Update()
        {
            ShootTarget = Raylib.GetMousePosition();
            
            if (Raylib.IsKeyDown(KeyboardKey.KEY_W))
            {
                MoveAxis.Y=-1;
              
            }
            else if (Raylib.IsKeyDown(KeyboardKey.KEY_S))
            {
                MoveAxis.Y=1;
            }
            else
            {
                MoveAxis.Y = 0;
            }
            if (Raylib.IsKeyDown(KeyboardKey.KEY_A))
            {
                MoveAxis.X=-1;
            }
            else if (Raylib.IsKeyDown(KeyboardKey.KEY_D))
            {
                MoveAxis.X=1;
            }
            else
            {
                MoveAxis.X = 0;
            }

        }


    }
}
