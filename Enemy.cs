﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using static System.MathF;

namespace GeoStorm
{
    
   public class Enemy : Entity
    {
        Random random = new();
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
            

        }
        override public void Render(Graphics graphics)
        {
            graphics.DrawGrunt(Position);
        }
    }
}
