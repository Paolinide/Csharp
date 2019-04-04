using System;
using System.Collections;

namespace sesto
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Persona("Mario", "Rossi");
            var p2 = new Persona("Luisa", "Bianchi");
            var p3 = new Persona("Carlo", "Verdi");

            ArrayList persone = new ArrayList();

            persone.Add(p1);
            persone.Add(p2);
            persone.Add(p3);

            Console.WriteLine(persone.Capacity);

            Persona tre = (Persona)persone[2];

            Console.WriteLine(tre.ToString());

            foreach(Persona buttero in persone){
                Console.WriteLine(buttero.ToString());
            }
        }
    }
}
