using System;
using ConsoleApp1.Clases;
using ConsoleApp1.Clases_OSM;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            IMapServiceFactory factory = new GoogleMapServicesFactory();
           
            var app = new Navegador(factory);
            app.Run("Nigger","Nigger2");
        }
    }
}
