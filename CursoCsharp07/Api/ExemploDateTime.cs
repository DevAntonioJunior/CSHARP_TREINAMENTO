using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp07.Api
{
    class ExemploDateTime
    {
        public static void Executar() {
            var datetime = new DateTime(year: 2030 , month: 2, day: 6);
            Console.WriteLine(datetime.Day);
            Console.WriteLine(datetime.Month);
            Console.WriteLine(datetime.Year);


            // sem hora 
            var hoje = DateTime.Today;
            Console.WriteLine(hoje);

            // com hora 
            var diaAtual = DateTime.Now;
            Console.WriteLine(diaAtual);
            Console.WriteLine("#############||Relogio||##############");
            Console.WriteLine("# Hora: "+diaAtual.Hour);
            Console.WriteLine("# Minutos: "+ diaAtual.Minute);
            Console.WriteLine("# Segundos: "+ diaAtual.Minute);
            Console.WriteLine("######################################");

            var amanha = diaAtual.AddDays(1);
            Console.WriteLine(amanha);

            var ontem = diaAtual.AddDays(-1);
            Console.WriteLine(ontem);



            Console.WriteLine(diaAtual.ToString("dd"));
            Console.WriteLine(diaAtual.ToString("d"));
            Console.WriteLine(diaAtual.ToString("D"));
            Console.WriteLine(diaAtual.ToString("g"));
            Console.WriteLine(diaAtual.ToString("G"));
            Console.WriteLine(diaAtual.ToString("dd-MM-yyyy HH:mm"));










        }
    }
}
