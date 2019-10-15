using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp07.OO
{
    public abstract class Celular
    {
        public abstract string Assistente();

        public string Tocar()
        {

            return "Trim , Trim ";
        }
    }
        public class Samsung : Celular {
            public override string Assistente()
            {
            return "Ola meu nome é bixby"; 
            }
        }

        public class Iphone : Celular {
            public override string Assistente()
            {
                return "Ola meunome é Siri";
            }
        }


    
    class Abstract
    {
        public static void Executar() {

            var celulares = new List<Celular> {
             new Samsung(),
             new Iphone()
            };
            
            foreach (var celular in celulares)
            {
                Console.WriteLine(celular.Assistente()); 

            }

        }
    }
}
