using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpresorasAdapter
{
    public static class Cliente
    {
        public static void Run()
        {
            IImpresora impresora = new AdaptadorTermica(new ImpresoreTermicaVieja());
            impresora.Imprimir("Imprimiendo");
        }
    }
}

