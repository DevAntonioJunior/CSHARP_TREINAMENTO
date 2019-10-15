using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp07.Colecao
{
    class Array
    {
        public static void Executar()
        {
            string[] alunos = new string[5];
            alunos[0] = "Antonio";
            alunos[1] = "Valdete";
            alunos[2] = "Maysa";
            alunos[3] = "Anselmo";
            alunos[4] = "Areta";

            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno); ;
            }
        
            double somatorio = 0;
            double[] notas = { 9.5, 9.8, 0.1, 1.3, 2.3 };
            foreach (var nota in notas) {
                somatorio += nota;
            }
           // for (int i = 0; i < notas.Length; i++)
            //{
             //   somarotio += notas[i];
           // }
            double media = somatorio / notas.Length;
            Console.WriteLine(media);


            char[] letras = { 'A', 'R', 'R', 'A', 'Y' };
            string palavra = new string(letras);
            Console.WriteLine(palavra); 

        }
    }
}
