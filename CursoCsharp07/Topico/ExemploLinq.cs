using System;
using System.Collections.Generic;
using System.Linq;

namespace CursoCsharp07.Topico
{
    class ExemploLinq
    {
        public class Aluno {
            public string Nome;
            public int Idade; 
            public double Nota; 
        }
        public static void Executar (){
            var alunos = new List<Aluno> {
                new Aluno() {Nome = "Pedro", Idade = 26 , Nota = 8.3 },
                new Aluno() {Nome = "Andre", Idade = 17 , Nota = 0.3 },
                new Aluno() {Nome = "Felipe", Idade = 39 , Nota = 8.5 },
                new Aluno() {Nome = "Lucas", Idade = 19 , Nota = 6.5 },
                new Aluno() {Nome = "James", Idade = 27 , Nota = 8.3 },
                new Aluno() {Nome = "Bruno", Idade = 26 , Nota = 8.3 }

            };
            Console.WriteLine("== Aprovados ordenados por nota ========");
            var aprovados = alunos.Where(a => a.Nota>=7)
                .OrderBy(a=>a.Nota);
            foreach (var aluno in aprovados) {
                Console.WriteLine(aluno.Nome);
            }
            Console.WriteLine("\n== chamada ========");
            var chamada = alunos.OrderBy(a => a.Nome).Select(a => a.Nome);
            foreach (var aluno in chamada)
            {
                Console.WriteLine(aluno);
            }

            Console.WriteLine("\n == Aprovados (ordenado por idade)========");
            var alunosAprovados =
                from aluno in alunos
                where aluno.Nota >= 6
                orderby aluno.Idade
                select aluno.Nome;


            foreach(var aluno in alunosAprovados)
            {
                Console.WriteLine(aluno);
            }

        }
    }
}
