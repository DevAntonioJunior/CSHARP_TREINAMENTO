using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp07.EstruturaDeControle
{
    class EstruturaWhile
    {
        public static void Executar()
        {
            int palpite = 0;
            Random random = new Random();

            int numeroSecreto = random.Next(1, 16);
            bool numeroEncontrdo = false;
            int tentativasRestantes = 5;
            int tentativas = 0;

            while (tentativasRestantes > 0 && !numeroEncontrdo)
            {
                Console.WriteLine("Insira seu palpite:");
                string entrada = Console.ReadLine();
                int.TryParse(entrada, out palpite);

                tentativas++;
                tentativasRestantes++;

                if (numeroSecreto == palpite)
                {
                    numeroEncontrdo = true;
                    var corAnterior = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine("Numero encontrado em {0} tentativas", tentativas);
                    Console.BackgroundColor = corAnterior;
                }
                else if (palpite > numeroSecreto)
                {
                    Console.WriteLine("O valor eh menor...Tente novamente___Tetativas Restantes{0}", tentativas);


                }
                else
                {
                    Console.WriteLine("O valor eh maior...Tente novamente___Tetativas Restantes{0}", tentativas);
                }

            }
        }
    }
}














