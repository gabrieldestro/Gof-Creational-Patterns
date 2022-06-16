using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Prototype_Imp
{
    public class Programador : Funcionario
    {
        public string Linguagem { get; set; }

        public Programador(string _Nome, string _Cargo, string _Linguagem) : base(_Nome, _Cargo)
        {
            Linguagem = _Linguagem;
        }

        public Programador(Programador p) : base(p.Nome, p.Cargo)
        {
            this.Linguagem = p.Linguagem;
        }

        public override Funcionario Clone() 
        {
            return (Programador)this.MemberwiseClone();
        }

        public override void ExibirInfo()
        {
            Console.WriteLine($"Programador: {Nome}, {Cargo}-{Linguagem}");
        }
    }
}
