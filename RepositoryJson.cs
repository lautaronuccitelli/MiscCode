namespace Data;

using Models;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Linq; // Necesario para .ToList()

public class RepositorioJson : IRepositorio<Pedido>
{
    private const string FILE_NAME = "archivo.json";

    public void Guardar(Pedido pedido)
    {
        var pedidos = ObtenerTodos();
        pedidos.Add(pedido);

        try
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            string jsonString = JsonSerializer.Serialize(pedidos, options);
            File.WriteAllText(FILE_NAME, jsonString);
            Console.WriteLine("guardado.");
        }
        catch
        {
            Console.WriteLine("Error al guardar.");
        }
    }
    
    public List<Pedido> ObtenerTodos()
    {
        if (!File.Exists(FILE_NAME))
        {
            return new List<Pedido>();
        }

        try
        {
            string JsonString = File.ReadAllText(FILE_NAME);
            return JsonSerializer.Deserialize<List<Pedido>>(JsonString) ?? new List<Pedido>();
        }
        catch
        {
            Console.WriteLine("Error al leer el archivo.");
            return new List<Pedido>();
        }
    }
}