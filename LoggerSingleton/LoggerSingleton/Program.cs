using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== PRUEBA DEL LOGGER SINGLETON ===");

        var a = Logger.Instancia;
        Console.WriteLine("Primera referencia obtenida (variable 'a')");

        a.Info("Aplicacion iniciada");
        a.Info("Usuario logueado correctamente");
        a.Info("Procesando datos importantes");
        a.Info("Operacion completada exitosamente");

        Console.WriteLine($"Total de mensajes registrados: {a.TotalMensajes}");

        var b = Logger.Instancia;
        Console.WriteLine("Segunda referencia obtenida (variable 'b')");

        b.Info("Nuevo proceso iniciado");
        b.Info("Guardando configuracion");

        b.Dump();

        bool sonElMismoObjeto = ReferenceEquals(a, b);
        Console.WriteLine($"Las variables 'a' y 'b' referencian al mismo objeto: {sonElMismoObjeto}");
        Console.WriteLine($"Hash de 'a': {a.GetHashCode()}");
        Console.WriteLine($"Hash de 'b': {b.GetHashCode()}");

        Console.WriteLine("=== PRUEBA DESDE METODOS SEPARADOS ===");
        PruebaDesdeMetodo1();
        PruebaDesdeMetodo2();

        Logger.Instancia.Dump();

        Console.WriteLine("Presiona cualquier tecla para salir...");
        Console.ReadKey();
    }

    static void PruebaDesdeMetodo1()
    {
        Logger.Instancia.Info("Mensaje desde Metodo1");
    }

    static void PruebaDesdeMetodo2()
    {
        Logger.Instancia.Info("Mensaje desde Metodo2");
    }
}