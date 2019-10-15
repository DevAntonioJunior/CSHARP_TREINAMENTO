using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp07.MettodoseFuncoes
{
    class UsandoDelegates
    {
        delegate double Soma(double a, double b);
        delegate void ImprimirSenha(double x, double Y);

        static double MinhaSoma(double x, double y) {
            return x + y; 
        }

        static void MeuImprimirSoma(double a , double b)
        {
            Console.WriteLine(a + b ); 
        }
        public static  void Executar() {
            Soma op1 = MinhaSoma;
            Console.WriteLine(op1(2, 3.9));

            ImprimirSenha op2 = MeuImprimirSoma;
            op2(5.4, 8);


        }
    }
}
