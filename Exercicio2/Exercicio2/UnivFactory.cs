using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    public abstract class UnivFactory
    {
        public abstract IUniversidade? GetUniversidade(string curso);

        public static UnivFactory? CreateUniversidade(string universidade)
        {
            UnivFactory? factory = null;

            try
            {
                if (universidade.ToUpper() == "1")
                {
                    factory = new Univ1Factory();
                }
                else if (universidade.ToUpper() == "2")
                {
                    factory = new Univ2Factory();
                }
            }
            catch
            {
                Console.WriteLine("Universidade não existe!");
            }

            return factory;
        }
    }
}
