using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp07.fundamentos
{
    class OperadoreAtribuicao
    {
        public static void Executar() {
            var num1 = 3;
            num1 = 7; 
            num1 += 10;
            num1 -= 3;
            num1 *= 16;
            num1 /= 17;


                Console.WriteLine(num1);
                


            int a = 1;
            int b = a;

            a++;
            b--;

            Console.WriteLine($"{a} {b}");


            dynamic c = new System.Dynamic.ExpandoObject();
            c.nome = "joao";

            dynamic d = c;
            d.nome = "Maria";

            Console.WriteLine(c.nome);

            
        }
    }
}
