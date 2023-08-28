namespace Atividades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int activity;

            do
            {
                Console.WriteLine("Digite a atividade que deseja executar:");
                Console.WriteLine("Atividade 1 (Digite 1)");
                Console.WriteLine("Atividade 2 (Digite 2)");
                Console.WriteLine("Atividade 3 (Digite 3)");
                Console.WriteLine("Atividade 4 (Digite 4)\n");

                activity = Convert.ToInt32(Console.ReadLine());

            }while(activity < 1 || activity > 4);

            Console.Clear();

            if (activity == 1)
                Activity1();
            else if (activity == 2)
                Activity2();
            else if (activity == 3)
                Activity3();
            else
                Activity4();


            void Activity1()
            {
                //bool foundNum = false;
                int num;
                int[] vetor = { 2, 5, 1, 3, 4, 9, 7, 8, 10, 6};

                Console.WriteLine("------------------------- Atividade 1 -------------------------");
                Console.WriteLine("Digite um número para conferir a posição dele no vetor:");
                num = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\n---------------------------------------------------------------\n");

                if(Array.IndexOf(vetor, num) != -1)
                    Console.WriteLine($"O número {num} está localizado na posição: {Array.IndexOf(vetor, num)}");
                else
                    Console.WriteLine($"O número {num} não foi encontrado!");

                /*
                for (int i = 0; i < vetor.Length; i++)
                {
                    if (vetor[i] == num)
                    {
                        Console.WriteLine($"O número {num} está localizado na posição: {i}");
                        foundNum = true;
                    }
                }

                if (foundNum == false)
                    Console.WriteLine($"O número {num} não foi encontrado!");
                */
            }

            void Activity2()
            {
                float sum = 0;
                string indexPair = "", indexOdd = "";
                int[] vetor = new int[10];

                Console.WriteLine("------------------------- Atividade 2 -------------------------");
                
                for (int i = 0; i < vetor.Length; i++)
                {
                    Console.Write($"Digite um número para a posição {i} do vetor: ");
                    vetor[i] = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\n");

                    if (i % 2 != 0)
                        indexOdd += $"{vetor[i]} ";
                    if(vetor[i] % 2 == 0)
                        indexPair += $"{vetor[i]} ";

                    sum += vetor[i];
                }

                Console.WriteLine($"Elementos nos índices ímpares: {indexOdd}");
                Console.WriteLine($"\nElementos pares: {indexPair}");
                Console.WriteLine($"\n\nSoma: {sum}");
                Console.WriteLine($"Média: {sum / vetor.Length:F2}");

                /*
                Console.WriteLine("Elementos nos índices ímpares: ");
                for (int i = 0; i < vetor.Length; i++)
                {
                    if (i % 2 != 0)
                        Console.Write($"{vetor[i]} ");
                }

                Console.WriteLine("\n\nElementos pares: ");
                for (int i = 0; i < vetor.Length; i++)
                {
                    if (vetor[i] % 2 == 0)
                        Console.Write($"{vetor[i]} ");
                }

                Console.WriteLine($"\n\nSoma: {sum}");
                Console.WriteLine($"Média: {sum/vetor.Length:F2}");
             */
            }

            void Activity3()
            {
                int mainDiagonalSum = 0, secundaryDiagonalSum = 0;
                string mainDiagonal = "", secundaryDiagonal = "";
                int[,] matriz = new int[3, 3];

                Console.WriteLine("------------------------- Atividade 3 -------------------------");

                for (int lin = 0; lin < Math.Sqrt(matriz.Length); lin++)
                    for (int col = 0; col < Math.Sqrt(matriz.Length); col++)
                    {
                        Console.WriteLine($"Escreva um número para a posição {lin}:{col} da matriz:");
                        matriz[lin, col] = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("\n");
                    }

                /*
                for(int lin = 0; lin < Math.Sqrt(matriz.Length); lin++)
                    for (int col = 0; col < Math.Sqrt(matriz.Length); col++)
                    {
                        if (lin == col)
                        {
                            mainDiagonal += $"{matriz[lin, col]} ";
                            mainDiagonalSum += matriz[lin, col];
                        }

                        if (lin + col == 2)
                        {
                            secundaryDiagonal += $"{matriz[lin, col]} ";
                            secundaryDiagonalSum += matriz[lin, col];
                        }
                    }
                */

                for (int i = 0; i < Math.Sqrt(matriz.Length); i++)
                {
                    mainDiagonal += $"{matriz[i, i]} ";
                    mainDiagonalSum += matriz[i, i];

                    secundaryDiagonal += $"{matriz[i, (int)(Math.Sqrt(matriz.Length) - 1 - i)]} ";
                    secundaryDiagonalSum += matriz[i, (int)(Math.Sqrt(matriz.Length) - 1 - i)];
                }

                Console.WriteLine($"\nElementos da Diagonal Principal:\n{mainDiagonal}");
                Console.WriteLine($"\nElementos da Diagonal Secundária:\n{secundaryDiagonal}");
                Console.WriteLine($"\nSoma dos elementos da Diagonal Principal:\n{mainDiagonalSum}");
                Console.WriteLine($"\nSoma dos elementos da Diagonal Secundária:\n{secundaryDiagonalSum}");
            }

            void Activity4()
            {
                float scoreSum = 0;
                float[,] matriz = new float[10, 4];
                float[] vetor = new float[10];

                Console.WriteLine("------------------------- Atividade 4 -------------------------");
                for (int lin = 0; lin < matriz.GetLength(0); lin++) 
                {
                    for(int col = 0; col < matriz.GetLength(1); col++)
                    {
                        Console.WriteLine($"\nEscreva a nota do aluno {lin+1}, do {col+1}º Bimestre:");
                        matriz[lin, col] = Convert.ToSingle(Console.ReadLine());

                        scoreSum += matriz[lin, col];
                    }
                    vetor[lin] = scoreSum / 4;
                    scoreSum = 0;
                }

                Console.Clear();
                
                Console.WriteLine("Vetor:");
                for(int i = 0; i < vetor.Length;  i++)
                {
                    Console.Write($"{vetor[i]:F1} ");
                }
            }
        }
    }
}