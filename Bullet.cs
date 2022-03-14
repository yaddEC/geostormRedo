using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using static System.MathF;

namespace GeoStorm
{
    class Bullet : Entity
    {
        float speed = 800.0f;
        Vector2 Velocity = new();

        public void SetRotation(float rotation)
        {
            Rotation = rotation;

            Velocity = new Vector2(Cos(rotation),Sin(rotation))*speed;

        }

        override public void Update(GameInputs inputs, GameData data)
        {
            Vector2 to = Vector2.Normalize(inputs.ShootTarget - Position);
            Rotation = Atan2(to.Y, to.X);

            Position += Velocity * inputs.Deltatime;
            if (Position.X >= inputs.ScreenSize.X || Position.Y >= inputs.ScreenSize.Y)
                IsDead = true;
        }
        override public void Render(Graphics graphics)
        {
            graphics.DrawBullet(Position, Rotation);
        }
    }
}
