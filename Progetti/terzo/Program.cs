using System;

namespace terzo
{
    class Program
    {
        static void Main(string[] args)
        {
            int add = (int x, int y) => { return x + y };
            Console.WriteLine("{0}", add(1, 2));

            Console.WriteLine("Hello World!");
        }
    }
}
