using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    internal class Univ1Factory : UnivFactory
    {
        public override IUniversidade? GetUniversidade(string curso)
        {
            IUniversidade? universidade = null;

            try 
            {
                if (curso.ToUpper() == "F")
                {
                    universidade = new Univ1Fisica();
                }
                else if (curso.ToUpper() == "Q")
                {
                    universidade = new Univ1Quimica();
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
