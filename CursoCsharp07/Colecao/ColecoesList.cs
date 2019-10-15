using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp07.Colecao
{
        public  class Produto {
            public string Nome;
            public double Preco;

            public Produto(string nome, double preco) {
              Nome = nome ; 
              Preco= preco; 


            }
        public override bool Equals(object obj)
        {
            Produto outroProduto = (Produto)obj;
            bool mesmoNome = Nome == outroProduto.Nome;
            bool mesmoPreco = Preco == outroProduto.Preco;
          return mesmoNome && mesmoPreco;
        }

        public override int GetHashCode()
        {
            return Nome.Length;
        }


    }
        public class ColecoesList
        {
        public static void Executar() {



            var livro = new Produto("Panico", 50.0);

            var carrinho = new List<Produto>();
            carrinho.Add(livro);

            var combo = new List<Produto> {
            new Produto("Camisa colorida", 20.0),
            new Produto("Camisa verde ", 70.0),
            new Produto("Harry",12.0)
            };
            carrinho.AddRange(combo);
            Console.WriteLine(carrinho.Count);
            carrinho.RemoveAt(3);

            foreach (var item in carrinho) {
                Console.WriteLine(carrinho.IndexOf(item));
                Console.WriteLine($"{item.Nome} {item.Preco}"); 
            }






        }
    }
}
