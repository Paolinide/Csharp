﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accesso_tradizionale
{
    class Automobile
    {
        public string Targa { get; set; }
        public string Modello { get; set; }
        public int Cilindrata { get; set; }
        public string CodiceProprietario { get; set; }
        public Proprietario proprietario { get; set; }
    }
}
