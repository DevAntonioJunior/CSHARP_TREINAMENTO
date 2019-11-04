using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp07.Api
{
    class ExemploTimeSpan
    {
        public static  void Executar(){
            var intervalo = new TimeSpan(days: 10 , hours: 20 , minutes:15, seconds:31);

            Console.WriteLine(intervalo);
            Console.WriteLine("Minutos: " + intervalo.Minutes);
            Console.WriteLine("Intervalo em minutos: " + intervalo.TotalMinutes);

            var largada= DateTime.Now;
            var Chegada = DateTime.Now.AddMinutes(8);

            var tempo = largada - Chegada;

            Console.WriteLine("Duracao:" +tempo);
            Console.WriteLine(intervalo.Add(TimeSpan.FromMinutes(15)));
            Console.WriteLine(intervalo.Subtract(TimeSpan.FromMinutes(13)));

            Console.WriteLine("ToString: " +intervalo.ToString("g"));
            Console.WriteLine("ToString: " +intervalo.ToString("G"));
            Console.WriteLine("ToString: " +intervalo.ToString("c"));

            Console.WriteLine("Parse:" + TimeSpan.Parse("1:02:03").TotalMilliseconds);





            



            Console.WriteLine();

        

        }
    }
}
