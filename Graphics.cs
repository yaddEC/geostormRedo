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
            PlayerShape[7] = new Vector2(-0.4f, -0.8f) * 20;
        }

        public void LoadBulletShape()
        {
            BulletShape[0] = new Vector2(-0.3f, 0.0f) * 15;
            BulletShape[1] = new Vector2(-0.1f, 0.2f) * 15 ;
            BulletShape[2] = new Vector2(0.8f, 0.0f) * 15 ;
            BulletShape[3] = new Vector2(-0.1f, -0.2f) * 15 ;
        }

        public void LoadGruntShape()
        {
            GruntShape[0] = new Vector2(-1.0f, 0.0f) * 18;
            GruntShape[1] = new Vector2(-0.0f, -1.0f) * 18 ;
            GruntShape[2] = new Vector2(1.0f, 0.0f) * 18 ;
            GruntShape[3] = new Vector2(-0.0f, 1.0f) * 18 ;
        }



        public Graphics()
        {
            LoadPlayerShape();
            LoadBulletShape();
            LoadGruntShape();
        }

        public void DrawPlayer(Vector2 pos, float rotation)
        {
            Matrix3x2 transform = Matrix3x2.CreateRotation(rotation) * Matrix3x2.CreateTranslation(pos);
            for (int i = 0; i < PlayerShape.Length; i++)
            {
                Vector2 start = PlayerShape[i];
                Vector2 end   = PlayerShape[(i+1) % PlayerShape.Length];

                start = Vector2.Transform(start, transform);
                end   = Vector2.Transform(end,   transform);

                Raylib.DrawLineV(start, end, Color.WHITE);
            }
        }

        public void DrawBullet(Vector2 pos, float rotation)
        {

            Matrix3x2 transform = Matrix3x2.CreateRotation(rotation) * Matrix3x2.CreateTranslation(pos);
            for (int i = 0; i < BulletShape.Length; i++)
            {
                Vector2 start = BulletShape[i];
                Vector2 end = BulletShape[(i + 1) % BulletShape.Length];

                start = Vector2.Transform(start, transform);
                end = Vector2.Transform(end, transform);

                Raylib.DrawLineV(start, end, Color.WHITE);
            }
        }
        public void DrawEnemy(Vector2 pos)
        {
            Matrix3x2 transform = Matrix3x2.CreateTranslation(pos);
            for (int i = 0; i<GruntShape.Length;i++)
            {
                Vector2 start = GruntShape[i];
                Vector2 end = GruntShape[(i + 1) % GruntShape.Length];

                start = Vector2.Transform(start, transform);
                end = Vector2.Transform(end, transform);

                Raylib.DrawLineV(start, end, Color.BLUE);
            }
        }
    }
}
