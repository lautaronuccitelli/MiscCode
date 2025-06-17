using Models;
using System;
using System.Collections.Generic;

namespace Views
{
    public static class LibroView
    {
        public static Libro CargarLibro()
        {
            Libro temp = new Libro();
            Console.Write("Titulo: ");
            temp.Titulo = Console.ReadLine();
            Console.Write("Autor: ");
            temp.Autor = Console.ReadLine();
            Console.Write("ISBN: ");
            temp.ISBN = Console.ReadLine();
            temp.Disponible = true;
            return temp;
        }

        public static void MostrarListaDeLibros(List<Libro> libros)
        {
            Console.WriteLine("------ LISTA DE LIBROS ------");
            foreach (var l in libros)
            {
                Console.WriteLine($"Titulo: {l.Titulo}, Autor: {l.Autor}, ISBN: {l.ISBN}, Disponible: {l.Disponible}");
            }
        }

        //public static void MostrarLibro(Libro libro)
        //{
        //    Console.WriteLine($"Titulo: {libro.Titulo}, Autor: {libro.Autor}, ISBN: {libro.ISBN}, Disponible: {libro.Disponible}");
        //}

        public static void MostrarMensaje(string mensaje)
        {
            Console.WriteLine(mensaje);
        }
    }
}   