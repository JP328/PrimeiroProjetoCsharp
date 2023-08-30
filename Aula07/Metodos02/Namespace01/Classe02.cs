using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos02.Namespace01
{
    public class Classe02
    {
        public static void MetodoPublico()
        {
            Console.WriteLine("Método Público da Classe02");
        }

        internal static void MetodoInternal()
        {
            Console.WriteLine("Método Interno da Classe02");
        }

        protected static void MetodoProtegido()
        {
            Console.WriteLine("Método Protegido da Classe02");
        }

        private static void MetodoPrivado()
        {
            Console.WriteLine("Método Privado da Classe02");
        }
    }
}
