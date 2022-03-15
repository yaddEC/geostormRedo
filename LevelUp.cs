using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoStorm
{
    public class LevelUp : Entity
    {
       public LevelUp()
        {
            CollisionRadius = 3;
        }
        
        override public void Update(GameInputs inputs, GameData data)
        {

        }

        override public void Render(Graphics graphics)
        {
            graphics.DrawLevelUp(Position);
        }
    }
}
