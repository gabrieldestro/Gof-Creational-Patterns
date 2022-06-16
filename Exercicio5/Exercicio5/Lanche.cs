using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5
{
    public class Lanche : LanchePrototype
    {
        private string Pao { get; set; }
        private string Recheio { get; set; }
        private string Condimentos { get; set; }

        public Lanche(string _Pao, string _Recheio, string _Condimentos)
        {
            Pao = _Pao;
            Recheio = _Recheio;
            Condimentos = _Condimentos;
        }

        public void Ingredientes()
        {
            Console.WriteLine("Exibindo ingredientes do lanche:");
            Console.WriteLine($"{Pao}\n{Recheio}\n{Condimentos}\n");
        }

        public override LanchePrototype Clone()
        {
            return (LanchePrototype)this.MemberwiseClone();
        }
    }
}
