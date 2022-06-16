using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    public class Cozinha
    {
        public static Lanche MontaLanche(CriadorLanche CriadorLanche)
        {
            CriadorLanche.AddPao();
            CriadorLanche.AddCondimentos();
            CriadorLanche.AddRecheio();
            CriadorLanche.AddVegetais();

            return CriadorLanche.Lanche;
        }
    }
}
