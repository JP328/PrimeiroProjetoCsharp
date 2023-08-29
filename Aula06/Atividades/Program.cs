namespace Atividades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int exerciseNum;

            do 
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("=======================================================================");
                Console.WriteLine("\n========================= ESCOLHA OS EXERCÍCIOS =======================\n");
                Console.WriteLine("=======================================================================");

                Console.WriteLine("\n Exercício 1 Lista 01 — Collection List     (Digite 1)");
                Console.WriteLine("\n Exercício 2 Lista 01 — Collection List     (Digite 2)");
                Console.WriteLine("\n Exercício 3 Lista 02 — Collection HashSet  (Digite 3)");
                Console.WriteLine("\n Exercício 4 Lista 02 — Collection HashSet  (Digite 4)");
                Console.WriteLine("\n Exercício 1 — Fila                         (Digite 5)");
                Console.WriteLine("\n Exercício 2 — Pilha                        (Digite 6)");

                exerciseNum = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

            } while (exerciseNum < 1 || exerciseNum > 6);

            switch (exerciseNum) 
            {
                case 1:
                    exercise1();
                    break;
                case 2:
                    exercise2();
                    break;
                case 3:
                    exercise3();
                    break;
                case 4:
                    exercise4();
                    break;
                case 5:
                    exercise1DataStructure();
                    break;
                default: 
                    exercise2DataStructure();
                    break;
            }

            //if (exerciseNum == 1)
            //    exercise1();
            //else if (exerciseNum == 2)
            //    exercise2();
            //else if (exerciseNum == 3)
            //    exercise3();
            //else if (exerciseNum == 4)
            //    exercise4();
            //else if (exerciseNum == 5)
            //    exercise1DataStructure();
            //else 
            //    exercise2DataStructure();

            //System.Environment.Exit(0);

            void exercise1() 
            {
                List<string> colors = new List<string>(); 

                Console.WriteLine("Digite 5 Cores diferentes:");
                for (int i = 0; i < 5; i++) 
                {
                    string? color = Console.ReadLine();
                    if (color is not null && color != "")
                        colors.Add(color);
                }

                Console.WriteLine("\n---------------------- Listar todas as cores: ----------------------\n");
                foreach (var color in  colors)
                    Console.WriteLine(color);

                Console.WriteLine("\n------------------------ Ordenar as cores: -------------------------\n");
                colors.Sort();
                foreach (var color in colors)
                    Console.WriteLine(color);
            }

            void exercise2() 
            {
                int num;
                List<int> integerNumbers = new List<int>()
                {
                    2, 5, 1, 3, 4, 9, 7, 8, 10, 6
                };

                Console.WriteLine("Digite um Número inteiro:");
                num = Convert.ToInt32(Console.ReadLine());

                if (integerNumbers.Contains(num))
                    Console.WriteLine($"\nO número {num} está localizado na posição: {integerNumbers.IndexOf(num)}");
                else
                    Console.WriteLine($"\nO número {num} não foi encontrado!");
            }
            
            void exercise3() 
            {
                HashSet<int> integerNumbers = new HashSet<int>();

                Console.WriteLine("Escreva um total de dez números inteiros:");
                for(int i = 0; i < 10; i++)
                    integerNumbers.Add(Convert.ToInt32(Console.ReadLine()));

                Console.WriteLine("\nListar dados do HashSet:");
                foreach(var num in integerNumbers)
                    Console.WriteLine(num); 
            }
            
            void exercise4() 
            {
                int num;
                HashSet<int> integerNumbers = new HashSet<int>()
                {
                    2, 5, 1, 3, 4, 9, 7, 8, 10, 6
                };

                Console.WriteLine("Digite um Número inteiro:");
                num = Convert.ToInt32(Console.ReadLine());

                if (integerNumbers.Contains(num))
                    Console.WriteLine($"\nO número {num} foi encontrado!");
                else
                    Console.WriteLine($"\nO número {num} não foi encontrado!");
            }
        
            void exercise1DataStructure() 
            {
                int action;
                Queue<string> bankQueue = new Queue<string>();

                do
                {
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("*********************************************************************\n");
                        Console.WriteLine("                         1 - Adicionar Clientes na Fila");
                        Console.WriteLine("                         2 - Listar todos os Clientes");
                        Console.WriteLine("                         3 - Retirar Cliente da Fila");
                        Console.WriteLine("                         0 - Sair");
                        Console.WriteLine("\n*********************************************************************\n");
                        Console.WriteLine("Entre com a opção desejada:");
                        action = Convert.ToInt32(Console.ReadLine());
                    } while (action > 6 || action < 0);


                    if (action == 1)
                    {
                        string? client;

                        Console.Clear();
                        Console.WriteLine("Escreva o nome do Cliente:\n");
                        
                        client = Console.ReadLine();
                        if(client is not null)
                            bankQueue.Enqueue(client);

                        Console.Clear();
                        Console.WriteLine("Fila\n");
                        ListClients();

                        Console.WriteLine("\n\nCliente adicionado a fila!");
                        Reset();
                    }
                    if(action == 2) 
                    {
                        Console.Clear();
                        Console.WriteLine("Lista de Clientes na Fila:");
                        ListClients();
                        Reset();
                    }
                    if(action == 3) 
                    {
                        Console.Clear();
                        if (bankQueue.Count() == 0) 
                        {
                            Console.WriteLine("A fila está vazia!");
                            Reset();
                        }
                        else 
                        {
                            Console.WriteLine("Fila:\n");

                            bankQueue.Dequeue();
                            ListClients();

                            Console.WriteLine("\n\nO Cliente foi chamado!");
                            Reset();
                        }
                    }
                } while (action != 0);

                void ListClients()
                {
                    foreach (var client in bankQueue)
                        Console.WriteLine(client);
                }

                void Reset()
                {
                    Console.WriteLine("\n\n\nPressione qualquer tecla para voltar ao menu!");
                    Console.ReadKey();
                }
            }
            
            void exercise2DataStructure() 
            {
                int action;
                Stack<string> pilebooks = new Stack<string>();

                do
                {
                    do
                    {
                        Console.Clear();
                        //Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("*********************************************************************");
                        Console.WriteLine("                                                                     ");
                        Console.WriteLine("                         1 - Adicionar Livro na pilha                  ");
                        Console.WriteLine("                         2 - Listar todos os Livros                    ");
                        Console.WriteLine("                         3 - Retirar Livro da pilha                    ");
                        Console.WriteLine("                         0 - Sair                                      ");
                        Console.WriteLine("                                                                     ");
                        Console.WriteLine("*********************************************************************");
                        Console.WriteLine("                                                                     ");
                        Console.WriteLine("Entre com a opção desejada:");
                        //Console.ResetColor();
                        action = Convert.ToInt32(Console.ReadLine());
                    } while (action > 6 || action < 0);

                    if (action == 1)
                    {
                        string? book;

                        Console.Clear();
                        Console.WriteLine("Escreva o nome do Livro:\n");

                        book = Console.ReadLine();
                        if (book is not null)
                            pilebooks.Push(book);

                        Console.Clear();
                        Console.WriteLine("Pilha\n");
                        ListClients();

                        Console.WriteLine("\n\nLivro adicionado a pilha!");
                        Reset();
                    }
                    if (action == 2)
                    {
                        Console.Clear();
                        Console.WriteLine("Lista de Livros na Pilha:");
                        ListClients();
                        Reset();
                    }
                    if (action == 3)
                    {
                        Console.Clear();
                        if (pilebooks.Count == 0)
                        {
                            Console.WriteLine("A pilha está vazia!");
                            Reset();
                        }
                        else
                        {
                            Console.WriteLine("Pilha:\n");

                            pilebooks.Pop();
                            ListClients();

                            Console.WriteLine("\n\nUm Livro foi retirado da pilha!");
                            Reset();
                        }
                    }

                } while (action != 0);

                void ListClients()
                {
                    foreach (var book in pilebooks)
                        Console.WriteLine(book);
                }

                void Reset()
                {
                    Console.WriteLine("\n\n\nPressione qualquer tecla para voltar ao menu!");
                    Console.ReadKey();
                }
            }
        }
    }
}