namespace Pilha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> pilha = new Stack<string>();

            pilha.Push("Breno");
            pilha.Push("Eduardo");
            pilha.Push("Julia");
            pilha.Push("leonardo");
            pilha.Push("Gaspar");

            pilha.Pop();
            foreach (var pessoa in pilha)
                Console.WriteLine(pessoa);

            Console.WriteLine("Quem é o primeiro da pilha " + pilha.Peek());

            Console.WriteLine("O Gaspar entrou na pilha? " + pilha.Contains("Gaspar"));
            Console.WriteLine("Número de pessoas na pilha? " + pilha.Count());
        }
    }
}