using System;
using Raylib_cs;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoStorm
{


   

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

}
