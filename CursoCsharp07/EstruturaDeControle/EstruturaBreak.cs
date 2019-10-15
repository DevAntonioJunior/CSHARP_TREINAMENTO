using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp07.EstruturaDeControle
{
    class EstruturaBreak
    {
        public static void Executar()
        {
            Random random = new Random();
            int numero = random.Next(1, 51);

            Console.Write("{0} é o numero que queremos?", numero);

            for (int i = 1; i <= 50; i++)
            {
                Console.Write("{0} é o numero que quermos?", i);
                if (i == numero)
                {
                    Console.WriteLine("Sim!");
                    break; 
                }
                else
                {
                    Console.WriteLine("Não!!");

                }

            }

            Console.WriteLine("FIM___O numero encotrado é {0}", numero); 




        }
    }
}
