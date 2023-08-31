using Atividade03.model;

namespace Atividade03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("=================================================================================");
            Console.WriteLine("===================        Atividade 03 - Produto         =======================");
            Console.WriteLine("=================================================================================");

            Produto product1 = new Produto("Controle de PS5", "Controle top de linha, vindo do Brás", "Jogos", 1, 6000, 150.00M);
            Produto product2 = new Produto(
                "Escudo do Capitão Ameria", 
                "Escudo do Capitão Ameria feito de metal em tamanho real, edição limitada!", 
                "Acessorios", 2, 100, 1000.00M);

            product1.View();
            product2.View();
        }
    }
}