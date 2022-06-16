using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    public class LancheNatural : CriadorLanche
    {
        public LancheNatural() : base("Natural")
        {
        }

        public override void AddCondimentos()
        {
            lanche.AddIngrediente("Condimentos 1", "Maionese Caseira.");
        }

        public override void AddPao()
        {
            lanche.AddIngrediente("Pão 1", "Pão de Forma Integral.");
        }

        public override void AddRecheio()
        {
            lanche.AddIngrediente("Recheio 1", "Queijo Cottage.");
            lanche.AddIngrediente("Recheio 2", "Fatias de Peito de Peru.");
        }

        public override void AddVegetais()
        {
            lanche.AddIngrediente("Vegetais 1", "Folhas de Alface.");
            lanche.AddIngrediente("Vegetais 2", "Fatias de tomate.");
            lanche.AddIngrediente("Vegetais 3", "Cenoura Ralada.");
        }
    }
}
