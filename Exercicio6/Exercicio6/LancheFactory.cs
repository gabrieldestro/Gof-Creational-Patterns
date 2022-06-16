using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio6
{
    public static class LancheFactory
    {
        private static Dictionary<string, Lanche> Lanches = new Dictionary<string, Lanche>()
        {   
            { "C", new CachorroQuente() },
            { "M", new MistoQuente() },
            { "N", new LancheNatural() }
        };

        public static Lanche CriaLanche(string tipo)
        {
            try
            {
                return Lanches[tipo.ToUpper()];
            }
            catch
            {
                throw new Exception("Lanche não existe!");
            }
        }
    }
}
