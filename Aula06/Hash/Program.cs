namespace Hash
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> setNomes = new HashSet<string>()
            {
                "Allan", "João", "Ingrid", "Allan", "Robson"
            };

            foreach( var nome in  setNomes ) 
                Console.WriteLine(nome);

            Console.WriteLine("\n");

            setNomes.Add("Samantha");
            // setNomes.Add(null);
            setNomes.Add("Julia");

            foreach (var nome in setNomes)
                Console.WriteLine(nome);

            Console.WriteLine("O nome Julia existe? " + setNomes.Contains("Julia"));
            setNomes.Remove("João");

            foreach (var nome in setNomes)
                Console.WriteLine(nome);

            
            Console.WriteLine("\n");


            List<string> hashList = setNomes.ToList();
            hashList.Sort();

            foreach (var hash in hashList)
                Console.WriteLine(hash);

        }
    }
}