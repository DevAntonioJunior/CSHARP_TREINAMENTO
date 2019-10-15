using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp07.ClassesEMetodos
{
    public class CalculadoraEstatica {
        public static int Somar(int a , int b)
        {
            return a + b; 
        }
        public static int Mutiplicar(int a, int b)
        {
            return a * b;
        }
    }

    class MetodoEstatico
    {
        public static void Executar()
        {
            var resultado = CalculadoraEstatica.Somar(2, 2);
            Console.WriteLine(resultado);

            Console.WriteLine(CalculadoraEstatica.Mutiplicar(2, 2));
        }


    }
}
