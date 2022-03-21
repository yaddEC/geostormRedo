using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using static System.MathF;

namespace GeoStorm
{
    
<<<<<<< HEAD
   public class Enemy : Entity
=======
    public   class Enemy : Entity
>>>>>>> 032f8b7 (add enemy fonction)
    {
        float speed = 200;
        Vector2 Velocity = new Vector2();

        public Enemy()
        {
            CollisionRadius = 10;
        }

        override public void Update(GameInputs inputs, GameData data, List<Event> Events)
        {
            Vector2 dist = Vector2.Normalize(Position - data.Player.Position);

            Position -= dist * inputs.Deltatime *speed;

            if (Position.X >= inputs.ScreenSize.X)
            {
                Position.X = inputs.ScreenSize.X;
            }
            if (Position.Y >= inputs.ScreenSize.Y)
            {
                Position.Y = inputs.ScreenSize.Y;
            }
            if (Position.X <= 0)
            {
                Position.X = 0;
            }
            if (Position.Y <= 0)
            {
                Position.Y = 0;
            }

        }
        override public void Render(Graphics graphics)
        {
            graphics.DrawGrunt(Position);
        }
    }
}
