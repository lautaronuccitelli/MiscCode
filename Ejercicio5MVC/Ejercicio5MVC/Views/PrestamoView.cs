using Models;
using System;
using System.Collections.Generic;

namespace Views
{
    public static class PrestamoView
    {
        public static void MostrarListaDePrestamos(List<Prestamo> prestamos)
        {
            Console.WriteLine("Prestamos actuales:");
            foreach (Prestamo p in prestamos)
            {
                Console.WriteLine($"Libro: {p.libro.Titulo}, ISBN: {p.libro.ISBN}, Prestado a: {p.usuario.Nombre}, {p.usuario.Email}, Fecha: {p.Fecha}");
            }
        }

        public static void MostrarMensaje(string mensaje)
        {
            Console.WriteLine(mensaje);
        }
    }
}