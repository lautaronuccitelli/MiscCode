using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MensajeriaDecorator
{
    public class MensajeSimple : IMensaje
    {
        public void Enviar(string texto)
        {
            Console.WriteLine(texto);
        }
    }
}
