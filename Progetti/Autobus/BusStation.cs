using System;
using System.Collections;

class BusStation
{
    // CAMPI E PROPRIETA'
    string _nome = "Stazione ATAP";
    GeoCoordinate _coordinate = new GeoCoordinate(45.9568900, 12.6605100, 24.0);
    public string nome { get => _nome; set => _nome = value; }
    public GeoCoordinate coordinate { get => _coordinate; set => _coordinate = value; }
    bool _aperta = false;
    public void Apri() { _aperta = true; }
    public void Chiudi() { _aperta = false; }
    public string stato { get { return "STATUS_TEST"; } } // dice se aperta la staz. e se ci sono bus in giro
    ArrayList _mezzi = new ArrayList();

    // COSTRUTTORI
    public BusStation() { }
    public BusStation(string nome, double latitudine, double longitudine, double altitudine = 0)
    {
        this.nome = nome;
        coordinate.latitudine = latitudine;
        coordinate.longitudine = longitudine;
        coordinate.altitudine = altitudine;
    }

    // GESTIONE DEI BUS

    void FaiUscireBus()
    {
        var bus = new AutoBus(coordinate);
        _mezzi.Add(bus);
    }



    override public string ToString()
    {
        return string.Format("{0} ({1}, {2}, {3})", nome, coordinate.latitudine, coordinate.longitudine, coordinate.altitudine);
    }
    public void Stampa(bool aCApo = false) { Console.Write(ToString() + (aCApo ? "\n" : "")); }
}