using System;

namespace Autobus
{
    class Program
    {




        public static void Main(string[] args)
        {
            Console.Clear();
            var BSPordenone = new BusStation();
            BSPordenone.Stampa(true);    //Your code goes here
            //GC.Collect();
            //GeoCoordinate.TestClass();
            // string stringa = "";
            // int i=0;
            // while(stringa!="gino")
            // {
            //     stringa = Minchiate.Incasina("gnoi").ToLower();
            //     if (stringa == "gino") Console.Write("*"+stringa.ToUpper() + "* ");
            //     else Console.Write(" "+stringa + "  ");
            //     if (i%20==19) Console.WriteLine();
            // }
            // Console.WriteLine();
            Console.WriteLine(Minchiate.Rovescia("salamandra"));
        }


    }
}
