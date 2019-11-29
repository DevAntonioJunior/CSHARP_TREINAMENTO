using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp07.Topico
{
    class Nullables
    {
        public static void Executar()
        {

            Nullable<int> numero1 = null;
            int? numero2 = null;
            if (numero1.HasValue)
            {
                Console.WriteLine("Valor de num: {0}", numero1);


            }
            else {
                Console.WriteLine("A variavel nao possui valor.");
            }

            int valor = numero1 ?? 1000;
            Console.Write(valor);

            bool? booleana = null;
            bool resultado = booleana.GetValueOrDefault();


            Console.WriteLine(resultado);
            try
            {
                int x = numero1.GetValueOrDefault();
                int y = numero2.GetValueOrDefault();
                Console.WriteLine(x + y);

            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message); 
            }


        }


    }
}
