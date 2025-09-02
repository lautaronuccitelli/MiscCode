namespace HamburguesaBuilder;

public interface IHamburguesaBuilder
{
    IHamburguesaBuilder ConPan(string pan);
    IHamburguesaBuilder ConCarne(string carne);
    IHamburguesaBuilder ConQueso(bool queso = true);
    IHamburguesaBuilder ConLechuga(bool lechuga = true);
    IHamburguesaBuilder ConTomate(bool tomate = true);
    IHamburguesaBuilder ConCebolla(bool cebolla = true);
    IHamburguesaBuilder ConSalsa(string salsa);
    Hamburguesa Build();
}