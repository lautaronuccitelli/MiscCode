using System;

namespace Ejercicios
{
    public class Ciudadano
    {
        public string Nombre { get; set; }
        public string DNI { get; set; }
        public int Edad { get; set; }

        public Ciudadano(string nombre, string dni, int edad)
        {
            Nombre = nombre;
            DNI = dni;
            Edad = edad;
        }

        public void Saludar()
        {
            Console.WriteLine($"Hola, soy {Nombre} y tengo {Edad} años.");
        }

        public bool EsMayor()
        {
            return Edad >= 18;
        }

        public static void Ejecutar()
        {
            Console.Write("Ingrese nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Ingrese DNI: ");
            string dni = Console.ReadLine();
            Console.Write("Ingrese edad: ");
            int edad = int.Parse(Console.ReadLine());

            var c = new Ciudadano(nombre, dni, edad);
            c.Saludar();
            Console.Write("Es mayor de edad?: ");
            Console.WriteLine(c.EsMayor() ? "Sí" : "No");
        }
    }
}