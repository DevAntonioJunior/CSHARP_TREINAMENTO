using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp07.Colecao
{
    class ColecoesDictionary
    {
        public static void Executar()
        {
            var filmes = new Dictionary<int, string>();

            filmes.Add(2000, "Gladiador");
            filmes.Add(2002, "Homem aranha");
            filmes.Add(2004, "Incriveis");
            filmes.Add(2006, "O grande truque");

            if (filmes.ContainsKey(2004))
            {
                Console.WriteLine("2004: " + filmes[2004]);
                Console.WriteLine("2004: " + filmes.GetValueOrDefault(2004));
            }
            Console.WriteLine(filmes.ContainsValue("Aminesia"));

            Console.WriteLine($"Remove? {filmes.Remove(2004)}");

            filmes.TryGetValue(2016, out string filme2006);
            Console.WriteLine($"Filme {filme2006}!");

            // percorrendo por chaves 
            foreach (var chave in filmes.Keys)
            {
                Console.WriteLine(chave);
            }

            //Pecorrendo por valor 
            foreach (var valor in filmes.Values)
            {
                Console.WriteLine(valor); 
            }

            // pecorrendo por Chave e valor 
            foreach (KeyValuePair<int, string> filme in filmes) {
                Console.WriteLine($"{filme.Value} é de {filme.Key}."); 
            }
            foreach (var filme in filmes)
            {
                Console.WriteLine($"{filme.Value} é de {filme.Key}."); 

            }
        }
    }
}
