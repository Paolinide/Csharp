using System;

namespace prova_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            // generazione di un vettore casuale
            int l = 5 + dado(11); // numero di elemanti tra 5 e 15
            int[] vett1 = new int[l];
            for (int i = 0; i < l; i++)
                vett1[i] = dado(l);
            StampaVettore(vett1);

            int[] vett2 = RiordinaVettore(vett1, alContrario: true);
            StampaVettore(vett2);
            ReversaVettore(ref vett2);
            StampaVettore(vett2);
        }



        static public int dado(int max)
        {
            Random rnd = new Random();
            return rnd.Next(max);
        }



        static public void StampaVettore<T>(T[] vettore, bool inLinea = true)
        {
            for (int i = 0; i < vettore.Length; i++)
                Console.Write("{0}{1,2}{2}", (inLinea) ? "" : "["+i+"]", vettore[i], (inLinea) ? " " : "\n");
            if (inLinea) Console.WriteLine();
        }
        static public T[] CopiaVettore<T>(T[] vettore)
        {
            T[] risultato = new T[vettore.Length];
            for (int i = 0; i < vettore.Length; i++)
                risultato[i] = vettore[i];
            return risultato;
        }
        static public void ReversaVettoreVecchio<T>(ref T[] vettore)
        {
            T temp;
            int l = vettore.Length;
            for (int i = 0; i < l / 2; i++)
            {
                //Console.WriteLine(i);
                temp = vettore[i];
                vettore[i] = vettore[l - i - 1];
                vettore[l - i - 1] = temp;
            }
        }
        static public void ReversaVettore<T>(ref T[] vettore)
        {
            for (int i = 0; i < vettore.Length / 2; i++)
                Scambia(ref vettore[i], ref vettore[vettore.Length - i - 1]);
        }
        static public void Scambia<T>(ref T primo, ref T secondo)
        {
            T temp = primo;
            primo = secondo;
            secondo = temp;
        }
        static public T[] RiordinaVettore<T>(T[] vettore, bool alContrario = false) where T : struct, IComparable<T>
        {
            for (int j = 0; j < vettore.Length - 1; j++)
            {
                for (int i = 0; i < vettore.Length - 1 - j; i++)
                {
                    if (alContrario)
                    { if (vettore[i].CompareTo(vettore[i + 1]) < 0) Scambia(ref vettore[i], ref vettore[i + 1]); }
                    else
                    { if (vettore[i].CompareTo(vettore[i + 1]) > 0) Scambia(ref vettore[i], ref vettore[i + 1]); }
                }
            }
            return vettore;
        }
    }
}
