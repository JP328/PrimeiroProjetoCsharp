namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> notas = new List<double>();

            notas.Add(7.0);
            notas.Add(5.0);
            notas.Add(4.0);
            notas.Add(7.0);
            notas.Add(10.0);

            foreach (double nota in notas)
                Console.WriteLine(nota);

            Console.WriteLine("\nPosição da nota 4: " + notas.IndexOf(4));

            Console.WriteLine("\nA nota 4 existe? " + notas.Contains(4));
            notas.Remove(7);

            Console.WriteLine("\nA nota 4 existe? " + notas.Contains(4));

            Console.WriteLine("\nTamanho da lista de notas: " + notas.Count());

            notas.Sort();
            notas.Reverse();
            foreach (double nota in notas)
                Console.WriteLine(nota);

            notas[0] = 9;

            foreach (double nota in notas)
                Console.WriteLine(nota);
        }
    }
}