using Models;
using Views;
using System.Collections.Generic;
using System;

namespace Controllers
{
    internal class LibroController
    {
        private List<Libro> libros = new List<Libro>();

        public void CargarLibro()
        {
            Libro libro = LibroView.CargarLibro();
            libros.Add(libro);
        }

        public List<Libro> ObtenerLibrosDisponibles()
        {
            return libros.FindAll(l => l.Disponible);
        }

        public void MostrarTodosLosLibros()
        {
            LibroView.MostrarListaDeLibros(libros);
        }

        public void MostrarLibrosDisponibles()
        {
            LibroView.MostrarListaDeLibros(ObtenerLibrosDisponibles());
        }

        public Libro SeleccionarLibroDisponible()
        {
            List<Libro> disponibles = ObtenerLibrosDisponibles();
            if (disponibles.Count == 0)
            {
                LibroView.MostrarMensaje("No hay libros disponibles.");
                return null;
            }

            MostrarLibrosDisponibles();
            Console.Write("Seleccione un libro por ISBN: ");
            string isbn = Console.ReadLine();
            return disponibles.Find(l => l.ISBN == isbn);
        }

        public void MarcarComoPrestado(Libro libro)
        {
            libro.Disponible = false;
        }

        public void MarcarComoDevuelto(Libro libro)
        {
            libro.Disponible = true;
        }
    }
}