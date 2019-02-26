using System;

namespace secondo_progetto
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Inserisci il primo valore : ");
            int a = Convert.ToInt32( Console.ReadLine()); // legge STINGHE!!
                        // e se non dichiaro dove metterlo lo mette
                        // in args[]
                        // allora aggiungo il metodio per convertire stringhe in numeri
            Console.Write("Inserisci il secondo valore : ");
            int b = Convert.ToInt32(Console.ReadLine());
           // int risultato ; //dichiarazione
            int risultato=0 ;//inizializzata
            
            risultato = Program.Somma(a,b);
            Console.WriteLine("il risultato della somma è : {0}",risultato);
        }

        public static int Somma(int a, int b)
        {
            // la parola chiave static serve per poter chiamare il metodo da un altro metodo
            return a + b;
        }
        public static int Moltiplicazione(int a, int b)
        {
            
            return a * b;
        }

        public static int Divisione(int a, int b)
        {

            return a / b;
        }

        public static int differenza(int a, int b)
        {

            return a - b;
        }
    }
}

