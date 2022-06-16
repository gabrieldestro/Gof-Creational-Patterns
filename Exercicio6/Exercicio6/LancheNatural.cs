using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio6
{
    internal class LancheNatural : Lanche
    {
        protected override void MontaLanche()
        {
            Ingredientes.Add("Pão de forma.");
            Ingredientes.Add("Salada.");
            Ingredientes.Add("Queijo.");
        }
    }
}
