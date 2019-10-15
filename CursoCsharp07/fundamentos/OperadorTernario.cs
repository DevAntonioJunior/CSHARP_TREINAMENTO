using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp07.fundamentos
{
    class OperadorTernario
    {
        public static void Executar() 
        {
            var nota = 7.0;
            bool bomCOmportamento = true;
            var resulltado = nota >= 7.0 && bomCOmportamento ?
                "Aprovado" : "Reprovado";
            Console.WriteLine(resulltado);


           
        }

    }
}
