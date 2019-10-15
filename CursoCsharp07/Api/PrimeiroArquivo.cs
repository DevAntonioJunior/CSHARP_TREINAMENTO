using System;
using System.IO; 

namespace CursoCsharp07.Api
{
    public static class ExtensaoString {
        public static string ParseHome(this string path) {
            string home = (Environment.OSVersion.Platform == PlatformID.Unix
                )
                ?
                Environment.GetEnvironmentVariable("HOME")
                : Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%");
            return path.Replace("~", home); 

        }
    }
    class PrimeiroArquivo
    {
        public static void Executar() {
            var path = @"~/primeiro_arquivo.txt".ParseHome();
            if (!File.Exists(path)) {
                using (StreamWriter sw = File.CreateText(path)) {
                    sw.WriteLine("esse é");
                    sw.WriteLine("nosso ");
                    sw.WriteLine("primeiro ");
                    sw.WriteLine("programa ");

                }

            }

        }
    }
}
