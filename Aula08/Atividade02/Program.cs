using Atividade02.model;

namespace Atividade02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("=================================================================================");
            Console.WriteLine("================        Atividade 02 - Funcionário         ======================");
            Console.WriteLine("=================================================================================");

            //Console.WriteLine("\n\n");
            //Funcionario fun1 = new Funcionario("João", "Desenvolvedor .Net Júnior", "000.000.000-00", 8, 0.00F, 2500 );
            //Funcionario fun2 = new Funcionario("Mônica", "Desenvolvedora .Net Pleno", "000.000.000-00", 8, 0.00F, 5000 );

            //fun1.View();
            //fun2.View();

            Console.WriteLine("\n\n");
            Gerente gen1 = new Gerente("Mônica", "Gerente De vendas", "000.000.000-00", 8, 0.00F, 5000, "Vendas");
            Gerente gen2 = new Gerente("João", "Gerente De marketing", "000.000.000-00", 8, 0.00F, 5000, "Marketing");

            gen1.View();
            gen2.View();

            Console.WriteLine("\n\n");
            Vendedor ve1 = new Vendedor("Julia", "Vendedor Júnior", "000.000.000-00", 8, 0.00F, 2000, 10000);
            Vendedor ve2 = new Vendedor("Andre", "Vendedor Sênior", "000.000.000-00", 8, 0.00F, 4000, 50000);

            ve1.View();
            ve2.View();


        }
    }
}