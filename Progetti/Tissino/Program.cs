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

            for (int i = 0; i < numero; i++)
            {
                Console.Write((  ? "B°°m!" : i.ToString()) + " ");
            }

            
        }
        static public bool Valido(int numero)
        {
            if (numero % 7 == 0) return true;
            string stringa = numero.ToString();
            for (int i = 0; i < stringa.Length; i++)
                if (stringa[i] == '7') return true;
            return false;
        }
        static public bool HaIlSette(int numero) 
        {
            
            return false;
        }

        static public int Controlla(string valore, int defaultV)
        {
            try
            {
                return Convert.ToInt32(valore);
            }
            catch (Exception e)
            {
                return defaultV;
                //throw;
            }
        }
    }
}
