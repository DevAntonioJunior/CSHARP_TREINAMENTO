using System;
using System.IO;

namespace CursoCsharp07.Api
{
    class LendoArquivos
    {
        public static void Executar()
        {
            var path = @"~/Lendo_arquivo.txt".ParseHome();

            if (!File.Exists(path)) {
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine("Produto;Preco;Quantidade");
                sw.WriteLine("Caneta BIC Prtea;3.59;27");
                sw.WriteLine("Cborracha BIC Prtea;3.59;27");

            }

            }
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    var texto = sr.ReadToEnd();
                    Console.WriteLine(texto);
                }
            }
            catch(Exception ex) {
                Console.WriteLine(ex.Message); 

            }


        }
    }
}
