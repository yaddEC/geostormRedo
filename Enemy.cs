using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using static System.MathF;

namespace GeoStorm
{
    
    class Enemy : Entity
    {
        Random random = new();
        float speed = 200;
        Vector2 Velocity = new Vector2();



        override public void Update(GameInputs inputs, GameData data)
        {
            Vector2 dist = Vector2.Normalize(Position - data.Player.Position);

            Position -= dist * inputs.Deltatime *speed;
            

        }
        override public void Render(Graphics graphics)
        {
            graphics.DrawEnemy(Position);
        }
    }
}
