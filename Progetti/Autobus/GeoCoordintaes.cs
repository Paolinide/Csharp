//Rextester.Program.Main is the entry point for your code. Don't change it.
//Compiler version 4.0.30319.17929 for Microsoft (R) .NET Framework 4.5

using System;
using static System.Math;
using System.Diagnostics;


public class GeoCoordinate : IEquatable<GeoCoordinate>
{
    public GeoCoordinate(double latitudine, double longitudine, double altitudine = 0)
    {
        _altitudine = altitudine;
        _latitudine = latitudine;
        _longitudine = longitudine;
    }
    private double _latitudine;
    private double _longitudine;
    private double _altitudine;
    public int lat { get => (int)latitudine; set => latitudine = value; }
    public int lon { get => (int)longitudine; set => longitudine = value; }
    public int alt { get => (int)altitudine; set => altitudine = value; }
    public double latitudine
    {
        get => _latitudine;
        set
        {
            if (value > 90 || value < -90) { throw new Exception("La latitudine deve essere compresa tra -90 e +90"); }
            _latitudine = value;
        }
    }

    public double longitudine
    {
        get => _longitudine;
        set
        {
            if (value > 180 || value < -180) { throw new Exception("La longitudine deve essere compresa tra -180 e +180"); }
            _longitudine = value;
        }
    }
    public double altitudine { get => _altitudine; set => _altitudine = value; }

    //// UTILITY VARIE

    public static double DifferenzaCircolare(double valore1, double valore2, int limite){
        double latMin = Min(valore1, valore2); // ricaviamo minimo
        double latMax = Max(valore1, valore2); // e massimo
        double lat1 = latMax - latMin;                      // la distanza davanti: -Lim··Min••••••Max···+Lim
        double lat2 = (latMin - (-limite)) + (limite - latMax); // e quella dietro: -Lim••Min······Max•••+Lim
        return Min(lat1, lat2); // e restituiamo il valore minore
    }
    public double Distanza(GeoCoordinate punto1, GeoCoordinate punto2)
    {
        double risultato = 0;
        if (punto1 == punto2) return risultato;

        risultato = Sqrt(Pow(DifferenzaCircolare(punto1.latitudine, punto2.latitudine, 90), 2)
                        + Pow(DifferenzaCircolare(punto1.longitudine, punto2.longitudine, 180), 2));

        return risultato;
    }
    public double Distanza3D(GeoCoordinate punto1, GeoCoordinate punto2)
    {
        double risultato = Distanza(punto1, punto2);
        double distanzaVerticale = punto1.altitudine - punto2.altitudine;
        if (distanzaVerticale == 0) return risultato;

        risultato = Sqrt(Pow(risultato, 2) + Pow(distanzaVerticale, 2));

        return risultato;
    }

    //// METODI NECESSARI PER LE INTERFACCE

    public override bool Equals(Object obj)
    {
        if (obj == null)
            return false;

        var coords = obj as GeoCoordinate;
        if ((Object)coords == null)
            return false;

        return (this.latitudine == coords.latitudine) && (this.longitudine == coords.longitudine);
    }

    public bool Equals(GeoCoordinate coords)
    {
        if ((object)coords == null)
            return false;

        return (this.latitudine == coords.latitudine) && (this.longitudine == coords.longitudine);
    }

    public override int GetHashCode()
    {
        return (int)Sqrt(Pow(this.latitudine, 2) * Pow(this.longitudine, 2));
    }




    public static void TestClass()
    {
        const int Count = 1_000_000;

        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        GeoCoordinate[] coords = new GeoCoordinate[Count];
        for (int i = 0; i < Count; i++)
        {
            coords[i] = new GeoCoordinate(23, 23, 23);
        }

        stopwatch.Stop();
        Console.WriteLine("Millisecondi: {0}, Memoria: {1}", stopwatch.ElapsedMilliseconds, GC.GetTotalMemory(forceFullCollection: false));
        GC.Collect();
    }

}

