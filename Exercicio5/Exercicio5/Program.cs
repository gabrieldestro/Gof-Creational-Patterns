// See https://aka.ms/new-console-template for more information
using Exercicio5;

Console.WriteLine("Clonando lanches!\n");

Lanche cachorroQuente = new Lanche("Pão de Cachorro Quente", "Salsicha", "Mostarda");
Lanche cachorroQuenteClone = (Lanche)cachorroQuente.Clone();

cachorroQuente.Ingredientes();
cachorroQuenteClone.Ingredientes();