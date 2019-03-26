using System;

namespace sesto
{
    class Persona
    {
        string _nome;
        string _cognome;
        internal DateTime dataDiNascita;

        public string nome { get => _nome; set => _nome = value[0].ToString().ToUpper()+value.Substring(1).ToLower(); }
        public string cognome { get => _cognome; set => _cognome = value[0].ToString().ToUpper()+value.Substring(1).ToLower(); }

        internal Persona(string nome = "Jhon", string cognome = "Doe", string StringDataDiNascita = "2/12/1980"){
            this.nome = nome;
            this.cognome = cognome;
            this.dataDiNascita = Convert.ToDateTime(StringDataDiNascita);
        }
        internal int eta()
        {
            return DateTime.Now.Year - dataDiNascita.Year;
        }
        internal string nominativo() { return this.nome + " " + cognome; }

        override public string ToString() { return nome + " " + cognome + " ha " + eta() + " anni."; }
    }
    class Genera
    {
        internal static string Password(Persona p){
            return (p.nome + p.cognome + DateTime.Now.Millisecond.ToString()).GetHashCode().ToString();
        }
    }
}