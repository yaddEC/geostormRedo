using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoStorm
{


    public interface GameEngine : IEventListener
    {
        public void HandleEvents(IEnumerable<Event> events, GameData data)
        {
            foreach (Event e in events)
            {
                switch (e)
                {
                    case BulletShootEvent bulletShootEvent:
                        break;
                }
            }
        }

    }

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
