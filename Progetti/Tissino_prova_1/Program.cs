using System;

using System.Threading;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Collections.Generic;
using System.Runtime.Serialization.Json;

namespace Tissino_prova_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Persona p = new Persona();
            Persona p2 = new Persona("Gina", 69);
            // p.Stampa();
            // p2.Stampa();
            ListaPersone lp = new ListaPersone();
            lp.Inserisci(p);
            lp.Inserisci(p2);
            lp.Stampa();
        }
    }
}
