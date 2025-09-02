using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MensajeriaDecorator
{
    public class MensajeConEmoji : MensajeDecorator
    {
        public MensajeConEmoji(IMensaje mensaje) : base(mensaje) { }

        public override void Enviar(string texto)
        {
            string textoConEmoji = texto + " 😊";
            mensajeInterno.Enviar(textoConEmoji);
        }
    }
}
