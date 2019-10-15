using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp07.ClassesEMetodos
{
    class ParametrosNomeados
    {
        public static void Formatar(int dia, int mes, int ano)
        {
            Console.WriteLine("{0:D2}/{1:D2}/{2}",dia,mes, ano);
        }
        public static void Executar()
        {
            Formatar(dia:1,mes: 4,ano: 2019);
        }
    }

}
