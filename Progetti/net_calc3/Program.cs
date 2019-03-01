using System;

namespace net_calc3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            //*
            byte[] ipvalue = { 192, 168, 95, 31 };
            byte[] mskvalue = impostaMaschera(23);//{ 255, 255, 224, 0 };
            Stampa(ipvalue);
            Stampa(mskvalue);
            //for (int i = 0; i < 10; i++)
            //  Stampa(ipvalue = Sposta(ipvalue, 128));

            //Console.WriteLine("\n" + Barra(ipvalue));
            return;
            //*/
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
            */
            // ESERCIZIO 2 : SUB QUALSIASI
            // STAMPA DI TUTTI MEMBRI DELLA SOTTORETE
            // Calcolare il numero di indirizzi possibili... (host disponibili=indirizzi-2)
            int posti = 256 * 256 * (255 - quartinaMSK[1]) + 256 * (255 - quartinaMSK[2]) + (255 - quartinaMSK[3]);
            // Ricavare la barra dalla maschera
            int barra = 32 - (int)Math.Round(Math.Log(posti, 2));
            // ...e poi ciclare fino a cosumarli tutti
            for (int i = 0; i <= posti; i++)
            {
                Console.WriteLine("{0}.{1}.{2}.{3}",
                            quartinaIP[0],
                                quartinaIP[1] + (i / 256 * 256) % 256,
                                    quartinaIP[2] + (i / 256) % 256,
                                        i % 256);
            }
            // ESERCIZIO 3: RICAVARE rete, inizio, fine, broadcast, prima rete successiva
            Console.WriteLine("/" + barra);
        }

        static public byte[] impostaMaschera(byte value)
        {
            //Console.WriteLine(value);
            byte[] IpValue = { 0, 0, 0, 0 };
            byte[] predefinito = { 128, 196, 225, 240, 248, 252, 254, 255 };
            for (int i = 0; i < 4; i++)
            {
                //Console.Write("{0}:{1}<{2}[{3}] * ", i, 8 * i, 8 * i + 7, value - 8 * i);
                //if (value > 8 * i + 7) IpValue[i] = 255;
                //else if (value < 8 * i) IpValue[i] = 0;
                //else IpValue[i] = predefinito[value - 8 * i];
                IpValue[i] = (byte)((value > 8 * i + 7) ? 255 : ((value < 8 * i + 1)) ? 0 : predefinito[value - 8 * i - 1]);
            }
            Console.WriteLine();
            return IpValue;
        }

        static public void Stampa(byte[] indirizzo)
        {
            for (int i = 0; i < 4; i++)
                Console.Write("{1}{0}", (i == 3) ? "\n" : ".", indirizzo[i]);
        }






        public class Rete
        {
            string nome = "Rete Senza Nome";
            byte[] ipValue = { 192, 168, 0, 0 };
            byte[] mskValue = { 255, 255, 255, 0 };
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
                this[1] = q1; this[2] = q2; this[3] = q3; this[4] = q4;
                this.barra = barra;
            }
            public Rete(string nome, byte q1, byte q2, byte q3, byte q4, uint utenti)
            {
                this.Nome = nome;
                this[1] = q1; this[2] = q2; this[3] = q3; this[4] = q4;
                this.utenti = utenti;
            }
            public Rete(string nome, byte[] quart, byte[] maschera)
            {
                this.Nome = nome;
                ipValue = quart;
                mskValue = maschera;
            }
            public Rete(string nome, byte[] quart, byte barra)
            {
                this.Nome = nome;
                ipValue = quart;
                this.barra = barra;
            }
            public Rete(string nome, byte[] quart, uint utenti)
            {
                this.Nome = nome;
                ipValue = quart;
                this.utenti = utenti;
            }
            ~Rete() // Non so ancora come, ma forse potrebbe servire anche un distruttore
            {
                Console.WriteLine("La rete '{0}' è appena stata eliminata.", this.Nome);
            }
            static public byte quantoGrande(uint utenti) // In che barra deve essere la maschera per gestire un certo numero di utenti
            {
                for (byte i = 2; i < 32; i++) // proviamo i CIDR partendo da quello con meno utenti
                    if (Math.Pow(2, i) - 2 >= utenti) return (byte)(32 - i); // il primo che offre abbastanza utenze è quello buono
                return 0; // altrimenti qualcosa non va
            }
            public byte barra
            { // Legge ed imposta la maschera passando il famigerato CIDR
                get
                {
                    for (byte q = 0; q < 4; q++) // cicliamo tra le quartine
                        for (byte i = 0; i < 8; i++) // cicliamo tra i bit del quartino
                            if ((IpValue[3 - q] / (Math.Pow(2, i))) % 2 == 1) return (byte)(32 - 8 * q - i); // cerchiamo il primo bit a 1, li si ferma la barra
                    return 0; // non dovrebbe capitare, ma nel caso si esca dal ciclo senza trovare un bit a 1
                }
                set
                {
                    byte[] predefinito = { 128, 196, 225, 240, 248, 252, 254 }; // non serve calcolare ogni volta il valore del byte, tanto le opzioni sone poche
                    for (int i = 0; i < 4; i++) // si valuta byte per byte se il valore passato è entro i limiti di quel quatino
                        IpValue[i] = (byte)((value > 8 * i + 7) ? 255 : ((value < 8 * i + 1)) ? 0 : predefinito[value - 8 * i - 1]); // e gli si assegna il valore corrispondente
                    // Con gli if..else il codice è più leggibile, ma una volta verificato si può tranquillamente usare l'operatore ternario annidandone uno nell'altro
                    //Console.Write("{0}:{1}<{2}[{3}] * ", i, 8 * i, 8 * i + 7, value - 8 * i);
                    //if (value > 8 * i + 7) IpValue[i] = 255;
                    //else if (value < 8 * i) IpValue[i] = 0;
                    //else IpValue[i] = predefinito[value - 8 * i];
                }
            }
            public uint utenti
            { // Conta il numero massimo di host ed imposta la maschera di conseguenza
                get => (uint)Math.Pow(2, 32 - barra) - 2;
                set => barra = quantoGrande(value);
            }
            // Portando fuori le funzioni di get e set si possono impostare delle limitazioni o delle verifiche sui dati
            public string Nome { get => nome; set => nome = value; }
            public byte[] IpValue { get => ipValue; set => ipValue = value; }
            public byte[] MskValue { get => mskValue; set => mskValue = value; }
            // in generale indicizzare una classe è molto fico
            public byte this[int indice] // si può accedere alle quartine tramite un indice
            { // da 1 a 4 è l'ip, da 5 a 8 la maschera, partiamo dall'indice 1 per rendere l'approccio più amichevole all'utente
                get { return (--indice < 4) ? IpValue[indice] : MskValue[indice - 4]; } // da 1 a 4 indirizzo ip e da 5 a 8 maschera
                set { if (--indice < 4) IpValue[indice] = value; else MskValue[indice - 4] = value; }
            } // comandi sulla stessa riga per rendere il codice più compatto, comunque in questo caso si legge bene lo stesso
            // Una funzione per spostare il valore di tutta una quartina di un tot, in avanti o in dietro, può sempre far comodo
            // Naturalmente tutte le funzioni 'utility' vanno definite come static perché indipendenti dalla singola istanza
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
            public byte[] gateway => Sposta(ultimo, 1);
            public byte[] prossimo => Sposta(ultimo, 2);
            // ANCORA CONVERSIONE DI DATI IN STRINGHE NEI VARI FORMATI
            public string stringaIp
            {
                get => ipValue[0] + "." + ipValue[1] + "." + ipValue[2] + "." + ipValue[3];
                set
                {// qua andrebbe previsto un controllo sulle stringhe passate
                    string[] str = value.Split(".");
                    for (int i = 0; i < 4; i++)
                        byte.TryParse(str[i], out IpValue[i]);
                }
            }
            public string stringaMsk
            {
                get => mskValue[0] + "." + mskValue[1] + "." + mskValue[2] + "." + mskValue[3];
                set
                {// qua andrebbe previsto un controllo sulle stringhe passate
                    string[] str = value.Split(".");
                    for (int i = 0; i < 4; i++)
                        byte.TryParse(str[i], out MskValue[i]);
                }
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

            public string stringaQuartina(int filtro = 0)
            {
                byte[] value = new byte[4] { 0, 0, 0, 0 };
                switch (filtro)
                {
                    case -2: value = mskValue; break;
                    case -1: value = ipValue; break;
                    case 0: value = rete; break;
                    case 1: value = primo; break;
                    case 2: value = ultimo; break;
                    case 3: value = gateway; break;
                    case 4: value = prossimo; break;
                }
                return value[0] + "." + value[1] + "." + value[2] + "." + value[3];
            }
            public string stringaBinario(int filtro = 0)
            {
                byte[] value = new byte[4] { 0, 0, 0, 0 };
                switch (filtro)
                {
                    case -2: value = mskValue; break;
                    case -1: value = ipValue; break;
                    case 0: value = rete; break;
                    case 1: value = primo; break;
                    case 2: value = ultimo; break;
                    case 3: value = gateway; break;
                    case 4: value = prossimo; break;
                }
                return Convert.ToString(value[0], 2).PadLeft(8, '0')
                + "." + Convert.ToString(value[1], 2).PadLeft(8, '0')
                 + "." + Convert.ToString(value[2], 2).PadLeft(8, '0')
                  + "." + Convert.ToString(value[3], 2).PadLeft(8, '0');
            }
            public void StampaStringa(int filtro = 0, bool giustifica = false)
            { // Stampiamo il nome del valore e poi le sue varie versioni
                if (filtro == -2) Console.Write("{0}Nome: {1}", (giustifica) ? "       " : "", nome);
                string[] lista = { "Maschera", "Indirizzo ip", "Rete", "Primo", "Ultimo", "Gateway", "Prossimo" };
                if (!giustifica) Console.Write("{0}: {1} - {2}{3}", lista[filtro + 2], stringaQuartina(filtro), stringaBinario(filtro), (filtro == -2) ? " /" + barra + "(" + utenti + ")" : "");
                else Console.Write("{0,12}: {1} - {2}{3}", lista[filtro + 2], stringaQuartina(filtro), stringaBinario(filtro), (filtro == -2) ? " /" + barra + "(" + utenti + ")" : "");
            }

            public void Stampa()
            {
                // QUESTA STAMPA TUTTO IN SEQUENZA
            }

        }
    }
}
