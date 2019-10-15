using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp07.ClassesEMetodos
{
    class CalculadoraCadeia {
        int memoria;

        public CalculadoraCadeia Somar(int a)
        {
            memoria += a;
            return this; 
        }
        public CalculadoraCadeia Subtrair(int a)
        {
            memoria -= a;
            return this; 
        }
        public CalculadoraCadeia Multiplicaçao(int a )
        {
            memoria *= a;
            return this; 
        }
        public CalculadoraCadeia Limpar()
        {
            memoria = 0;
            return this; 
        }

        public CalculadoraCadeia Imprimir()
        {
            Console.WriteLine(memoria);
            return this; 

        }
        public int Resultado() {
            return memoria; 
        }

    }
    class MetodoComRetorno2
    {
        public static void Executar()
        {
            var calcular = new CalculadoraCadeia();
            calcular.Somar(3).Somar(4).Multiplicaçao(10).Imprimir().Resultado();

            var resultado = calcular.Somar(2).Somar(2).Resultado();
            Console.WriteLine(resultado); 
        }
    }
}
