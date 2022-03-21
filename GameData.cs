using System;
using System.Collections.Generic;
using Raylib_cs;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoStorm
{
    public class GameData
    {
        public Player Player = new();
        public List<Entity> Entities = new();
        public List<Enemy> Enemies = new();
        public List<Bullet> Bullets = new();
        public List<BlackHoles> BlackHoles = new();
<<<<<<< HEAD
        public List<LevelUp> LevelUps = new();
        
=======
        public List<Event> Events = new();
>>>>>>> 032f8b7 (add enemy fonction)

        
        
        
       

        public GameData()
        {
            Entities.Add(Player);
        }


        public void AddBullet(Bullet bullet)
        {
            Bullets.Add(bullet);
            Entities.Add(bullet);
        }

        public void AddEnemy(Enemy enemy)
        {
            Enemies.Add(enemy);
            Entities.Add(enemy);
        }
        public void AddLevel(LevelUp level)
        {
            LevelUps.Add(level);
            Entities.Add(level);
        }
        public void Synchronize()
        {

            Entities.RemoveAll(s => s.IsDead);
            Enemies.RemoveAll(s => s.IsDead);
            LevelUps.RemoveAll(s => s.IsDead);
            Bullets.RemoveAll(s => s.IsDead);
            BlackHoles.RemoveAll(s => s.IsDead);
        }
    }
}
