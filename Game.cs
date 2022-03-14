using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using static System.MathF;


namespace GeoStorm
{
    class Game
    {
        GameData data = new GameData();
        Random random = new();


        public Game(GameInputs inputs)
        {
            data.Player.Position = inputs.ScreenSize / 2.0f;
            for(int i = 0; i < 10; i++)
            {
                Enemy enemy = new();
                enemy.Position = new Vector2(random.Next(17, (int)inputs.ScreenSize.X), random.Next(17, (int)inputs.ScreenSize.Y));
                if(enemy.Position == data.Player.Position)
                    enemy.Position = new Vector2(random.Next(17, (int)inputs.ScreenSize.X), random.Next(17, (int)inputs.ScreenSize.Y));
                data.AddEnemy(enemy);
            }
           // Ajoute 10 enemies
        }

        public void Update(GameInputs inputs)
        {
            for (int i = 0; i < data.Entities.Count; i++)
                data.Entities[i].Update(inputs, data);

            data.Synchronize();
        }

        public void Render(Graphics graphics)
        {
            foreach (Entity entity in data.Entities)
                entity.Render(graphics);
        }
    }
}
