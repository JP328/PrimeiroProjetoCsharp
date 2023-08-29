namespace Fila
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> fila = new Queue<string>();

            fila.Enqueue("Breno");
            fila.Enqueue("Eduardo");
            fila.Enqueue("Julia");
            fila.Enqueue("leonardo");
            fila.Enqueue("Gaspar");

            fila.Dequeue();
            foreach (var pessoa in fila)
                Console.WriteLine(pessoa);

            Console.WriteLine("Quem é o primeiro da fila " + fila.Peek());

            Console.WriteLine("O Gaspar entrou na fila? " + fila.Contains("Gaspar"));
            Console.WriteLine("Número de pessoas na fila? " + fila.Count());
        }
    }
}