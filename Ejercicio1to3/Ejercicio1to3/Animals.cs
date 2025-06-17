using System;

namespace Ejercicios
{
    public class Animal
    {
        public string Nombre { get; set; }

        public Animal(string nombre)
        {
            Nombre = nombre;
        }

        public virtual void EmitirSonido()
        {
            Console.WriteLine("...");
        }

        public virtual void Presentarse()
        {
            Console.WriteLine($"Soy un animal llamado {Nombre}");
        }
    }

    public class Perro : Animal
    {
        public Perro(string nombre) : base(nombre) { }

        public override void EmitirSonido()
        {
            Console.WriteLine("Guau!");
        }

        public override void Presentarse()
        {
            Console.WriteLine($"Soy un perro llamado {Nombre} y hago:");
            EmitirSonido();
        }
    }

    public class Gato : Animal
    {
        public Gato(string nombre) : base(nombre) { }

        public override void EmitirSonido()
        {
            Console.WriteLine("Miau!");
        }

        public override void Presentarse()
        {
            Console.WriteLine($"Soy un gato llamado {Nombre} y hago:");
            EmitirSonido();
        }
    }

    public static class AnimalEjecutable
    {
        public static void Ejecutar()
        {
            Console.Write("Nombre del perro: ");
            var p = new Perro(Console.ReadLine());
            Console.Write("Nombre del gato: ");
            var g = new Gato(Console.ReadLine());

            p.Presentarse();
            g.Presentarse();
        }
    }
}