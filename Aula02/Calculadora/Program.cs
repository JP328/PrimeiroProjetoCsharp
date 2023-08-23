namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float numero, numero2;

            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("                Digite o primeiro número:");
            Console.WriteLine("---------------------------------------------------------------");


            numero = Convert.ToSingle(Console.ReadLine());


            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("                Digite o segundo número:");
            Console.WriteLine("---------------------------------------------------------------");

            numero2 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("\nNúmero1 é: " + numero + "\n" + "Número2 é: " + numero2 + "\n");
            Console.WriteLine($"{numero} + {numero2}= " + (numero + numero2) + "\n");
            Console.WriteLine($"{numero} - {numero2}= " + (numero - numero2) + "\n");
            Console.WriteLine($"{numero} x {numero2}= " + (numero * numero2) + "\n");

            Console.WriteLine($"{numero} / {numero2}= " + "{0:F2}\n", (numero / numero2));
            Console.WriteLine($"{numero} / {numero2}= " + $"{(numero / numero2):F2}\n");
            Console.WriteLine("Divisão {0} / {1} =  {2:F2}", numero, numero2, (numero / numero2));
            
            Console.WriteLine("\n" + Math.Round(numero / numero2, 2));

            Console.WriteLine($"{numero} ^ {numero2}= " + Math.Pow(numero, numero2));
            Console.WriteLine($"Raiz quadrada de {numero} = " + Math.Sqrt(numero));

        }
    }
}