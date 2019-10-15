using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp07.EstruturaDeControle
{
    class EstruturaDoWhile
    {
        public static void Executar()
        {
            string entrada;

            do {
                Console.WriteLine("Qual seu nome ?");
                entrada = Console.ReadLine();
                Console.WriteLine("Seja bem vindo {0}", entrada);
                Console.WriteLine("Deseja Continura?(S/N)");
                entrada = Console.ReadLine(); 

            } while (entrada.ToLower() == "s"); 
        }
    }
}
