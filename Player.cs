using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using static System.MathF;

namespace GeoStorm
{
    public class Player : Entity
    {
        public Weapon weapon = new();
        public int Life = 3;
        public float Speed = 350.0f;

        public Player()
        {
            CollisionRadius = 15;
        }

        public override void Update(GameInputs inputs, GameData data)
        {
            Vector2 to = Vector2.Normalize(inputs.ShootTarget - Position);
            Rotation = Atan2(to.Y, to.X);

            Position += inputs.MoveAxis * Speed * inputs.Deltatime;

            if (Position.X >= inputs.ScreenSize.X)
            {
                Position.X = inputs.ScreenSize.X;
            }
            if (Position.Y >= inputs.ScreenSize.Y)
            {
                Position.Y = inputs.ScreenSize.Y ;
            }
            if (Position.X <= 0)
            {
                Position.X = 0;
            }
            if (Position.Y <= 0)
            {
                Position.Y = 0;
            }

            if(Life == 0)
                IsDead = true;
            weapon.Update(inputs, data);

        }

        public override void Render(Graphics graphics)
        {
            graphics.DrawPlayer(Position, Rotation);
        }

    }
}

 