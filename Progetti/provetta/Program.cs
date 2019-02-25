using System;

namespace provetta
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Ecco un bel programmino...";
            do
            {
                //ConsoleKeyInfo tasto; // Variabile per rappresentare il tasto premuto
                //Console.Clear(); // Facciamo un po' di pulizia
                
                Console.WriteLine();
                Console.WriteLine(value: s);
                Console.Write("Immetti il dividendo: ");
                int D = Convert.ToInt32(Console.ReadLine());
                Console.Write("Immetti il divisore: ");
                int d = Convert.ToInt32(Console.ReadLine());
                /*
                /if ( Divisibili(D, d) ) {
                    Console.WriteLine("Il numero {0} è divisibile per {1}", D, d);
                } else {
                    Console.WriteLine("Il {0} non è divisibile per {1}", D, d);
                }
                string s = Divisibili(D, d) ? "" : "non ";
                Console.WriteLine("Il numero '{0}' {1}è divisibile per '{2}'!", D, s, d);
                */
                Console.WriteLine("Il numero '{0}' {1}è divisibile per '{2}'!", D, (Divisibili(D, d) ? "" : "non "), d);

                Console.WriteLine();
                Console.WriteLine("Premi ESC per terminare oppure un altro tasto per continuare...");
                /*
                ConsoleKeyInfo tasto; // Variabile per rappresentare il tasto premuto
                tasto = Console.ReadKey(true); // Lettura del carattere digitato
                //Console.WriteLine("  Tasto premuto: {0}\n", tasto.Key); // Esposizione carattere
                if (tasto.Key == ConsoleKey.Escape) break;
                 */
                if (Console.ReadKey(true).Key == ConsoleKey.Escape) break;
                else s = "Ancora qua?!";
                Console.Clear(); // Facciamo un po' di pulizia
            } while (true);

        }
        private static bool Divisibili(int D, int d) => ((D % d) == 0);
        /*
        private static bool Divisibili(int D, int d)
        {
            return ((D % d) == 0);
        }
        */


    }
}

