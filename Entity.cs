using System;
using System.Collections.Generic;
using System.Numerics;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoStorm
{
<<<<<<< HEAD
   public abstract class Entity
=======
   public  abstract  class Entity
>>>>>>> 032f8b7 (add enemy fonction)
    {
        public Vector2 Position;
        public float Rotation ;
        public float CollisionRadius ;
        public bool IsDead;

<<<<<<< HEAD
        abstract public void Update(GameInputs inputs, GameData data, List<Event> Events);
        abstract public void Render(Graphics graphics);
=======
       public abstract  void Update(GameInputs inputs, GameData data);
       public abstract  void Render(Graphics graphics);
>>>>>>> 032f8b7 (add enemy fonction)
    }
}
