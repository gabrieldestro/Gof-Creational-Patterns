// See https://aka.ms/new-console-template for more information
using Exercicio6;

Console.WriteLine("Fábrica de Lanches!");

try
{
    Lanche cachorroQuente = LancheFactory.CriaLanche("C");
    Lanche mistoquente = LancheFactory.CriaLanche("M");
    Lanche lancheNatural = LancheFactory.CriaLanche("N");

    cachorroQuente.ExibirIngredientes();
    mistoquente.ExibirIngredientes();
    lancheNatural.ExibirIngredientes();
}
catch (Exception ex)
{
    Console.WriteLine(ex.ToString());
}
