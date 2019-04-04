using System;

namespace Tissino4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            string doveCercare = "Nel mezzo del cammin di nostra vita mi ritrovai un valle oscura, che la verace via era smarrita", daCercare = "e";
            TrovaQuanteStringhe(daCercare,doveCercare);
        }
        static public int TrovaQuanteStringhe(string daCercare, string doveCercare)
        {
            int risultato = -1;
            int trovato = -1, numero = 0;
            do
            {
                trovato = doveCercare.IndexOf(daCercare, trovato+1);
                if (trovato != -1) numero++;
            } while (trovato != -1);
            Console.WriteLine("trovate {0} occorrenze della stringa '{1}' dentro '{2}'.", numero, daCercare, doveCercare);

            return risultato;
        }
    }
}
