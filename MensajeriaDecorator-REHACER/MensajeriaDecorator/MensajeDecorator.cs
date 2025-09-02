using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MensajeriaDecorator
{
    public abstract class MensajeDecorator : IMensaje
    {
        protected IMensaje mensajeInterno;

        public MensajeDecorator(IMensaje mensaje)
        {
            this.mensajeInterno = mensaje;
        }

        public abstract void Enviar(string texto);
    }
}
