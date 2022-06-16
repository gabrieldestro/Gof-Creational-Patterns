// See https://aka.ms/new-console-template for more information
using Exercicio4;

Console.WriteLine("Cozinha:");

Lanche lancheNormal = Cozinha.MontaLanche(new LancheNormal());
Lanche lancheNatural = Cozinha.MontaLanche(new LancheNatural());

lancheNormal.Exibir();
lancheNatural.Exibir();