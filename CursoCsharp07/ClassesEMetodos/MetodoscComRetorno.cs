using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp07.ClassesEMetodos
{


    class CalculadoraComum
    {
        public int Somar(int a, int b)
        {
            return a + b; 
        }

        public int Subitrair(int a, int b)
        {
            return a - b; 
        }
        public int Multiplicar(int a, int b)
        {
            return a * b;
        }
        public int Disviao(int a, int b)
        {
            return a / b;
        }

    }
    class MetodoscComRetorno
    {
        public static void Executar() {
           var calculadora = new CalculadoraComum();
            var resultado = calculadora.Somar(5, 5);

            Console.WriteLine("resultado");
            Console.WriteLine(calculadora.Subitrair(2, 7));
            Console.WriteLine(calculadora.Multiplicar(4, 4)); 


            


        }
    }
}
