using ConsoleApp1.Controller;
using ConsoleApp1.model;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? name, fragrance, generic;
            int id, type, option;
            decimal price;
            
            ProdutoController produtos = new();

            Medicamento med = new Medicamento(produtos.GerarNumero(), "Dorflex", 1, 10, "Generico");
            produtos.Cadastrar(med);

            Cosmetico cos = new Cosmetico(produtos.GerarNumero(), "Perfume Doravante", 2, 160, "Brisa de verão");
            produtos.Cadastrar(cos);

            while (true) {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(
                    "\n\n================== Digite uma opção dentre as apresentadas abaixo: ==================================" +
                    "\n1 - Cadastrar Produto" +
                    "\n2 - Listar Produtos" +
                    "\n3 - Atualizar Produto inteiro" +
                    "\n4 - Apagar Produto" +
                    "\n5 - Sair" +
                    "\n====================================================================================================");

                try
                {
                    do
                    {
                        option = Convert.ToInt32(Console.ReadLine());
                    } while (option < 1 && option > 6);
                 
                    if (option == 5) 
                    {
                        Console.WriteLine("\n\nObrigado por usar nosso sistema!\n");
                        System.Environment.Exit(0);
                        Console.ResetColor();
                    }

                    Console.Clear();
                    switch (option) 
                    {
                        case 1:
                            Console.WriteLine("Digite o nome do produto");
                            name = Console.ReadLine();
                            name ??= string.Empty;

                            do
                            {
                                Console.WriteLine("Digite o tipo do produto (1 - Medicamento ou 2 - Cosmético):");
                                type = Convert.ToInt32(Console.ReadLine());
                            } while (type < 1 && type > 2);
                        
                            Console.WriteLine("Digite o preço do produto:");
                            price = Convert.ToDecimal(Console.ReadLine());

                            if(type == 1)
                            {
                                Console.WriteLine("O medicamento é generico? (Sim ou Não)");
                                generic = Console.ReadLine();
                                generic ??= string.Empty;

                                produtos.Cadastrar(new Medicamento(produtos.GerarNumero(), name, type, price, generic));
                            }
                            else
                            {
                                Console.WriteLine("Digite a fragância do cosmético:");
                                fragrance = Console.ReadLine();
                                fragrance ??= string.Empty;

                                produtos.Cadastrar(new Medicamento(produtos.GerarNumero(), name, type, price, fragrance));
                            }
                            break;
                        case 2:
                            produtos.ListarTodos();
                            break;
                        case 3:
                            Console.WriteLine("Digite o Id do produto que deseja atualizar:");
                            id = Convert.ToInt32(Console.ReadLine());

                            var produto = produtos.BuscarNaCollection(id);

                            if(produto == null)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"A produto com id {id} não foi encontrada");
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.WriteLine("Digite o nome do produto");
                                name = Console.ReadLine();
                                name ??= string.Empty;

                                Console.WriteLine("Digite o preço do produto:");
                                price = Convert.ToDecimal(Console.ReadLine());

                                if (produto.GetProductType() == 1)
                                {
                                    Console.WriteLine("O medicamento é generico? (Sim ou Não)");
                                    generic = Console.ReadLine();
                                    generic ??= string.Empty;

                                    produtos.Atualizar(new Medicamento(produto.GetId(), name, produto.GetProductType(), price, generic));
                                }
                                else
                                {
                                    Console.WriteLine("Digite a fragância do cosmético:");
                                    fragrance = Console.ReadLine();
                                    fragrance ??= string.Empty;

                                    produtos.Atualizar(new Medicamento(produto.GetId(), name, produto.GetProductType(), price, fragrance));
                                }
                            }

                            break;
                        case 4:
                            Console.WriteLine("Digite o ID do produto");
                            id = Convert.ToInt32(Console.ReadLine());

                            produtos.Deletar(id);
                            break;
                    }

                }
                catch (FormatException) 
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Escreva as entradas corretamenten, conforme descrito no enunciado. Tente novamente.");
                    Console.ResetColor();
                }
            }
        }
    }
}