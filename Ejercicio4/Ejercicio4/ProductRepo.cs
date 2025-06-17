using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Ejercicios
{
    public class ProductoRepo
    {
        string path = "productos.json";
        List<Producto> lista = new();

        public ProductoRepo()
        {
            Cargar();
        }

        public void Agregar(Producto p)
        {
            lista.Add(p);
            Guardar();
        }

        public void Mostrar()
        {
            foreach (var p in lista)
            {
                Console.WriteLine($"{p.Id} - {p.Nombre} - ${p.Precio} - Stock: {p.Stock}");
            }
        }

        public void Eliminar(int id)
        {
            lista.RemoveAll(p => p.Id == id);
            Guardar();
        }

        public void Modificar(int id, string nuevoNombre, double nuevoPrecio, int nuevoStock)
        {
            var p = lista.Find(x => x.Id == id);
            if (p != null)
            {
                p.Nombre = nuevoNombre;
                p.Precio = nuevoPrecio;
                p.Stock = nuevoStock;
                Guardar();
            }
        }

        void Guardar()
        {
            File.WriteAllText(path, JsonSerializer.Serialize(lista, new JsonSerializerOptions { WriteIndented = true }));
        }

        void Cargar()
        {
            if (File.Exists(path))
            {
                var json = File.ReadAllText(path);
                lista = JsonSerializer.Deserialize<List<Producto>>(json) ?? new();
            }
        }
    }
}