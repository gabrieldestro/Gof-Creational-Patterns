using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    public class Lanche
    {
        private string TipoLanche { get; set; }
        private Dictionary<string, string> Ingredientes { get; set; }

        public Lanche(string _TipoLanche)
        {
            TipoLanche = _TipoLanche;
            Ingredientes = new Dictionary<string, string>();
        }

        public void AddIngrediente(string tipo, string ingrediente)
        {
            Ingredientes.Add(tipo, ingrediente);
        }

        public void Exibir()
        {
            Console.WriteLine($"Exibindo Lanche {TipoLanche}:");
            Console.WriteLine($"-----------------------------");
            foreach (var ingrediente in Ingredientes)
            {
                Console.WriteLine($"{ingrediente.Key} - {ingrediente.Value}");
            }
            Console.WriteLine($"-----------------------------\n");
        }
    }
}
