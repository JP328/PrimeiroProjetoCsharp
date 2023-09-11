using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.model
{
    public class Cosmetico : Produto
    {
        private string fragrance;

        public Cosmetico(int id, string name, int type, decimal price, string fragrance) : base(id, name, type, price)
        {
            this.fragrance = fragrance;
        }

        public string GetFragrance() 
        {
            return fragrance;
        }

        public void SetFragrance(string fragrance)
        {
            this.fragrance = fragrance; 
        }

        public override void View() 
        {
            base.View();
            Console.WriteLine($"A fragância do Cosmético é {fragrance}");
            Console.WriteLine("****************************************************");
        }
    }
}
