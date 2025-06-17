using Controllers;
using System;

class Program
{
    static void Main()
    {
        LibroController lController = new LibroController();
        UsuarioController uController = new UsuarioController();
        PrestamoController pController = new PrestamoController(lController, uController);

        string opcion = "";
        do
        {
            Console.WriteLine("MENU PRINCIPAL");
            Console.WriteLine("1. Cargar Libro");
            Console.WriteLine("2. Listar Todos los Libros");
            Console.WriteLine("3. Listar Libros Disponibles");
            Console.WriteLine("4. Registrar Prestamo");
            Console.WriteLine("5. Devolver Libro");
            Console.WriteLine("6. Mostrar Prestamos");
            Console.WriteLine("0. Salir");
            Console.Write("Opcion: ");
            opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1": lController.CargarLibro(); break;
                case "2": lController.MostrarTodosLosLibros(); break;
                case "3": lController.MostrarLibrosDisponibles(); break;
                case "4": pController.CrearPrestamo(); break;
                case "5": pController.DevolverLibro(); break;
                case "6": pController.MostrarPrestamos(); break;
            }

        } while (opcion != "0");
    }
}