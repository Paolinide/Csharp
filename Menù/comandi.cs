using System;

namespace Menù
{
    static class Piramide
    {
        static public string nome => "Stampa una piramide.";
        static public void StampaPiramide()
        {
            for (int i = 0; i < 10; i++)
                Console.WriteLine(new string(' ', 9 - i) + new string('*', 2 * i + 1));
        }
    }
    static class StampaMatrice
    {
        static public string nome => "Stampa una matrice 3x3.";
        static public void StampaMatrice3x3()
        {
            for (int i = 0; i < 3; ++i)
            {
                for (int j = 0; j < 3; j++)
                    Console.Write(i * 3 + j + 1 + " ");
                Console.WriteLine();
            }
        }
    }
}