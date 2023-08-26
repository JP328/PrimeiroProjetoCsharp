namespace Atividades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int activityCod;

            do { 
                Console.WriteLine(
                    "Selecione a atividade:\n" +
                    "Atividade 1 (digite 1)\n" +
                    "Atividade 2 (digite 2)\n" +
                    "Atividade 3 (digite 3)\n" +
                    "Atividade 4 (digite 4)\n" +
                    "Atividade 5 (digite 5)\n" +
                    "Atividade 6 (digite 6)\n" +
                    "Sair (Digite 0)");

                activityCod = Convert.ToInt32(Console.ReadLine());  
                Console.Clear();
            
            } while (activityCod > 6 || activityCod < 0);

            if (activityCod == 1)
                Atividade1();
            else if (activityCod == 2)
                Atividade2();
            else if (activityCod == 3)
                Atividade3();
            else if (activityCod == 4)
                Atividade4();
            else if (activityCod == 5)  
                Atividade5();
            else if (activityCod == 6)
                Atividade6();

            void Atividade1() 
            {
                int num1, num2;

                Console.WriteLine("Digite o primeiro número do intervalo:"); 
                num1 = Convert.ToInt32(Console.ReadLine());
                
                Console.WriteLine(
                    "Digite o segundo número do intervalo\n(lembre que tem que ser um número maior do que o número anterios)"); 
                num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"No intevalo entre {num1} e {num2}:");
                if (num1 > num2)
                    Console.WriteLine("Intervalo Inválido");
                else
                    for(int i = num1; i < num2; i++) 
                    {
                        if(i % 3 == 0 && i % 5 == 0)        
                            Console.WriteLine($"{i} é multiplo de 3 e 5");    
                    }
            }

            void Atividade2() 
            {
                int num, odd = 0, pair = 0;

                for(int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Digite um número:");
                    num = Convert.ToInt32(Console.ReadLine());

                    if (num % 2 == 0)
                        odd++;
                    else
                        pair++;
                }
                Console.WriteLine($"Total de números pares: {pair}\nTotal de números ímpares: {odd}");
            }

            void Atividade3() 
            {
                int idade = 1, person21 = 0, person50 = 0;

                while (idade >= 1) 
                {
                    Console.WriteLine("Digite sua idade:");
                    idade = Convert.ToInt32(Console.ReadLine());

                    if (idade < 21 && idade > 0)
                        person21++;
                    else if (idade > 50)
                        person50++;
                }

                Console.WriteLine(
                    $"Total de pessoas menores de 21 anos: {person21}\n" +
                    $"Total de pessoas maiores de 50 anos: {person50}");

            }

            void Atividade4()
            {
                int gen, idade, developerType, 
                    backDevelopers = 0, 
                    womenFront = 0, 
                    mansMob40 = 0, 
                    noBFullstack30 = 0, 
                    total = 0, 
                    average = 0;
                string? cont = "s";

                while (cont.Equals("s")) {
                    Console.WriteLine("Digite sua idade:");
                    idade = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Digite sua identidade de gênero, conforme os códigos abaixo:\n" +
                        "1 – Mulher Cis\n" +
                        "2 – Homem Cis\n" +
                        "3 – Não Binário\n" +
                        "4 – Mulher Trans\n" +
                        "5 – Homem Trans\n" +
                        "6 – Outros\n");
                    gen = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Digite sua área, conforme os códigos abaixo:\n" +
                        "1 – Backend\n" +
                        "2 – Frontend\n" +
                        "3 – Mobile\n" +
                        "4 – FullStack\n");
                    developerType = Convert.ToInt32(Console.ReadLine());

                    total++;
                    average += idade;
                    if (developerType == 1)
                        backDevelopers++;
                    if((gen == 1 || gen == 4) && developerType == 2)
                        womenFront++;
                    if(developerType == 3 && (gen == 2 || gen == 5) && idade > 40)
                        mansMob40++;
                    if (gen == 3 &&  developerType == 4 && idade < 30)
                        noBFullstack30++;

                    Console.WriteLine("Você deseja continuar a leitura dos dados de um novo colaborador ou não (S/N):");
                    if(cont is not null)
                        cont = Console.ReadLine();
                }

                Console.WriteLine($"O número de pessoas desenvolvedoras Backend: {backDevelopers}\n" +
                    $"O número de Mulheres Cis e Trans desenvolvedoras Frontend: {womenFront}\n" +
                    $"O número de Homens Cis e Trans desenvolvedores Mobile maiores de 40 anos: {mansMob40}\n" +
                    $"O número de Não Binários desenvolvedores FullStack menores de 30 anos: {noBFullstack30}\n" +
                    $"O número total de pessoas que responderam à pesquisa: {total}\n" +
                    $"A média de idade das pessoas que responderam à pesquisa: {average/total}");

            }
            
            void Atividade5() 
            {
                int num, sum = 0;

                do
                {
                    Console.WriteLine("Escreva um número inteiro:\nPara sair digite 0");
                    num = Convert.ToInt32(Console.ReadLine());

                    if (num > 0)
                        sum += num;

                } while (num != 0);

                Console.WriteLine($"A soma dos números inteiro positivos que foram digitados é {sum}");
            }
        
            void Atividade6() 
            {
                float average = 0, num, numMult3 = 0;

                do
                {
                    Console.WriteLine("Digite um número inteiro: ");
                    num = Convert.ToInt32(Console.ReadLine());
                
                    if(num > 0 && num % 3 == 0) 
                    {
                        average += num;
                        numMult3++;
                    }
                } while(num != 0);
                    
                Console.WriteLine($"A média de todos os números múltiplos de 3 é {average/numMult3:F2}");
            }
        }
    }
}