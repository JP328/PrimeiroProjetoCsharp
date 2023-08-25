namespace Atividades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int activitiesList, endProgram = 0;

            do
            {
                Console.WriteLine("=============================================================");
                Console.WriteLine("=================== +  ATIVIDADES  + ========================");
                Console.WriteLine("=============================================================");

                Console.WriteLine("\nPara selecionar as listas de exercício digite:");
                Console.WriteLine("\n1 - Lista de Laços Condicionais IF");
                Console.WriteLine("\n2 - Lista de Laços Condicionais SWITCH\n");
                Console.WriteLine("\n3 - Encerrar programa\n");

                activitiesList = Convert.ToInt32(Console.ReadLine());

                Console.Clear();


                if (activitiesList == 1)
                    ListaIF();
                else if (activitiesList == 2)
                    ListaSwitch();
                else if (activitiesList == 3)
                    endProgram = 1;
                else {
                    Console.WriteLine("Opção inválida");
                    reset();
                }  
                
            } while (endProgram == 0);


            void ListaIF()
            {
                int ifExercises;

                Console.WriteLine("\n------------------------------------------------------------");
                Console.WriteLine("---------------- Laço Condicional IF ------------------------");
                Console.WriteLine("-------------------------------------------------------------");
                Console.WriteLine("--------- SELECIONE O EXERCÍCIO QUE QUER EXECUTAR: ----------");
                Console.WriteLine("\nExercicio 2 (Digite 1)");
                Console.WriteLine("\nExercício 4 (Digite 2)\n");

                ifExercises = Convert.ToInt32(Console.ReadLine());
                
                Console.Clear();
                
                if (ifExercises == 1)
                    Exercise1If();
                else if (ifExercises == 2)
                    Exercise2If();
                else
                    Console.WriteLine("Opção inválida");
            }

            void ListaSwitch()
            {
                int switchExercises;
                Console.WriteLine("\n------------------------------------------------------------");
                Console.WriteLine("--------------- Laço Condicional SWITCH ---------------------");
                Console.WriteLine("-------------------------------------------------------------");
                Console.WriteLine("--------- SELECIONE O EXERCÍCIO QUE QUER EXECUTAR: ----------");
                Console.WriteLine("\nExercicio 5 (Digite 1)");
                Console.WriteLine("\nExercício 8 (Digite 2)\n");

                switchExercises = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                if (switchExercises == 1)
                    Exercise1Switch();
                else if (switchExercises == 2)
                    Exercise2Switch();
                else
                    Console.WriteLine("Opção inválida");
            }
        
            void Exercise1If() 
            {
                int number;

                Console.WriteLine("-----------------------------------------------------------------"); 
                Console.WriteLine("------------------ # Exercício 2 - Lista 01 # -------------------"); 
                Console.WriteLine("-----------------------------------------------------------------"); 
                Console.WriteLine("\nDigite um Número:");
                
                number = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\n-----------------------------------------------------------------\n");
                if (number % 2 == 0)
                    Console.WriteLine((number > 0) ? 
                        $"O Número {number} é par e positivo!" : 
                        $"O Número {number} é par e negativo!");
                else
                    Console.WriteLine((number > 0) ?
                        $"O Número {number} é ímpar e positivo!" :
                        $"O Número {number} é ímpar e negativo!");

                reset();
            }

            void Exercise2If() 
            {
                string? vertebrate;
                string? animalType;
                string? food;

                Console.WriteLine("-----------------------------------------------------------------");
                Console.WriteLine("------------------ # Exercício 4 - Lista 01 # -------------------");
                Console.WriteLine("-----------------------------------------------------------------");
                Console.WriteLine("\n Digite vertebrado ou invertebrado:");
                vertebrate = Console.ReadLine()?.ToLower();

                Console.WriteLine(
                    "\nSe você digitou vertebrado agora digite ave ou mamífero.\n" +
                    "Caso contrario digite inseto ou anélideo.\n"
                );
                animalType = Console.ReadLine()?.ToLower();
                

                Console.WriteLine(
                    "\nDigite as alternativas conforme a opção que escolheu:\n" +
                    "(Ave) - carnívoro ou onívoro\n" +
                    "(Mamífero) - herbívoro ou onívoro\n" +
                    "(Inseto) - hematófago ou herbívoro\n" +
                    "(Anélideo) - hematófago ou onívoro\n"
                );
                food = Console.ReadLine()?.ToLower();

                Console.Clear();
                Console.WriteLine("--------------------------------------------------------------------");

                if (vertebrate is not null && animalType is not null && food is not null)
                {
                    if (vertebrate.Equals("vertebrado"))
                        if (animalType.Equals("ave"))
                            Console.WriteLine(food.Equals("carnívoro") ? "\nÁguia" : "\nPombo");
                        else
                            Console.WriteLine(food.ToUpper().Equals("onívoro") ? "\nHomem" : "\nVaca");
                    else
                        if (animalType.Equals("inseto"))
                            Console.WriteLine(food.Equals("hematófago") ? "\nPulga" : "\nLagarta");
                        else
                            Console.WriteLine(food.Equals("hematófago") ? "\nSanguessuga" : "\nMinhoca");
                }

                reset();
            }
            
            void Exercise1Switch() 
            {
                int cod;
                float quantity;

                Console.WriteLine("-----------------------------------------------------------------");
                Console.WriteLine("------------------ # Exercício 5 - Lista 02 # -------------------");
                Console.WriteLine("-----------------------------------------------------------------");
                Console.WriteLine("\n------------------- Códigos disponíveis: ------------------------\n");
                
                Console.WriteLine(
                    "             1 = Cachorro Quente  - R$10,00\n" +
                    "             2 = X - Salada       - R$15,00\n" +
                    "             3 = X - Bacon        - R$18,00\n" +
                    "             4 = Bauru            - R$12,00\n" +
                    "             5 = Refrigerante     - R$8,00\n" +
                    "             6 =  Suco de Laranja - R$13,00\n");
             
                Console.WriteLine("\nDigite o código do produto:");
                cod = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nMuito bem! Agora digite a quantidade do produto:");
                quantity = Convert.ToInt32(Console.ReadLine());

                Console.Clear();
                Console.WriteLine("\n-----------------------------------------------------------------\n");

                switch (cod)
                {
                    case 1:
                        Console.WriteLine("Produto: Cachorro Quente");
                        Console.WriteLine($"Valor total: R${(10*quantity):F2}");
                        break;
                    case 2:
                        Console.WriteLine("Produto: X - Salada");
                        Console.WriteLine($"Valor total: R${(15 * quantity):F2}");
                        break;
                    case 3:
                        Console.WriteLine("Produto: X - Bacon");
                        Console.WriteLine($"Valor total: R${(18 * quantity):F2}");
                        break;
                    case 4:
                        Console.WriteLine("Produto: Bauru");
                        Console.WriteLine($"Valor total: R${(12 * quantity):F2}");
                        break;
                    case 5:
                        Console.WriteLine("Produto: Refrigerante");
                        Console.WriteLine($"Valor total: R${(8 * quantity):F2}");
                        break;
                    case 6:
                        Console.WriteLine("Produto: Suco de Laranja");
                        Console.WriteLine($"Valor total: R${(13 * quantity):F2}");
                        break;
                    default:
                        Console.WriteLine(("Pedidio Inválido"));
                        break;
                }

                reset();
            }

            void Exercise2Switch() 
            {
                int cod;
                float balance = 1000, value = 0;

                Console.WriteLine("-----------------------------------------------------------------");
                Console.WriteLine("------------------ # Exercício 8 - Lista 02 # -------------------");
                Console.WriteLine("-----------------------------------------------------------------");
                Console.WriteLine("\n------------------- Códigos disponíveis: ------------------------");
                Console.WriteLine("\n1 - Ver Saldo\n2 - Sacar\n3 - Depositar\n");
                Console.WriteLine("\nDigite o código da operação:");
                cod = Convert.ToInt32(Console.ReadLine());

                if (cod != 1)
                {
                    Console.WriteLine("\nDigite o valor da operação:");
                    value = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine("\n----------------------------------------------------------------\n");

                switch(cod) 
                { 
                    case 1:
                        Console.WriteLine("Operação - Saldo");
                        Console.WriteLine($"Saldo: R${balance:F2}");
                        
                        break;
                    case 2:
                        Console.WriteLine("Operação - Saque");
                        //balance -= value;
                        Console.WriteLine(
                            ((balance - value) > 0) ? 
                                $"Novo Saldo: R${balance:F2}" : 
                                "Saldo Insuficiente!");

                        break;
                    case 3:
                        Console.WriteLine("Operação - Déposito");
                        balance += value;
                        Console.WriteLine($"Novo Saldo: R${balance:F2}");

                        break;
                    default:
                        Console.WriteLine(("Operação Inválido"));
                        break;
                }

                reset();
            }

            void reset()
            {
                Console.WriteLine("\n----------------------------- FIM -----------------------------");
                Console.WriteLine("Pressione qualquer tecla para continuar");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}