﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using static System.MathF;

namespace GeoStorm
{
     public class Bullet : Entity
    {
        Player player = new();
        float speed = 800.0f;
        Vector2 Velocity = new();

        public Bullet(Player player)
        {
            CollisionRadius = 1;
            Position = player.Position;
            
            Rotation = player.Rotation;
            
            SetRotation(Rotation);
        }


        public void SetRotation(float rotation)
        {
            Rotation = rotation;

            Velocity = new Vector2(Cos(rotation), Sin(rotation)) * speed;

        }

        override public void Update(GameInputs inputs, GameData data)
        {
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
