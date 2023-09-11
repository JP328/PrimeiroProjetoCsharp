using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.model
{
    public class Medicamento : Produto
    {
        public string generic;

        public Medicamento(int id, string name, int type, decimal price, string generic) : base(id, name, type, price)
        {
            this.generic = generic;
        }

        public string GetGeneric() 
        { 
            return generic;
        }

        public void SetGeneric( string generic ) 
        { 
            this.generic = generic;
        }


        public override void View()
        {
            base.View();
            Console.WriteLine($"{(generic.ToLower().Equals("sim") ? "Esse medicamento é Genérico." : "Esse medicamento é a formula original.")}");
            Console.WriteLine("****************************************************");
        }
    }
}
