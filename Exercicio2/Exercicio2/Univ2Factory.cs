using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    public class Univ2Factory : UnivFactory
    {
        public override IUniversidade? GetUniversidade(string curso)
        {
            IUniversidade? universidade = null;

            try
            {
                if (curso.ToUpper() == "B")
                {
                    universidade = new Univ2Biologica();
                }
                else if (curso.ToUpper() == "M")
                {
                    universidade = new Univ2Medicina();
                }
            }
            catch
            {
                Console.WriteLine("Curso não existe!");
            }

            return universidade;
        }
    }
}
