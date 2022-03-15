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
        float timer = 0.0f;
        float duration = 0.3f;
        public int nbBullets = 1;
        public  int level = 1;

        public void IncreaseLevel()
        {
            level += 1;
            if (level == 2)
                duration = 0.1f;
            if (level == 3)
                duration = 0.05f;
                nbBullets = 3;
        }


        public void Update(GameInputs inputs, GameData data )
        {
            if(timer > 0)
             timer -= inputs.Deltatime;

            if (inputs.Shoot && timer <= 0.0f)
            {
                for (int i = 0; i < nbBullets; ++i)
                {
                    Bullet b = new Bullet(data.Player);
                    data.AddBullet(b);
                }

                timer += duration;
                
            }
        }
    }
}
    