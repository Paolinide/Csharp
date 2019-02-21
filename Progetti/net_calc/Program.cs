using System;
using System.Collections;

namespace net_calc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear(); // una ripulita all'inizio andrebbe sempre data
            /*
            // TUTTA 'STA ROBA SEVIVA PER LE PROVE DI COSA METTERE POI NEI METODI DELLA CLASSE 'ipV4Mask'

            BitArray vettore = new BitArray(32); // dichiarazione /inizializzazione vettore binario
            // FORNIAMO UN VALORE CASUALE ALLA SUBNETMASK
            int cifre = 1 + Dado(30); // la subnet mask ha senso tra 30 e 1 ?!
            Console.WriteLine("Partiamo con una sub di {0} bit.", cifre);
            for (int i = 0; i < 32; i++) // ciclo di assegnazione
                vettore[i] = i < cifre; // assegnazione del valore binario
            // STAMPIAMO IL BINARIO
            Console.WriteLine("Il vettore in binario è questo:");
            for (int i = 0; i < 32; i++) // ciclo di lettura
                Console.Write("{0}{1}", (i > 0 && i % 8 == 0) ? "." : "", vettore[i] ? "1" : "0"); // stampaggio del vettore binario (anche coi separatori ;D)
            Console.WriteLine(); // a capo finita la sfila di uni e zeri
            // CONVERTIAMO E STAMPIAMO IN DECIMALE
            // conversione binario in decimale (numero di bit usati)
            cifre = 0; // ricicliamo la vecchia variabile che non ci serve più
            for (int i = 0; i < 32; i++) // ciclo di lettura
                if (vettore[i]) cifre++; // se il bit è 'su' allora abbiamo una cifra esi stampa '1', altrimenti si stampa '0'
            Console.WriteLine("In decimale diventa: {0}", cifre);
            // CONVERTIAMO E STAMPIAMO DA BINARIO IN QUARTINE DECIMALI
            // andiamo con le quartine in decimali?
            Console.Write("Le quartine sono: ");
            int[] quartina = new int[4]; // abbiamo quattro quartine (si poteva anche usare int16 per risparmiare memoria)
            for (int q = 0; q < 4; q++) // cicliamo le quartine
            {
                if (q > 0) Console.Write("."); // un punto tra le quartine ci sta
                for (int i = 0; i < 8; i++) // cicliamo nelle quartine
                {
                    //Console.Write("[{0}{1}]", q, i); // stampa gli indici relativi alle quartine
                    //Console.Write("{0}:{1} ",1+i+q*8,vettore[i+q*8] ? "1" : "0"); // stampa l'indice del vettore binario col relativo valore
                    // ricordiamoci che la potenza del bit segue l'indice nella quartina ma i bit partono da quello più alto (quindi 7-i)...
                    // ...ma l'elemento del vettore da prelevare ha indice nel vettore intero (quindi i+q*8)
                    if (vettore[i + q * 8]) quartina[q] += Convert.ToInt16(Math.Pow(2, 7 - i));
                }
                Console.Write(quartina[q]); // una volta contata la stampiamo anche
            }
            Console.WriteLine(); // a capo ancora
            // CONVERTIAMO E STAMPIAMO DA QUARTINE DECIMALI NUOVAMENTE A BINARIO
            for (int q = 0; q < 4; q++) // cicliamo le quartine
            {
                string binario = Convert.ToString(quartina[q], 2).PadLeft(8, '0'); // ricaviamo il binario dal decimale
                //if (q > 0) Console.Write("."); // il solito punto tra le quartine
                //Console.Write(binario); // stampa di prova
                for (int i = 0; i < 8; i++) // cicliamo nelle quartine
                {
                    //Console.Write("{0}", binario[i] == '1' ? "1" : "0"); // prova
                    //Console.Write("[{0} {1}] ", i+q*8, i); // prova
                    vettore[i + q * 8] = binario[i] == '1'; // assegnamo il vaolre corretto al relativo bit del vettore
                }
            }
            //Console.WriteLine(); // un separatore serve se facciamo stampare nel ciclo la serie binaria

            // E INFINE STAMPIAMO DI NUOVO IL BINARIO COME PROVA DEL 9
            Console.WriteLine("Il vettore in binario adesso è questo:");
            for (int i = 0; i < 32; i++) // ciclo di lettura
                Console.Write("{0}{1}", (i > 0 && i % 8 == 0) ? "." : "", vettore[i] ? "1" : "0"); // stampaggio del vettore binario (anche coi separatori ;D)
            Console.WriteLine(); // a capo finita la sfila di uni e zeri
            */

            ipV4Mask msk = new ipV4Mask(24);
            msk.stampa();
            msk.stampaBinario();
            msk.cifre = 12;
            msk.stampa();
            msk.cifre = 8;
            msk.stampa();
            msk.cifre = 21;
            msk.stampa();
            msk.cifre = 4;
            msk.stampa();
            msk.cifre = 27;
            msk.stampa();
            msk.cifre = 30;
            msk.stampa();
            msk = new ipV4Mask(255,255,128,0);
            Console.WriteLine(msk.cifre);
            Console.WriteLine(msk.quartetto);
            Console.WriteLine(msk.binario);
            msk[3] = 128+64+32;
            msk.stampaBinario();
            msk.stampa();

            Console.WriteLine(); // un separatore alla fine ci sta sempre

        }





        static public int Dado(int entro)
        {
            Random caso = new Random();
            return caso.Next(entro);
        }


        static public string Converti(int valore, int aBase = 2, int daBase = 10)
        {
            String numero = Convert.ToString(valore);
            return Convert.ToString(Convert.ToInt32(numero, daBase), aBase);
        }







        class ipV4Mask
        {
            BitArray valore = new BitArray(32);
            public ipV4Mask(int dimensione) { this.cifre = dimensione; } // costruttore per numero di bit (sta in una sola riga)
            /*
            public ipV4Mask(string val) // Costruttore per stringa
            {
                // qui ci andrebbe un controllo della validità della stringa
                // se la stringa contiene 32 o 35 caratteri (coi punti) probabilmente è un binario
                for (int i = 0; i < val.Length; i++)
                    valore[i] = val[i] == 1;
            }
            */
            public ipV4Mask(int q1, int q2, int q3, int q4) // Costruttore per quartine (anche questo starebbe in una sola riga volendo)
            {
                this[1] = q1; this[2] = q2; this[3] = q3; this[4] = q4; // facile lavorare con le quartine quando si è indicizzata la classe
            }
            public int this[int q] // Indicizzatore, per scegliere la quartina (RICORDARSI CHE LE QUARTINE VANNO DA 1 A 4 E NON DA 0 A 3)
            {
                get
                {
                    q = Math.Max(1, Math.Min(4, q)) - 1; // in un colpo limitiamo l'indice tra 1 e 4 e lo riduciamo di 1 per farlo diventare più 'amichevole'
                    int quartina = 0; // abbiamo quattro quartine (si poteva anche usare int16 per risparmiare memoria)
                    for (int i = 0; i < 8; i++) // cicliamo nelle quartine
                        if (valore[i + q * 8]) quartina += Convert.ToInt16(Math.Pow(2, 7 - i)); // leggiamo il bit dal vettore e lo convertiamo in decimale portandolo a potenza, ma dalla cifra più a sinistra, quindi con l'esponente maggiore
                    return quartina; // finito il calcolo si restituisce il valore
                }
                set
                {
                    q = Math.Max(1, Math.Min(4, q)) - 1; // come sopra
                    string binario = Convert.ToString(value, 2).PadLeft(8, '0'); // ricaviamo il binario dal decimale e aggiungiamo zeri a sinistra, se servono
                    for (int i = 0; i < 8; i++) // cicliamo nella quartina
                        valore[i + q * 8] = binario[i] == '1'; // assegnamo il vaolre corretto al relativo bit del vettore 'valore'
                }
            }
            public int cifre
            {
                get // leggiamo il numero di bit
                {
                    int cifre = 0;
                    for (int i = 0; i < 32; i++)
                        if (valore[i]) cifre++;
                    return cifre;
                }
                set // impostiamo un nuovo valore di bit
                {
                    for (int i = 0; i < 32; i++)
                        valore[i] = i < value;
                }
            }

            public string quartetto
            {
                get // ecco un bel quartetto restituito da una finta proprietà!
                {
                    return this[1] + "." + this[2] + "." + this[3] + "." + this[4];
                }
                //set {} // ************** vedremo più avanti di implementare anche 'sta roba
            }
            public string binario
            {
                get // ecco un bel quartetto restituito da una finta proprietà!
                {
                    string risultato = "";
                    for (int i = 0; i < 32; i++)
                        risultato += (((i > 0) && (i % 8 == 0)) ? "." : "") + "" + (valore[i] ? "1" : "0");
                    return risultato;
                }
                //set {} // ************** vedremo più avanti di implementare anche 'sta roba
            }
            public void stampa() // stampiamo la quartina
            {
                //Console.WriteLine("{0}.{1}.{2}.{3}", this[1], this[2], this[3], this[4]);
                Console.WriteLine("({0,2}) {1}", cifre, quartetto);
            }
            public void stampaBinario(bool separatore = true) // stampiamo il binario
            {
                for (int i = 0; i < 32; i++)
                    Console.Write("{0}{1}", ((separatore) && (i > 0) && (i % 8 == 0)) ? "." : "", valore[i] ? "1" : "0");
                Console.WriteLine();
            }
        }
    }
}
