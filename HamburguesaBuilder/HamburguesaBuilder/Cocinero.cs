namespace HamburguesaBuilder;

public class Cocinero
{
    public static Hamburguesa Clasica(IHamburguesaBuilder builder)
    {
        return builder
            .ConPan("Pan clasico")
            .ConCarne("Carne simple")
            .ConQueso()
            .ConLechuga()
            .ConTomate()
            .ConSalsa("Ketchup")
            .Build();
    }

    public static Hamburguesa DobleCheddar(IHamburguesaBuilder builder)
    {
        return builder
            .ConPan("Pan premium")
            .ConCarne("Carne doble")
            .ConQueso()
            .ConCebolla()
            .ConSalsa("Cheddar")
            .Build();
    }
}