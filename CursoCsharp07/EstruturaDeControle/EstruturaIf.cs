using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp07.EstruturaDeControle
{
    class EstruturaIf
    {
        public static void Executar()
        {
            bool bomComportamento;
            string entrada;
            Console.WriteLine("Digite a nota do ALuno ");
            entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);

            Console.WriteLine("Possui um bom comportamente (S/N)");
            entrada = Console.ReadLine();

            bomComportamento = entrada.ToLower() == "s";


            if (nota >= 9.0 && bomComportamento)
            {
                Console.WriteLine("Quadro de honra!!");
            }
        }
    }
}
