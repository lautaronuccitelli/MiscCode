// Program.cs
using System;
using Ejercicios;

class Program
{
    static void Main()
    {
        int op = 0;
        while (op != 4)
        {
            Console.Clear();
            Console.WriteLine("=== Selecciona un ejercicio ===");
            Console.WriteLine("1. Ciudadano (POO)");
            Console.WriteLine("2. Animales (Herencia)");
            Console.WriteLine("3. Facturación (SRP + ISP)");
            Console.WriteLine("4. Salir");
            Console.Write("Opcion: ");
            op = int.Parse(Console.ReadLine());
            Console.Clear();

            switch (op)
            {
                case 1: Ciudadano.Ejecutar(); break;
                case 2: AnimalEjecutable.Ejecutar(); break;
                case 3: FacturaEjecucion.Ejecutar(); break;
            }

            if (op != 4)
            {
                Console.WriteLine("Presione una tecla para continuar...");
                Console.ReadKey();
            }
        }
    }
}