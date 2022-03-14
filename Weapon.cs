using ImGuiNET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoStorm
{
    class Weapon
    {
        float timer = 0.0f;
        public void Update(GameInputs inputs, GameData data )
        {
            if(timer > 0)
             timer -= inputs.Deltatime;


            if (inputs.Shoot && timer <= 0.0f)
            {
                Bullet b = new Bullet();
                b.Position = data.Player.Position;
                b.SetRotation(data.Player.Rotation);
                data.AddBullet(b);

                timer += 0.07f;
            }
        }
    }
}
    