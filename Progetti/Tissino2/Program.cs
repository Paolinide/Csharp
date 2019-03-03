using System;

namespace Tissino2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            int[] v1 = { 2, 7, 9, 25, 25, 26 }, v2 = { 8, 12, 32 }, v3 = new int[v1.Length + v2.Length];
            int i1 = 0, i2 = 0, i3 = 0;
            do
            {
                if (i1 == v1.Length) v3[i3++] = v2[i2++];
                else if (i2 == v2.Length) v3[i3++] = v1[i1++];
                else v3[i3++] = (v1[i1] < v2[i2]) ? v1[i1++] : v2[i2++];
            } while (i1 < v1.Length && i2 < v2.Length);
            
            for (int i=0;i<v3.Length;i++)
                Console.WriteLine("{0} ",v3[i]);
        }
    }
}