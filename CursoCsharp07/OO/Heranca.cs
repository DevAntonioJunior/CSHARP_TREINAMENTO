using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp07.OO
{

    public class Carro
    {
        protected readonly int VelocidadeMaxima;
        int VelocidadeAtual;

        public Carro(int velocidadeMaxima)
        {
            VelocidadeMaxima = velocidadeMaxima;
        }
        protected int AlterarVelocidade(int delta)
        {
            int novaVelocidade = VelocidadeAtual + delta;

            if (novaVelocidade < 0)
            {
                VelocidadeAtual = 0;
            }
            else if (novaVelocidade < 0)
            {
                VelocidadeAtual = VelocidadeMaxima;
            }
            else
            {
                VelocidadeAtual = novaVelocidade;

            }

            return VelocidadeAtual;

        }


        public virtual int Acelerar() {
            return AlterarVelocidade(5); 
        }

        public int Frear() {
            return AlterarVelocidade(-5);
        }

    }
    public class Uno : Carro {
        public Uno() : base(200) {

        }
    }
    public class Celta : Carro {
        public Celta() : base(160) {

        }
    public override int Acelerar() {
        return AlterarVelocidade(15); 
        }
        public new  int Frear() {
            return AlterarVelocidade(-15); 
        }
    }
    public class Ferrari : Carro {
        public Ferrari() : base(350) {


        }
        public override int Acelerar() {
            return AlterarVelocidade(20);
        }
        public new int Frear() {
            return AlterarVelocidade(-15);
        }
        
    }

    class Heranca
    {
        public static void Executar()
        {
            Console.WriteLine("Uno..");
            Uno carro1 = new Uno();
            Console.WriteLine(carro1.Acelerar()); 
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Frear());
            Console.WriteLine(carro1.Frear());
            Console.WriteLine(carro1.Frear());


            Console.WriteLine("Celta");
            Celta carro2 = new Celta(); 
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Frear());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());


            Console.WriteLine("ferrri ...");
            Ferrari carro3 = new Ferrari(); // polimorfismo 
            Console.WriteLine(carro3.Acelerar()); 
            Console.WriteLine(carro3.Acelerar()); 
            Console.WriteLine(carro3.Frear()); 
            Console.WriteLine(carro3.Frear()); 
            Console.WriteLine(carro3.Acelerar()); 






        




        }
    }
}
