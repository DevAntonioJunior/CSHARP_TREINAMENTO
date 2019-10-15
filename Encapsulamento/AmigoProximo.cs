using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento
{
    public class AmigoProximo
    {
        public readonly Subcelebridade amiga = new Subcelebridade();

        public void MeusAcessos() {
            Console.WriteLine("Amigo Proximo....");

            Console.WriteLine(amiga.Infopublica);
            //Console.WriteLine(amiga.CorDoOlho);
            Console.WriteLine(amiga.Numerocelular);
            Console.WriteLine(amiga.JeitodeFalar);
            //Console.WriteLine(amiga.SegredoFamilia);
            //Console.WriteLine(amiga.UsamuitoPhotoshop);




        }
    }
}
