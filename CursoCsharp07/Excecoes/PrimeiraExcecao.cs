﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp07.Excecoes
{
    public class Conta {
        double Saldo;

        public Conta(double saldo)
        {
            Saldo = saldo; 
        }

        public void Sacar(double valor) {
            if(valor > Saldo)
            {
                throw new ArgumentException("Saldo Insuficiente"); 
            }
            Saldo += valor; 
        }

    }
    class PrimeiraExcecao
    {
        public static void Executar() {

            var conta = new Conta(1_223.45);
            try
            {
                conta.Sacar(1600);
                Console.WriteLine("Saque efetuado com sucesso");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally {
                Console.WriteLine("Obrigado"); 
            }
               



        }
    }
}
