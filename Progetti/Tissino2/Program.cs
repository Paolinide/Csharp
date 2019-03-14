using System;

namespace Tissino2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            var casuale = new Random();
            int[] v1 = new int[5 + casuale.Next(5)], v2 = new int[5 + casuale.Next(5)], v3 = new int[v1.Length + v2.Length];
            int n = 0;
            for (int i = 0; i < v1.Length; i++)
                v1[i] = n += 1 + casuale.Next(5);
            n = 0;
            for (int i = 0; i < v2.Length; i++)
                v2[i] = n += 1 + casuale.Next(5);

            for (int i1 = 0, i2 = 0; i1 + i2 < v1.Length + v2.Length;)
                v3[i1 + i2] =    (i1 == v1.Length)  ?  v3[i1 + i2] = v2[i2++] :  (i2 == v2.Length)  ?  v3[i1 + i2] = v1[i1++] :  v3[i1 + i2]  =    (v1[i1] < v2[i2])  ?  v1[i1++] : v2[i2++];
            {
                //if (i1 == v1.Length) v3[i1 + i2] = v2[i2++];
                //else if (i2 == v2.Length) v3[i1 + i2] = v1[i1++];
                //lse v3[i1 + i2] = ((v1[i1] < v2[i2]) ? v1[i1++] : v2[i2++]);
            }
            Console.Write("\n1° vettore: ");
            for (int i = 0; i < v1.Length; i++)
                Console.Write("{0} ", v1[i]);
            Console.Write("\n2° vettore: ");
            for (int i = 0; i < v2.Length; i++)
                Console.Write("{0} ", v2[i]);
            Console.Write("\n3° vettore: ");
            for (int i = 0; i < v3.Length; i++)
                Console.Write("{0} ", v3[i]);
            Console.WriteLine();
        }
    }
}