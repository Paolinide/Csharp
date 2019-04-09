using System;

class AutoBus
{
    string _nome;
    GeoCoordinate coordinate;

    public AutoBus(GeoCoordinate coordinate, string nome = "" ) { this.coordinate = coordinate; }
    public void Disegna()
    {
        Console.WriteLine(ToString());
    }
}