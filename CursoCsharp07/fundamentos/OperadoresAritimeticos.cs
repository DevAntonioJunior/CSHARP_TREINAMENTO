using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace CursoCsharp07.fundamentos
{
    class OperadoresAritimeticos
    {
        public static void  Executar (){

            // preço desconto 
            var preco = 1000.00;
            var imposto = 355;
            var desconto = 0.1;


            double total = preco + imposto;
            var totalcomDesconto = total - (total * desconto);
            Console.WriteLine("O preço final é {0}", totalcomDesconto);


            // IMC 
            double peso = 91.2; 
            double altura= 1.82;
            double imc = peso / Math.Pow(altura, 2);
            Console.WriteLine($"IMC ée {imc}.");

            // numero par/impar 
            int par = 24;
            int impar = 55;
            Console.WriteLine("{0}/2 tem resto {1}",par,par %2);
            Console.WriteLine("{0}/2 tem o resto {1}",impar,impar %2);
        

        }


    }
}
