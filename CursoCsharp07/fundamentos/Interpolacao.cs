using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp07.fundamentos
{
    class Interpolacao
    {
        public static void Executar()
        {
            string nome = " MAcOS";
            string marca = "Apple";
            double preco = 7000.00; 
        Console.WriteLine(" O" + nome + "da Marca" + marca + "custa" + preco + ".");

        Console.WriteLine("O {0} da marca {1} custa {2}.", nome, marca, preco);

        Console.WriteLine($" A maraca {marca} é legal");


        }
    }
}
