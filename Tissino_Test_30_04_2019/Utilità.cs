using System;
using System.Collections.Generic;
/*
DISTRIBUTORE DI CARTE DA GIOCO
l’applicazione ha a disposizione un insieme di carte da gioco;
ogni carta è definita da tre parametri (valore, seme, dorso);
il numero di carte effettivamente presenti può variare
(ci può essere un mazzo da 40, un mazzo da 52, due mazzi da 52, ecc.);
l’applicazione deve essere in grado di mescolare le carte e distribuirle a n giocatori presenti
(eventualmente tenendo traccia di quali sono le carte in mano a ciascun giocatore)
e con la possibilità di lasciarne alcune nel mazzo
*/

namespace Test_30_04_2019
{
    enum TipoCarte { Briscola, Pocker, ScalaQuaranta };
    class Mazzo
    {
        public List<Carta> carte = new List<Carta>(); // le carte in mano a ciascun giocatore

        public Mazzo(TipoCarte tipo = TipoCarte.Briscola)
        {
            switch (tipo)
            {
                case TipoCarte.Pocker:
                    Console.WriteLine("Pocker");
                    NuovoMazzo("c,q,f,p", "A,6,7,8,9,10,Q,J,K"); //"♥,♦,♣,♠"
                    break;
                case TipoCarte.ScalaQuaranta:
                    Console.WriteLine("Scala quaranta");
                    NuovoMazzo("c,q,f,p", "A,2,3,4,5,6,7,8,9,10,Q,J,K,jolly");
                    break;
                default: // TipoCarte.Briscola o non gestito
                    Console.WriteLine("Briscola by Default");
                    NuovoMazzo("d,c,b,s", "A,2,3,4,5,6,7,F,C,R");
                    break;
            }
        }
        void NuovoMazzo(string semi, string valori, int numColori = 1, bool jolly = false)
        {
            List<Carta> nuovoMazzo = new List<Carta>(); // il mazzo da generare
            var aSemi = semi.Split(","); // si poteva usare la semplice stringa per l'iterazione, ma così è più duttile
            var aValori = valori.Split(","); // qui era necessario per la lungezza dei 'nomi' (...9 10...)
            for (int colore = 0; colore < numColori; colore++)
            {
                foreach (var seme in aSemi)
                {
                    foreach (var valore in aValori)
                    {
                        nuovoMazzo.Add(new Carta(valore, seme, (numColori == 1) ? "" : ((colore == 0) ? "rosso" : "blu")));
                    }
                }
            }
            carte = nuovoMazzo;
            MescolaMazzo();
        }
        void MescolaMazzo()
        {
            List<Carta> mescolate = new List<Carta>(); // il mazzo da mescolare
            var caso = new Random();
            while (carte.Count > 0)
            {
                // scegliamo una carta a caso
                int qualeCarta = caso.Next(carte.Count);
                // aggiungiamo la carta al nuovo mazzo
                mescolate.Add(carte[qualeCarta]);
                // togliamola dal vecchio
                carte.RemoveAt(qualeCarta);
            }
            carte = mescolate; // aggiorniamo il mazzo svuotato
        }
        public override string ToString()
        {
            string risultato = "";
            foreach (var carta in carte)
                risultato += carta + " ";
            return risultato;
        }
        public void Stampa(bool aCapo = false)
        {
            Console.Write("Mazzo({0}): {1}", carte.Count, (aCapo ? "\n" : " "));
            foreach (var carta in carte)
                Console.Write(carta + (aCapo ? "\n" : " "));
            Console.WriteLine();
        }


    }
    class Carta
    {
        string valore; // valore della carta (Asso 2 3 4... ...Fante Cavallo Re, oppure ...9 10 Jack Donna Re Jolly)
        string colore; // il seme della carta
        string dorso; // il dorso blu o rosso

        public Carta(string valore, string colore, string coloreDorso)
        {
            this.valore = valore;
            this.colore = colore;
            this.dorso = coloreDorso;
        }
        public override string ToString() { return valore + colore + dorso; }
        public void Stampa(bool aCapo = false) { Console.Write(ToString() + (aCapo ? "\n" : "")); }

    }
    class Giocatore
    {
        static int _giocatori = 0; // contatore dei giocatori, tiene traccia del numero di giocatori...
        static int giocatori { get => _giocatori++; } // ...ed è utile a fornire un nome generico
        string nome = "Giocatore " + giocatori;

        public List<Carta> mano = new List<Carta>(); // le carte in mano a ciascun giocatore

        public void Dai(Carta carta) // carta aggiunta alla mano del giocatore
        {
            mano.Add(carta);
        }
        public void Gioca(Carta carta) // carta tolta dalla mano del giocatore
        {
            mano.Remove(carta);
        }
        public override string ToString()
        {
            string risultato = nome;
            foreach (var carta in mano)
                risultato += " " + carta;
            return risultato;
        }
        public void Stampa() { Console.Write(ToString()); }
    }
    class Gioco
    {
        TipoCarte gioco;
        Mazzo m;
        public Giocatore[] giocatori;
        public Gioco(TipoCarte gioco = TipoCarte.Briscola, int numGiocatori = 4)
        {
            this.gioco = gioco;
            m = new Mazzo(gioco);
            numGiocatori = Math.Max(1, numGiocatori);
            giocatori = new Giocatore[numGiocatori];
            for (int i = 0; i < numGiocatori; i++)
            {
                giocatori[i] = new Giocatore();
            }
        }
        // distribuiamo 5 carte a testa
        void Distribuisci(int numCarte = 5)
        {
            var caso = new Random();
            foreach (var giocatore in giocatori)
            {
                for (int i = 0; i < numCarte; i++)
                {
                    // scegliamo una carta a caso
                    int qualeCarta = caso.Next(m.carte.Count);
                    // aggiungiamo la carta al nuovo mazzo
                    giocatore.Dai(m.carte[qualeCarta]);
                    // togliamola dal vecchio
                    m.carte.RemoveAt(qualeCarta);
                }
            }
        }
    }
}