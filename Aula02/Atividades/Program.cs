using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Atividades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int atividade;

            Console.WriteLine("\n----------------------------------------------------------------\n");
            Console.WriteLine("             Escolha qual atividade que inicializar\n");
            Console.WriteLine("   *Digite 1 para a Atividade 1");
            Console.WriteLine("   *Digite 2 para a Atividade 2");
            Console.WriteLine("   *Digite 3 para a Atividade 3");
            Console.WriteLine("   *Digite 4 para a Atividade 4");
            Console.WriteLine("\n----------------------------------------------------------------\n");

            atividade = Convert.ToInt32(Console.ReadLine());

            void Atividade1()
            {
                float salary, allowance;

                Console.WriteLine("\n---------------------- # ATIVIDADE 1 # -------------------------");
                Console.WriteLine("\n----------------------------------------------------------------");
                Console.WriteLine("\n                       Digite o sálario:");
                Console.WriteLine("\n----------------------------------------------------------------");

                salary = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine("\n----------------------------------------------------------------");
                Console.WriteLine("\n                        Digite o abono:");
                Console.WriteLine("\n----------------------------------------------------------------");

                allowance = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine("\nNovo Sálario: {0:F2}", (salary + allowance));
                Console.WriteLine("\n-------------------------- * FIM * -----------------------------");
            }

            void Atividade2()
            {
                float grade1, grade2, grade3, grade4, average;

                Console.WriteLine("\n---------------------- # ATIVIDADE 2 # -------------------------");
                Console.WriteLine("\n----------------------------------------------------------------");
                Console.WriteLine("\nDigite a primeira nota:");
                grade1 = Convert.ToSingle(Console.ReadLine());  

                Console.WriteLine("\nDigite a segunda nota:");
                grade2 = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine("\nDigite a terceira nota:");
                grade3 = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine("\nDigite a quarta nota:");
                grade4 = Convert.ToSingle(Console.ReadLine());
                
                Console.WriteLine("\n----------------------------------------------------------------");
                
                average = (grade1 + grade2 + grade3 + grade4)/4;
                Console.WriteLine("\nMedia Final: {0:F1}", average);
                Console.WriteLine("\n-------------------------- * FIM * -----------------------------");
            }

            void Atividade3()
            {
                float groosSalary, extraNight, overtime, discounts, netSalary;

                Console.WriteLine("\n---------------------- # ATIVIDADE 3 # -------------------------");
                Console.WriteLine("\n----------------------------------------------------------------");
                Console.WriteLine("\nDigite o sálario bruto:");
                groosSalary = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine("\nDigite o adicional noturno:");
                extraNight = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine("\nDigite as horas extras:");
                overtime = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine("\nDigite os discontos:");
                discounts = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine("\n----------------------------------------------------------------");

                netSalary = groosSalary + extraNight + (overtime * 5) - discounts;
                Console.WriteLine("\nMedia Final: {0:F2}", netSalary);
                Console.WriteLine("\n-------------------------- * FIM * -----------------------------");
            }

            void Atividade4()
            {
                float num1, num2, num3, num4, difference;

                Console.WriteLine("\n---------------------- # ATIVIDADE 4 # -------------------------");
                Console.WriteLine("\n----------------------------------------------------------------");
                Console.WriteLine("\nDigite o primeiro valor:");
                num1 = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine("\nDigite o segundo valor:");
                num2 = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine("\nDigite o terceiro valor:");
                num3 = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine("\nDigite o quarto valor:");
                num4 = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine("\n----------------------------------------------------------------");

                difference = (num1 * num2) - (num3 * num4);
                Console.WriteLine("\nDiferença: {0:F1}", difference);
                Console.WriteLine("\n-------------------------- * FIM * -----------------------------");
            }

            if (atividade == 1) {
                Atividade1 ();
            } else if (atividade == 2) {
                Atividade2();
            } else if (atividade == 3) {
                Atividade3();
            } else if (atividade == 4) {
                Atividade4();
            };
        }
    }
}