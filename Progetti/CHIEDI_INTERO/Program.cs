using System;

namespace CHIEDI_INTERO
{
    class Program
    { // {0}:nome utente, {1}:minimo, {2}:massimo, {3}:valore attuale, {4}:valore passato, {5}:tentativi rimasti, {5}:singolare/plurale
        // Nome dell'interlocutore
        public static string nomeUtente = "jp"; // {0}
        // limiti del valore da inserire
        public static int vMin = 1; // {1}
        public static int vMax = 10;// {2}
        // domanda iniziale
        public static string frase = "Salve {0}, inserisci un valore compreso tra {1} e {2}: ";
        // Elenco di frasi per ripetere identica la domanda iniziale
        public static string[] frasiErratoTipo = { "Il valore che hai inserito,'{4}', non è corretto. Riprova: ",
            "'{4}' proprio no, hai sbagliato a digitare? Riprova: ",
            "Hai ancora {5} tentativ{6} {0}, poi scelierò io. Dai, di nuovo: " };
        public static string[] frasiFuoriLimiti = { "Il valore che hai inserito,'{4}', è oltre i limiti. Riprova: ",
            "Devi inserire un valore compreso tra {1} e {2}: ",
            "Hai ancora {5} tentativ{6} {0}, poi scelierò io. Prova di nuovo: " };
        public static string fraseUscita = "Useremo il '{3}'!";
        // alcuni valori di default proposti in caso l'utente non inserisca un valore accettabile
        public static int[] vDefault = { }; //es.{1,5,10,20} o {7} se rimane vuoto verrà proposto un numero casuale entro i limiti vMin e vMax



        static void Main(string[] args)
        {

            int v = 0;
            chiedi(ref v, 0);
            Console.WriteLine("E' stato accettato il valore '{0}'.", v);

            //Console.WriteLine((char)126);
            /*
            int c = 0;
            for (int i = 0; i < 100; i++)
            {
                v = casuale(3);
                if (v == 0) c++;
                Console.WriteLine(v);
            }
            Console.WriteLine("{0} zeri stampati!", c);
            */
        }


        public static bool chiedi(ref int c, int m = 10)
        {
            // La funzione richiede di inserire un valore numerico accettabile, per un massimo 'm' volte
            Console.Clear();
            // messaggio in caso di loop infinito
            if (m <= 0) Console.WriteLine(" ~ Sei in un ciclo infinito, per forzarne l'uscita premi il solo tasto IVIO.");
            string str = "";
            int i = m;
            do
            {
                // messaggio in caso di loop infinito
                if (m <= 0) Console.Write(" ~ ");
                // frase di introduzione alla richiesta
                Console.Write(frase, nomeUtente, vMin, vMax, c, str, ((m > 1) ? "∞" : "" + (m - i)), (m - i == 1) ? "o" : "i");
                // acquisizione del dato dall'utente
                str = Console.ReadLine();
                // digitando solo RETURN si esce comunque dal ciclo
                if (str == "")
                {
                    Console.WriteLine("Digitando solo INVIO sei uscito dal ciclo di domande.");
                    break;
                }
                // verifica della validità del dato passato...
                if (int.TryParse(str, out c)) // tipo giusto
                {
                    if (vMin <= c && c <= vMax) // entro i limiti
                    {
                        return true; // si esce dalla funzione
                    }
                    else // fuori dai limiti
                    {
                        frase = frasiFuoriLimiti[casuale(frasiFuoriLimiti.Length)];
                    }
                }
                else // tipo sbagliato
                {
                    frase = frasiErratoTipo[casuale(frasiErratoTipo.Length)];
                }
                // impostazione nuova frase in caso di ricorsione
                if (m > 0) i--;
            } while (i > 0);
            { // dentro le graffe le variabili create al volo vengono immediatamente distrutte allorché divengono inutili
                if (vDefault.Length == 0) c = casuale(vMin, vMax); // se non ci sono default proposti...
                else c = vDefault[casuale(vDefault.Length)]; //...viene passato un valore casuale entro i limiti impostati
            }
            Console.WriteLine(fraseUscita, nomeUtente, vMin, vMax, c, str, 0, "o");
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
    }
}
