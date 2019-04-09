using System;
using System.Runtime.Serialization;

namespace Tissino_prova_1
{
    class Persona
    {
        [DataMember(Name="person")] // per far coincidere il nome json col nome C#
        string _nome;
        int _eta;
        [DataMember(Name="name")] // per far coincidere il nome json col nome C#
        public string nome { get => _nome; set => _nome = value; }
        [DataMember(Name="age")] // per far coincidere il nome json col nome C#
        public int eta { get => _eta; set => _eta = value; }

        public Persona() { DefaultValues(); }

        public Persona(string nome, int eta)
        {
            this.nome = nome;
            this.eta = eta;
        }

        public Persona SetNome(string nome)
        {
            this.nome = nome;
            return this;
        }

        public Persona SetEta(int eta)
        {
            this.eta = eta;
            return this;
        }

        void DefaultValues()
        {
            nome = "Giggi";
            eta = 23;
        }

        override public string ToString()
        {
            return nome + " ha " + eta + " anni.";
        }
        public void Stampa() { Console.WriteLine(ToString()); }

    }
}

