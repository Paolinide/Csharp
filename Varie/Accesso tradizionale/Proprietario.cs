using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accesso_tradizionale
{
    class Proprietario
    {
        public string CodiceFiscale { get; set; }
        public string Nome { get; set; }
        public string CittaResidenza { get; set; }
        public int AnnoPatente { get; set; }
        //navigation property che consentono di "navigae" nella mia struttura dati in ram
        public List<Automobile> ListaAutomobili { get; set; }
    }
}
