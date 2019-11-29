using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace CursoCsharp07.Topico
{
    class ExemploLINQ2
    {
        public static void Executar() {
           var alunos = new List<Aluno> {
                new Aluno() {Nome = "Pedro", Idade = 26 , Nota = 8.3 },
                new Aluno() {Nome = "Ana", Idade = 17 , Nota = 0.3 },
                new Aluno() {Nome = "Felipe", Idade = 39 , Nota = 8.5 },
                new Aluno() {Nome = "Lucas", Idade = 19 , Nota = 6.5 },
                new Aluno() {Nome = "James", Idade = 27 , Nota = 8.3 },
                new Aluno() {Nome = "Bruno", Idade = 26 , Nota = 8.3 }

            };
            var pedro = alunos.Single(aluno => aluno.Nome.Equals("Pedro"));
            Console.WriteLine($"{pedro.Nome}{pedro.Nota}");



            var fulano = alunos.SingleOrDefault(
                aluno => aluno.Nome.Equals("Fulano"));
            if (fulano == null)
            {
                Console.WriteLine("Aluno inexistente");
            }



            var ana = alunos.First(aluno=>aluno.Nome.Equals("Ana"));
            Console.WriteLine(ana.Nota);

            var sicrano = alunos.FirstOrDefault(aluno => aluno.Nota.Equals("Sicrano")); 
            if (sicrano == null )
            {
                Console.WriteLine("Aluno Inexistente");
            }
            var outraana = alunos.LastOrDefault(aluno => aluno.Nome.Equals("Ana"));
            Console.WriteLine(outraana.Nota); 

            var exemploskip = alunos.Skip(1).Take(3);
            foreach(var item in exemploskip)
            {
                Console.WriteLine(item.Nome);
            }


            Console.WriteLine("######Maior_Nota######## ");
            var maiornota = alunos.Max(aluno => aluno.Nota);
            Console.WriteLine(maiornota);

            Console.WriteLine("######Menor_Nota######## ");
            var menorNota = alunos.Min(aluno => aluno.Nota);
            Console.WriteLine(menorNota);



            Console.WriteLine("######Somatorio_Nota######## ");
            var somatorioNotas = alunos.Sum(aluno => aluno.Nota);
            Console.WriteLine(somatorioNotas);

            Console.WriteLine("######Media_Nota######## ");
            var mediaDATURMA = alunos.Average(aluno=> aluno.Nota);
            Console.WriteLine(mediaDATURMA); 

        }
        
    }
}
