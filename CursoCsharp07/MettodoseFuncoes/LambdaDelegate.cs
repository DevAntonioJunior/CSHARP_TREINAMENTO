using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp07.MettodoseFuncoes
{
        delegate double Operacao(double x, double y);


    class LambdaDelegate
    {

        public static void Executar() {
            Operacao sum = (x, y) => x + y;
            Operacao sub = (x, y) => x - y;
            Operacao mul = (x, y) => x * y;
            Operacao div= (x, y) => x / y;



            Console.WriteLine (sum(5, 3));
            Console.WriteLine (mul(5, 3));
            Console.WriteLine (sub(5, 3));
        }
    }
}
