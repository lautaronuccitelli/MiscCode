using System;

namespace ImpresorasAdapter
{
    class Program
    {
        static void Main(string[] args)
        {
            IImpresora Tadeo = new AdaptadorTermica(new ImpresoreTermicaVieja());
            Tadeo.Imprimir("Nigga");
        }
    }
}
