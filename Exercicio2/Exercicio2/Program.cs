// See https://aka.ms/new-console-template for more information
using Exercicio2;

Console.WriteLine("Lista cursos:");

IUniversidade UnivFis1 = UnivFactory.CreateUniversidade("1")?.GetUniversidade("F");
IUniversidade UnivQui1 = UnivFactory.CreateUniversidade("1")?.GetUniversidade("Q");
IUniversidade UnivBio1 = UnivFactory.CreateUniversidade("1")?.GetUniversidade("B");

IUniversidade UnivMed2 = UnivFactory.CreateUniversidade("2")?.GetUniversidade("M");
IUniversidade UnivBio2 = UnivFactory.CreateUniversidade("2")?.GetUniversidade("B");

foreach (string curso in UnivFis1?.Cursos() ?? new List<string>()) { Console.WriteLine(curso); }
Console.WriteLine("\n");
foreach (string curso in UnivQui1?.Cursos() ?? new List<string>()) { Console.WriteLine(curso); }
Console.WriteLine("\n");
foreach (string curso in UnivBio1?.Cursos() ?? new List<string>()) { Console.WriteLine(curso); }
Console.WriteLine("\n");
foreach (string curso in UnivMed2?.Cursos() ?? new List<string>()) { Console.WriteLine(curso); }
Console.WriteLine("\n");
foreach (string curso in UnivBio2?.Cursos() ?? new List<string>()) { Console.WriteLine(curso); }