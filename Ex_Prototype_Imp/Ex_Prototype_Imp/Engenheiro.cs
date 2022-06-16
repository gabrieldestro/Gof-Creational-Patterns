using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Prototype_Imp
{
    public class Engenheiro : Funcionario
    {
        public string Especialidade { get; set; }

        public Engenheiro(string _Nome, string _Cargo, string _Especialidade) : base(_Nome, _Cargo)
        {
            Especialidade = _Especialidade;
        }

        public Engenheiro(Engenheiro p) : base(p.Nome, p.Cargo)
        {
            this.Especialidade = p.Especialidade;
        }

        public override Funcionario Clone()
        {
            return (Engenheiro)this.MemberwiseClone();
        }

        public override void ExibirInfo()
        {
            Console.WriteLine($"Engenheiro: {Nome}, {Cargo}-{Especialidade}");
        }
    }
}
