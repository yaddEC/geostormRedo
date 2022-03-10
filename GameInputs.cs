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
        public Vector2  MoveAxis;
        public Vector2  ShootAxis;
        public Vector2  ShootTarget;

        public float    Deltatime;
        public bool     shoot;
        public GameInputs()
        {
           
        }

        public void Update()
        {

        }


    }
}
