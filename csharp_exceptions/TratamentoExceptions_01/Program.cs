using System.Runtime.ConstrainedExecution;

namespace TratamentoExceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero1 = 0;
            int numero2 = 0;
            bool loop = true;

            do 
            {
                try 
                {
                    Console.WriteLine("Digite o Dividendo: ");
                    numero1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Digite o Divisor: ");
                    numero2 = Convert.ToInt32(Console.ReadLine());

                    divide(numero1, numero2);
                    loop = false;
                } catch (FormatException e) 
                {
                    //Console.Error.WriteLine($"Exceção: {e.Message}");
                    Console.Error.WriteLine($"Digite valores inteiros");
                } catch (DivideByZeroException e) 
                {
                    //Console.Error.WriteLine($"Exceção: {e}");
                    Console.Error.WriteLine($"Digite valores inteiros positivos");
                } finally 
                {
                    Console.WriteLine("Sempre será executado!");
                }
            } while (loop);
        }

        public static void divide(int dividendo, int divisor)
        {
            Console.WriteLine("Divisão = " + (dividendo / divisor));
        }

    }
}