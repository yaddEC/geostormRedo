using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoStorm
{
    public interface IEventListener
    {
        public void HandleEvent(List<Event> events, GameData data);
        
    }
    public class Event
    {

    }
    public class EnemyKilled : Event
    {
        public Enemy Enemy;
        public Bullet Bullet; 
    }
    
}
