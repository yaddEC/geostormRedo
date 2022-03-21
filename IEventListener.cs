using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoStorm
{
    public interface IEventListener
    {
        public void HandleEvents(in List<Event> events);
      
    }
}
