using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio3
{
    public class MontadoraFactory
    {
        private static readonly Dictionary<string, IMontadora> montadoraDictionary = 
            new Dictionary<string, IMontadora>()
        {
            { "C", new Chevrolet() },
            { "F", new Ford() },
            { "H", new Honda() }
        };

        public static IMontadora? GetVeiculo(string opcao) 
        {
            if (montadoraDictionary.ContainsKey(opcao))
                return montadoraDictionary[opcao];
            return null;
        }
    }
}
