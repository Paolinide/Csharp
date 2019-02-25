using System; // questo è un namespace

// questa è una direttiva
// senza questa avrei dovuto scrivere System.Console.WriteLine...
// namespace contenitpore di classi 
// metodi = azioni (le funzioni del c)
// 

namespace Primo_Progetto
{
    class Program
    // questo è oil vero programma C//

    {
        static void Main(string[] args)
        // void non permette un costrutto simile:
        // a= main(edkj)

        // questo è l'unico metodo della classe program del mio namespace Primo_Progetto
        // il metodo Main è OBBLIGATORIO, e deve essere univoco
        // è il punto di inizio del programma C//

        {
            Console.WriteLine("Hello World!");
        }
        static int Somma(int a, int b){
             return a+b;
        }         
    }
}
