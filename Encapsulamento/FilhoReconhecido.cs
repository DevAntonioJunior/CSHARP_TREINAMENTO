using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento
{
    public class FilhoReconhecido : Subcelebridade
    {
        public new void MeusAcessos() {
            Console.WriteLine("FIlhoreconhecido......");


            Console.WriteLine(Infopublica);
            Console.WriteLine(CorDoolho);
            Console.WriteLine(Numerocelular);
            Console.WriteLine(JeitodeFalar);
            Console.WriteLine(segredoFamilia);
            ///Console.WriteLine(UsamuitoPhothoshop);

            

        }
    }
}
