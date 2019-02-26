using System;

namespace quinto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Inserisci la dimensione del vettore: ");
            int lung = Convert.ToInt32(Console.ReadLine());
            int[] vett1 = new int[lung];
            int[] vett2 = new int[lung];
            int[] vett3 = new int[lung];
            for (int i = 0; i < lung; i++)
            {
                Console.Write("Inserisci il {0}° valore: ", i + 1);
                vett1[i] = Convert.ToInt32(Console.ReadLine());
            }

            //string[] vett2 = new string[10];
            copia(vett1, vett2);
            riordina(vett2);
            copia(vett2, vett3);
            inverti(vett3);
            stampa(vett1);
            stampa(vett2, true);
            stampa(vett3, false);

        }
        public static void riordina(int[] vett)
        {
            //Console.WriteLine("RIORDINO");
            int lung = vett.Length;
            for (int j = 0; j <= lung - 2; j++)
            {
                for (int i = 0; i <= lung - 2; i++)
                {
                    if (vett[i] > vett[i + 1])
                    {
                        int temp = vett[i + 1];
                        vett[i + 1] = vett[i];
                        vett[i] = temp;
                    }
                } 
            }
        }
        public static void copia(int[] vett1, int[] vett2)
        {
            //Console.WriteLine("COPIA");
            int lung = vett1.Length;
            for (int i = 0; i < lung; i++)
            {
                //Console.WriteLine("Copio valore {0}: {1}", i + 1, vett1[i]);
                vett2[i] = vett1[i];
            }
        }

        public static void inverti2(int[] vett)
        {
            //Console.WriteLine("INVERSIONE GREZZA");
            int lung = vett.Length;
            int[] temp = new int[lung];
            copia(vett, temp);
            for (int i = 0; i < lung; i++)
            {
                //Console.WriteLine("Inverto valore {0} da: {1} a {2}", i + 1, vett[i], temp[lung - i - 1]);
                vett[i] = temp[lung - i - 1];
            }
        }

        public static void inverti(int[] vett)
        { // Più snello della prima versione, occupa meno memoria, meno processore ed é anche più veloce
            //Console.WriteLine("INVERSIONE MIGLIORATA");
            int lung = vett.Length;
            int fine = (lung / 2);
            int temp;
            for (int i = 0; i < fine; i++)
            {
                //Console.WriteLine("{0} Scambio il valore: {1} con il {2}", i + 1, vett[i], vett[lung - i - 1]);
                temp = vett[i];
                vett[i] = vett[lung - i - 1];
                vett[lung - i - 1] = temp;
            }
        }

        public static void stampa(int[] vett, bool inRiga=true)
        {
            Console.WriteLine("STAMPA IN {0}", (inRiga?"LINEA":"COLONNA"));
            int lung = vett.Length;
            for (int i = 0; i < lung; i++)
            {
                Console.Write("[{0}]:{1}{2}", i + 1, vett[i], (inRiga?" ":"\n"));
            }
            if (inRiga) Console.WriteLine();
        }
    }
}
