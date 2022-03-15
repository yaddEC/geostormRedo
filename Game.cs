using System;
using Raylib_cs;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using static System.MathF;


namespace GeoStorm
{
   public class Game
    {
        public  GameData data = new GameData();
        Random random = new();
        public int score = 0;

        List<IEventListener> eventListeners = new List<IEventListener>();
       
        public Game(GameInputs inputs)
        {
            data.Player.Position = inputs.ScreenSize / 2.0f;
            for (int i = 0; i < 10; i++)
            {
                Enemy enemy = new();
                enemy.Position = new Vector2(random.Next(17, (int)inputs.ScreenSize.X), random.Next(17, (int)inputs.ScreenSize.Y));
                if (enemy.Position == data.Player.Position)
                    enemy.Position = new Vector2(random.Next(17, (int)inputs.ScreenSize.X), random.Next(17, (int)inputs.ScreenSize.Y));
                data.AddEnemy(enemy);
            }
            for (int i = 0; i < 3; i++)
            {
                LevelUp level = new();
                level.Position = new Vector2(random.Next(5, (int)inputs.ScreenSize.X), random.Next(5, (int)inputs.ScreenSize.Y));
                data.AddLevel(level);
            }

            
        }


        public void Update(GameInputs inputs)
        {
            List<Event> events = new();

            for (int i = 0; i < data.Entities.Count; i++)
            {
                data.Entities[i].Update(inputs, data);
            }
            foreach (Enemy enemy in data.Enemies)
            {
                foreach(Bullet bull in data.Bullets)
                {
                    if(Raylib.CheckCollisionCircles(bull.Position,bull.CollisionRadius, enemy.Position, enemy.CollisionRadius))
                    {
                        bull.IsDead = true;
                        enemy.IsDead = true;
                        events.Add(new EnemyKilled());
                        score += 10;
                    }
                } 

                if (Raylib.CheckCollisionCircles(data.Player.Position, data.Player.CollisionRadius, enemy.Position, enemy.CollisionRadius))
                {
                    data.Player.Life -= 1;
                    enemy.IsDead = true;
                }
            }

            foreach(LevelUp level in data.LevelUps)
            {
                if(Raylib.CheckCollisionCircles(data.Player.Position,data.Player.CollisionRadius,level.Position,level.CollisionRadius))
                {
                    level.IsDead = true;
                    data.Player.weapon.IncreaseLevel();
                }
            }

            data.Synchronize();

            foreach (IEventListener eventListener in eventListeners)
                eventListener.HandleEvent(events, data);
        }

        public void AddEventListener(IEventListener listener)
        {
            eventListeners.Add(listener);
        }

        public void Render(Graphics graphics)
        {
            foreach (Entity entity in data.Entities)
                entity.Render(graphics);
        }
    }
}
