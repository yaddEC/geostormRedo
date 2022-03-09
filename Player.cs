using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Raylib_cs;
using System.Numerics;

namespace GeoStorm
{
    class Player
    {
        public int Life;

        public Vector2 Position;
        
        private float Rotation;

        void Draw(Graphics graphics)
        {
            graphics.DrawPlayer(Position, Rotation);
        }

        void Update(GameInputs inputs)
        {
            
        }

    }
}
