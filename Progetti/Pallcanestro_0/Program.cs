using System;

namespace Pallcanestro_0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Squadra sA = new Squadra('A');
            Squadra sB = new Squadra('B');
            sA.stampa();
            sB.stampa();
            /*
            var gA = new[]{
                new Giocatore(1),
                new Giocatore(2),
                new Giocatore(3)
            };
            for (int i = 0; i < 3; ++i)
            {
                gA[i].stampa();
                Console.Write(" ");
                //gA[i].stampaDescrizione();
            }
            Console.WriteLine();
            var gB = new[]{
                new Giocatore(1,0,'B'),
                new Giocatore(2,0,'B'),
                new Giocatore(3,0,'B')
            };
            for (int i = 0; i < 3; ++i)
            {
                gB[i].stampa();
                Console.Write(" ");
            }
            
            for (int i = 0; i < 20; i++)
                Console.Write("{0} ", 1 + Globale.dado(4));
            Console.WriteLine();
            for (int i = 0; i < 31; ++i)
                Console.Write("{0}", (i % 3 == 0) ? "  +" : "  -");
            */
            Partita partita = new Partita();
            partita.stampaCampo();

            XY canestro = new XY(4, 0);
            XY coord1 = new XY(2, 2);
            XY coord2 = new XY(0, 0);
            Console.WriteLine(coord1.testo() + "-" + coord2.testo() + "=" + (coord1 - coord2));
            Console.WriteLine(canestro.testo() + "-" + coord1.testo() + "=" + (canestro - coord1));
            Console.WriteLine(canestro.testo() + "-" + coord2.testo() + "=" + (canestro - coord2));
            
        }



    }






    public static class Globale
    {
        public static int dado(int ultimo) { Random random = new Random(); return (int)random.Next(ultimo + 1); }
    }








    public class XY
    {
        public int x, y;
        public XY() { this.x = 0; this.y = 0; }
        public XY(int x, int y) { this.x = x; this.y = y; }
        public int this[int indice]
        {
            get { return (indice == 0) ? x : y; }
            set { if (indice == 0) x = value; else y = value; }
        }
        public static XY operator +(XY destro, int[] sinistro)
        {
            if (sinistro == null) throw new ArgumentNullException(nameof(sinistro));
            if (sinistro.Length != 2) throw new ArgumentOutOfRangeException(nameof(sinistro));

            XY risultato = new XY();
            risultato.x = destro.x + sinistro[0];
            risultato.y = destro.y + sinistro[1];
            return risultato;
        }
        public static int operator -(XY destro, XY sinistro)
        {
            int x = Math.Abs(destro.x - sinistro.x);
            int y = Math.Abs(destro.y - sinistro.y);
            return (int)Math.Sqrt(x * x + y * y);
        }
        public string testo() { return "[" + x + "," + y + "]"; }
        public void stampa() { Console.Write("[{0},{1}]", x, y); }
    }





    public class Partita
    {
        string[,] campo = new string[9, 14];
        public bool area2Punti(int x, int y, char squadra = ' ')
        {
            int yy = 1 + Math.Abs(y - 4);
            int xx = 1 + x;
            if ((int)(Math.Sqrt(xx * xx + yy * yy)) < 5 && squadra != 'B') return true;
            xx = 14 - x;
            if ((int)(Math.Sqrt(xx * xx + yy * yy)) < 5 && squadra != 'A') return true;
            return false;
        }
        public Partita()
        {
            for (int i = 0; i < 9; i++)
                for (int j = 0; j < 14; j++)
                    campo[i, j] = (area2Punti(j, i)) ? " . " : (j < 7) ? " a " : " b ";
            campo[4, 0] = " :0"; // canestro A
            //campo[4, 4] = " + "; // fallo, tiro da 1 punto A
            campo[4, 13] = "0: ";  // canestro B
            //   campo[4, 9] = " + "; // fallo, tiro da 1 punto B
        }
        public void stampaCampo()
        {
            Console.WriteLine();

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 14; j++)
                {
                    Console.Write(campo[i, j]);
                }
                Console.WriteLine();
            }
        }
    }





    public class Squadra
    {

        char squadra;
        Giocatore[] giocatore;
        public Squadra(char sq, int numGiocatori = 3)
        {
            squadra = (sq == 'A' || sq == 'a') ? 'A' : 'B';
            giocatore = new Giocatore[numGiocatori];
            for (int i = 0; i < numGiocatori; i++)
                giocatore[i] = new Giocatore(i + 1, 0, squadra);
        }
        public Giocatore this[int num]
        {
            get { return giocatore[num - 1]; }
            set { giocatore[num - 1] = value; }
        }
        public int palla        {get{
            for(int i=0;i<giocatore.Length;i++)
                if (giocatore[i].palla) return i+1;
            return 0;
        }}
        public void lasciaPalla(int num = 0)
        {
            giocatore[num - 1].palla = false;
            Console.WriteLine("Il giocatore {0} della squadra {1} ha perso la palla.", num, squadra);
        }
        public void prendiPalla(int num)
        {
            giocatore[num - 1].palla = true;
            Console.WriteLine("Il giocatore {0} della squadra {1} ha guadagnato palla.", num, squadra);
        }
        public void stampa()
        {
            Console.Write("Squadra {0}: ", squadra);
            foreach (var g in giocatore)
                Console.Write("<{0}{1}{2}> ", g.squadra, g.numero, g.iTipo);
            Console.Write("\n", squadra);
        }
    }




    public class Giocatore
    {
        public int numero;
        public int[] XY = new int[2] { 0, 0 };
        public bool palla = false;
        public char squadra;
        public int stazza;// = Globale.dado(4);
        public int Stazza
        {
            get => stazza;
            set { stazza = Math.Max(1, Math.Min(5, value)); }
        }

        public void Cresci(int valore = 1) { Stazza += Math.Max(-4, Math.Min(4, valore)); }

        public Giocatore(int num, int st = 0, char sq = 'A')
        {
            numero = num;
            squadra = (sq == 'A' || sq == 'a') ? 'A' : 'B';
            Stazza = (st == 0) ? 1 + Globale.dado(4) : st;
        }
        public char iTipo { get { return "pmnga"[Stazza - 1]; } }
        string Tipo
        {
            get
            {
                string[] tipo = { "piccolo", "magro", "normale", "grosso", "altissimo" };
                return tipo[Stazza - 1];
            }
        }

        public void stampa(bool lunga = false, bool aCapo = false)
        {
            if (lunga) Console.Write("Sono il giocatore numero {0} della squadra {1} e sono {2}.{3}", numero, squadra, Tipo, (aCapo) ? "\n" : "");
            else Console.Write("[{0}{1}.{2}]{3}", squadra, numero, iTipo, (aCapo) ? "\n" : "");
        }
    }
}
