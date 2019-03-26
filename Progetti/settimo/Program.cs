using System;

namespace settimo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            //Console.WriteLine("Hello World!");
            var d = new Docente("Dino", "Risi");
            d.Scrivi();
            d.nome = "Daniele";
            d.cognome = "Gobbo";
            d.materia = "Informatica";
            d.Scrivi();
            var a = new Allievo("Gino", "Ginetti");
            a.Scrivi();
            var p = new Persona();
            p.Scrivi();
            p = d;
            d.nome = "Lazzaro";
            p.Scrivi();
            p.nome = "Arnaldo";
            d = (Docente)p;
            d.Scrivi();
        }
    }

    class Persona
    {
        private string _nome;
        private string _cognome;
        private DateTime _dataDiNascita;

        internal string nome { get => _nome; set => _nome = value[0].ToString().ToUpper() + value.Substring(1).ToLower(); }
        internal string cognome { get => _cognome; set => _cognome = value[0].ToString().ToUpper() + value.Substring(1).ToLower(); }
        internal DateTime dataDiNascita { get => _dataDiNascita; set => _dataDiNascita = value; }
        internal Persona(string nome, string cognome)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.dataDiNascita = DateTime.Now;
        }
        internal Persona(string nome = "Jhon", string cognome = "Doe", string StringDataDiNascita = "")
        {
            this.nome = nome;
            this.cognome = cognome;
            this.dataDiNascita = (StringDataDiNascita == "") ? DateTime.Now : Convert.ToDateTime(StringDataDiNascita);
        }
        internal int eta()
        {
            return DateTime.Now.Year - dataDiNascita.Year;
        }
        virtual internal string nominativo() { return this.nome + " " + cognome; }
        internal void Scrivi() { Console.WriteLine(ToString()); }

        override public string ToString() { return nominativo() + " ha " + eta() + " anni."; }
    }

    class Docente : Persona
    {
        private string _materia;
        internal string materia { get => _materia; set => _materia = value; }

        internal Docente(string nome, string cognome) : base(nome, cognome)
        {
            this.nome = nome;
            this.cognome = cognome;
            dataDiNascita = System.DateTime.Now;
        }
        override internal string nominativo() { return "Dott. " + base.nominativo(); }
    }

    class Allievo : Persona
    {
        private string _matricola;
        internal string matricola { get => _matricola; }

        internal Allievo(string nome, string cognome) : base(nome, cognome)
        {
            this.nome = nome;
            this.cognome = cognome;
            dataDiNascita = System.DateTime.Now;
        }
        override internal string nominativo() { return "Studente " + base.nominativo(); }
    }
}
