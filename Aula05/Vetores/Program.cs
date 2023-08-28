namespace Vetores
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] vetor = { 1, 2, 3, 4, 5 };
            int[] vetor01 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] vetor02 = new int[5];

            string[] vetor03 = { "Alan", "João", "Ingrid", "Daniel", "Karina", "João" };


            foreach (int elemento in vetor)
            {
                Console.WriteLine(elemento);
            }


            //for (int indice1 = 0; indice1 < vetor01.Length; indice1++)
            //{
            //    Console.WriteLine($"vetor01[{indice1}] = {vetor01[indice1]}");
            //}

            //for (int indice1 = 0; indice1 < vetor02.Length; indice1++)
            //{
            //    Console.Write($"vetor02[{indice1}] =");
            //    vetor02[indice1] = Convert.ToInt32(Console.ReadLine());
            //}

            //Console.WriteLine("\n");
            //Array.Sort(vetor02);

            //for (int indice1 = 0; indice1 < vetor02.Length; indice1++)
            //{
            //    Console.WriteLine($"vetor02[{indice1}] = {vetor02[indice1]}");
            //}

            //Console.WriteLine("\n");
            //Array.Reverse(vetor02);

            //for (int indice1 = 0; indice1 < vetor02.Length; indice1++)
            //{
            //    Console.WriteLine($"vetor02[{indice1}] = {vetor02[indice1]}");
            //}

            //Array.Sort(vetor03);
            //for (int indice1 = 0; indice1 < vetor03.Length; indice1++)
            //{
            //    Console.WriteLine($"vetor03[{indice1}] = {vetor03[indice1]}");
            //}

            //Console.WriteLine("Qual a posição do João no vetor: " + Array.IndexOf(vetor03, "João"));
            //Console.WriteLine("Qual a posição do João no vetor: " + Array.BinarySearch(vetor03, "João"));

            //for (int indice1 = 0; indice1 < vetor01.Length; indice1++)
            //{
            //    if (vetor01[indice1] % 2 == 0)
            //        Console.WriteLine($"vetor01[{indice1}] = {vetor01[indice1]}");
            //}
        }
    }
}