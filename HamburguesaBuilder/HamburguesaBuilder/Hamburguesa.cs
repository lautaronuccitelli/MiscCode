using System.Text;

public class Hamburguesa
{
    public string Pan { get; set; }
    public string Carne { get; set; }
    public bool Queso { get; set; }
    public bool Lechuga { get; set; }
    public bool Tomate { get; set; }
    public bool Cebolla { get; set; }
    public string Salsa { get; set; }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine("=== HAMBURGUESA ===");
        sb.AppendLine($"Pan: {Pan}");
        sb.AppendLine($"Carne: {Carne}");
        
        if (Queso) sb.AppendLine("Queso");
        if (Lechuga) sb.AppendLine("Lechuga");
        if (Tomate) sb.AppendLine("Tomate");
        if (Cebolla) sb.AppendLine("Cebolla");
        
        if (!string.IsNullOrEmpty(Salsa))
            sb.AppendLine($"Salsa: {Salsa}");
        
        sb.AppendLine("==================");
        
        return sb.ToString();
    }
}