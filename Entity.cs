﻿using System;
using System.Collections.Generic;
using System.Numerics;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoStorm
{
    abstract class Entity
    {
        public Vector2 Position;
        public float Rotation ;
        public float CollisionRadius ;
        public bool IsDead;

        abstract public void Update(GameInputs inputs, GameData data);
        abstract public void Render(Graphics graphics);
    }
}
