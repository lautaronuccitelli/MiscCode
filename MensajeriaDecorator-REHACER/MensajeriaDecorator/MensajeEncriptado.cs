using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MensajeriaDecorator
{
    public class MensajeEncriptado : MensajeDecorator
    {
        public MensajeEncriptado(IMensaje mensaje) : base(mensaje) { }

        public override void Enviar(string texto)
        {
            string textoEncriptado = texto.ToUpper();
            mensajeInterno.Enviar(textoEncriptado);
        }
    }
}
