using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp07.OO
{
    public class Animal
    {
        public string Nome { get; set; }

        public Animal(string nome)
        {
            Nome = nome;

        }
    }
    public class Cachorro : Animal
    {
        public double Altura { get; set; }

        public Cachorro(string nome) : base(nome)
        {
            Console.WriteLine($"Cachorro {nome} incializado");

        }
        public Cachorro(string nome, double altura) : this(nome)
        {
            Altura = altura;
        }
        public override string ToString()
        {
            return $"{Nome} tem {Altura} cm de altura!!";


        }
    }


        class ConstrutorThis
        {
            public static void Executar()
            {
                var spike = new Cachorro("spike");
                var max = new Cachorro("max", 40.1);

                Console.WriteLine(spike);
                Console.WriteLine(max);


            }


        }
    }
    

