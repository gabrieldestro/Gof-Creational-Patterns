using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    public class Univ2Medicina : IUniversidade
    {
        public List<string> Cursos()
        {
            var list = new List<string>();
            list.Add("Infectologia");
            list.Add("Anatomia");
            return list;
        }
    }
}
