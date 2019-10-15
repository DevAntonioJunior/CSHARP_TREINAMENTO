using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp07.fundamentos
{
    class VariaveisEConstantes
    {
        public static  void  Executar() {
            // Area da circuferencia 
            double raio  = 4.5; 
            const double PI= 3.14;

            raio = 5.5;
            //Pi=5.1415 

            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("Area é " + (area + 1000));
            // tipos internos 

            bool estachovendo = true;
            Console.WriteLine("Esta chovendo"+ estachovendo);

            byte idade = 45;
            Console.WriteLine("Idade: " + idade);

            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine(" Salde de Gols" + saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("Salario" + salario);

            int menorValor = int.MinValue;
            Console.WriteLine("Menor int" + menorValor);

            float precoComputtador = 1333.66F;
            Console.WriteLine("preco do computaor: " + precoComputtador);

            double VarlorDeMercado = 1_000_000_000_000.00;
            Console.WriteLine("Valor Apple"+ VarlorDeMercado);

            char letra = 'b';
            Console.WriteLine("Letra: " + letra);

            string texto = "Seja bem vindo ao Curso";
            Console.WriteLine(texto); 


          




            
        }
    }
}
