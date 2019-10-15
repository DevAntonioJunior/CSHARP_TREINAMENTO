using System;
using System.Collections;
using System.Text;

namespace CursoCsharp07.Colecao
{
    class ColecoesArrayList
    {
        public static void Executar()
        {
            var arraylist = new ArrayList {
                "palavra", 
                3,
                true
            };

            foreach (var item in arraylist) {
                Console.WriteLine("{0} => {1}", item, item.GetType()); 
            }


        }
    }
}
