using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade03.model
{
    internal class Jogo : Produto
    {
        private int ageClassification;

        public Jogo(
            string name, string description, string category, int cod, int stock, decimal price, int ageClassification) :
            base(name, description, category, cod, stock, price)
        {
            this.ageClassification = ageClassification;
        }

        public int GetModel() 
        {
            return ageClassification; 
        }

        public void SetModel(int ageClassification) 
        {
            this.ageClassification = ageClassification;
        }

        public override void View()
        {
            base.View();
            Console.WriteLine($"Classificação indicativa: {this.ageClassification} anos");
            Console.WriteLine("***************************************************\n");
        }
    }
}
