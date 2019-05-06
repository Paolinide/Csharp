using System;
using Battaglia;

namespace Battaglia
{
    class Program
    {
        static Random dado = new Random();
        static string LanciaMoneta() => (dado.Next(2) == 0) ? "Testa" : "Croce";
        static int Dado6() => dado.Next(1, 7);
        static int Dado20() => dado.Next(1, 21);
        static string Grado20(int valore)
        {
            if (valore == 1) return "Perfetto";
            else if (valore == 20) return "Maldestro";
            else if (valore >= 2 && valore <= 7) return "Fortunato";
            else if (valore >= 8 && valore <= 13) return "Normale";
            else /*if (valore >= 14)*/ return "Sfortunato";
        }

        static void Main(string[] args)
        {
            Console.Clear();
            var g1 = new Player("Tony");
            var g2 = new Player("Meny");

            Console.WriteLine(g1.ToString());
            Console.WriteLine(g2.ToString());

            g1.Sfida(g2);

            int primo = LanciaMoneta() == "Testa" ? 0 : 1;
            for (int i = 0; i < 5; i++)
                Console.WriteLine(((primo + i) % 2 == 0 ? g1 : g2).Attacca());
        }

        public class Player
        {
            static private int _newId = 0;
            static int newId { get => _newId++; }
            private int _id = newId;
            public string nome;
            int _salute = 20 + Dado20() + Dado20();
            int _intelligenza = 10 + Dado20();
            int _forza = 10 + Dado20();
            int _destrezza = 10 + Dado20();
            int _resistenza = 10 + Dado20();
            Player _avversario;
            public Player(string nome = null) { this.nome = (nome == null) ? "Giocatore " + _id : nome; }



            public void Sfida(Player avversario) { this._avversario = avversario; avversario._avversario = this; }
            public string Attacca()
            {
                if (_avversario == null) return "";
                int attaccato = Dado20() + (this._forza + this._destrezza);
                int schivata = Dado20() + _avversario._intelligenza;
                if (schivata > attaccato) return _avversario.nome + " ha schivato l'attacco di " + nome;
                int difesa = Dado20() + _avversario._resistenza;
                if (difesa > attaccato) return _avversario.nome + " ha parato l'attacco di " + nome;
                int danno = Math.Max(0, dado.Next(_forza) + dado.Next(_destrezza) - dado.Next(_avversario._resistenza));
                _avversario._salute -= danno;
                return $"{nome} [{_salute}] ha inflitto {danno} danni a {_avversario.nome} [{_avversario._salute}]";
            }
            public override string ToString()
            {
                return "“" + nome + "”\n" +
                       "PV: " + _salute + "\n" +
                       "IN: " + _intelligenza + "\n" +
                       "FO: " + _forza + "\n" +
                       "DE: " + _destrezza + "\n" +
                       "RE: " + _resistenza + "\n";
            }
        }
    }
}
