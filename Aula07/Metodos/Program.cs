using static System.Runtime.InteropServices.JavaScript.JSType;
using Metodos02.Namespace01;

namespace Metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float numero, numero2;

            Console.WriteLine("Digite o primeiro número:");
            numero = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            numero2 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine($"{numero} + {numero2} = " + Somar(numero, numero2));
            Console.WriteLine($"{numero} - {numero2} = " + Subtrair(numero, numero2));
            Console.WriteLine($"{numero} * {numero2} = " + Multiplicar(numero, numero2));
            Console.WriteLine("{0:F} / {1:F} = {2:F2}", numero, numero2, Dividir(numero, numero2));
            Console.WriteLine($"{numero} ^ {numero2} = " + Potencia(numero, numero2));
            Console.WriteLine($"Raiz quadrada de {numero} = " + Raiz(numero));

            Dev();

            Classe02.MetodoPublico();

            
        }

        static float Somar(float num, float num2) 
        {
            return num + num2;
        }

        static float Subtrair(float num, float num2)
        {
            return num - num2;
        }

        static float Multiplicar(float num, float num2)
        {
            return num * num2;
        }

        static float Dividir(float num, float num2)
        {
            if (num2 > 0)
                return num / num2;
            else
                return 0;
        }

        static double Potencia(float num, float num2)
        {
            return Math.Pow(num, num2);
        }

        static double Raiz(float num)
        {
            return Math.Sqrt(num);
        }

        static void Dev() 
        {
            Console.WriteLine("Criado por, João Pedro!");
        }
    }
}