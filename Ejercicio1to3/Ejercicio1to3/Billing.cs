using System;

namespace Ejercicios
{
    public class Factura
    {
        public int ID { get; set; }
        public double Monto { get; set; }
    }

    public class FacturaCalculadora
    {
        public double CalcularTotal(Factura f) => f.Monto * 1.21;
    }

    public class FacturaSaver
    {
        public void Guardar(Factura f)
        {
            Console.WriteLine("Factura guardada.");
        }
    }

    public interface Imprimible
    {
        void Imprimir();
    }

    public class ImpresionDigital : Imprimible
    {
        public void Imprimir() => Console.WriteLine("Imprimiendo digital...");
    }

    public class ImpresionPapel : Imprimible
    {
        public void Imprimir() => Console.WriteLine("Imprimiendo en papel...");
    }

    public static class FacturaEjecucion
    {
        public static void Ejecutar()
        {
            Console.Write("ID de factura: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Monto de factura: ");
            double monto = double.Parse(Console.ReadLine());

            var f = new Factura { ID = id, Monto = monto };
            var calc = new FacturaCalculadora();
            Console.WriteLine("Total con IVA:");
            Console.WriteLine(calc.CalcularTotal(f));

            var saver = new FacturaSaver();
            saver.Guardar(f);

            Imprimible imp = new ImpresionDigital();
            imp.Imprimir();
        }
    }
}