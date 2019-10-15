using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp07.ClassesEMetodos
{
    class ExemploEnum
    {
        public enum Genero{Acao, Aventura, Terror, Animacao, Comedia};

        public class Filme {
            public string Titulo;
            public Genero GeneroFilme;
        }


        public static void Executar() {

            int id = (int)Genero.Animacao;
            Console.WriteLine(id);

            var filmePararafamilia = new Filme();
            filmePararafamilia.Titulo = "Gente grande";
            filmePararafamilia.GeneroFilme = Genero.Comedia;

            Console.WriteLine("{0} eh {1}",filmePararafamilia.Titulo,
                filmePararafamilia.GeneroFilme);

        }
    }
}
