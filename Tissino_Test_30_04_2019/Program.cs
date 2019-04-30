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
    class Program
    {

    
        static void Main(string[] args)
        {
            Console.Clear();
            var g = new Gioco();
            foreach (var giocatore in g.giocatori)
            {
                giocatore.Stampa();
            }
        }
    }
}
