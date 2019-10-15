using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp07.ClassesEMetodos
{
    class Membros
    {
        public static void Executar()
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Nome = "Antonio Junior";
            pessoa.Idade = 29;

            Console.WriteLine($"{pessoa.Nome} tem {pessoa.Idade}anos");


            Pessoa pessoa1 = new Pessoa();
            pessoa1.Nome = "Vanda Silva";
            pessoa1.Idade = 52;






            Console.WriteLine($"{pessoa1.Nome} tem {pessoa1.Idade } "); 
        }
    }
}
