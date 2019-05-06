using System;

namespace Cambia_Base
{
    class Forza4
    {
        char[] quadro;
        int righe, colonne;
        bool primoGiocatore = true;
        public Forza4(int righe = 6, int colonne = 7)
        {
            this.righe = Math.Min(20, Math.Max(4, righe));
            this.colonne = Math.Min(23, Math.Max(4, colonne));
            quadro = new char[righe * colonne];
            Resetta();
        }
        public void Resetta() { Riempi(); }
        public void Riempi(char valore = ' ')
        {
            for (int i = 0; i < quadro.Length; i++)
                quadro[i] = valore;
        }
        public override string ToString()
        {
            string risultato = "";
            for (int c = 0; c < colonne; c++)
                risultato += "   " + (1 + c);
            risultato += "\n\n";
            for (int r = 0; r < righe; r++)
            {
                for (int c = 0; c < colonne; c++)
                {
                    risultato += " | " + quadro[righe * c + r];
                }
                risultato += " |\n";
            }
            risultato += " ";
            for (int c = 0; c < colonne; c++)
                risultato += "+---";
            risultato += "+\n\n";
            return risultato;
        }
        public void Stampa() { Console.Clear(); Console.WriteLine(ToString()); }
        public bool Gioca(int c)
        {
            for (int r = righe - 1; r >= 0; r--) // iterazione per le righe della colonna scelta, partendo dal fondo
                if (quadro[righe * c + r] == ' ') // giocata valida
                {
                    quadro[righe * c + r] = (primoGiocatore) ? 'o' : 'x'; // assegnata posizione
                    VerificaVittoria();
                    primoGiocatore = !primoGiocatore; // aggiornamento giocatore
                    Stampa(); // rigenerazione del quadro di gioco
                    return true; // uscita positiva
                }
            Console.Write("\a"); // messaggio di errore
            return false; // uscita negativa
        }
        public void Chiedi()
        {
            Console.Write("Tocca al giocatore {0} muovere (scegli un numero da 1 a {1}): ", primoGiocatore ? 'O' : 'X', colonne);
            string scelta = Console.ReadLine();
            int col = 0;
            while (col < 1 || col > colonne)
            {
                if (scelta == "x") return;
                int.TryParse(scelta, out col);
                if (col < 1 || col > colonne)
                {
                    Console.Write("Valore non valido! Riprova: ");
                    scelta = Console.ReadLine();
                }
            }
            if (!Gioca(col-1)) Console.WriteLine("La colonna è piena!");
            Chiedi();
        }
        void VerificaVittoria()
        {
            if (ControllaOrizzontale() || ControllaVerticale() || ControllaDiagonale()) // Il giocatore attivo ha vinto
            {
                Stampa();
                Console.WriteLine("Il giocatore {0} ha vinto!!!\n\n", primoGiocatore ? 'O' : 'X');
                System.Environment.Exit(1);
            }
        }
        bool ControllaOrizzontale()
        {
            if (quadro[0] == 'o' || quadro[0] == 'x') return true;
            return false;
        }
        bool ControllaVerticale()
        {
            return false;
        }
        bool ControllaDiagonale()
        {
            return false;
        }
    }
}