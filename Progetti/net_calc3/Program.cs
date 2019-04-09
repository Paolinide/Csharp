using System;
using System.Collections;
using System.Collections.Generic;

namespace net_calc3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Clear();
            //int[] ints = { 10, 45, 15, 39, 21, 26 };
            //var result = ints.OrderBy(g => g);

            /*
                Type type = typeof(ConsoleColor);
                StampaColorato("Stringa Fantasma!!!\n", ConsoleColor.Black);
                for (int i = 0; i < Enum.GetNames(type).Length; i++)
                {
                    var name = Enum.GetNames(type)[i];
                    Console.BackgroundColor = (ConsoleColor)Enum.Parse(type, Enum.GetNames(type)[15-(i)]);
                    Console.ForegroundColor = (ConsoleColor)Enum.Parse(type, name);
                    Console.WriteLine(name);
                }
                Console.ResetColor();
                byte[] MskValue = { 255, 255, 224, 0 };
                StampaQuartina(MskValue);
                for (byte i = 1; i < 33; i++)
                {
                    MskValue = setBarra((byte)(32 - i));
                    uint utenti = (uint)(1 + Math.Pow(3, i - 1) - 2);
                    //MskValue = setUtenti((byte)(utenti));
                    //Console.WriteLine("{0,2}: {1,6}>>{2,6} {3} /{4}", i, utenti, getUtenti(MskValue), Stringa(MskValue), getBarra(MskValue));
                    Console.WriteLine("{0,2}: {1} /{2,2}({3,13:#,##0})", i, Stringa(MskValue), getBarra(MskValue), utenti);
                }
                */
            /*
            int max = 0;
            for (int i = 0; i < 500; i++)
            {
                int n1 = Dado(7), n2 = Dado(7), n3 = (int)(1 + Math.Pow(n1, n2));
                max = Math.Max(max, n3);
                Console.Write("{0} ^ {1} = {2, 5}{3}", n1, n2, (uint)n3, (i % 10 == 9) ? "\n" : "   ");
            }
            Console.WriteLine(max + " · " + (uint)(1 + Math.Pow(6, 6)));
            */
            //Console.Write("\nPremi INVIO per continuare o un altro tasto per terminare.");
            //if (Console.ReadKey().Key != ConsoleKey.Enter) { Console.WriteLine(); return; }
            /*
            ConsoleKeyInfo tasto;
            do
            {
                tasto = Console.ReadKey();
                if (tasto.Key == ConsoleKey.Escape) { Console.WriteLine(); return; }
            } while (tasto.Key != ConsoleKey.Enter);
            */
            Console.Clear();

            var prova = new IPAddressV4();
            prova.stampa();

            byte[] ip = { 192, 169, 23, 46 };
            Rete rete_0 = new Rete("Rete Totale", ip, barra: 16);
            Console.WriteLine(rete_0.ToString());
            StampaVettore(rete_0.IpValue);
            rete_0.setName("Rete Grandona").setCIDR(15).setStringIp("192.168.128.64");
            Console.WriteLine(rete_0.ToString());
            /*
            uint[] posti = new uint[5 + Dado(10)];//{ 5000, 600, 200, 10000 };
            for (int i = 0; i < posti.Length; i++)
                posti[i] = (uint)(1 + Math.Pow(Dado(7), Dado(7)));
            rete_0.SottoReti(posti, new string[] { "Rete_0", "R1", "R2", "R3", "R4" });
            */
            rete_0.SottoReti(new uint[] { 2, 4, 12000 }, new string[] { "piccola", "Granda", "Più Granda" });
            Console.WriteLine(rete_0.ToString());
            Console.WriteLine(rete_0.stringaIp);
            StampaVettore(rete_0.IpValue);
            rete_0.StampaRete();
            /*
            string str = "a.0.0.0";
            Console.WriteLine("{0} -> {2} = {1}", str, Rete.StringaToMsk(str, ref ip), string.Join(".", ip));
            str = "255.0.0.269";
            Console.WriteLine("{0} -> {2} = {1}", str, Rete.StringaToMsk(str, ref ip), string.Join(".", ip));
            str = "-5.0.0.0";
            Console.WriteLine("{0} -> {2} = {1}", str, Rete.StringaToMsk(str, ref ip), string.Join(".", ip));
            str = "128.230.6.9";
            Console.WriteLine("{0} -> {2} = {1}", str, Rete.StringaToMsk(str, ref ip), string.Join(".", ip));
            str = "128.192.224.240";
            Console.WriteLine("{0} -> {2} = {1}", str, Rete.StringaToMsk(str, ref ip), string.Join(".", ip));
            return;
            rete_0.Stampa();
            // VEDIAMO DI INTEGRARE LA GENERAZIONE DI SOTTORETI
            // ALL'INTERNO DELL'ISTANZA RETE()
            // A PARTIRE DA UN ELENCO DI NOMI(opzionale) E DI NUMERO DI HOST(necessario)
            Rete[] listaReti = new Rete[10];
            for (int i = 0; i < listaReti.Length; i++)
                listaReti[i] = new Rete("" + "ABCDEFGHIJKLMNOPQRSTUVWXYZ"[i], rete_0.IpValue, utenti: (uint)(1 + Math.Pow(Dado(7), Dado(7))));
            Rete.Riordina(ref listaReti);
            for (int i = 0; i < listaReti.Length; i++)
                listaReti[i].StampaInRiga();
            //Console.WriteLine();
            listaReti[listaReti.Length - 1].StampaStringa(4, true);
            Console.WriteLine();
            //*

            //for (int i = 0; i < 10; i++)
            //  Stampa(ipvalue = Sposta(ipvalue, 128));

            //Console.WriteLine("\n" + Barra(ipvalue));
            return;
            //*
            // ******************************************************************************************
            // ACQUISIZIONE INDIRIZZO IP
            int[] quartinaIP = { 192, 168, 25, 4 };
            //do
            //{
            Console.Write("Digita un indirizzo ip valido: ");
            //string s1 = Console.ReadLine();
            //} while (true);            
            //string[] strIP = s1.Split(".");
            //for (int i = 0; i < 4; i++)
            //Int32.TryParse(strIP[i], out quartinaIP[i]);
            //ACQUISIZIONE MASCHERA
            int[] quartinaMSK = { 255, 255, 0, 0 };

            Console.Write("Inserisci una maschera di sottorete: ");
            string s2 = Console.ReadLine();
            string[] strMSK = s2.Split(".");
            for (int i = 0; i < 4; i++)
                Int32.TryParse(strMSK[i], out quartinaMSK[i]);

            // STAMPA IP E SUB
            Console.Write("\nIndirizzo ip: ");
            for (int i = 0; i < 4; i++)
                Console.Write("[{0}:{1}]", i, quartinaIP[i]);
            Console.Write("\nMaschera: ");
            for (int i = 0; i < 4; i++)
                Console.Write("[{0}:{1}]", i, quartinaMSK[i]);

            // ESERCIZIO 1 : SUB /8-/16-/24
            // STAMPA DI TUTTI MEMBRI DELLA SOTTORETE
            Console.WriteLine("\nStampiamo tutti gli host di questa rete.");
            /*
            for (int j2 = quartinaMSK[1]; j2 < 256; j2 += 15)
                for (int j3 = quartinaMSK[2]; j3 < 256; j3 += 15)
                    for (int j4 = 0; j4 < 256; j4++)
                    {
                        Console.WriteLine("{0}.{1}.{2}.{3}",
                            quartinaIP[0],
                                (quartinaMSK[1] == 0) ? j2 : quartinaIP[1],
                                    (quartinaMSK[2] == 0) ? j3 : quartinaIP[2],
                                        j4);
                    }
            *
            // ESERCIZIO 2 : SUB QUALSIASI
            // STAMPA DI TUTTI MEMBRI DELLA SOTTORETE
            // Calcolare il numero di indirizzi possibili... (host disponibili=indirizzi-2)
            */
        }



        static public void StampaColorato(string stringa, ConsoleColor colore = ConsoleColor.DarkRed)
        {
            //Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = colore;
            Console.WriteLine(stringa);//.PadRight(Console.WindowWidth - 1));
            Console.ResetColor();
        }


        static public byte getBarra(byte[] MskValue)
        {
            for (byte q = 0; q < 4; q++) // cicliamo tra le quartine
                for (byte i = 0; i < 8; i++) // cicliamo tra i bit del quartino
                    if ((MskValue[3 - q] / (Math.Pow(2, i))) % 2 == 1) return (byte)(32 - 8 * q - i); // cerchiamo il primo bit a 1, li si ferma la barra
            return 0; // non dovrebbe capitare, ma nel caso si esca dal ciclo senza trovare un bit a 1
        }
        static public byte[] setBarra(byte value)
        {
            byte[] MskValue = { 0, 0, 0, 0 };
            byte[] predefinito = { 128, 192, 224, 240, 248, 252, 254 }; // non serve calcolare ogni volta il valore del byte, tanto le opzioni sone poche
            for (int i = 0; i < 4; i++) // si valuta byte per byte se il valore passato è entro i limiti di quel quatino
                MskValue[i] = (byte)((value > 8 * i + 7) ? 255 : ((value < 8 * i + 1)) ? 0 : predefinito[value - 8 * i - 1]); // e gli si assegna il valore corrispondente
            return MskValue;
        }
        static public uint getUtenti(byte[] indirizzo)
        {
            byte barra = getBarra(indirizzo);
            int esponente = 32 - barra;
            Console.Write("<[/{0}^{1}={2}]>", barra, esponente, Math.Pow(2, esponente) - 2);
            //            Math.Pow(2, 32 - getBarra(indirizzo)) - 2
            //return (uint)(Math.Pow(2, 32 - getBarra(indirizzo)) - 2);
            return (uint)(Math.Pow(2, esponente) - 2);
        }
        static public byte[] setUtenti(uint value) => setBarra(quantoGrande(value));

        static public byte quantoGrande(uint utenti) // In che barra deve essere la maschera per gestire un certo numero di utenti
        {
            for (byte i = 2; i < 32; i++) // proviamo i CIDR partendo da quello con meno utenti
                if (Math.Pow(2, i) - 2 >= utenti) return (byte)(32 - i); // il primo che offre abbastanza utenze è quello buono
            return 32; // altrimenti qualcosa non va
        }





        static public string Stringa(byte[] quartina)
        {
            string risultato = "";
            for (int i = 0; i < 4; i++)
                risultato += quartina[i].ToString().PadLeft(3, '0') + ((i == 3) ? "" : ".");
            return risultato;
        }
        static public void StampaQuartina(byte[] quartina) => Console.Write(Stringa(quartina) + "\n");
        static public void StampaVettore<T>(T[] vettore)
        {
            for (int i = 0; i < vettore.Length; i++)
            {
                Console.Write("'{0}' ", vettore[i]);
            }
            Console.WriteLine();
        }
        static public int Dado(int max)
        {
            Random casuale = new Random();
            return casuale.Next(max);
        }






        public class Rete : Object, IEquatable<Rete>, IComparable<Rete>
        {
            string nome = "Rete Senza Nome";
            byte[] ipValue = { 192, 168, 0, 0 };
            byte[] mskValue = { 255, 255, 255, 0 };
            Rete[] sottoRete = null;
            // OLTRE AL COSTRUTTORE DI DEFAULT C'E' UN'AMPIA SCELTA DI ALTERNATIVE
            public Rete() { }
            public Rete(string nome, string indirizzoIP, string maschera)
            {
                this.Nome = nome;
                stringaIp = indirizzoIP;
                stringaMsk = maschera;
            }
            public Rete(string nome, string indirizzoIP, byte barra)
            {
                this.Nome = nome;
                stringaIp = indirizzoIP;
                this.barra = barra;
            }
            public Rete(string nome, string indirizzoIP, uint utenti)
            {
                this.Nome = nome;
                stringaIp = indirizzoIP;
                this.utenti = utenti;
            }
            public Rete(string nome, byte q1, byte q2, byte q3, byte q4, byte barra)
            {
                this.Nome = nome;
                this.IpValue = new byte[4] { q1, q2, q3, q4 };
                this.barra = barra;
            }
            public Rete(string nome, byte q1, byte q2, byte q3, byte q4, uint utenti)
            {
                this.Nome = nome;
                this.IpValue = new byte[4] { q1, q2, q3, q4 };
                this.utenti = utenti;
            }
            public Rete(string nome, byte[] quart, byte[] maschera)
            {
                this.Nome = nome;
                IpValue = quart;
                mskValue = maschera;
            }
            public Rete(string nome, byte[] quart, byte barra)
            {
                this.Nome = nome;
                IpValue = quart;
                this.barra = barra;
            }
            public Rete(string nome, byte[] quart, uint utenti)
            {
                this.Nome = nome;
                IpValue = quart;
                this.utenti = utenti;
            }
            ~Rete() // Non so ancora come, ma forse potrebbe servire anche un distruttore
            {
                Console.WriteLine("La rete '{0}' è stata eliminata.", this.Nome);
            }
            static public byte quantoGrande(uint utenti) // In che barra deve essere la maschera per gestire un certo numero di utenti
            {
                for (byte i = 2; i < 32; i++) // proviamo i CIDR partendo da quello con meno utenti
                    if (Math.Pow(2, i) - 2 >= utenti) return (byte)(32 - i); // il primo che offre abbastanza utenze è quello buono
                return 0; // altrimenti qualcosa non va
            }
            public byte barra
            { // Legge ed imposta la maschera col famigerato CIDR
                get
                {
                    for (byte q = 0; q < 4; q++) // cicliamo tra le quartine
                        for (byte i = 0; i < 8; i++) // cicliamo tra i bit del quartino
                            if ((MskValue[3 - q] / (Math.Pow(2, i))) % 2 == 1) return (byte)(32 - 8 * q - i); // troviamo il primo bit a 1, li si ferma la barra
                    return 0; // non dovrebbe capitare, ma nel caso si esca dal ciclo senza trovare un bit a 1
                }
                set
                {
                    byte[] predefinito = { 128, 192, 224, 240, 248, 252, 254 }; // non serve calcolare ogni volta il valore del byte, tanto le opzioni sone poche
                    for (int i = 0; i < 4; i++) // si valuta byte per byte se il valore passato è entro i limiti di quel quartino
                        MskValue[i] = (byte)((value > 8 * i + 7) ? 255 : ((value < 8 * i + 1)) ? 0 : predefinito[value - 8 * i - 1]); // e gli si assegna il valore corrispondente
                    // Con gli if..else il codice è più leggibile, ma una volta verificato si può tranquillamente usare l'operatore ternario annidandone uno nell'altro
                    //Console.Write("{0}:{1}<{2}[{3}] * ", i, 8 * i, 8 * i + 7, value - 8 * i);
                    //if (value > 8 * i + 7) IpValue[i] = 255;
                    //else if (value < 8 * i) IpValue[i] = 0;
                    //else IpValue[i] = predefinito[value - 8 * i];
                }
            }
            public Rete setCIDR(byte barra) { this.barra = barra; return this; } // per concatenare in una sola riga tutte le istruzioni di impostazione
            public uint utenti
            { // Conta il numero massimo di host ed imposta la maschera di conseguenza
                get => (uint)Math.Pow(2, 32 - barra) - 2;
                set => barra = quantoGrande(value);
            }
            public Rete setUsers(uint utenti) { this.utenti = utenti; return this; } // per concatenare in una sola riga tutte le istruzioni di impostazione
            // Portando fuori le funzioni di get e set delle proprietà si possono impostare delle limitazioni o eseguire delle verifiche sui dati
            public string Nome { get => nome; set => nome = value; }
            public Rete setName(string nome) { this.Nome = nome; return this; } // per concatenare in una sola riga tutte le istruzioni di impostazione
            public byte[] IpValue
            {
                get => ipValue;
                set { if (value.Length == 4) ipValue = value; }
            }
            public Rete setIpValue(byte[] ip) { this.IpValue = ip; return this; } // per concatenare in una sola riga tutte le istruzioni di impostazione
            public byte[] MskValue
            {
                get => mskValue;
                set
                {
                    if (value.Length != 4) return; // Controlliamo il numero di parametri passati...
                    byte[] seq = { 0, 128, 192, 224, 240, 248, 252, 254, 255 };// "00000000" "10000000" "11000000" ... "11111100" "11111110" "11111111"
                    for (int i = 0; i < 4; i++)
                    {
                        byte n = value[i];
                        if (Array.IndexOf(seq, n) == -1) return; // ...e che siano parte di una sequenza binaria prestabilita
                        else value[i] = n;
                    }
                    mskValue = value;
                }
            }
            public Rete setMskValue(byte[] msk) { this.MskValue = msk; return this; } // per concatenare in una sola riga tutte le istruzioni di impostazione
            // in generale indicizzare una classe è molto fico
            public byte this[int indice] // si può accedere alle quartine tramite un indice
            { // da 1 a 4 è l'ip, da 5 a 8 la maschera, partiamo dall'indice 1 per rendere l'approccio più amichevole all'utente
                get { return (--indice < 4) ? IpValue[indice] : MskValue[indice - 4]; } // da 1 a 4 indirizzo ip e da 5 a 8 maschera
                set { if (--indice < 4) IpValue[indice] = value; else MskValue[indice - 4] = value; }
            } // comandi sulla stessa riga per rendere il codice più compatto, comunque in questo caso si legge bene lo stesso
              // Una funzione per spostare il valore di tutta una quartina di un tot, in avanti o in dietro, può sempre far comodo
              // Naturalmente tutte le funzioni 'utility' vanno definite come static perché indipendenti dalla singola istanza
            static public void Riordina(ref Rete[] lista) // Riordina una lista di Reti e le rende sequenziali
            {
                for (int j = 0; j < lista.Length - 1; j++)
                    for (int i = 0; i < lista.Length - 1 - j; i++)
                        if (lista[i] < lista[i + 1]) Scambia(ref lista[i], ref lista[i + 1]);
                for (int j = 0; j < lista.Length - 1; j++)
                    lista[j + 1].IpValue = lista[j].prossimo;
            }
            public bool SottoReti(uint[] posti, string[] nomi = null)
            {
                if (posti == null) return false;
                if (nomi == null || nomi.Length < posti.Length) nomi = NomiOriginali(nomi, posti.Length);
                sottoRete = new Rete[posti.Length];
                byte[] copiaIp = new byte[4];
                this.IpValue.CopyTo(copiaIp, 0);
                for (int i = 0; i < sottoRete.Length; i++)
                    sottoRete[i] = new Rete(nomi[i], copiaIp, utenti: posti[i]);
                Riordina(ref sottoRete);
                return true;
            }
            static public string[] NomiOriginali(string[] nomi, int lunghezza)
            {
                string[] nuoviNomi = new string[lunghezza];
                for (int i = 0; i < lunghezza; i++)
                {
                    if (i < nomi.Length) nuoviNomi[i] = nomi[i];
                    else nuoviNomi[i] = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"[i - nomi.Length].ToString();
                }
                return nuoviNomi;
            }
            static public void Scambia(ref Rete primo, ref Rete secondo) { Rete temp = primo; primo = secondo; secondo = temp; }
            static public byte[] Sposta(byte[] indirizzo, long varaiazione) // somma un certo avlore ad una quartina e ne restituisce il risultato
            { // avere delle 'utility' permette di ridurre un metodo a poche righe di comando, o anche ad una sola, rendendolo più chiaro e facile da manutenere
                return LongToIp(varaiazione + IptoLong(indirizzo));
            }
            // Le trasformazioni dei tipi di dato sono sempre comode per non dover duplicare il codice all'interno di una classe
            static public long IptoLong(byte[] valore) // conversione di 4 byte separati ad un int di 4 byte
            {
                long risultato = 0;
                for (int i = 0; i < 4; i++)
                    risultato += valore[i] * (long)Math.Pow(256, 3 - i);
                return risultato;
            }
            static public byte[] LongToIp(long valore)  // conversione da un int di 4 byte ad 4 byte separati
            {
                byte[] risultato = { 0, 0, 0, 0 };
                for (int i = 0; i < 4; i++)
                    risultato[i] = (byte)((valore / Math.Pow(256, 3 - i)) % 256);
                return risultato;
            }
            // ADESSO LA SERIE DI FUNZIONI PER IL TRATTAMENTO DEI VALORI PRINCIPALI
            static public byte[] Maschera(byte[] indirizzo, byte[] maschera) // applica la maschera all'indirizzo e restituisce il risultato
            {
                for (int i = 0; i < 4; i++)
                    indirizzo[i] = (byte)(indirizzo[i] & maschera[i]);
                return indirizzo;
            }
            // selezione di un valore importante
            public byte[] rete => Maschera(ipValue, mskValue);
            public byte[] primo => Sposta(rete, 1);
            public byte[] ultimo => Sposta(rete, utenti);
            public byte[] broadcast => Sposta(ultimo, 1);
            public byte[] prossimo => Sposta(ultimo, 2);
            // CONVERSIONE IN STRINGHE DI VARIO TIPO
            public string stringaIp
            {
                get => ipValue[0].ToString().PadLeft(3, '0') + "." + ipValue[1].ToString().PadLeft(3, '0') + "." + ipValue[2].ToString().PadLeft(3, '0') + "." + ipValue[3].ToString().PadLeft(3, '0');
                set => StringaToIp(value, ref ipValue); // qua è previsto un controllo sulle stringhe passate
            }
            public Rete setStringIp(string ipString) { this.stringaIp = ipString; return this; } // per concatenare in una sola riga tutte le istruzioni di impostazione
            override public string ToString() => "“" + Nome + "” " + stringaIp + "/" + barra + ((sottoRete == null) ? "." : "...");
            static public bool StringaToIp(string stringa, ref byte[] ipValue)
            {
                byte[] value = new byte[4];
                string[] str = stringa.Split(".");
                if (str.Length != 4) return false; // verifica che siano stati passati 4 valori separati dal punto...
                for (int i = 0; i < 4; i++)
                    if (!byte.TryParse(str[i], out value[i])) return false;// ...e che siano byte validi, ovvero interi tra 0 e 255
                ipValue = value;
                return true;
            }
            public string stringaMsk
            {
                get => mskValue[0].ToString().PadLeft(3, '0') + "." + mskValue[1].ToString().PadLeft(3, '0') + "." + mskValue[2].ToString().PadLeft(3, '0') + "." + mskValue[3].ToString().PadLeft(3, '0');
                set
                {// qua è previsto un controllo sulle stringhe passate
                    StringaToMsk(value, ref mskValue);
                    //string[] str = value.Split(".");
                    //for (int i = 0; i < 4; i++)
                    //    byte.TryParse(str[i], out MskValue[i]);
                }
            }
            public Rete setStringMsk(string msk) { this.stringaMsk = msk; return this; } // per concatenare in una sola riga tutte le istruzioni di impostazione
            static public bool StringaToMsk(string stringa, ref byte[] mskValue)
            {
                byte[] value = new byte[4], seq = { 0, 128, 192, 224, 240, 248, 252, 254, 255 };
                string[] str = stringa.Split(".");
                if (str.Length != 4) return false; // verifica che siano stati passati 4 valori separati dal punto...
                for (int i = 0; i < 4; i++)
                {
                    if (!byte.TryParse(str[i], out byte n)) return false; // ...che siano byte validi, ovvero interi tra 0 e 255
                    if (Array.IndexOf(seq, n) == -1) return false; // ...e che siano parte di una sequenza binaria prestabilita
                    else value[i] = n;
                }
                mskValue = value;
                return true;
            }


            static public string StringaToBinario(byte[] valore)
            {
                return Convert.ToString(valore[0], 2).PadLeft(8, '0')
                + "." + Convert.ToString(valore[1], 2).PadLeft(8, '0')
                 + "." + Convert.ToString(valore[2], 2).PadLeft(8, '0')
                  + "." + Convert.ToString(valore[3], 2).PadLeft(8, '0');
            }
            public string StringaIpBinario() { return StringaToBinario(ipValue); }
            public string StringaMskBinario() { return StringaToBinario(mskValue); }
            // STAMPA A CONSOLE DEI VALORI PRINCIPALI
            public void StampaIpQuartina() { Console.Write("Ip: " + stringaIp); }
            public void StampaIpBinario() { Console.Write("Ip: " + StringaIpBinario()); }

            public string Stringa(int filtro = 0, bool binario = false)
            {
                byte[] value = new byte[4] { 0, 0, 0, 0 };
                switch (filtro)
                {
                    case -2: value = ipValue; break;
                    case -1: value = mskValue; break;
                    case 0: value = rete; break;
                    case 1: value = primo; break;
                    case 2: value = ultimo; break;
                    case 3: value = broadcast; break;
                    case 4: value = prossimo; break;
                }
                if (binario) return Convert.ToString(value[0], 2).PadLeft(8, '0')
                             + "." + Convert.ToString(value[1], 2).PadLeft(8, '0')
                              + "." + Convert.ToString(value[2], 2).PadLeft(8, '0')
                               + "." + Convert.ToString(value[3], 2).PadLeft(8, '0');
                else return value[0].ToString().PadLeft(3, '0') + "."
                           + value[1].ToString().PadLeft(3, '0') + "."
                            + value[2].ToString().PadLeft(3, '0') + "."
                             + value[3].ToString().PadLeft(3, '0');
            }

            // -3: nome, -2: Indirizzo ip, -1: maschera, 0: rete, 1: primo host, 2: ultimo host, 3: broadcast, 4: prossimo
            public void StampaStringa(int filtro = 0, bool giustifica = false)
            { // Stampiamo il nome del valore e poi le sue varie versioni
                if (filtro == -3) { Console.Write("{0}Nome: “", (giustifica) ? "        " : ""); Colora(nome, ConsoleColor.DarkRed); Console.Write("”"); return; }
                string[] lista = { "Indirizzo ip", "Maschera", "Rete", "Primo", "Ultimo", "Broadcast", "Prossimo" };
                if (giustifica)
                {
                    Console.Write("{0,12}: {1}", lista[filtro + 2], Stringa(filtro));
                    Colora(" - " + Stringa(filtro, binario: true) + ((filtro == -1) ? " /" + barra + string.Format(" ({0:#,##0})", utenti) : ""));
                }
                else
                {
                    Console.Write("{0}: {1} - ", lista[filtro + 2], Stringa(filtro));
                    Colora(Stringa(filtro, binario: true) + ((filtro == -1) ? " /" + barra + string.Format(" ({0:#,##0})", utenti) : ""));
                }
            }
            static public void Colora(string stringa, ConsoleColor colore = ConsoleColor.DarkGray)
            {
                Console.ForegroundColor = colore;
                Console.Write(stringa);
                Console.ResetColor();
            }
            void StampaInRiga(int pan = 0)
            {
                Colora(string.Format("{0," + pan + "} ", "“" + Nome + "”"), ConsoleColor.DarkGreen);
                Colora(stringaIp, ConsoleColor.White);
                Colora(string.Format(" {0} /{1,2} ({2,6:#,##0})", stringaMsk, barra, utenti), ConsoleColor.DarkYellow);
                Colora(string.Format("  fst: {0}", Stringa(1)), ConsoleColor.DarkCyan);
                Colora(string.Format("  lst: {0}", Stringa(2)), ConsoleColor.DarkBlue);
                Colora(string.Format("  bdc: {0}", Stringa(3)), ConsoleColor.DarkMagenta);
                Colora(string.Format("  nxt: {0}", Stringa(4)), ConsoleColor.Gray);
                Console.WriteLine();
            }
            public void Stampa(bool tutto = true)
            {
                StampaStringa(-3, true); Console.WriteLine(); // nome
                StampaStringa(-2, true); Console.WriteLine(); // ip
                StampaStringa(-1, true); Console.WriteLine(); // maschera
                if (tutto) { StampaStringa(0, true); Console.WriteLine(); } // rete
                if (tutto) { StampaStringa(1, true); Console.WriteLine(); } // primo
                if (tutto) { StampaStringa(2, true); Console.WriteLine(); } // ultimo
                StampaStringa(3, true); Console.WriteLine(); // broadcast
                if (tutto) { StampaStringa(4, true); Console.WriteLine(); } // prossimo
            }
            public void StampaRete()
            { // dovendo stampare tutti i nomi delle sottoreti...
                int pan = 0; // ...trova quello più lungo...
                for (int i = 0; i < sottoRete.Length; i++)
                    pan = Math.Max(pan, 2 + sottoRete[i].Nome.Length);
                this.Stampa();
                for (int i = 0; i < sottoRete.Length; i++)
                    sottoRete[i].StampaInRiga(pan); // ...ela passa alla funzione che li deve stampare
            }
            // IMPLEMENTAZIONE DELLE INTERFACCE

            public bool Equals(Rete other)
            {
                if (other == null) return false; // se il referente è nullo, non possono essere uguali
                return this.ipValue == other.ipValue && this.mskValue == other.mskValue;
                //throw new NotImplementedException();
            }
            public override int GetHashCode()
            {
                int n = this.barra;
                for (int i = 0; i < nome.Length; i++)
                    n += nome[i] * (int)Math.Pow(2, i);
                return n;
            }
            public int CompareTo(object obj)
            {
                var other = obj as Rete;
                if (other == null) return 1;
                //return this.utenti.CompareTo(other.utenti);
                /*if (this.barra == other.barra) return 0;
                else if (this.barra > other.barra) return -1;
                else return 1;*/
                //return (this.barra == other.barra) ? 0 : (this.barra > other.barra) ? -1 : 1;
                return this.CompareTo(other);
            }
            public override bool Equals(Object obj)
            {
                if (obj == null || !(obj is Rete))
                    return false;
                else
                    return this.ipValue == ((Rete)obj).ipValue && this.mskValue == ((Rete)obj).mskValue;
            }
            public int CompareTo(Rete other)
            {
                if (other == null) return 1; // se il referente è nullo, questo rislta maggiore
                if (this.MskValue == other.MskValue) return 0;
                for (int i = 0; i < 4; i++)
                    if (this.MskValue[i] < other.MskValue[i]) return 1;
                    else if (this.MskValue[i] > other.MskValue[i]) return -1;
                return 0; // non capita perché c'é gia il controllo all'inizio, ma il compilatore lo pretende
                //throw new NotImplementedException();
            }

            // OVERRIDE DEGLI OPERATORI BOOLEANI
            public static Rete operator +(Rete sinistro, int valore)
            {
                return sinistro;
            }
            //public static bool operator ==(Rete sinistro, Rete destro) => sinistro.CompareTo(destro) == 0;  // Uguale
            //public static bool operator !=(Rete sinistro, Rete destro) => sinistro.CompareTo(destro) != 0;  // Diverso
            public static bool operator >(Rete sinistro, Rete destro) => sinistro.CompareTo(destro) == +1;  // Maggiore
            public static bool operator <(Rete sinistro, Rete destro) => sinistro.CompareTo(destro) == -1;  // Minore
            public static bool operator >=(Rete sinistro, Rete destro) => sinistro.CompareTo(destro) >= 0;  // Maggiore o uguale
            public static bool operator <=(Rete sinistro, Rete destro) => sinistro.CompareTo(destro) <= 0;  // Minore o uguale
        }
    }
}
