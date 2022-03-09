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
            data.Player.Position = inputs.ScreenSize / 2.0f;
        }
        void AddEvent()
        {

        }

        public void Update(GameInputs inputs)
        {
            data.Player.Update(inputs); // Position += inputs.MoveAxis * speed;
        }

        public void Render()
        {

        }

    }
}
