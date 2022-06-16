using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Prototype_Imp
{
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public string Cargo { get; set; }

        public Funcionario(string _Nome, string _Cargo)
        {
            Nome = _Nome;
            Cargo = _Cargo;
        }

        public abstract Funcionario Clone();

        public abstract void ExibirInfo();
    }
}
