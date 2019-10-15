using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp07.fundamentos
{
    class Conversoes
    {
        public static void  Executar() {
            int inteiro = 10;
            double quebrado = inteiro;

            Console.WriteLine(quebrado);

            double nota = 9.7;
            int notaTruncada = (int)nota;
            Console.WriteLine("Nota truncada: {0}",notaTruncada);

            Console.Write("Digite sua idade: ");
            string idadeString = Console.ReadLine();
            int idadeInteiro = int.Parse(idadeString);
            Console.WriteLine("Idade inserida: {0}", idadeInteiro);

            idadeInteiro = Convert.ToInt32(idadeInteiro);
            Console.WriteLine("Resultado: {0}",idadeInteiro );

            Console.Write("Digite o primeiro numero");
             string palavra = Console.ReadLine();
             int numero1;
              int.TryParse(palavra, out numero1);
            Console.WriteLine("Resultado 2: {0}",numero1);

            Console.WriteLine("Digite segundo numero : ");
            int.TryParse(Console.ReadLine(), out int numero2);
            Console.WriteLine("O resultado : {0}",numero2);

        }
    }
}
