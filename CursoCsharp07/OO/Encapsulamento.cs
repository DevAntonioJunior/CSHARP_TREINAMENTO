using System;
using Encapsulamento;
namespace CursoCsharp07.OO
{
    class Encapsulamento
    {
        public class FilhoNaoReconhecido : Subcelebridade
        {
            public new void MeusAcessos()
            {
                Console.WriteLine("FilhoNaoReconhecido....");

                Console.WriteLine(Infopublica);
                Console.WriteLine(CorDoolho);
                //  Console.WriteLine(NumeroDocelular); 
                Console.WriteLine(JeitodeFalar);
                //Console.WriteLine(SegredoFamilia); 
                // Console.WriteLine(UsaMuitoPhotoshop); 


            }
        }


        public class AmigoDistante
        {
            public readonly Subcelebridade amiga = new Subcelebridade();


            public void MeusAcessos()
            {
                Console.WriteLine("AmigoDistante....");

                Console.WriteLine(amiga.Infopublica);
                // Console.WriteLine(amiga.CorDoolho);
                //  Console.WriteLine(amiga.NumeroDocelular); 
                // Console.WriteLine(amiga.JeitodeFalar);
                //Console.WriteLine(amiga.SegredoFamilia); 
                // Console.WriteLine(amigaUsaMuitoPhotoshop); 
            }

        }




        public static void Executar()
        {
            Subcelebridade sub = new Subcelebridade();
            sub.MeusAcessos();

            new FilhoReconhecido().MeusAcessos();

            new AmigoProximo().MeusAcessos();

            new FilhoNaoReconhecido().MeusAcessos();

            new AmigoDistante().MeusAcessos();

        }
    }
}


