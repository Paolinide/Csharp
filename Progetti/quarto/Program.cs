using System;

namespace quarto
{
    class CharType
    {
        public static string nome = "Jean Paul";
        //public string Nome { get => nome; set => nome = value; }

        static void Main(string[] args)
        {

            /*
            int ch;
            Console.Write("Digita un carattere in \"minuscolo\" [ ]\b\b");
            ch = Console.Read();
            int ch_U = toUpper(ch);
            Console.Write("\aIl maiuscolo del carattere \"{0}\" unicode {1} digitato: {2} [{3}]\n", (char)ch, ch, (char)ch_U, ch_U );
            
            Console.Write("Digita il carattere di partenza: ");
            int ch_1 = Convert.ToChar(Console.ReadLine());

            Console.Write("Digita il carattere di arrivo: ");
            int ch_2 = Convert.ToChar(Console.Read());
            */
            int ch_par = 30;//Math.Min(ch_1, ch_2);
            int ch_arr = 150;//Math.Max(ch_1, ch_2);
            /*
            for (int i = ch_par; i <= ch_arr; i++)
            {
                Console.WriteLine(" {0} --> [{1}]", (char)i, i);
            }
            */
            //string nome = "amico";
            {
                int indice = Convert.ToInt32(Console.ReadLine());
                string[] nomi = { "Daniele", "Mauro", "Marco", "Gianluca" };
                indice = Math.Max(0, Math.Min(nomi.Length - 1, indice));
                nome = nomi[indice];
            }
            Console.Clear();
            int nColonne = 13;
            chiedi(ref nColonne);
            /*
            Console.Write("Ciao {0}, quante colonne vuoi? ", nome);
            int nColonne = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("{0}<{1}<{2} : {3}", 1, nColonne, 69, fuori(1, nColonne, 69));
            if (fuori(1, nColonne, 69))
            {
                Console.WriteLine("Mi spiace carino, ma il range é tra 1 e 69!");
                chiedi(ref nColonne);
                //nColonne = Math.Max(1, Math.Min(69, nColonne));
            }
            */
            //Console.WriteLine("numero colonne: {0}", nColonne);
            int j = 0;
            for (int i = ch_par; i <= ch_arr; i++)
            {
                if (aGoodChar(i))//((i >= 65 && i <= 90) || (i >= 97 && i <= 122))
                {
                    j = ((++j) % nColonne);
                    if (nColonne == 1)
                    {
                        Console.WriteLine(" [{0}] => {1}", i, (char)i);
                    }
                    else
                    {
                        if (j == 0) Console.WriteLine(" {0}", (char)i);
                        else Console.Write(" {0}, ", (char)i);
                    }
                }
            }
            //Console.Write("[{0}]", j);
            if (j != 0)
            {
                while (j < nColonne)
                {
                    Console.Write(" @{0}", ((j == (nColonne - 1)) ? "" : ", "));
                    j++;
                }
            }
        }
        public static bool chiedi(ref int c, int m = 3)
        {
            // La funzione richiede di inserire un valore numerico accettabile, ma massimo n volte
            string[] frasi = { "Aspetta, roproviamo", "Cos'é troppo difficile? Riprova", "Forse non era chiaro, tra 1 e 69", "Riprova",
            "Lo fai apposta? Riimmetti", "Dai, ancora", "Ha ha ha. Di nuovo", "Reninserire", "Di nuvo", "Digita un'altra cifra" };
            string frase = "Ciao " + nome + ", inserisci il numero di colonne";
            for (int i = 0; i < m; i++)
            {
                Console.Write("{0}: ", frase);
                string str = Console.ReadLine();
                if (int.TryParse(str, out c) && entro(1, c, 69)) return true;
                frase = frasi[casuale(frasi.Length)];
            }
            //c = Math.Max(1, Math.Min(69, c));
            { // dentro le graffe le variabili create al volo vengono immediatamente distrutte allorché divengono inutili
                int[] opzioni = { 1, 10, 13, 26, 52 };
                c = opzioni[casuale(opzioni.Length)];
            }
            Console.WriteLine("Basta, il numero di colonne è {0}!", c);
            return false;
        }
        static int casuale(int finoA)
        {
            Random random = new Random();
            return random.Next(Math.Max(2, finoA));
        }
        static int casuale(int da, int a)
        {
            Random random = new Random();
            return random.Next(Math.Min(da, a), Math.Max(da, a));
        }
        static bool entro(int v1, int v2, int v3, bool compreso = true)
        { // compreso sta per "compresi gli estremi"
            int vMin = Math.Min(v1, v3);
            int vMax = Math.Max(v1, v3);
            if (compreso) return (vMin <= v2 && v2 <= vMax);
            return (vMin < v2 && v2 < vMax);
        }
        static bool fuori(int v1, int v2, int v3, bool compreso = true)
        {
            return !entro(v1, v2, v3, compreso);
        }
        public static bool aGoodChar(int ch)
        {
            //if (ch >= '0' && ch <= '9') return true; // cifre
            if (ch >= 'A' && ch <= 'Z') return true; // maiuscole
            if (ch >= 'a' && ch <= 'z') return true; // minuscole
            return false;
        }
        public static int toUpper(int ch)
        {
            if ('a' <= ch && ch <= 'z') return ch - 'a' + 'A';
            return ch;//+'\a';
        }
        public int rnd(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
    }
}
