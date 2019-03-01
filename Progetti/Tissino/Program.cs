using System;

namespace Tissino
{
    class Program
    {
        static void Main(string[] args)
        {
            // ESERCIZIO 
            int numero;
            do
            {                
                Console.Clear();
                Console.Write("Inserisci un numero: ");
            } while (!int.TryParse(Console.ReadLine(), out numero));
            
            Console.WriteLine(numero);
        }
    }
}
