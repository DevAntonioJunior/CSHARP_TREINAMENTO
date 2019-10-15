using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp07.fundamentos
{
    class OperadoresRelacionais
    {
        public static void Executar() {

            //double nota = 6.0;
            Console.Write("Digite uma nota:"); 
            double.TryParse(Console.ReadLine(), out double nota);
            double notaDecorte = 7.0;

            Console.WriteLine("Nota invalida? {0}", nota > 10.0);
            Console.WriteLine(" Nota Invalida? {0}", nota < 0.0);
            Console.WriteLine("Perfeito?{0}", nota == 10);
            Console.WriteLine("Tem como melhorar? {0}", nota!= 10.0);
            Console.WriteLine("Passou por media? {0}", nota >= notaDecorte);
            Console.WriteLine("Recuperação? {0}", nota < notaDecorte);
            Console.WriteLine("Reprovado? {0}", nota <= 3.0);

        }
    }
}
