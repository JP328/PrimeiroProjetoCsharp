namespace Transporte
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Transporte t1 = new Transporte(50);
            Terrestre t2 = new Terrestre(4, 50, 80);
            Automovel a1 = new Automovel("branco", "GIN-2F25", 4, 1, 4, 50, 80);

            Console.WriteLine("---------------------------------------------------------------------------\n\n");

            t1.Visualizar();

            Console.WriteLine("\n\n");
            
            t2.Visualizar();

            Console.WriteLine("\n\n");

            a1.Visualizar();
        }
    }
}