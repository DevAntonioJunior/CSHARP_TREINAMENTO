using System;
using System.Collections.Generic;
using CursoCsharp07.EstruturaDeControle;
using CursoCsharp07.fundamentos;
using CursoCsharp07.ClassesEMetodos;
using CursoCsharp07.Colecao;
using CursoCsharp07.OO;
using CursoCsharp07.MettodoseFuncoes; 
using CursoCsharp07.Excecoes; 
using CursoCsharp07.Api; 


namespace CursoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var central = new CentralDeExercicios(new Dictionary<string, Action>()
            {
                {"Primeiro Programa - Fundamentos",PrimeiroProgrma.Executar},
                {"Comentarios - Fundamentos", Comentarios.Executar},
                {"Variaveis e constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferencia - Fundamentos", Inferencia.Executar},
                {"Interpolacao - Fundamentos", Interpolacao.Executar},
                {"Notacao Ponto - Fundamentos",NotacaoPonto.Executar },
                {"Lendo Dados - Fundamentos", LendoDados.Executar},
                {"Formatando Numeros - Fundamentos",FormatandoNumero.Executar},
                {"Conversoes - Fundamentos",Conversoes.Executar},
                {"Operadores Aritimeticos - Fundamentos",OperadoresAritimeticos.Executar},
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores Unarios - Fundamentos",OperadoresUnarios.Executar},
                {"Operadores  de atribuição  - Fundamentos",OperadoreAtribuicao.Executar},
                {"Operadores Ternario - Fundamentos",OperadorTernario.Executar},
                // Estrutura de Controle
                { "Estrutura de Controle - Estrutura IF",EstruturaIf.Executar} ,
                { "Estrutura de Controle - Estrutura IF/else",EstruturaIfElse.Executar},
                { "Estrutura de controle - Estutura If/Else/If",EstruturaifElseif.Executar },
                { "Estrutura de Controle - Estrutura Switch",EstruturaSwitch.Executar },
                { "Estrutura de Controle - Estrutura While",EstruturaWhile.Executar },
                { "Estrutura de Controle - Estrutura DoWhile",EstruturaDoWhile.Executar },
                { "Estrutura de Controle - Estrutura For",EstruturaFor.Executar },
                { "Estrutura de Controle - Estrutura ForEach",EstruturaForEach.Executar },
                { "Estrutura de Controle - Estrutura Break",EstruturaBreak.Executar },
                { "Estrutura de Controle - Estrutura Continue",EstruturaContinue.Executar },
                // Classes e metodos 
                {"Membros - Classes e Metodos",Membros.Executar },
                {"Construtores - Classes e Metodos",Construtores.Executar },
                {"Metodos Com Retorno - Classes e Metodos",MetodoscComRetorno.Executar},
                {"Metodos Com Retorno 2 - Classes e Metodos",MetodoComRetorno2.Executar},
                {"Metodos Estaticos - Classes e Metodos",MetodoEstatico.Executar},
                {"Atributos Estaticos - Classes e Metodos",AtributosEstaticos.Executar},
                {"Desafio atributo - Classes e Metodos",DesafioAtributo.Executar},
                {"Params - Classe e Metodos",Params.Executar},
                {"Parametros Nomeados - Classe e Metodos",ParametrosNomeados.Executar},
                {"Get e Set  - Classe e metodos ",GetSet.Executar},
                {"Props - Classes e Metodos",Props.Executar},
                {"ReadOnly  - Classes e Metodos",ReadOnly.Executar},
                {"Enumeracoes - Classe e Metodos",ExemploEnum.Executar },
                {"Structs - Classes e Metodos",ExemploStruct.Executar},
                {"Classe vs Struct Classes e Metodos",StructVsClasse.Executar},
                {"Valor vs Referencia - Classes e Metodos",ValorVsReferencia.Executar},
                {"Parametros por referencia - Classes e Metodos", ParemetrosPorReferencia.Exeutar},
                {"Parametro com Valor Padrao - Classes e Metodos ",ParamentroPadrao.Executar},
                // Colecoes 

                { "Array- Colecões ",CursoCsharp07.Colecao.Array.Executar},
                { "List - Colecões ",ColecoesList.Executar},
                { "ArrayList - Colecões ",ColecoesArrayList.Executar},
                { "Set - Colecões ",ColecoesSet.Executar},
                { "Queue - Colecões ",ColecaoQueue.Executar},
                { "igualadade - Colecões ",Igualdade.Executar},
                { " Stack - Colecoes",ColecaoStack.Executar},
                { " Dictonary - Colecoes",ColecoesDictionary.Executar}, 

                // Orientacao a Objeto 
                { " Heranca - Orientacao a Objeto",Heranca.Executar},
                { " Construtor This - Orientacao a Objeto",ConstrutorThis.Executar},
                { " Encapsulamento - Orientacao a Objeto",CursoCsharp07.OO.Encapsulamento.Executar},
                { " Polimorfismo - Orientacao a Objeto",CursoCsharp07.OO.Polimorfismo.Executar},
                { " Classe Abstrata - Orientacao a Objeto",Abstract.Executar},
                { " Interface - Orientacao a Objeto",Interface.Executar},
                { " Sealed - Orientacao a Objeto",Sealed.Executar},
                
                
                // Metodos e Funçoes 
                { " Exemplo Lambda - Metodos e Funçoes",ExLambida.Executar},
                { " Delegate com Lambda - Metodos e Funçoes",LambdaDelegate.Executar},
                { " Delegate  - Metodos e Funçoes",UsandoDelegates.Executar}, 
                { " Delegate como funcao anonima- Metodos e Funçoes",DelegateFuncAnonima.Executar},
                { " Delegate como Parametro - Metodos e Funçoes",DelegateComoParametro.Executar},
                { " Metodos de Extensao- Metodos e Funçoes",MetodosDeExtensao.Executar },
              
                
                //Excecao
                { " Primeira Excecao - Excecoes",PrimeiraExcecao.Executar }, 
                { " Excecao Personalizada - Excecoes",ExcecaoPersonalizada.Executar },
                //Api
                { " Primeiro Arquivo - Usando API",PrimeiroArquivo.Executar },
                { " Lendo Arquivo - Usando API",LendoArquivos.Executar },
                { " FILE INFO - Usando API",ExemploFileInfo.Executar },
                { " DIRETORIOS - Usando API",Diretorios.Executar },
                { " Exemplo Directory Info - Usando API",ExemploDirectonaryInfo.Executar },
                { " Exemplo Path - Usando API",ExemploPath.Executar },
                { " Exemplo Date time- Usando API",ExemploDateTime.Executar },
                { " Exemplo Time Span- Usando API",ExemploTimeSpan.Executar },

                // LINQ
                { " - Usando API",ExemploTimeSpan.Executar },
                


            });
            central.SelecionarEExecutar();
        }
    }
}