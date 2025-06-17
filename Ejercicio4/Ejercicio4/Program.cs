using System;
using Ejercicios;

class Program
{
    static void Main()
    {
        var repo = new ProductoRepo();
        int op = 0;

        while (op != 5)
        {
            Console.Clear();
            Console.WriteLine("1. Agregar producto");
            Console.WriteLine("2. Mostrar productos");
            Console.WriteLine("3. Eliminar producto");
            Console.WriteLine("4. Modificar producto");
            Console.WriteLine("5. Salir");
            Console.Write("Opción: ");
            int.TryParse(Console.ReadLine(), out op);

            switch (op)
            {
                case 1:
                    Console.Write("Nombre: ");
                    var nombre = Console.ReadLine();
                    Console.Write("Precio: ");
                    var precio = double.Parse(Console.ReadLine());
                    Console.Write("Stock: ");
                    var stock = int.Parse(Console.ReadLine());
                    var nuevo = new Producto { Id = DateTime.Now.Millisecond, Nombre = nombre, Precio = precio, Stock = stock };
                    repo.Agregar(nuevo);
                    break;
                case 2:
                    repo.Mostrar();
                    Console.ReadKey();
                    break;
                case 3:
                    Console.Write("ID a eliminar: ");
                    var del = int.Parse(Console.ReadLine());
                    repo.Eliminar(del);
                    break;
                case 4:
                    Console.Write("ID a modificar: ");
                    var mod = int.Parse(Console.ReadLine());
                    Console.Write("Nuevo nombre: ");
                    var nn = Console.ReadLine();
                    Console.Write("Nuevo precio: ");
                    var np = double.Parse(Console.ReadLine());
                    Console.Write("Nuevo stock: ");
                    var ns = int.Parse(Console.ReadLine());
                    repo.Modificar(mod, nn, np, ns);
                    break;
            }
        }
    }
}
