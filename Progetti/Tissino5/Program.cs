using System;

namespace Tissino5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] v = { 10, 20, 50, 23 };
            Console.WriteLine(Trova(v, 23));
        }
        static public int? Trova(int[] vettore, int valore)
        {
            for (int i = 0; i < vettore.Length; i++)
            {
                if (vettore[i] == valore) return i;
            }
            return null;
        }
    }
}
