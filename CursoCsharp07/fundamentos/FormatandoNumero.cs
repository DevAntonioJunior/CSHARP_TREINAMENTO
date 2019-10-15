using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace CursoCsharp07.fundamentos
{
    class FormatandoNumero
    {
        public static void Executar() {

            double valor = 15.175;
            int inteiro = 256;
            Console.WriteLine(valor.ToString("F1"));
            Console.WriteLine(valor.ToString("C"));
            Console.WriteLine(valor.ToString("P"));
            Console.WriteLine(valor.ToString("#.##"));

            CultureInfo cultura = new CultureInfo("pt-BR");
            Console.WriteLine(valor.ToString("C0", cultura));

            Console.WriteLine(inteiro.ToString("D10"));

        }
    }
}
