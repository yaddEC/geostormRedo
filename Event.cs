using System;
<<<<<<< HEAD
using Raylib_cs;
=======
>>>>>>> 032f8b7 (add enemy fonction)
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoStorm
{
<<<<<<< HEAD


   

    public class Event
    {

    }
    public class EnemyKilled : Event
    {
        public Enemy Enemy;
        public Bullet Bullet; 
    }

    public class BulletShootEvent : Event
    {
        
    }

=======
   public abstract class Event
    {
        
    }
    public class EnemyKill : Event
    {
        public Enemy Enemy
        {
            get; set;
        }
        public Bullet Bullet
        {
            get; set;
        }

        public EnemyKill(in Enemy enemy, in Bullet bullet)
        { 
            Enemy = enemy;
            Bullet = bullet;
        }
    }
>>>>>>> 032f8b7 (add enemy fonction)
}
