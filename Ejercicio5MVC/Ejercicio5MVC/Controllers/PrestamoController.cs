using Models;
using Views;
using System.Collections.Generic;
using System;

namespace Controllers
{
    internal class PrestamoController
    {
        private List<Prestamo> prestamos = new List<Prestamo>();
        private LibroController lController;
        private UsuarioController uController;

        public PrestamoController(LibroController lc, UsuarioController uc)
        {
            lController = lc;
            uController = uc;
        }

        public void CrearPrestamo()
        {
            Libro libro = lController.SeleccionarLibroDisponible();
            if (libro == null) return;

            Usuario usuario = uController.CargarUsuario();
            Prestamo prestamo = new Prestamo(libro, usuario);

            lController.MarcarComoPrestado(libro);
            prestamos.Add(prestamo);
            PrestamoView.MostrarMensaje("Prestamo registrado.");
        }

        public void DevolverLibro()
        {
            PrestamoView.MostrarListaDePrestamos(prestamos);
            Console.Write("Ingrese el ISBN del libro a devolver: ");
            string isbn = Console.ReadLine();

            Prestamo prestamo = prestamos.Find(p => p.libro.ISBN == isbn);
            if (prestamo == null)
            {
                PrestamoView.MostrarMensaje("No se encontro el pre}stamo.");
                return;
            }

            lController.MarcarComoDevuelto(prestamo.libro);
            prestamos.Remove(prestamo);
            PrestamoView.MostrarMensaje("Libro devuelto con exito.");
        }

        public void MostrarPrestamos()
        {
            PrestamoView.MostrarListaDePrestamos(prestamos);
        }
    }
}