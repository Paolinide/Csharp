using System;
using System.Collections;
using System.Collections.Generic;

namespace Menù
{
    class ElementoDiMenu // classe elemento del menu (con un nome da stampare ed una funzione da eseguire)
    {
        public string nome; // testo da stampare in console che descrive il comando
        public delegate void Azione(); // tipo della funzione da eseguire (una funzione senza parametri che non restituisce niente)
        public Azione Esegui; // la funzione da eseguire (resa pubblica per poerla richiamare dal Menu)
        public ElementoDiMenu(string nome, Azione azione) // costruttore dell'Elemento
        {
            this.nome = nome;
            this.Esegui = azione;
        }
    }

    class Menu // classe menu (lista di elementi con un nome da stampare ed una funzione da eseguire)
    {
        private string nome; //  nome del menu
        private List<ElementoDiMenu> lista = new List<ElementoDiMenu>(); // lista degli Elementi (List può essere acceduta con la notazione lista[n])
        public Menu(string nome) => this.nome = nome; // il costruttore richiede solo il nome del Menu
        public void Aggiundi(ElementoDiMenu elemento) => lista.Add(elemento); // per aggiungere una nuova voce
        public void Esegui(int i) => lista[i - 1].Esegui(); // per eseguire l'ennesimo comando (da 1 a n anziché da 0 a n-1)
        public void Stampa() => Console.WriteLine(ToString()); // stampa l'elenco delle voci nella console
        public override string ToString() // restituisce l'elenco delle voci
        {
            string risultato = " * * * " + nome + " * * *"; // iniziamo col nome del menu evidenziato
            int n = 0; // contatore delle voci
            foreach (var elemento in lista) // iterzaione nella lista
                risultato += "\n" + ++n + ". " + elemento.nome; // aggiungiamo una nuova riga, l'indice e infine il nome della voce
            return risultato; // restituiamo la stringa
        }
        public void Chiedi() // così viene direttamente chiesto al Menu quale voce selezionare
        {
            Stampa(); // stampiamo per bene il Menu
            int scelta = 0; // inizializziamo la voce scelta
            while (scelta < 1 || scelta > lista.Count) // poi entriamo in un ciclo che continua a chiedere finché la risposta non è corretta
            {
                try
                {
                    Console.Write("Scegli una voce dal menu (0 per annullare): "); // poi chiediamo quale voce sciegliere
                    scelta = int.Parse(Console.ReadLine()); // proviamo a vedere se il carattere digitato è un numero
                    if (scelta == 0) // se si sceglie di annullare
                    {
                        Console.WriteLine("Sei uscito dal menu."); // viene avvisato l'utente
                        return; // e poi si esce dal menu
                    }
                    // se si, controlliamo che sia entro i parametri
                    if (scelta < 1 || scelta > lista.Count) Console.WriteLine("Devi digitare un numero tra 1 e " + lista.Count + ".");
                    // se no, avvisiamo dell'errore
                }
                catch (System.Exception)
                { // se non è stato digitato un numero, avvisiamo dell'errore
                    Console.WriteLine("Devi digitare un numero tra 1 e " + lista.Count + ".");
                }
            }
            Esegui(scelta); // se è stato digitato un valore corretto, la relativa voce di menu viene attivata
        }
    }
}
