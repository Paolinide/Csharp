using System;

namespace test_1_vettori
{
    class Program
    {
        public static int len1, len2 = 0;
        static void Main(string[] args)
        {
            Random casuale = new Random();

            int d = 5 + casuale.Next(6); // dimensione del vettore
            int[] vett = new int[d]; // dichiarazione vettore

            len1 = Convert.ToString(d - 1).Length;
            for (int i = 0; i < d; i++)
            {
                vett[i] = casuale.Next(d / 2);
                len2 = Math.Max(Convert.ToString(vett[i]).Length, len2);
            }
            Console.WriteLine(" *** \n "+vett+"\n ***");
            /*
            // Istruzioni compito
            vett[0] = 1; // inizializzazione 1° valore
            vett[1] = 5; // inizializzazione 2° valore
            vett[2] = 1; // inizializzazione 3° valore
            */

            // ciascun valore unico nel vettore viene stampato
            bool[] vb = new bool[d]; // creato vettore parallelo
            for (int i = 0; i < d; i++)
                vb[i] = true; // inizializziamo il vettore

            Console.WriteLine("\nIl vettore contiene {0} elementi:", d);
            stampaVettore(vett);
            /*
            Console.WriteLine("Ecco i booleani all'inizio");
            stampaVettore(vb);
            */
            int doppi = 0;
            for (int i = 0; i < d - 1; i++) // inizio del ciclo di ricerca
            {
                if (vb[i]) // se il valore in esame non è già stato scartato...
                    for (int j = i + 1; j < d; j++) // ...viene controllato
                    {
                        if (vb[j] && (vett[i] == vett[j])) // se il valore di controllo non è già stato scartato, viene verificato...
                        { // ...e se coincide i valori uguali vengono scartati
                            //Console.WriteLine("i:{0}={1}[{2}] j:{3}={4}[{5}]", i, vett[i], vb[i], j, vett[j], vb[j]);
                            vb[i] = vb[j] = false;
                            doppi++;
                        }
                    }
            }

            /*
            Console.WriteLine("Ecco il vettore alla fine");
            stampaVettore(vett);
            Console.WriteLine("Ecco i booleani alla fine");
            stampaVettore(vb);
             */
            int n = 0;
            for (int i = 0; i < vb.Length; i++)
                if (vb[i]) n++;
            Console.WriteLine("\nTrovat{1} {0} element{1} unic{1}:", n, (n == 1) ? "o" : "i");
            for (int i = 0; i < d; i++)
                if (vb[i]) Console.WriteLine("[{0," + len1 + "}] '{1," + len2 + "}'", i, vett[i]);
            Console.WriteLine("{0} element{1} su {2} sono unic{1}, il {3}%.", n, (n == 1) ? "o" : "i", d, 100 * n / d);
        }
        static void stampaVettore(int[] v) { for (int i = 0; i < v.Length; i++) Console.WriteLine("[{0," + len1 + "}] '{1," + len2 + "}'", i, v[i]); }
        static int contaVeri(bool[] v)
        {
            int n = 0;
            for (int i = 0; i < v.Length; i++)
                if (v[i]) n++;
            return n;
        }
    }
}
