using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    public class LancheNormal : CriadorLanche
    {
        public LancheNormal() : base("Normal")
        {
        }

        public override void AddCondimentos()
        {
            lanche.AddIngrediente("Condimentos 1", "Molho Especial.");
        }

        public override void AddPao()
        {
            lanche.AddIngrediente("Pão 1", "Pão de hamburguer.");
        }

        public override void AddRecheio()
        {
            lanche.AddIngrediente("Recheio 1", "Queijo Cheddar.");
            lanche.AddIngrediente("Recheio 2", "Hamburguer de Costela.");
        }

        public override void AddVegetais()
        {
            lanche.AddIngrediente("Vegetais 1", "Folhas de Alface.");
            lanche.AddIngrediente("Vegetais 2", "Fatias de tomate.");
        }
    }
}
