using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Clases
{
    public class GoogleMapServicesFactory : IMapServiceFactory
    {
        public IMapa CreateMap()
        {
            return new GoogleMapa();
        }

        public IGeocoder CreateGeocoder()

        {
            return new GoogleGeocoder();
        }
    }
}
