using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoStorm
{
    class Game
    {
        GameData data = new GameData();
        
        public Game(GameInputs inputs)
        {

          data.player.Position = inputs.ScreenSize / 2.0f;
        }
        void AddEvent()
        {

        }

        public void Draw(Graphics graphics)
        {
            graphics.DrawPlayer(data.player.Position);
            graphics.DrawEnemy();
        }

        public void Update(GameInputs inputs)
        {
           data.player.Update(inputs); 
           // Position += inputs.MoveAxis * speed;
           
        }

        public void Render()
        {

        }

    }
}
