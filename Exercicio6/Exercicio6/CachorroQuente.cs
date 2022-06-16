using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio6
{
    internal class MistoQuente : Lanche
    {
        protected override void MontaLanche()
        {
            Ingredientes.Add("Pão de forma.");
            Ingredientes.Add("Presunto.");
            Ingredientes.Add("Queijo.");
        }
    }
}
