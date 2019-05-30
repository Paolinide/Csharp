using System;

namespace Menù
{
    static class Freccette
    {
        public static string nome => "Gioca a freccette.";
        public static int raggioBersaglio = 10;
        static public void Gioca()
        {
            int punteggio = 0, xLancio = 0, yLancio = 0;
            char[] bersaglio = NuovoBersaglio().ToCharArray();
            Modifica(ref bersaglio, 0, 0, 'o');
            bool resta = false;
            do
            {
                Console.Clear();
                Console.WriteLine(bersaglio);
                Console.WriteLine($"Punteggio: {punteggio} {bersaglio.Length / (2 * raggioBersaglio + 1)}x{2 * raggioBersaglio + 1}");
                Console.Write("Digita 'X' e poi invio per lanciare, o un altro tasto per uscire: ");
                string scelta = Console.ReadLine();
                if (resta) Modifica(ref bersaglio, xLancio, yLancio, '+');
                resta = (scelta == "x" || scelta == "X");
                if (!resta)
                {
                    Console.WriteLine("Siamo usciti.");
                    return;
                }
                xLancio = Dadi.IntervalloCasuale(-raggioBersaglio, raggioBersaglio);
                yLancio = Dadi.IntervalloCasuale(-raggioBersaglio, raggioBersaglio);
                punteggio += Math.Max(0, raggioBersaglio - Distanza(xLancio, yLancio));
                Modifica(ref bersaglio, xLancio, yLancio, 'X');
            }
            while (resta);
        }
        static public string NuovoBersaglio()
        {
            string risultato = "";
            for (int x = -raggioBersaglio; x <= raggioBersaglio; x++)
            {
                for (int y = -raggioBersaglio; y <= raggioBersaglio; y++)
                {
                    risultato += Valuta(x, y);
                }
                risultato += "\n";
            }
            return risultato;
        }
        static void Modifica(ref char[] mappa, int x, int y, char nuovo) => mappa[2 * (x + raggioBersaglio) + (raggioBersaglio * 4 + 3) * (y + raggioBersaglio)] = nuovo;
        static int Distanza(int x, int y) => (int)Math.Sqrt(x * x + y * y);
        static string Valuta(int x, int y) => ((Distanza(x, y) / 2) % 2 == 0) ? "• " : "· ";
    }
    static class Dadi
    {
        static Random casuale = new Random(); // generatore di casualità
        public static int LanciaDado(int finoA = 6) => 1 + casuale.Next(finoA); // dado da 1 a n
        public static int IntervalloCasuale(int da = 1, int finoA = 10) => casuale.Next(da, 1 + finoA); // dado da n a m
    }
}