using System;
using System.Text;

namespace progetto2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int numero;
            Console.Write("Digita un numero intero ");
            numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Il numero {0} espresso in base 10 ha le sguenti rappresentazioni:", numero);
            Console.WriteLine("in base 2 -> {0}", Convert.ToString(numero, 2));
            Console.WriteLine("In base 8 -> O{0}", Convert.ToString(numero, 8));
            Console.WriteLine("In base 16 -> 0x{0}", Convert.ToString(numero, 16));
            
            float a_float = 1234.444f;
            double a_double = 4.58e-2;
            double b_double = 1.660538921e-27;
            string s1 = Convert.ToString(a_float);
            string s2 = Convert.ToString(a_double);
            string s3 = Convert.ToString(b_double);
            int tabulatore = 1+Math.Max(s1.Length, Math.Max(s2.Length, s3.Length));
            Console.WriteLine("{0}", tabulatore);
            Console.WriteLine("Valore di a f : {0, "+tabulatore+":F3}", a_float);
            Console.WriteLine("Valore di a d : {0, "+tabulatore+"}", a_double);
            Console.WriteLine("Valore di b d : {0, "+tabulatore+":E9}", b_double);
            */
            decimal ammontare = 456890m;
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Ammontare: {0:C}", ammontare);
        }
    }
}
