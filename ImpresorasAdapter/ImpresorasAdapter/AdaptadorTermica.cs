using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpresorasAdapter
{
    public class AdaptadorTermica: IImpresora
    {
        private readonly ImpresoreTermicaVieja impresoreTermicaVieja;

        public AdaptadorTermica(ImpresoreTermicaVieja impresoreTermicaVieja)
        {
            this.impresoreTermicaVieja = impresoreTermicaVieja;
        }

        public void Imprimir(string texto)
        {
            Console.WriteLine("IMPRIMIR DATOS: ");
            impresoreTermicaVieja.PrintTicket(texto);
        }
    }
}
