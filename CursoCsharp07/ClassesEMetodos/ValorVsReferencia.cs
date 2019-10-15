using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp07.ClassesEMetodos
{
    public class Dependente
    {
        public string Nome;
        public int Idade;
    }
    class ValorVsReferencia
    {

        public static void Executar()
        {
            int numero = 3;
            int copianumero = numero;
            Console.WriteLine($"{numero} {copianumero}");

            numero++;
            Console.WriteLine($"{numero} {copianumero}");

            Dependente dep = new Dependente
            {
                Nome = "Beto",
                Idade = 20
            };

            Dependente copiadep = dep;

            Console.WriteLine($"{dep.Nome} {copiadep.Nome}");
            Console.WriteLine($"{dep.Idade} {copiadep.Idade}");

            copiadep.Nome = "Renato";
            copiadep.Idade = 21; 

        }
    }
}


