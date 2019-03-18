using System;

namespace Tissino3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            var casuale = new Random();
            int[] vettore = new int[5 + casuale.Next(5)];
            int n = 0;
            for (int i = 0; i < vettore.Length; i++)
            {
                n += (int)Math.Pow(1 + casuale.Next(3), casuale.Next(3));
                vettore[i] = n;
            }

            StampaVettore(vettore);
            MostraDispari(vettore);
            Console.WriteLine("Trovati " + ContaDispari(vettore) + " numeri dispari.");
            Console.WriteLine("Il primo numero dispari, {0}, è al {1} posto.", TrovaPrimoDispari(vettore), TrovaPrimoDispari(vettore, true));
            Console.WriteLine("L'ultimo numero dispari, {0}, è al {1} posto.", TrovaUltimoDispari(vettore), TrovaUltimoDispari(vettore, true));
            Console.WriteLine("Il numero dispari più grosso, {0}, è al {1} posto.", TrovaDispariPiuGrosso(vettore), TrovaDispariPiuGrosso(vettore, true));
        }
        static public void StampaVettore(int[] vettore)
        {
            for (int i = 0; i < vettore.Length; i++)
                Console.Write(vettore[i] + " ");
            Console.WriteLine();
        }
        static public void MostraDispari(int[] vettore)
        {
            Console.WriteLine("Dispari!");
            return;
            for (int i = 0; i < vettore.Length; i++)
                if (vettore[i] % 2 == 1) Console.Write(vettore[i] + " ");
            Console.WriteLine();
        }
        static public int ContaDispari(int[] vettore)
        {
            int risultato = 0;
            for (int i = 0; i < vettore.Length; i++)
                if (vettore[i] % 2 == 1) risultato++;
            return risultato;
        }
        static public bool TrovaPrimoDispari(int[] vettore, ref int risultato, bool posizione = false)
        {
            for (int i = 0; i < vettore.Length; i++)
                if (vettore[i] % 2 == 1) { risultato = (posizione ? i : vettore[i]); return true; }
            return false;
        }
        static public bool TrovaUltimoDispari(int[] vettore, ref int risultato, bool posizione = false)
        {
            bool trovato = false;
            for (int i = 0; i < vettore.Length; i++)
                if (vettore[i] % 2 == 1) { risultato = posizione ? i : vettore[i]; trovato = true}
            return trovato;
        }
        static public int TrovaDispariPiuGrosso(int[] vettore, bool posizione = false)
        {
            int risultato = -1;
            return risultato;
        }
    }
}
