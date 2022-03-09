using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Raylib_cs;

namespace GeoStorm
{
    class Graphics
    {
        public Graphics()
        {

        }

        public void DrawPlayer(Vector2 pos, float rotation)
        {
            Raylib.DrawPoly(pos, 8, 30, rotation, Color.RED);
        }

        public void Update()
        {

        }
    }
}
