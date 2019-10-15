using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization; 

namespace CursoCsharp07.fundamentos
{
    class LendoDados
    {
        public static void Executar() {
            string nome;
            int idade;
            double salario;

            Console.WriteLine("Qual  é seu nome?");
            nome = Console.ReadLine();

            Console.WriteLine("Qual sua idade?");
            idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual seu salario? ");
            salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine($"{nome} {idade} R${salario}");


        }
    }
}
