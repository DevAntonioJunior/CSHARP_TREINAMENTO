using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento
{
   public  class Subcelebridade
    {
        // todos 
        public string Infopublica = "tenho um instagram";

        // herança  
        protected string CorDoolho = "Verde";

        // mesmo projeto 
        internal ulong Numerocelular = 222222222222;

        // heranca ou mesmo projeto
        protected internal string JeitodeFalar = "Uso muitas girias";

        // mesma class ou herançça no mesmo projeto 
        private protected string segredoFamilia = "bla bala";

        // private é o padrao 
        readonly bool  UsamuitoPhothoshop = true;

        public void MeusAcessos() {
            Console.WriteLine("Subcelebridade...");

            Console.WriteLine(Infopublica);
            Console.WriteLine(CorDoolho);
            Console.WriteLine(Numerocelular);
            Console.WriteLine(JeitodeFalar);
            Console.WriteLine(segredoFamilia);
            Console.WriteLine(UsamuitoPhothoshop);
          


        }
    }
}
