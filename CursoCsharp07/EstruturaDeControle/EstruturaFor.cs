using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp07.EstruturaDeControle
{
    class EstruturaFor
    {
        public static void Executar()
        {
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine($"O valor de i é {i}"); 
            //}
            double somatorio = 0;
            string entrada;

            Console.WriteLine("Informe o tamanho da turma: ");
            entrada = Console.ReadLine();
            int.TryParse(entrada, out int tamanhoturma);

            for (int i = 1; i <= tamanhoturma; i++)
            {
                Console.WriteLine("Informe a nota do aluno {0}:",i);
                entrada = Console.ReadLine();
                double.TryParse(entrada, out double NotaAtual);

                somatorio += NotaAtual; 

            }
            double media = tamanhoturma > 0 ? somatorio / tamanhoturma : 0;
            Console.WriteLine("Media da turma: {0}", media); 



        }
    
    }
}
