using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accesso_tradizionale
{
    class Program
    {
      
       
        static void Main(string[] args)
        {
            DBProprietari g = new DBProprietari();
            List<Proprietario> elencoProprietari = g.RecuperaTutti();
            foreach (Proprietario p in elencoProprietari)
            {
                Console.WriteLine(p.CodiceFiscale + " " + p.Nome + " " + p.CittaResidenza + " "+ p.AnnoPatente);
                Console.WriteLine("possiede le seguenti automobili:");
                foreach(Automobile b in p.ListaAutomobili)
                {
                    Console.WriteLine(b.Targa);
                    Console.WriteLine(b.Modello);
                    Console.WriteLine(b.Cilindrata);
                }
                Console.WriteLine();
            }
            var a = new Proprietario();
            a.CodiceFiscale = "66546567";
            a.CittaResidenza = "Roma";
            a.Nome = "Paolo";
            a.AnnoPatente = 2020;
            g.Aggiungi(a);

            Console.ReadLine();
        }
    }
}
