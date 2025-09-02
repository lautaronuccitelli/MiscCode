using System;
using HamburguesaBuilder;

class Program
{
    static void Main(string[] args)
    {

        int opcion = 0;
        while (opcion != 5)
        {
            Console.Clear();
            Console.WriteLine("=== CONSTRUCCION DE HAMBURGUESAS (INTERACTIVO) ===");
            Console.WriteLine("1) HAMBURGUESA CLASICA (usando Cocinero)");
            Console.WriteLine("2) HAMBURGUESA DOBLE CHEDDAR (usando Cocinero)");
            Console.WriteLine("3) HACER HAMBURGUESA PERSONALIZADA (manual)");
            Console.WriteLine("4) INTENTAR CREAR UNA INCOMPLETA (para ver excepcion)");
            Console.WriteLine("5) SALIR");
            Console.Write("Elige una opcion (1-5): ");

            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    CrearConReceta("Clasica", b => Cocinero.Clasica(b));
                    break;
                case 2:
                    CrearConReceta("Doble Cheddar", b => Cocinero.DobleCheddar(b));
                    break;
                case 3:
                    CrearManual();
                    break;
                /*case 4:
                    IntentarIncompleta();
                    break;*/
                case 5:
                    return;
                default:
                    Console.WriteLine("Opcion invalida. Presiona una tecla para continuar...");
                    Console.ReadKey();
                    break;
            }
        }
    }

    static void CrearConReceta(string nombre, Func<IHamburguesaBuilder, Hamburguesa> receta)
    {
        var builder = new HamburguesaClasicaBuilder();
        try
        {
            Console.WriteLine();
            Console.WriteLine($"--- Creando: {nombre} ---");
            var h = receta(builder);
            Console.WriteLine(h);
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"ERROR: {ex.Message}");
        }

        Console.WriteLine("Presiona cualquier tecla para volver al menu...");
        Console.ReadKey();
    }

    static void CrearManual()
    {
        var builder = new HamburguesaClasicaBuilder();
        Console.WriteLine();
        Console.WriteLine("--- Hamburguesa personalizada ---");

        Console.Write("Pan (ej: Pan integral): ");
        var pan = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(pan)) builder.ConPan(pan);

        Console.Write("Carne (ej: Pollo / Vacuna): ");
        var carne = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(carne)) builder.ConCarne(carne);

        if (AskYesNo("¿Queso? (s/n): ")) builder.ConQueso();
        else builder.ConQueso(false);

        if (AskYesNo("¿Lechuga? (s/n): ")) builder.ConLechuga();
        if (AskYesNo("¿Tomate? (s/n): ")) builder.ConTomate();
        if (AskYesNo("¿Cebolla? (s/n): ")) builder.ConCebolla();

        Console.Write("Salsa (enter para nada): ");
        var salsa = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(salsa)) builder.ConSalsa(salsa);

        try
        {
            var h = builder.Build();
            Console.WriteLine();
            Console.WriteLine("--- Resultado ---");
            Console.WriteLine(h);
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"ERROR: {ex.Message}");
        }

        Console.WriteLine("Presiona cualquier tecla para volver al menu...");
        Console.ReadKey();
    }

    /*static void IntentarIncompleta()
    {
        var builder = new HamburguesaClasicaBuilder();
        Console.WriteLine();
        Console.WriteLine("--- Intento de hamburguesa incompleta (solo pan) ---");
        builder.ConPan("Pan comun");
        try
        {
            var h = builder.Build();
            Console.WriteLine(h);
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"ERROR: {ex.Message}");
        }

        Console.WriteLine("Presiona cualquier tecla para volver al menu...");
        Console.ReadKey();
    }*/

    static bool AskYesNo(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            var r = Console.ReadLine()?.Trim().ToLower();
            if (string.IsNullOrEmpty(r)) return false;
            if (r == "s" || r == "si" || r == "y" || r == "yes") return true;
            if (r == "n" || r == "no") return false;
            Console.WriteLine("Respuesta no valida. Responde 's' o 'n'.");
        }
    }
}
