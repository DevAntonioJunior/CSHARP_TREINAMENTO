using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp07.Colecao
{
    class Igualdade
    {
        public static void Executar() {
            var p1 = new Produto("Caneta", 1.89); 
            var p2 = new Produto("Caneta", 1.89);

            Console.WriteLine(p1 == p2); 



        }
    }
}
