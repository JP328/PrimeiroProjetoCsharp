namespace Pesquisa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? nome, continua = "s";
            int idade, esporte, futebol = 0, voleibolM18 = 0, basquetebolMen18 = 0;

            do
            {
                Console.WriteLine("Digite seu nome: ");
                nome = Console.ReadLine();

                Console.WriteLine("Digite sua idade: ");
                idade = Convert.ToInt32(Console.ReadLine());

                do
                {
                    Console.WriteLine(
                        "Digite o código do seu esporte: " +
                        "\n1 - Fut\n2 - Vôl\n3 - Basq\n4 - Outros");
                    esporte = Convert.ToInt32(Console.ReadLine());

                } while (esporte < 1 || esporte > 4);

                Console.WriteLine("Deseja continuar (S/N)");
                continua = Console.ReadLine().ToLower();

                if (esporte == 1)
                    futebol++;
                 else if (esporte == 2 && idade > 18)
                    voleibolM18++;
                else if (esporte == 3 &&  idade < 18)
                    basquetebolMen18++; 

            } while (continua.Equals("s"));


            Console.WriteLine(
                $"Pessoas que gostam de futebol: {futebol}\n" +
                $"Pessoas que gostam de Vôlei e tem mais de 18 anos: {voleibolM18}\n" +
                $"Pessoas que gostam de basquete e tem menos de 18 anos: {basquetebolMen18}");
        }
    }
}