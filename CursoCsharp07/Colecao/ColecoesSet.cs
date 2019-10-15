using CursoCsharp07.ClassesEMetodos;
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp07.Colecao
{
    class ColecoesSet
    {
        public static void Executar() {
            var livro = new Produto("Panico", 50.0);

            var carrinho = new HashSet<Produto>
            {
                livro
            };

            var combo = new HashSet<Produto> {
            new Produto("Camisa colorida", 20.0),
            new Produto("Camisa verde ", 70.0),
            new Produto("Harry",12.0),
            new Produto("Harry",12.0)
            };
            carrinho.UnionWith(combo);
            Console.WriteLine(carrinho.Count);
            //carrinho.RemoveAt(3);

            foreach (var item in carrinho) {
              //  Console.WriteLine(carrinho.IndexOf(item));
                Console.WriteLine($"{item.Nome} {item.Preco}"); 
            }

            Console.WriteLine(carrinho.Count);
            carrinho.Add(livro);
            Console.WriteLine(carrinho.Count); 

        }
    }
}
