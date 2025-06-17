using Models;
using System;

namespace Views
{
    public static class UsuarioView
    {
        public static Usuario CargarUsuario()
        {
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            return new Usuario(nombre, email);
        }

        public static void MostrarUsuario(Usuario usuario)
        {
            Console.WriteLine($"Nombre: {usuario.Nombre}, Email: {usuario.Email}");
        }
    }
}