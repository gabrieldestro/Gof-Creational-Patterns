using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    public class Univ2Biologica: IUniversidade
    {
        public List<string> Cursos()
        {
            var list = new List<string>();
            list.Add("Biologia Celular");
            list.Add("Biologia Animal");
            return list;
        }
    }
}
