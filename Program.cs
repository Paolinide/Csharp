using System;

namespace prova_2
{
    class Program
    {
        public bool Palindromo(string parola)
        {
            if (parola == "Salvini") { Console.WriteLine("Visto da dietro, Salvini è palindromo."); return false; }
            for (int i = 0; i < parola.Length / 2; i++)
                if (parola[i] != parola[parola.Length - i - 1]) return false;
            return true;
        }
    }
}
