using System;

namespace Tissino2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
<<<<<<< HEAD
            //var casuale = new Random();
            //Console.WriteLine("numero casuale: " + casuale.Next(100));
            int[] v1 = { 2, 7, 9, 13, 20, 25, 26 }, v2 = { 8, 12, 22 }, v3 = new int[v1.Length + v2.Length];

            v3 = Fondi(v1, v2);
            Console.Write("1° vettore: ");
            StampaVettore(v1);
            Console.WriteLine("2° vettore: " + string.Join(", ", v2));
            Console.Write("3° vettore: ");
            StampaVettore(v3);
            Console.WriteLine();

            v1 = new int[] { 1, 1, 3, 3, 3, 2, 2, 6 };
            v2 = new int[] { 6, 9, 23, 23, 23, 23, 46, 2 };
            StampaSomme(v1, v2);
        }
        static public void StampaSomme(int[] v1, int[] v2)
        {
            if (v1.Length == 0 || v2.Length == 0) return;
            int n = v1[0], somma = 0, length = Math.Min(v1.Length, v2.Length);
            Console.Write("{0,3}: ", v1[n]);
            for (int i = 0; i < length; i++)
                if (v1[i] == n) somma += v2[i];
                else
                {
                    n = v1[i];
                    Console.Write("{0,5}\n{1,3}: ", somma, n);
                    somma = v2[i];
                }
            Console.Write("{0,5}\n", somma);
        }
        static public int[] Fondi(int[] v1, int[] v2)
        {
            int[] v3 = new int[v1.Length + v2.Length];
=======
            var casuale = new Random();
            int[] v1 = new int[5 + casuale.Next(5)], v2 = new int[5 + casuale.Next(5)], v3 = new int[v1.Length + v2.Length];
            int n = 0;
            for (int i = 0; i < v1.Length; i++)
                v1[i] = n += 1 + casuale.Next(5);
            n = 0;
            for (int i = 0; i < v2.Length; i++)
                v2[i] = n += 1 + casuale.Next(5);

>>>>>>> 2f708df0aa02a54e276a1cb292bff5afe4a5047e
            for (int i1 = 0, i2 = 0; i1 + i2 < v1.Length + v2.Length;)
                v3[i1 + i2] =    (i1 == v1.Length)  ?  v3[i1 + i2] = v2[i2++] :  (i2 == v2.Length)  ?  v3[i1 + i2] = v1[i1++] :  v3[i1 + i2]  =    (v1[i1] < v2[i2])  ?  v1[i1++] : v2[i2++];
            {
<<<<<<< HEAD
                if (i1 == v1.Length) v3[i1 + i2] = v2[i2++];
                else if (i2 == v2.Length) v3[i1 + i2] = v1[i1++];
                else v3[i1 + i2] = ((v1[i1] < v2[i2]) ? v1[i1++] : v2[i2++]);
=======
                //if (i1 == v1.Length) v3[i1 + i2] = v2[i2++];
                //else if (i2 == v2.Length) v3[i1 + i2] = v1[i1++];
                //lse v3[i1 + i2] = ((v1[i1] < v2[i2]) ? v1[i1++] : v2[i2++]);
>>>>>>> 2f708df0aa02a54e276a1cb292bff5afe4a5047e
            }
            return v3;
        }
        static public void StampaVettore(int[] vettore)
        {
            for (int i = 0; i < vettore.Length; i++)
                Console.Write("{0} ", vettore[i]);
            Console.WriteLine();
        }
    }
}