using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp07.Topico
{
    class Dynamics
    {
        public static void Executar() { 
       dynamic meuObjeto = "Teste";
            meuObjeto = 3;
            Console.WriteLine(meuObjeto);

            dynamic aluno = new System.Dynamic.ExpandoObject();
            aluno.Nome = "Junior"; 
            aluno.Nota = 8.9;
            aluno.Idade = 29;

            Console.WriteLine($"{aluno.Nome} {aluno.Nota} {aluno.Idade}"); 


            }
    }
}
