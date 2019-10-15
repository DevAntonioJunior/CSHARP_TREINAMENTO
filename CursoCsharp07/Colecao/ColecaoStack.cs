using System;
using System.Collections.Generic;
using System.Text;
using System.Collections; 


namespace CursoCsharp07.Colecao
{
    class ColecaoStack
    {
        public static void Executar() {
            var pilha = new Stack();
            pilha.Push(3);
            pilha.Push("C");
            pilha.Push("Jr");
            pilha.Push(3.15);

            foreach (var item in pilha) {
                Console.Write($"{item} "); 
            }

            Console.WriteLine($"\nPeek: {pilha.Pop()}");

            foreach (var item in pilha) {
            Console.WriteLine(pilha.Count);
            }
            Console.WriteLine($"\nPeek: {pilha.Peek()}");
            Console.WriteLine(pilha.Count); 

        }

    }
}
