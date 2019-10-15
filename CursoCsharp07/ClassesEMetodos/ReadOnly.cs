using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp07.ClassesEMetodos
{
    class ReadOnly
    {
        public class Cliente {
            public string Nome;
            public readonly DateTime Nascimento;

            public Cliente(string nome, DateTime nascimento)
            {
                Nome = nome;
                Nascimento = nascimento; 

                
            }

            public string GetDataDeNascimento()
            {

                return String.Format("{0}/{1}/{2}",Nascimento.Day,Nascimento.Month, Nascimento.Year);
                    
                
            }
        }

        public static void Executar()
        {
            var novoCLiente = new Cliente("Ana silva", new DateTime(2019, 5, 22));
            Console.WriteLine("Nome: "+ novoCLiente.Nome);
            Console.WriteLine("Data de nascimento: " + novoCLiente.GetDataDeNascimento()); 
        }
    }
}
