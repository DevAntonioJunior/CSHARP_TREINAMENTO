using System;

using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp07.Colecao
{
    class ColecaoQueue
    {
        public static void Executar() {

            var fila = new Queue<string>();
            // Adiciona na fila 
            fila.Enqueue("Assis");
            fila.Enqueue("Danilo");
            fila.Enqueue("vanda");
             fila.Enqueue("vanda");

            // mostra o primeiro elemento q vai sair da fila 
            Console.WriteLine(fila.Peek());
            Console.WriteLine(fila.Count);
             
            //remove da lista 
            Console.WriteLine(fila.Dequeue()); 
            Console.WriteLine(fila.Count);

            foreach (var pessoa in fila) {
                Console.WriteLine(pessoa);
            }

            var salada = new Queue();
            salada.Enqueue(3);
            salada.Enqueue("jr");
            salada.Enqueue("Abc");
            salada.Enqueue("Item");

            Console.WriteLine(salada.Contains("item"));
            Console.WriteLine(salada.Contains("Item")); 



            





        } 


    }
}
