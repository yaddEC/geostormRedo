using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoStorm
{
    class GameData
    {
        private List<Entity> entities;
        private List<Enemy> enemies;
        private List<Bullet> bullets;
        private List<BlackHoles> blackHoles;
        private List<Enemy> enemiesAdded;
        private List<Bullet> bulletsAdded;
        private List<BlackHoles> blackHolesAdded;
        public IEnumerable<Entity> Entities { get { return entities; } }
        public IEnumerable<Enemy> Enemies { get { return enemies; } }
        public IEnumerable<Bullet> Bullets { get { return bullets; } }
        public IEnumerable<BlackHoles> BlackHoles { get { return blackHoles; } }


        void AddEnemyDelayed(Enemy enemy)
        {
            enemiesAdded.Add(enemy);
        }

        void AddBulletsDelayed(Bullet bullet)
        {
            bulletsAdded.Add(bullet);
        }

        void AddBlackHolesDelayed(BlackHoles blackHole)
        {
            blackHolesAdded.Add(blackHole);
        }

        void Update()
        {
            entities.AddRange(enemiesAdded);
            enemies.AddRange(enemiesAdded);
            entities.AddRange(bulletsAdded);
            bullets.AddRange(bulletsAdded);
            entities.AddRange(blackHolesAdded);
            blackHoles.AddRange(blackHolesAdded);
            enemiesAdded.Clear();
            bulletsAdded.Clear();
            blackHolesAdded.Clear();
            entities.RemoveAll(s => s.isDead);
            enemies.RemoveAll(s => s.isDead);
            bullets.RemoveAll(s => s.isDead);
            blackHoles.RemoveAll(s => s.isDead);

            
        }


    }
}
