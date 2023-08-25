namespace RH
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cargo;
            string ?nome;
            float salario, reajuste;

            
            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();

            Console.Write($"\nMuito bom te ver aqui {nome}! Agora digite o número do seu cargo: ");
            cargo = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nDigite seu sálario agora: ");
            salario = Convert.ToSingle(Console.ReadLine());

            switch (cargo)
            {
                case 1:
                    reajuste = (salario * 7) /100;
                    break;
                case 2:
                    reajuste = (salario * 9) / 100;
                    break;
                case 3:
                    reajuste = (salario * 5) / 100;
                    break;
                default:
                    reajuste = (salario * 12) / 100;
                    break;
            }

            Console.WriteLine($"\nCerto {nome}, seu reajuste de sálario é: {reajuste}");
            Console.WriteLine($"Seu novo sálario é de: {salario + reajuste}!!!\n\n");



        }
    }
}