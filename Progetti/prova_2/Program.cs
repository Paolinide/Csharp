using System;

namespace prova_2
{
    class Program
    {
        static public void Main(string[] args)
        {
            Console.Clear();
            bool dentro = true;
            do
            {
                Console.WriteLine("Per uscire dal ciclo digita solo INVIO.");
                Console.Write("Scrivi una parola: ");
                string parola = Console.ReadLine();
                if (parola == "") { Console.WriteLine("Ciao!"); break; }
                Console.WriteLine("La parola '{0}'{1} é un palindromo.", parola, Palindromo(parola) ? "" : " non");
                Console.WriteLine();
            } while (dentro);
            Console.WriteLine();
        }

        static public bool Palindromo(string parola)
        {
            if (parola == "Salvini") { Console.WriteLine("Visto da dietro, Salvini è palindromo."); return false; }
            for (int i = 0; i < parola.Length / 2; i++)
                if (parola[i] != parola[parola.Length - i - 1]) return false;
            return true;
        }
    }
}
