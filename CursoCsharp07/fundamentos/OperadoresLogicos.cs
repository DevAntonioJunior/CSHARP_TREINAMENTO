﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp07.fundamentos
{
    class OperadoresLogicos
    {
        public static void Executar()
        {
            var executouTrabalho1 = true;
            var executouTrabalho2 = false;

            var comprouTv50 = executouTrabalho1 && executouTrabalho2;
            Console.WriteLine("Comprou a tv 50?{0}",comprouTv50);

            var comprouSorvete = executouTrabalho1 || executouTrabalho2;
            Console.WriteLine(" Comprou o sorvete?",comprouSorvete);

            var comprouTv32 = executouTrabalho1 ^ executouTrabalho2;
            Console.WriteLine("Comprou a tv 32? {0}", comprouTv32);

            Console.WriteLine("Mais saudavel? ", !comprouSorvete); 


        }
    }
}
