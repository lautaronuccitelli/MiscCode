using System;

namespace MensajeriaDecorator
{
    class Program
    {
        static void Main(string[] args)
        {
            IMensaje mensaje = new MensajeSimple();

            IMensaje mensajeDecorado = new MensajeConEmoji(new MensajeEncriptado(mensaje));
            mensajeDecorado.Enviar("Hola mundo");

            IMensaje mensajeDecorado2 = new MensajeEncriptado(new MensajeConEmoji(mensaje));
            mensajeDecorado2.Enviar("Hola mundo");
        }
    }
}
