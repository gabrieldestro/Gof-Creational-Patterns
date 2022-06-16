using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio6
{
    public abstract class Lanche
    {
        protected List<string> Ingredientes = new List<string>();

        public Lanche()
        {
            MontaLanche();
        }

        protected abstract void MontaLanche();

        public void ExibirIngredientes()
        {
            Console.WriteLine($"\nExibindo ingredientes do lanche:");
            foreach (var ingrediente in Ingredientes)
            {
                Console.WriteLine($"{ingrediente}");
            }
        }
    }
}
