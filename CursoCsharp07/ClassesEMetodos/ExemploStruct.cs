using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp07.ClassesEMetodos
{
    interface Ponto
    {
        void MoverNaDiagonal(int delta);

    }
    struct Coordenada : Ponto
    {
        public int X;
        public int Y;

        public Coordenada(int x, int y)
        {
            X = x;
            Y = y;
        }

        

        public void MoverNaDiagonal(int delta)
        {
            X += delta;
            Y += delta;
        }

    }



    class ExemploStruct
    {
        public static void Executar()
        {
            Coordenada coordenadainicial;
            coordenadainicial.X = 2;
            coordenadainicial.Y = 2;

            Console.WriteLine("Cordenada inicial: ");
            Console.WriteLine("X = {0}",coordenadainicial.X);
            Console.WriteLine("Y= {0}", coordenadainicial.Y);
            


            
            var CoordenadaFinal = new Coordenada(x: 9, y: 1);
            CoordenadaFinal.MoverNaDiagonal(10);
            
            Console.WriteLine("Coordenada Final: ");
            Console.WriteLine("X = {0}",CoordenadaFinal.X);
            Console.WriteLine("Y = {0}",CoordenadaFinal.Y); 
        }
    }
}

