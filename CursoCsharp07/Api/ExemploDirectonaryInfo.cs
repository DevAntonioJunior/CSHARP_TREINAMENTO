using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace CursoCsharp07.Api
{
    class ExemploDirectonaryInfo
    {
        public static void Executar() {

            var dirProjeto = @"~/source/repos/CursoCSharp07".ParseHome();

            var dirInfo = new DirectoryInfo(dirProjeto);

            if (!dirInfo.Exists) {
                dirInfo.Create(); 

            }

            Console.WriteLine("== Arquivos==============");
            var arquivos = dirInfo.GetFiles();
            foreach (var arquivo in arquivos ) {
                Console.WriteLine(arquivo);
            }

            Console.WriteLine("\n== Diretorios =======================");
            var pastas = dirInfo.GetDirectories();
            foreach (var pasta in pastas) {
                Console.WriteLine(pasta);
            }

            Console.WriteLine(dirInfo.CreationTime);
            Console.WriteLine(dirInfo.FullName);
            Console.WriteLine(dirInfo.Root);
            Console.WriteLine(dirInfo.Parent.Parent); 




        }


    }
}
