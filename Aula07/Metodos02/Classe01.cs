using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos02
{
    public class Classe01
    {
        public static void MetodoPublico()
        {
            Console.WriteLine("Método Público da Classe01");
        }

        internal static void MetodoInternal()
        {
            Console.WriteLine("Método Interno da Classe01");
        }

        protected static void MetodoProtegido()
        {
            Console.WriteLine("Método Protegido da Classe01");
        }

        private static void MetodoPrivado()
        {
            Console.WriteLine("Método Privado da Classe01");
        }
    }
}
