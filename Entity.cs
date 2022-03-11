using System;
using System.Collections.Generic;
using System.Numerics;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoStorm
{


    class Entity
    {
        public Vector2 position;
        public float rotation = 0;
        public float collisionRadius;
        public bool isDead;

         public Vector2 rotateVec(Vector2 tor, Vector2 origin, float angleDeg)
        {
            Vector2 tor2;
            double angle = angleDeg * Math.PI / 180;
            tor2.X = (float)(Math.Cos(angle) * (tor.X - origin.X) - Math.Sin(angle) * (tor.Y - origin.Y) + origin.X);
            tor2.Y = (float)(Math.Sin(angle) * (tor.X - origin.X) + Math.Cos(angle) * (tor.Y - origin.Y) + origin.Y);

            return tor2;
        }


    }
}
