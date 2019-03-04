using System;

namespace Tissino2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            var casuale = new Random();
            //Console.WriteLine("numero casuale: " + casuale.Next(100));
            int[] v1 = { 2, 7, 9, 13, 20, 25, 26 }, v2 = { 8, 12, 22 }, v3 = new int[v1.Length + v2.Length];
            //Console.WriteLine("max1:{0} max2:{1}", v1.Length, v2.Length);
            for (int i1 = 0, i2 = 0; i1 + i2 < v1.Length + v2.Length;)
            {
                //Console.Write(" ({4}) [{0}:{1}][{2}:{3}]->", i1, ((i1 < v1.Length) ? v1[i1] : 0), i2, ((i2 < v2.Length) ? v2[i2] : 0), 1 + i1 + i2);
                if (i1 == v1.Length) v3[i1 + i2] = v2[i2++];
                else if (i2 == v2.Length) v3[i1 + i2] = v1[i1++];
                else v3[i1 + i2] = ((v1[i1] < v2[i2]) ? v1[i1++] : v2[i2++]);
                //Console.Write("[{0}:{1}] ", i1 + i2 - 1, v3[i1 + i2 - 1]);
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