using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp07.OO
{

    interface IOperacaoBinaria
    {
        int Operacao(int a, int b);
    }

    class Soma : IOperacaoBinaria
    {
        public int Operacao(int a, int b)
        {
            return a + b;
        }
    }
    class Subtrair : IOperacaoBinaria
    {
        public int Operacao(int a, int b)
        {
            return a - b;

        }
    }


        class Multipicacao : IOperacaoBinaria
        {
            public int Operacao(int a, int b)
            {
                return a * b;
            }
        }

    class Calculadora
    {
        List<IOperacaoBinaria> operacoes = new List<IOperacaoBinaria>{

            new Soma(),
            new Subtrair(),
            new Multipicacao()
             };

        public string ExecutarOperaçoes(int a, int b)
        {
            string result = "";

            foreach (var op in operacoes)
            {
                result += $"Usando {op.GetType().Name}= {op.Operacao(a, b)}\n";

            }
            return result;
        }
    }
        
    

        class Interface
        {
            public static void Executar()
            {
                var calc = new Calculadora();
                var resultado = calc.ExecutarOperaçoes(30, 50);
                Console.WriteLine(resultado);


            }
        }
 }   

