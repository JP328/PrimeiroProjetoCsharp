using Metodos02.Namespace01;

namespace Metodos02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MetodoInternal();
            MetodoPublico();
            MetodoProtegido();
            MetodoPrivado();

            Console.WriteLine("\n");

            Classe01.MetodoPublico();
            Classe01.MetodoInternal();
            //Classe01.MetodoProtegido();
            //Classe01.MetodoPrivado();

            Console.WriteLine("\n");

            Classe02.MetodoPublico();
            Classe02.MetodoInternal();
            Classe02.MetodoProtegido();
            Classe02.MetodoPrivado();
        }

        public static void MetodoPublico() 
        {
            Console.WriteLine("Método Público da classe Program");
        }
        internal static void MetodoInternal()
        {
            Console.WriteLine("Método Interno da classe Program");
        }
        protected static void MetodoProtegido()
        {
            Console.WriteLine("Método Protegido da classe Program");
        }
        private static void MetodoPrivado()
        {
            Console.WriteLine("Método Privado da classe Program");
        }
    }
}