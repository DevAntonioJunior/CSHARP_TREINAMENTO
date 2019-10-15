using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp07.ClassesEMetodos
{
    public class CarroOpcional {
        double desconto = 0.1;

        string nome; 
        public string Nome{
            get {
                return "Opcional: " + nome; 
            }
            set {
                nome = value; 
            }
        }
        // propriedades autoimplementada 
        public double Preco { get; set;}

        // somete leitura 
        public double PrecocomDesconto {
            get => Preco - (desconto * Preco); 
        }

        public CarroOpcional() { }

        public CarroOpcional(string nome, double preco) {
            Nome = nome;
            Preco = preco; 
        }

    }

    class Props
    {
        public static void Executar() {

            var Op1 = new CarroOpcional("desenbacador",500.0 );
            Console.WriteLine(Op1.Nome);
            Console.WriteLine(Op1.Preco); 
            Console.WriteLine("Desconto : "+ Op1.PrecocomDesconto); 

            var Op2 = new CarroOpcional("Ar-condicionado", 1000.1);
            Console.WriteLine(Op2.Nome);
            Console.WriteLine("Preco: " + Op2.Preco);
            Console.WriteLine("Desconto: " + Op2.PrecocomDesconto); 



        }
    }
}
