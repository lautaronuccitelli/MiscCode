using System;

namespace Models
{
    public class Prestamo
    {
        public Libro libro { get; set; }
        public Usuario usuario { get; set; }
        public DateTime Fecha { get; set; }

        public Prestamo() { }

        public Prestamo(Libro libro, Usuario usuario)
        {
            this.libro = libro;
            this.usuario = usuario;
            this.Fecha = DateTime.Now;
        }
    }
}