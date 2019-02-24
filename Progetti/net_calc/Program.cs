using System;
using System.Collections; // bitarray
using System.Collections.Generic; // dictionary
using System.Linq; // pairvalue

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

            ipV4Mask msk1 = new ipV4Mask(cifre: 25);
            msk1.stampa();
            msk1.stampaBinario();
            msk1.posti = 500;
            msk1.stampa();
            msk1.stampaBinario();



            var ipA1 = new ipV4Address(192, 168, 128, 10, barra: 24, nome: "Rete A");
            ipA1.stampaBinario();
            ipA1.stampa();
            ipA1[3] += 64 + 16 + 8;
            ipA1.barra = 21;
            ipA1.stampaBinario();
            ipA1.stampa();

            Console.WriteLine();
            ipA1.stampa();
            //ipA1.stampaFiltro(0);
            //ipA1.stampaFiltro(1);
            //ipA1.stampaFiltro(2);
            //ipA1.stampaFiltro(3);
            ipA1.stampaFiltro(5);

            Console.Write("Originale: ");
            ipA1.stampaQuartettoVettore(ipA1.Filtra(0));
            int variazione = -255;
            Console.Write("Spostato di {0}: ", variazione);
            ipA1.stampaQuartettoVettore(ipA1.setVal(ipA1.getVal(ipA1.Filtra(0)) + variazione));

            {
                int numero = 9;
                int parte = (int)Math.Sqrt(numero);
                int[] lista = new int[numero];
                for (int j = 0; j < numero; j++)
                {
                    lista[j] = 2 + Dado(100) * (int)Math.Pow(Dado(10), Dado(5));
                    Console.Write("{0, 6}{1}", lista[j], (j % parte == parte - 1) ? "\n" : " ");
                }
                Console.WriteLine();
                Array.Sort<int>(lista);
                for (int j = 0; j < numero; j++)
                    Console.Write("{0, 6}{1}", lista[j], (j % parte == parte - 1) ? "\n" : " ");
                Console.WriteLine("\n{0, 6}", 2 + 99 * Math.Pow(9, 4));
                string s = Console.ReadLine();
            }

            */

            Console.Clear();

            // SCEGLIAMO UNA MODALITA' DI INSERIMENTO DEI DATI
            Console.Write("Digita 1 per creare un set di reti casuali, 2 per un set predefinito o qualsiasi altro per inserire i dati manualmente: ");
            string modoInserimento = Console.ReadLine();
            var ip_0 = new ipV4Address(192, 168, 128 + 64 + 32 + 16 + 8, 0, barra: 20, nome: "Rete generale");
            string str = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            BitArray valore = ip_0.valIndirizzo;
            if (modoInserimento == "1" || modoInserimento == "2")
            {
                var raccolta = new Dictionary<string, int>();
                if (modoInserimento == "1")
                {
                    for (int j = 0; j < 10 + Dado(16); j++)
                    {
                        string nome = "" + str[j];
                        raccolta.Add(nome, 2 + Dado(100) * (int)Math.Pow(Dado(10), Dado(5))); // 1 + (int)Math.Pow(7, Dado(7)));
                        Console.WriteLine("Nuova rete '{0}' con {1} posti.", nome, raccolta[nome]);
                    }
                }
                else
                {
                    raccolta.Add("A", 100);
                    raccolta.Add("B", 1000);
                    raccolta.Add("C", 10);
                    raccolta.Add("D", 10000);
                    raccolta.Add("E", 2);
                    raccolta.Add("F", 2);
                    raccolta.Add("G", 4);
                    raccolta.Add("H", 500);
                }
                // creaiamo una lista ordinata per numero di host dell'elenco
                var oggetti = from pair in raccolta
                              orderby pair.Value descending
                              select pair;
                // dopodiché li assegneremo a degli oggetti ipV4AddressD
                //Console.WriteLine("Nuova rete '{0}' con {1} posti.", oggetto.Key, oggetto.Value);
                ip_0.stampa();
                ip_0.stampaFiltro(7);
                foreach (var oggetto in oggetti)
                {
                    //Console.WriteLine("Nuova rete '{0}' con {1} posti.", oggetto.Key, oggetto.Value);
                    ip_0 = new ipV4Address(valore, oggetto.Value, oggetto.Key);
                    ip_0.stampa();
                    ip_0.stampaFiltro(0);
                    ip_0.stampaFiltro(3);
                    //ip_0.stampaFiltro(6);
                }
                // per vedere come sarebbe iniziata la rete successiva all'ultima
                ip_0.stampaFiltro(5);

                return;
            }
            //Console.WriteLine(int.MaxValue);










            // ACQUISIZIONE DELL'INIDIRIZZO IP DI PARTENZA
            int i = 0; // *** questa variabile poi non serve più
            int[] ipQ = { 0, 0, 0, 0 }; // qui memoriziamo le qaurtine dell'indirizzo
            Console.Write("Digita il punto '.' come separatore. Premi ESC per uscire.\nInserisci un indirizzo ip v4 valido: ");
            do
            {
                //Console.Write("[{0}]",i);
                ConsoleKeyInfo ck = Console.ReadKey();
                //Console.Write("\b[{0}]",(int)ck.KeyChar);
                if (ck.Key == ConsoleKey.Escape) { Console.WriteLine("\b "); return; } // Q sta per 'quit' e serve ad uscire
                if (ck.KeyChar == 32 && ipQ[i] > 0)
                {
                    Console.Write("\b");
                    for (int j = 0; j < 3 - i; j++)
                        Console.Write(".0");
                    Console.WriteLine();
                    break;
                }
                if (ck.KeyChar >= ',' && ck.KeyChar <= '.') // digitao separatore di quartine separatore (',' '-' '.')
                {
                    Console.Write("\b{0}{1}", ipQ[i] == 0 ? "0" : "", (i < 3) ? "." : "");
                    i++;
                    continue;
                }
                else if (ck.KeyChar >= '0' && ck.KeyChar <= '9') // digitata cifra (0...9)
                {
                    if (ck.KeyChar == 48 && ipQ[i] == 0) { Console.Write("\b0\b"); continue; }
                    int nuovoValore = ipQ[i] * 10 + (ck.KeyChar - 48);
                    if (nuovoValore < 256) ipQ[i] = nuovoValore;
                    else
                    {
                        if (i == 3) { Console.Write("\b \n"); break; }
                        ipQ[++i] = ck.KeyChar - 48;
                        Console.Write("\b.{0}", ck.KeyChar);
                        continue;
                    }
                }
                else // qualsiasi altro tasto non serve a niente (TAB e INVIO fanno casino)
                {
                    string s = "" + ck.Key;
                    Console.Write((s.Length == 1) ? "\b" : "");
                }
            } while (i < 4);

            // ACQUISIZIONE DELL'INIDIRIZZO IP DI PARTENZA
            int subNetMask = 0;
            //string str; // *** questa variabile poi non serve più 
            while (true)
            {
                Console.Write("Inserisci un valore tra 30 e 1 per la maschera di sottorete: ");
                str = Console.ReadLine();
                if (int.TryParse(str, out subNetMask)) if (subNetMask > 0 && subNetMask < 31) break;
            }

            /*
            // STAMPA DEI DATI ACQUISITI
            Console.WriteLine();
            for (i = 0; i < 4; i++)
                Console.Write("{0}{1}", ipQ[i], (i == 3) ? "" : ".");
            Console.WriteLine(" /" + subNetMask + "\n");
            */
            //ASSEGNAZIONE E STAMPA DATI ACQUISITI
            ip_0 = new ipV4Address(ipQ[0], ipQ[1], ipQ[2], ipQ[3], (byte)subNetMask, "Rete principale");
            valore = ip_0.valIndirizzo;

            // ADESSO SCEGLAIMO UNPO' DI SOTTORETI
            // metteremo i valori passati dall'utente in un dizionario...
            var raccoltaSottoReti = new Dictionary<string, int>();
            Console.Write("\nAdesso inseriamo un po' di sottoreti. Digita INVIO per terminare.\n");
            while (true)
            {
                Console.Write("Numero di host desiderati (2 ···> 2'147'483'647): ");
                str = Console.ReadLine();
                if (str == "") break;
                if (!(int.TryParse(str, out i) && i >= 2 && i <= 2147483647)) continue;
                Console.Write("Stabilisci un nome per questa sotto-rete: ");
                str = Console.ReadLine();
                if (str == "") break;
                // arrivati fin qui inizia la registrazione dei dati in un dizionario
                //Console.Write("Nuova rete '{0}' con {1} posti.", str, i);
                raccoltaSottoReti.Add(str, i);
            }
            //  ...e li ordineremo
            var reti = from pair in raccoltaSottoReti
                       orderby pair.Value descending
                       select pair;
            // stampiamo i valori della rele generale
            //Console.Clear();// pulizia e poi stampa
            ip_0.stampa();
            ip_0.stampaFiltro(0);
            ip_0.stampaFiltro(3);
            //ip_0.stampaFiltro(6);
            // dopodiché li assegneremo a degli oggetti ipV4AddressD per stamparli
            foreach (var rete in reti)
            {
                //Console.WriteLine("Nuova rete '{0}' con {1} posti.", oggetto.Key, oggetto.Value);
                ip_0 = new ipV4Address(valore, rete.Value, rete.Key);
                ip_0.stampa();
                ip_0.stampaFiltro(6);
            }
            // per vedere come sarebbe iniziata la rete successiva all'ultima
            ip_0.stampaFiltro(5);



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



        class ipV4Address
        {
            public string nomeRete;
            public void Set(string nome) => nomeRete = nome;
            public BitArray valMaschera = new BitArray(32);
            public BitArray valIndirizzo = new BitArray(32);
            public ipV4Address(BitArray valore, int posti, string nome)
            {
                nomeRete = nome;
                this.posti = posti;
                valIndirizzo = valore;
            }
            public ipV4Address(int q1, int q2, int q3, int q4, byte barra = 24, string nome = "") // Costruttore per quartine e subnet mask
            {
                this[1] = q1; this[2] = q2; this[3] = q3; this[4] = q4; // facile lavorare con le quartine quando si è indicizzata la classe
                this.barra = barra;
                nomeRete = nome;
            }
            public ipV4Address(int q1, int q2, int q3, int q4, int posti, string nome = "") // Costruttore per quartine e numero di host richiesti
            {
                this[1] = q1; this[2] = q2; this[3] = q3; this[4] = q4; // facile lavorare con le quartine quando si è indicizzata la classe
                this.posti = posti;
                nomeRete = nome;
            }
            public int this[int q] // Indicizzatore, per scegliere la quartina (RICORDARSI CHE LE QUARTINE VANNO DA 1 A 4 E NON DA 0 A 3)
            {
                get
                {
                    q = Math.Max(1, Math.Min(4, q)) - 1; // in un solo colpo limitiamo l'indice tra 1 e 4 e lo riduciamo di 1 per farlo diventare più 'amichevole'
                    int quartina = 0; // abbiamo quattro quartine (si poteva anche usare int16 per risparmiare memoria)
                    for (int i = 0; i < 8; i++) // cicliamo nelle quartine
                        if (valIndirizzo[i + q * 8]) quartina += Convert.ToInt16(Math.Pow(2, 7 - i)); // leggiamo il bit dal vettore e lo convertiamo in decimale
                    return quartina; // finito il calcolo si restituisce il valore
                }
                set
                {
                    q = Math.Max(1, Math.Min(4, q)) - 1; // come sopra
                    value = Math.Max(0, Math.Min(255, value));
                    string binario = Convert.ToString(value, 2).PadLeft(8, '0'); // ricaviamo il binario dal decimale e aggiungiamo zeri a sinistra, se servono
                    for (int i = 0; i < 8; i++) // cicliamo nella quartina
                        valIndirizzo[i + q * 8] = binario[i] == '1'; // assegnamo il vaolre corretto al relativo bit del vettore 'valore'
                }
            }
            int getQuart(int q, BitArray valore)
            {
                q = Math.Max(1, Math.Min(4, q)) - 1; // in un solo colpo limitiamo l'indice tra 1 e 4 e lo riduciamo di 1 per farlo diventare più 'amichevole'
                int quartina = 0; // abbiamo quattro quartine (si poteva anche usare int16 per risparmiare memoria)
                for (int i = 0; i < 8; i++) // cicliamo nelle quartine
                    if (valore[i + q * 8]) quartina += Convert.ToInt16(Math.Pow(2, 7 - i)); // leggiamo il bit dal vettore e lo convertiamo in decimale
                return quartina; // finito il calcolo si restituisce il valore
            }
            void setQuart(int q, int value, BitArray valore)
            {
                q = Math.Max(1, Math.Min(4, q)) - 1; // come sopra
                value = Math.Max(0, Math.Min(255, value));
                string binario = Convert.ToString(value, 2).PadLeft(8, '0'); // ricaviamo il binario dal decimale e aggiungiamo zeri a sinistra, se servono
                for (int i = 0; i < 8; i++) // cicliamo nella quartina
                    valore[i + q * 8] = binario[i] == '1'; // assegnamo il vaolre corretto al relativo bit del vettore 'valore'
            }
            public int quantiBitServono(int necessari) // valutiamo quanti bit servono per un certo numero di posti
            {
                for (int i = 2; i < 32; i++)
                    if (Math.Pow(2, i) - 2 >= necessari) return i;
                return 0;
            }
            public int posti // con questa pseudo proprietà possiamo leggere e scrivere il numero di posti, al posto dei bit
            {
                get
                {
                    int i = 0; // l'indice lo teniamo fuori così rimane in memoria anche dopo il loop
                    for (i = 0; i < 32; i++)
                        if (valMaschera[32 - i - 1]) break; // stavolta i valori le leggiamo dal fondo, e ci interrompiamo al primo zero
                    return (int)Math.Pow(2, i) - 2; // lo zero che ha fermato il ciclo è stato comunque contato, che è ok perchè l'esponente deve avere +1 rispetto all'indice
                }
                set => barra = 32 - quantiBitServono(value);
            }
            public int barra
            {
                get // leggiamo il numero di bit
                {
                    int cifre = 0;
                    for (int i = 0; i < 32; i++)
                        if (valMaschera[i]) cifre++;
                    return cifre;
                }
                set // impostiamo un nuovo valore di bit
                {
                    value = Math.Max(1, Math.Min(30, value));
                    for (int i = 0; i < 32; i++)
                        valMaschera[i] = i < value;
                }
            }
            public string quartetto
            {
                get // ecco un bel quartetto restituito da una finta proprietà!
                {
                    return Convert.ToString(this[1]).PadLeft(3, '0')
                    + "." + Convert.ToString(this[2]).PadLeft(3, '0')
                    + "." + Convert.ToString(this[3]).PadLeft(3, '0')
                    + "." + Convert.ToString(this[4]).PadLeft(3, '0');
                }
                //set {} // ************** vedremo più avanti di implementare anche 'sta roba
            }
            public string vettQuartetto(BitArray valore)
            { // ecco un bel quartetto restituito da una finta proprietà!
                return Convert.ToString(getQuart(1, valore)).PadLeft(3, '0')
                + "." + Convert.ToString(getQuart(2, valore)).PadLeft(3, '0')
                + "." + Convert.ToString(getQuart(3, valore)).PadLeft(3, '0')
                + "." + Convert.ToString(getQuart(4, valore)).PadLeft(3, '0');
            }
            public string binario
            {
                get // ecco un bel quartetto restituito da una finta proprietà!
                {
                    string risultato = "";
                    for (int i = 0; i < 32; i++)
                        risultato += (((i > 0) && (i % 8 == 0)) ? "." : "") + "" + (valIndirizzo[i] ? "1" : "0");
                    return risultato;
                }
                //set {} // ************** vedremo più avanti di implementare anche 'sta roba
            }
            public string vettBinario(BitArray valore)
            {
                string risultato = "";
                for (int i = 0; i < 32; i++)
                    risultato += (((i > 0) && (i % 8 == 0)) ? "." : "") + "" + (valore[i] ? "1" : "0");
                return risultato;
            }
            public void stampa(bool aCapo = true) // stampiamo la quartina
            {
                Console.Write("{0}: {1} sub {2} /{3}({4}){5}", nomeRete, quartetto, vettQuartetto(valMaschera), barra, posti, aCapo ? "\n" : "");
            }
            public void stampaBinario(bool separatore = true) // stampiamo il binario
            {
                Console.WriteLine("{0} /{1}({2}) {3}", binario, barra, posti, vettBinario(valMaschera));
            }
            public void stampaQuartettoVettore(BitArray vettore) // stampiamo la quartina di un vettore passato
            {
                Console.WriteLine(vettQuartetto(vettore));
            }
            public void stampaBinarioVettore(BitArray vettore, bool separatore = true) // stampiamo il binario di un vettore passato
            {
                Console.WriteLine(vettBinario(vettore));
            }
            public BitArray Filtra(int filtro = 0) // 0:rete 1:primo 2:ultimo 3:broadcast -1:Ultimo rete precedente 4:primo rete successiva
            {
                if (filtro == 4) return setVal(getVal(Filtra(0)) - 1); // ultimo della rete precedente
                if (filtro == 5) return setVal(getVal(Filtra(3)) + 1); // primo della rete susccessiva
                BitArray risultato = new BitArray(32);
                for (int i = 0; i < 32; i++)
                    risultato[i] = (valMaschera[i]) ? valIndirizzo[i] : (i == 31) ? filtro % 2 == 1 : filtro > 1;
                return risultato;
            }
            public void stampaFiltro(int filtro = 0) // -1:nome della rete 0:rete 1:primo 2:ultimo 3:broadcast 4:Ultimo rete precedente 5:primo rete successiva
            {
                if (filtro == -1) { Console.WriteLine("      Nome: " + nomeRete); return; }
                if (filtro == 6) { for (int i = -1; i < 4; i++) { stampaFiltro(i); } return; } // se passo il 6, me li stampa tutti
                if (filtro == 7) { for (int i = -1; i < 6; i++) { stampaFiltro(i); } return; } // se passo il 7, me li stampa tutti compresi precedente e successivo
                string[] nome = { "Rete", "Primo", "Ultimo", "Broadcast", "Precedente", "Successivo" };
                var vettore = Filtra(filtro);
                Console.Write("{0}: {1} = {2}\n", nome[filtro].PadLeft(10, ' '), vettQuartetto(vettore), vettBinario(vettore));
            }
            public long getVal(BitArray vettore)
            {
                double valore = 0; // 
                for (int i = 0; i < 32; i++) // 
                    if (vettore[i]) valore += Math.Pow(2, 31 - i);
                return (long)valore; // finito il calcolo si restituisce il valore
            }
            public BitArray setVal(long value)
            {
                BitArray valore = new BitArray(32);
                string binario = Convert.ToString(value, 2).PadLeft(32, '0'); // ricaviamo il binario dal decimale e aggiungiamo gli zeri necessari
                for (int i = 0; i < 32; i++) // 
                    valore[i] = binario[i] == '1'; // assegnamo il vaolre corretto al relativo bit del vettore passato
                return valore;
            }
            public BitArray Sposta(long variazione, int filtro = 0) // FILTRO 0:rete 1:primo 2:ultimo 3:broadcast -1:Ultimo rete precedente 4:primo rete successiva
            {
                return setVal(getVal(Filtra(filtro)) + variazione); // primo della rete susccessiva
            }
        }



        class ipV4Mask
        {
            public BitArray valore = new BitArray(32);
            public ipV4Mask(int posti) { this.cifre = 32 - quantiBitServono(posti); } // costruttore per numero di host necessari (sta in una sola riga)
            public ipV4Mask(byte cifre) { this.cifre = cifre; } // costruttore per numero di bit (sta in una sola riga)
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
                    value = Math.Max(0, Math.Min(255, value));
                    string binario = Convert.ToString(value, 2).PadLeft(8, '0'); // ricaviamo il binario dal decimale e aggiungiamo zeri a sinistra, se servono
                    for (int i = 0; i < 8; i++) // cicliamo nella quartina
                        valore[i + q * 8] = binario[i] == '1'; // assegnamo il vaolre corretto al relativo bit del vettore 'valore'
                }
            }
            public int quantiBitServono(int necessari) // valutiamo quanti bit servono per un certo numero di posti
            {
                for (int i = 2; i < 32; i++)
                    if (Math.Pow(2, i) - 2 >= necessari) return i;
                return 0;
            }
            public int posti // con questa pseudo proprietà possiamo leggere e scrivere il numero di posti, al posto dei bit
            {
                get
                {
                    int i = 0; // l'indice lo teniamo fuori così rimane in memoria anche dopo il loop
                    for (i = 0; i < 32; i++)
                        if (valore[32 - i - 1]) break; // stavolta i valori le leggiamo dal fondo, e ci interrompiamo al primo zero
                    return (int)Math.Pow(2, i) - 2; // lo zero che ha fermato il ciclo è stato comunque contato, che è ok perchè l'esponente deve avere +1 rispetto all'indice
                }
                set
                {
                    cifre = 32 - quantiBitServono(value);
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
                    value = Math.Max(1, Math.Min(30, value));
                    for (int i = 0; i < 32; i++)
                        valore[i] = i < value;
                }
            }

            public string quartetto
            {
                get // ecco un bel quartetto restituito da una finta proprietà!
                {
                    return Convert.ToString(this[1]).PadLeft(3, '0')
                    + "." + Convert.ToString(this[2]).PadLeft(3, '0')
                    + "." + Convert.ToString(this[3]).PadLeft(3, '0')
                    + "." + Convert.ToString(this[4]).PadLeft(3, '0');
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
                Console.WriteLine("{0} /{1}({2})", quartetto, cifre, posti);
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
