using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp07.OO
{
    public class Comida {
        public double Peso;

        public Comida(double peso)
        {
            Peso = peso; 
        }
        public Comida() { }
    }

    public class Feijao : Comida
    {
        public Feijao(double peso) : base(peso) { }
        
    }
    public class Arroz:Comida
    {
        public Arroz(double peso) : base(peso) { }
        
    }
    public class Carne : Comida
    {
        public Carne(double peso) : base(peso) { }
        
    }
    public class Pessoa {
        public double Peso;

        //public void Comer(Feijao feijao)
        //{
        //    Peso += feijao.Peso;
        //}
        //public void Comer(Arroz arroz )
        //{
        //    Peso += arroz.Peso;
        //}
        //public void Comer(Carne carne) {
        //    Peso += carne.Peso;
        //}

        public void Comer(Comida comida)
        {
            Peso += comida.Peso; 

        }
    }

    class Polimorfismo
    {
        public static void Executar()  {
            Feijao ingrediente1 = new Feijao(0.3);
          //  ingrediente1.Peso = 0.5;

            Arroz ingrediente2 = new Arroz(0.7);
            //ingrediente2.Peso =0.7;

            Carne ingrediente3 = new Carne(0.8);
           // ingrediente3.Peso = 0.8;

            Pessoa cliente = new Pessoa();
            cliente.Peso = 80.0;
            cliente.Comer(ingrediente1); 
            cliente.Comer(ingrediente2); 
            cliente.Comer(ingrediente3);

            Console.WriteLine($"agora o peso do Cliente é {cliente.Peso} KG");




        }
    }
}
