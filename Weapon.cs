using ImGuiNET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoStorm
{
   public  class Weapon
    {
        public float timer = 0.0f;
        public void Update(GameInputs inputs, GameData data, List<Event> Events)
        {
            if(timer > 0)
             timer -= inputs.Deltatime;


            if (inputs.Shoot && timer <= 0.0f)
            {
                Bullet b = new Bullet(data.Player);
                data.AddBullet(b);
                timer += 0.07f;

                BulletShootEvent shot = new BulletShootEvent();
                Events.Add(shot);
               
            }
        }
    }
}
    