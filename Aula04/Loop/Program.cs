namespace Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int numero;
            int numero, contador = 1;
            
            Console.WriteLine("Digite o número da tabuada: ");
            numero = Convert.ToInt32(Console.ReadLine());

            /*
            for (int contador = 1; contador <= 10; contador++) {
                Console.WriteLine($"{numero} X {contador} = {numero * contador}");
            }
            */

            while (contador <= 10)
            {
                Console.WriteLine($"{numero} X {contador} = {numero * contador}");
                contador++;
            }


        }
    }
}