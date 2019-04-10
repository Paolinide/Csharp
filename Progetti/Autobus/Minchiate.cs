using System;

public static class Minchiate
{
    static public string Incasina(string stringa)
    {
        string risultato = string.Empty;
        Random dado = new Random();
        foreach (var c in stringa)
            risultato = risultato.Insert((dado.Next(risultato.Length + 1)), c.ToString());
        return risultato;
    }
    static public string Rovescia(string stringa)
    {
        string risultato = string.Empty;
        foreach (char c in stringa)
            risultato = c + risultato;
        return risultato;
    }
}