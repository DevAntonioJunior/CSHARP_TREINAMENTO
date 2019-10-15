using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp07.MettodoseFuncoes
{
    public static class ExtensoesInteiro {

    public static int Soma(this int num, int outronumero)
    {
        return num + outronumero;
    }

    public static int  Subtracao(this int num , int outronumero)
    {
        return num - outronumero; 
    }

    }

    class MetodosDeExtensao
    {

        public static void Executar() {

        int numero = 5;


            Console.WriteLine(numero.Soma(3)); 
            Console.WriteLine(numero.Subtracao(3)); 


        }

    }
}
