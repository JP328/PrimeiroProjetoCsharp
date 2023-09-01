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

            //Produto product1 = new Produto("Controle de PS5", "Controle top de linha, vindo do Brás", "Jogos", 1, 6000, 150.00M);
            //Produto product2 = new Produto(
            //    "Escudo do Capitão Ameria", 
            //    "Escudo do Capitão Ameria feito de metal em tamanho real, edição limitada!", 
            //    "Acessorios", 2, 100, 1000.00M);

            //product1.View();
            //product2.View();

            Jogo j1 = new Jogo("Call of Duty",
                "Ação frenetica e tiro pra todos os lados!",
                "Jogos de Ação", 88, 10500, 80.00M, 16);

            Jogo j2 = new Jogo("Sonic Generations",
            "SIMPLESMENTE PERFEITO!",
            "Jogos de Ação", 98, 1000, 89.90M, 12);

            VideoGame v1 = new VideoGame(
            "Xbox 360",
            "Console de última geração.",
            "Consoles", 8, 1000, 1000.00M, "Slim");
            
            VideoGame v2 = new VideoGame(
            "PlayStation 3",
            "Console de última geração.",
            "Consoles", 13, 1000, 1500.00M, "Pro");
            
            j1.View();
            j2.View();

            Console.WriteLine("\n\n");

            v1.View();

            v2.SetModel("Slim");
            
            v2.View();
        }
    }
}