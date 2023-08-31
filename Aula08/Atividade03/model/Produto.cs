using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade03.model
{
    public class Produto
    {
        private string name = string.Empty;
        private string description = string.Empty;
        private string category = string.Empty;
        private int cod;
        private int stock;
        private decimal price;

        public Produto(string name, string description, string category, int cod, int stock, decimal price)
        {
            this.name = name;
            this.description = description;
            this.category = category;
            this.cod = cod;
            this.stock = stock;
            this.price = price;
        }

        public string GetName()
        {
            return this.name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetDescription()
        {
            return this.description;
        }

        public void SetDescription(string description)
        {
            this.description = description;
        }
        
        public string GetCategory()
        {
            return this.category;
        }

        public void SetCategory(string category)
        {
            this.category = category;
        }

        public int GetCod()
        {
            return this.cod;
        }

        public void SetCod(int cod)
        {
            this.cod = cod;
        }

        public int GetStock()
        {
            return this.stock;
        }

        public void SetStock(int stock)
        {
            this.stock = stock;
        }

        public decimal GetPrice()
        {
            return this.price;
        }

        public void SetPrice(decimal price)
        {
            this.price = price;
        }

        public void View()
        {
            Console.WriteLine("\n****************************************************");
            Console.WriteLine("                 Dados do Produto:");
            Console.WriteLine("****************************************************");
            Console.WriteLine($"Código do Produto: {this.cod}");
            Console.WriteLine($"Nome: {this.name}");
            Console.WriteLine($"Categoria: {this.category}");
            Console.WriteLine($"Descrição: {this.description}");
            Console.WriteLine($"Preço: {(this.price).ToString("C")}");
            Console.WriteLine($"Quantidade em estoque: {this.stock}");
            Console.WriteLine("***************************************************\n");
        }
    }
}
