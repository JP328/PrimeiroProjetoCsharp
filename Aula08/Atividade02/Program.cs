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

            Funcionario fun1 = new Funcionario("João", "Desenvolvedor .Net Júnior", "000.000.000-00", 8, 0.00F, 2500 );
            Funcionario fun2 = new Funcionario("Mônica", "Desenvolvedora .Net Pleno", "000.000.000-00", 8, 0.00F, 5000 );

            fun1.View();
            fun2.View();
        }
    }
}