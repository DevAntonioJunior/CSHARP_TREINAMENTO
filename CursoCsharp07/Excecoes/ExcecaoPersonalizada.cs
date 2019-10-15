using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp07.Excecoes
{
    public class NegativoExcepition : Exception
    {
        public NegativoExcepition() { }

        public NegativoExcepition(string message) : base(message) { }

        public NegativoExcepition(string message, Exception inner)
                : base(message, inner) { }

    }
    public class ImparException : Exception {
        public ImparException(string message) : base(message) { }
    }


    class ExcecaoPersonalizada
    {
        public static int PositivoPar() {
            Random random = new Random();
            int valor = random.Next(-30, 30);

            if (valor < 0) {
                throw new NegativoExcepition("numero negativo....("); 
            }
            if (valor % 2 == 1) {
                throw new ImparException("valor impar...("); 
            }
            return valor;

        }

        public static void Executar()
        {
            try
            {
                Console.WriteLine(PositivoPar());
            }
            catch (NegativoExcepition ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ImparException ex) {
                Console.WriteLine(ex.Message); 
            }


        }
    }
}
