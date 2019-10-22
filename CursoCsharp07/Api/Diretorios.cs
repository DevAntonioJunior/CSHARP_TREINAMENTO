using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CursoCsharp07.Api
{
    class Diretorios
    {
        public static void Executar() {

            var novoDir = @"-/PastaCsharp".ParseHome();
            var novoDirDestino = @"~/PastaCsharpDestino".ParseHome(); 
            var dirProjeto = @"~/source/repos/CursoCsharp".ParseHome();

            if (Directory.Exists(novoDir)) {
                Directory.Delete(novoDir, true); 
            }
            if (Directory.Exists(novoDirDestino)) {
                Directory.Delete(novoDirDestino, true); 


            }
            Directory.CreateDirectory(novoDir);
            Console.WriteLine(Directory.GetCreationTime(novoDir)); 
            
        }
    }
}
