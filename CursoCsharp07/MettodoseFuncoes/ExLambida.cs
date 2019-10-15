using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp07.MettodoseFuncoes
{
    class ExLambida
    {
        public static void Executar() {

            Action <string> algoNoCOnsole = (a) =>
            {
                Console.WriteLine("Lambda com C#!"+ a);
                
            };
            algoNoCOnsole("!!");


            Func<int> jogarDado = () =>
            {
                Random aleatorio = new Random();
                return aleatorio.Next(1, 7);
            };

            Console.WriteLine(jogarDado());

            Func<int, string> conversorHex = (numero) => numero.ToString("X");
            Console.WriteLine(conversorHex(078123));


            Func< int, int,int, string> formatData = (dia, mes, ano) => 
            String.Format("{0:D2}/{1:d2}/{2:D2}", dia, mes, ano);
            Console.WriteLine(formatData(3,10,2019));
              
            
        }
    }
}
