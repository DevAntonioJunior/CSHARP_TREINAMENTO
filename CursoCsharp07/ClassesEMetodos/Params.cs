using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp07.ClassesEMetodos
{
    class Params
    {

        public static void recepcionar(params string[] pessoas)
        {
            foreach (var pessoa in pessoas) {
                Console.WriteLine("Ola {0}", pessoa);
            }


        }

        public static void Executar()
        {
            recepcionar("Pedro", "Assis", "Carol"); 

        }
    }
}
