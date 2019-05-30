using System;

namespace Menù
{
    class Program
    {
        public static void Saluta() => System.Console.WriteLine("Ciao!");

        static void Main(string[] args)
        {
            Console.Clear();
            
            Freccette.Gioca();
            return;

            Menu menu = new Menu("Menu di prova"); // si crea un nuovo menu vuoto con un nome
            // poi gli si aggiungono le voci al volo
            menu.Aggiundi(new ElementoDiMenu("uno", delegate () { Console.WriteLine("hai scleto la prima voce"); }));
            menu.Aggiundi(new ElementoDiMenu(Piramide.nome, Piramide.StampaPiramide)); // possono essere metodi di altre classi
            menu.Aggiundi(new ElementoDiMenu(StampaMatrice.nome, StampaMatrice.StampaMatrice3x3));
            menu.Aggiundi(new ElementoDiMenu("quattro", delegate () { Console.WriteLine("hai scleto la quarta voce"); }));
            menu.Aggiundi(new ElementoDiMenu("Stampa una riga di asterischi.", delegate () { Console.WriteLine(new string('*', 69)); })); // o funzioni anonime
            // aggiungiamo un sotto-menu
            Menu menuSaluta = new Menu("Saluta in tutte le lingue"); // prima si crea
            menuSaluta.Aggiundi(new ElementoDiMenu("Italia", delegate () { Console.WriteLine("Ciao!"); })); // poi si popola
            menuSaluta.Aggiundi(new ElementoDiMenu("Friuli", delegate () { Console.WriteLine("Mandi!"); }));
            menuSaluta.Aggiundi(new ElementoDiMenu("Milano", delegate () { Console.WriteLine("Uuueeé!"); }));
            menuSaluta.Aggiundi(new ElementoDiMenu("Palermo", delegate () { menuSaluta.Esegui(3); }));
            menu.Aggiundi(new ElementoDiMenu("Saluta", delegate () { menuSaluta.Chiedi(); })); // infine si linka
            // ultima riga del primo menu
            menu.Aggiundi(new ElementoDiMenu("ultimo", delegate () { Console.WriteLine("hai scleto l'ultima voce"); }));

            // menu.Stampa();
            // Console.Write("Scegli una voce dal menu: ");
            // menu.Esegui(int.Parse(Console.ReadLine()));
            menu.Chiedi();
        }
    }
}
