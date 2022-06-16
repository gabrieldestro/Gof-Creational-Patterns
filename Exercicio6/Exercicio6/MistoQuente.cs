using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio6
{
    internal class CachorroQuente : Lanche
    {
        protected override void MontaLanche()
        {
            Ingredientes.Add("Pão de Cachorro Quente.");
            Ingredientes.Add("Salsicha.");
            Ingredientes.Add("Molho de Tomate.");
        }
    }
}
