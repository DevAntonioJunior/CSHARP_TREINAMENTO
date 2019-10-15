using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp07.OO
{
    sealed class SemFilho
    {
        public double ValorDaFortuna()
        {

            return 1_407_033.65;
        }
    }

    //class SouFilho : SemFilho
    //{

    //    }

    class Avo {
        public virtual  bool HorrarNomeFamilia() {

            return true; 
        }
    }

    class Pai : Avo {
        public override sealed bool HorrarNomeFamilia()
        {
            return true;
        }
    }
   class FilhoRebelde : Pai {
    //    public override bool HorrarNomeFamilia()
    //    {
    //        return false;  
                
    //    }
    }







    class Sealed
    {
        public static void Executar()
        {
            SemFilho  semfilho = new SemFilho();
            Console.WriteLine(semfilho.ValorDaFortuna());


            FilhoRebelde filho = new FilhoRebelde();
            Console.WriteLine(filho.HorrarNomeFamilia());




        }
    }
}
