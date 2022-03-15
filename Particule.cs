using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Raylib_cs;

namespace GeoStorm
{
    public interface IEventListener
    {
        public void HandleEvent(IEnumerable<Event> events, GameData data);


    }
    public class SoundEngine : IEventListener
    {
       Sound shoot;
        public void Load()
        {
            shoot = Raylib.LoadSound("resources/shoot.mp3");
        }
        public void HandleEvent(IEnumerable<Event> events, GameData data)
        {
            foreach (Event e in events)
            {
                switch (e)
                {
                    case BulletShootEvent bulletShootEvent:
                        Raylib.PlaySound(shoot);

                        break;
                }
            }
        }

     
    }
}
