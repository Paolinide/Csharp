using System;

namespace net_calc3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            byte[] ipvalue = { 255, 240, 0, 0 };
            for (int i = 0; i < 4; i++)
            {
                //Console.WriteLine("/{0}: {1}^2-2 = {2}", i, (32 - i), Barra(i));
                Console.Write("{0}{1}", (i == 0) ? "" : ".", ipvalue[i]);
            }
            Console.WriteLine("\n" + Barra(ipvalue));
            return;
            // ACQUISIZIONE INDIRIZZO IP
            int[] quartinaIP = { 192, 168, 30, 4 };
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

        static public byte[] Barra(byte value)
        {
            byte[] IpValue = { 240, 240, 240, 240 };
            /*for (byte q = 0; q < 4; q++)
                for (byte i = 0; i < 8; i++)
                    if ((ipvalue[3 - q] / (Math.Pow(2, i))) % 2 == 1) return (byte)(32 - 8 * q - i);
            return 0;*/
            byte[] predefinito = { 128, 196, 225, 240, 248, 252, 254, 255 };
            // primo quarteto da inistra (barra bassa molti utenti)
            IpValue[0] = (value > 7) ? (byte)255 : predefinito[value];
            IpValue[1] = (value > 7) ? (byte)255 : predefinito[value];
            IpValue[2] = (value > 7) ? (byte)255 : predefinito[value];
            // primo quarteto da destra (meno utenti barra alta)
            IpValue[3] = (value > 7) ? (byte)255 : predefinito[value];
            return IpValue;
        }





        public class Rete
        {
            string nome = "Rete Senza Nome";
            byte[] ipValue = { 192, 168, 0, 0 };
            byte[] mskValue = { 255, 255, 255, 0 };
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
            static public byte quantoGrande(uint utenti) // In che barra deve essere la maschera per il numero di utenti
            {
                for (byte i = 2; i < 32; i++)
                    if (Math.Pow(2, i) - 2 >= utenti) return (byte)(32 - i);
                return 0;
            }
            public byte barra
            { // Legge ed imposta la maschera passando il CIDR
                get
                {
                    for (byte q = 0; q < 4; q++)
                        for (byte i = 0; i < 8; i++)
                            if ((IpValue[3 - q] / (Math.Pow(2, i))) % 2 == 1) return (byte)(32 - 8 * q - i);
                    return 0;
                }
                set
                {
                    byte[] predefinito = { 128, 196, 225, 240, 248, 252, 254, 255 };
                    IpValue[0] = (value > 7) ? (byte)255 : predefinito[value];
                }
            }
            public uint utenti
            { // Conta il numero massimo di host ed imposta la maschera di conseguenza
                get => (uint)Math.Pow(2, 32 - barra) - 2;
                set => barra = quantoGrande(value);
            }

            public string Nome { get => nome; set => nome = value; }
            public byte[] IpValue { get => ipValue; set => ipValue = value; }
            public byte[] MskValue { get => mskValue; set => mskValue = value; }

            public byte this[int indice]
            { // si può accedere alle quartine tramite un indice
                get { return 69; } // da 1 a 4 indirizzo ip e da 5 a 8 maschera
                set { }
            }

            static public byte[] Sposta(byte[] indirizzo, uint valore) // somma un certo avlore ad una quartina e ne restituisce il risultato
            {
                byte[] risultato = new byte[4];
                return risultato;
            }

            static public byte[] Maschera(byte[] indirizzo, byte[] maschera) // applica la maschera all'indirizzo e restituisce il risultato
            {
                byte[] risultato = new byte[4];
                return risultato;
            }
            public byte[] rete => Maschera(ipValue, mskValue);
            public byte[] primo => Sposta(rete, 1);
            public byte[] ultimo => Sposta(rete, utenti);
            public byte[] gateway => Sposta(ultimo, 1);
            public byte[] prossimo => Sposta(ultimo, 2);

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
            public string stringaIpBinario()
            {
                return Convert.ToString(ipValue[0], 2).PadLeft(8, '0')
                + "." + Convert.ToString(ipValue[1], 2).PadLeft(8, '0')
                 + "." + Convert.ToString(ipValue[2], 2).PadLeft(8, '0')
                  + "." + Convert.ToString(ipValue[3], 2).PadLeft(8, '0');
            }
            public void StampaIpQuartina() { Console.Write("Ip: " + stringaIp); }
            public void StampaIpBinario() { Console.Write("Ip: " + stringaIpBinario()); }

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
