using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    public class Univ1Fisica : IUniversidade
    {
        public List<string> Cursos()
        {
            var list = new List<string>();
            list.Add("Física Básica");
            list.Add("Física Moderna");
            return list;
        }
    }
}
