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

        Vector2[] PlayerShape = new Vector2[8];
        Vector2[] BulletShape = new Vector2[4];
        Vector2[] GruntShape = new Vector2[4];
        public void LoadPlayerShape()
        {
            PlayerShape[0] = new Vector2(-1.0f, 0.0f) * 20;
            PlayerShape[1] = new Vector2(-0.4f, 0.8f) * 20;
            PlayerShape[2] = new Vector2(0.6f, 0.3f) * 20;
            PlayerShape[3] = new Vector2(-0.2f, 0.55f) * 20;
            PlayerShape[4] = new Vector2(-0.5f, 0.0f) * 20;
            PlayerShape[5] = new Vector2(-0.2f, -0.55f) * 20;
            PlayerShape[6] = new Vector2(0.6f, -0.3f) * 20;
            PlayerShape[7] = new Vector2(- 0.4f, -0.8f )* 20 ;
        }

        public void LoadBulletShape()
        {
            BulletShape[0] = new Vector2(-0.3f, 0.0f) * 15;
            BulletShape[1] = new Vector2(-0.1f, 0.2f) * 15;
            BulletShape[2] = new Vector2(0.8f, 0.0f) * 15;
            BulletShape[3] = new Vector2(BulletShape[1].X, -BulletShape[1].Y) * 15;
        }

        public void LoadGruntShape()
        {
            GruntShape[0] = new Vector2(-1.0f, 0.0f) * 18;
            GruntShape[1] = new Vector2(-0.0f, -1.0f) * 18;
            GruntShape[2] = new Vector2(1.0f, 0.0f) * 18;
            GruntShape[3] = new Vector2(-0.0f, 1.0f) * 18;
        }



        public Graphics()
        {

        }

        public void DrawPlayer(Vector2 pos)
        {
            LoadPlayerShape();
            for(int i = 0;i < PlayerShape.Length ; i++)
            {
                Raylib.DrawLine((int)PlayerShape[i].X+(int)pos.X , (int)PlayerShape[i].Y+ (int)pos.Y, (int)PlayerShape[(i+1)%PlayerShape.Length].X+(int)pos.X, (int)PlayerShape[(i + 1) % PlayerShape.Length].Y+ (int)pos.Y, Color.BLACK);
            }
        }

        public void DrawBullet()
        {

        }
        public void DrawEnemy()
        {
            LoadGruntShape();
            for(int i = 0; i<GruntShape.Length-1;i++)
            {
                Raylib.DrawLine((int)GruntShape[i].X, (int)GruntShape[i].Y, (int)GruntShape[i + 1].X, (int)GruntShape[i + 1].Y, Color.BLUE);
            }
        }

        public void Update()
        {

        }
    }
}
