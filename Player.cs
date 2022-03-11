using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Raylib_cs;
using System.Numerics;

namespace GeoStorm
{
    class Player : Entity
    {



        public int Life;
        

        public Vector2 Position;

        private float Rotation;
        private float Speed = 3.5f;


        public void Update(GameInputs inputs)
        {
            
            Position.X += inputs.MoveAxis.X*Speed;
            Position.Y += inputs.MoveAxis.Y*Speed;
            float dot = 0 * inputs.ShootTarget.X + 0 * inputs.ShootTarget.Y;
            float det = 0 * inputs.ShootTarget.Y - 0 * inputs.ShootTarget.X;
            rotation =(float) Math.Atan2(det, dot);
            Position = rotateVec(Position, inputs.ShootTarget, rotation);
        }

    }
}
