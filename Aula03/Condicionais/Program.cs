namespace Condicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? nome;
            int idade;

            Console.WriteLine("=============================================================");
            Console.WriteLine("=================== + CONDICIONAIS + ========================");
            Console.WriteLine("=============================================================");
            
            Console.WriteLine("\nDigite seu nome:");
            nome = Console.ReadLine();
            
            Console.WriteLine($"\nMuito bem {nome}! Agora digite sua idade:");
            idade = Convert.ToInt32(Console.ReadLine());

            if (idade <= 0 || idade > 120)
                Console.WriteLine("Valor inválido!");
            else if (idade <= 10 && idade == 0)
                Console.WriteLine("Mensalidade do plano é de 100 reais.");
            else if (idade <= 29)
                Console.WriteLine("Mensalidade do plano é de 200 reais.");
            else if (idade <= 45)
                Console.WriteLine("Mensalidade do plano é de 300 reais.");
            else if (idade <= 59)
                Console.WriteLine("Mensalidade do plano é de 500 reais.");
            else if (idade <= 65)
                Console.WriteLine("Mensalidade do plano é de 600 reais.");
            else
                Console.WriteLine("Mensalidade do plano é de 1000 reais.");

        }
    }
}