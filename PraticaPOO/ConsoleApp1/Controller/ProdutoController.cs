using ConsoleApp1.model;
using ConsoleApp1.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1.Controller
{
    public class ProdutoController : IProdutoRepository
    {
        private readonly List<Produto> productList = new();
        int num = 0;

        public void Atualizar(Produto produto)
        {
            var searchProductId = BuscarNaCollection(produto.GetId());

            if (searchProductId == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"A conta número {num} não foi encontrada");
                Console.ResetColor();
            }
            else
            {
                var index = productList.IndexOf(searchProductId);
                productList[index] = produto;

                Console.WriteLine($"A produto número {produto.GetId()} foi atualizada com sucesso");
            }
        }

        public void Cadastrar(Produto produto)
        {
            productList.Add(produto);
            Console.WriteLine($"O Produto {produto.GetName()} foi cadastrado com sucesso");
        }

        public void Deletar(int id)
        {
            var produto = BuscarNaCollection(id);
            
            if (produto == null ) 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"A conta número {id} não foi encontrada");
                Console.ResetColor();
            }
            else
            {
                if (productList.Remove(produto) == true)
                    Console.WriteLine($"Produto do Id {id} foi removido com sucesso!");
            }
        }

        public void ListarTodos()
        {
            if (productList.Count() > 0)
            {
                foreach (var produto in productList)
                    produto.View();
            }
            else
            {
                Console.WriteLine("Estamos sem produtos no momento, volte mais tarde!");
            }
        }

        public int GerarNumero()
        {
            return ++num;
        }

        public Produto? BuscarNaCollection(int id)
        {
            foreach (var produto in productList)
            {
                if (produto.GetId() == id)
                    return produto;
            }

            return null;
        }
    }
}
