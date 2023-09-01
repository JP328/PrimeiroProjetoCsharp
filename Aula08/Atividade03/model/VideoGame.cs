using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade03.model
{
    internal class VideoGame : Produto
    {
        private string model;

        public VideoGame(
            string name, string description, string category, int cod, int stock, decimal price, string model) : 
            base(name, description, category, cod, stock, price)
        {
            this.model = model;
        }

        public string GetModel() { return model; }

        public void SetModel(string model) { this.model = model;}

        public override void View()
        {
            base.View();
            Console.WriteLine($"Modelo do Console: {this.model}");
            Console.WriteLine("***************************************************\n");
        }
    }
}
