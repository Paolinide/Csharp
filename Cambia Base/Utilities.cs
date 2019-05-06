using System;

namespace Cambia_Base
{
    class Utilitià
    {
        const string cifre = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public static string CambiaBase(int _valore, int _base = 2)
        {
            string risultato = "";
            while (_valore > 0)
            {
                int indice = _valore % _base;
                risultato = cifre[indice] + risultato;
                _valore /= _base;
            }
            return risultato;
        }
    }
}