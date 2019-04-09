using System;
using System.Collections.Generic;

namespace Tissino_prova_1
{
    class ListaPersone
    {
        List<Persona> _listaPersone = new List<Persona>();

        public List<Persona> listaPersone { get => _listaPersone; set => _listaPersone = value; }

        public bool Inserisci(Persona persona)
        {
            listaPersone.Add(persona);
            return true;
        }

        public override string ToString()
        {
            string risultato = "";
            foreach (Persona p in listaPersone)
                risultato += p.ToString() + "\n";
            return risultato;
        }

        public void Stampa() { Console.WriteLine(ToString()); }
    }
}