namespace LinQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>() { 1,2,3,4,5,6,7,8,9,10};

            List<string> nomes = new List<string>() {
                "João", 
                "Breno",
                "Julia", 
                "Samantha", 
                "Vitor",
                "Victor 1",
                "Victor", 
                "Matheus", 
                "Matheus", 
                "Karina",
                "Carol"
            };

            //------------------------------------------------------------------------------------------
            var numerosAoCubo = numeros.Select(n => Math.Pow(n, 3));
        
            Console.WriteLine("Números elevados ao cubo: " + String.Join(", ", numerosAoCubo));

            var numerosImpares = from numero in numeros
                                 where numero % 2 != 0
                                 select (numero);

            Console.WriteLine("Números impares: " + String.Join(", ", numerosImpares));


            //------------------------------------------------------------------------------------------
            var nomesIniciaisMV = (from nome in nomes 
                                  where nome.StartsWith('M') ||
                                        nome.StartsWith('V')
                                  select nome).ToList();

            //nomesIniciaisMV.ForEach(n => Console.WriteLine(n));
            //Outra alternativa
            //nomesIniciaisMV.ToList().ForEach(n => Console.WriteLine(n));

            Console.WriteLine("Nomes que iniciam com a letra M ou V: " + String.Join(", ", nomesIniciaisMV));

            //verifica somente o "c" minusculo
            var nomesContemC = from nome in nomes
                                  where nome.ToLower().Contains("c")
                                  select nome;

            Console.WriteLine("Nomes que contém a letra C: " + String.Join(", ", nomesContemC));


           //------------------------------------------------------------------------------------------
            var numerosOrdemAscendente= from numero in numeros
                                 orderby numero
                                 select numero;

            Console.WriteLine("Números em ordem crescente: " + String.Join(", ", numerosOrdemAscendente));

            var numerosOrdemDescendente = from numero in numeros
                                         orderby numero descending
                                         select numero;

            Console.WriteLine("Números em ordem decrescente: " + String.Join(", ", numerosOrdemDescendente));


            //------------------------------------------------------------------------------------------
            var nomesSemRepeticao = from nome in nomes
                               .Distinct()
                               select nome;
            Console.WriteLine("Nomes sem duplicidade: " + String.Join(", ", nomesSemRepeticao));

            var contarVictors = nomes.Count(n => n.Contains("Victor"));
            Console.WriteLine("Número de vezes que o nome Victor aparece na lista: " + contarVictors);

            var primeiroVictor = nomes.First(n  => n.Contains("Victor"));
            Console.WriteLine("Primeiro Vitor  da lista: " + primeiroVictor);
        }
    }
}