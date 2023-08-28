using System.Numerics;
using System.Xml.Linq;

namespace Matrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int soma = 0;
            int[,] matriz = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            int[,] matriz2 = new int[4, 4];

            int[,] matriz3 = { { 1, 2, 3 }, { 4, 5, 6 } };

            foreach (int elemento in matriz)
            {
                //elemento = matriz[lin, col];
                soma += elemento;
                if(elemento % 3 == 0)
                    Console.WriteLine(elemento);
            }

            Console.WriteLine($"A soma de todos os elemento é: {soma}");


            //for (int lin = 0; lin < matriz3.GetLength(0); lin++)
            //{
            //    for (int col = 0; col < matriz3.GetLength(1); col++)
            //    {
            //        Console.WriteLine($"Matriz[{lin}, {col}] = {matriz3[lin,col]}");

            //    }
            //}




            //for (int linha  = 0; linha < Math.Sqrt(matriz.Length); linha++)
            //{
            //    for (int col = 0; col < Math.Sqrt(matriz.Length); col++)
            //    {
            //        Console.WriteLine($"Matriz[{linha}, {col}] = {matriz[linha,col]}");
            //    }
            //}




            //Console.WriteLine("\n");

            //for (int linha = 0; linha < Math.Sqrt(matriz2.Length); linha++)
            //{
            //    for (int col = 0; col < Math.Sqrt(matriz2.Length); col++)
            //    {
            //        Console.Write($"Matriz[{linha}, {col}] = ");
            //        matriz2[linha, col] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}

            //Console.WriteLine("\n");

            //for (int linha = 0; linha < Math.Sqrt(matriz2.Length); linha++)
            //{
            //    for (int col = 0; col < Math.Sqrt(matriz2.Length); col++)
            //    {
            //        Console.WriteLine($"Matriz[{linha}, {col}] = {matriz2[linha, col]}");
            //    }
            //}

        }
    }
}