using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp07.ClassesEMetodos
{

    public struct SPonto
    {
        public int X;
        public int Y;
    }

    public class Cponto
    {
        public int X;
        public int Y;
    }

    class StructVsClasse
    {
        
        public static void Executar() {
            SPonto ponto1 = new SPonto {X = 1 , Y = 3 };
            SPonto copiaponto1 = ponto1; // atribuicao por valor 
            ponto1.X= 10;

            Console.WriteLine("Ponto 1 X:{0}",ponto1.X);
            Console.WriteLine("copia do Ponto 1 X :{0} ",copiaponto1.X);

            Cponto ponto2 = new Cponto { X = 2, Y = 4 };
            Cponto copiaponto2 = ponto2; // atribuicao por referencia 
            ponto2.X = 20;

            Console.WriteLine("Ponto 2 X:{0}", ponto2.X);
            Console.WriteLine("copia do Ponto 2 X :{0} ", copiaponto2.X);

        }
    }
}
