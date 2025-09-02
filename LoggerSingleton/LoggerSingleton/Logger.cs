using System;
using System.Collections.Generic;

public sealed class Logger
{
    private static readonly Lazy<Logger> _instancia = new Lazy<Logger>(() => new Logger());
    private readonly List<string> _historial;

    private Logger()
    {
        _historial = new List<string>();
        Console.WriteLine("[SISTEMA] Logger inicializado");
    }

    public static Logger Instancia => _instancia.Value;

    public void Info(string mensaje)
    {
        var mensajeCompleto = $"[INFO] {DateTime.Now:HH:mm:ss} - {mensaje}";
        _historial.Add(mensajeCompleto);
        Console.WriteLine(mensajeCompleto);
    }

    public void Dump()
    {
        Console.WriteLine("=== HISTORIAL DE LOGS ===");
        
        if (_historial.Count == 0)
        {
            Console.WriteLine("No hay mensajes en el historial");
        }
        else
        {
            for (int i = 0; i < _historial.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_historial[i]}");
            }
        }
        
        Console.WriteLine("=========================");
    }

    public int TotalMensajes => _historial.Count;
}