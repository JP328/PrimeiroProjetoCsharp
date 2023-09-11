using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.model
{
    public abstract class Produto
    {
        private int id;
        private string name;
        private int type;
        private decimal price;

        public Produto(int id, string name, int type, decimal price)
        {
            this.id = id;
            this.name = name;
            this.type = type;
            this.price = price;
        }

        public int GetId () { 
            return id; 
        }

        public void SetId (int id) { 
            this.id = id; 
        }

        public string GetName () 
        { 
            return name;
        }

        public void SetName (string name)
        {
            this.name = name;
        }

        public int GetProductType() { 
            return type;
        }

        public void SetProductType(int type)
        {
            this.type = type;
        }

        public decimal GetPrice () 
        { 
            return price; 
        }

        public void SetPrice (decimal price) 
        {  
            this.price = price; 
        }
    
        public virtual void View()
        {
            string? writingType = string.Empty;

            if (this.type == 1)
                writingType = "Medicamento";
            else
                writingType = "Cosmetico";


            Console.WriteLine("****************************************************");
            Console.WriteLine("                 Informações do Produto:");
            Console.WriteLine("****************************************************");
            Console.WriteLine($"Número do Id: {this.id}");
            Console.WriteLine($"Nome do Produto: {this.name}");
            Console.WriteLine($"Preço do Produto: {this.price}");
            Console.WriteLine($"Tipo do Produto: {writingType}");
        }
    }
}
