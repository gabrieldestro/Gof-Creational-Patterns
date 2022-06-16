using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    public abstract class CriadorLanche
    {
        protected Lanche lanche { get; set; }

        public Lanche Lanche
        {
            get { return lanche; }
        }

        protected CriadorLanche(string TipoLanche)
        {
            lanche = new Lanche(TipoLanche);
        }

        public abstract void AddPao();
        public abstract void AddRecheio();
        public abstract void AddVegetais();
        public abstract void AddCondimentos();

    }
}
