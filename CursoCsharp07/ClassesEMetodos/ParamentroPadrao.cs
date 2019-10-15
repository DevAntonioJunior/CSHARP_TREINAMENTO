using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp07.ClassesEMetodos
{
    class ParamentroPadrao
    {


        public static int Somar(int a = 1 , int b =1)
        {
            return a + b; 
        }
        public static void Executar() {

            Console.WriteLine((Somar(10,5)));
            Console.WriteLine((Somar()));
            Console.WriteLine((Somar(3)));
            Console.WriteLine((Somar(a:5)));
            Console.WriteLine((Somar(b:100)));

        }
    }
}
