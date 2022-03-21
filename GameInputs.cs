using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using Raylib_cs;

namespace GeoStorm
{
<<<<<<< HEAD
    public class GameInputs
=======
   public  class GameInputs
>>>>>>> 032f8b7 (add enemy fonction)
    {


        public Vector2  ScreenSize;  
        public Vector2  MoveAxis = new Vector2(0,0);
        public Vector2  ShootAxis  ;
        public Vector2  ShootTarget = new();

        public float    Deltatime;
        public bool     Shoot = false;
        public GameInputs()
        {
            
        }


        


    }
}
