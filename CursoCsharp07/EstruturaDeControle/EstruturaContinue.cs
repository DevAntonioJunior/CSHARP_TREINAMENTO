using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp07.EstruturaDeControle
{
    class EstruturaContinue
    {
        public static void Executar() {
            
            int intervalo = 50;

                Console.Write("{0} é o numero que quermos");

            for (int i = 1; i <= intervalo; i++)
            {
                if (i % 2 == 1)
                {
                    continue;
                }
                Console.Write(i + " "); 

            }
        }

    }
}
