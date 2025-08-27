using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Clases_OSM
{
   public  class OsmMapServiceFactory
    {
        public IMapa CreateMapa()
        {
            return new OsmMapa();
        }

        public IGeocoder CreateGeocoder()
        {
            return new OsmGeocoder();
        }
    }
}

