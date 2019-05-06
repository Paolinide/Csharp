using System;
using System.Collections;

namespace ProgettoAutobus
{
    static class Trasmettitore // l'elemento che trasmette i dati al server
    {
        static public bool connessione = false; /////////////////// QUESTA SERVE SOLO PER IL DEBUG, POI VA ELIMINATA
        static bool connessioneAttiva => VerificaConnessione();
        static Stack pila = new Stack(); // il contenitore dei record
        //Archiviatore a; // il sistema di archiviazione che però non ha senso sia un'istanza
        static public bool VerificaConnessione()
        {
            // verifichiamo lo stato della connessione
            return connessione;
        }
        static public bool InoltraRecord(JsonDataRecord jsonData)
        {
            // se la connessione è attiva, spediamo il dato al server
            if (connessioneAttiva)
            {
                InoltraAlServer(jsonData);
                return true;
            }
            // altrimenti la rete non è raggiungibile e memoriziamo i dati in locale
            Trattieni(jsonData);
            return false;
        }
        static void InoltraAlServer(JsonDataRecord jsonData)
        {
            // non ci sono impedimenti e quindi spediamo il nostro dato al server
            Spedisci("{ \"VettoreDati\": [ " + jsonData.ToString() + " ]}");
            // poi verifichiamo se la pila ha altri record da inviare
            if (pila.Count > 0)
            {
                // spediamone il contenuto al server
                Spedisci(JsonDataRecord.StackToString(pila));
                // poi svuotiamo la pila
                pila.Clear();
            }
            // verifichiamo se ci sono file salvati da inviare
            while (Archiviatore.fileInArchivio)
            {
                // recuperiamo i dati archiviati
                string stringaPila = Archiviatore.Pop();
                // e spediamo al server anche i file archiviati
                Spedisci(stringaPila);
            };
        }

        static void Spedisci(string stringaPila)
        { // trasmissione di pile di record
            // l'oggetto jsonData è stato previsto anche come array di record, pertanto può essere inviata l'intera pila senza dover ciclare i suoi elementi
            Console.WriteLine("Inoltro:");
            Console.WriteLine(stringaPila);
        }
        static void Trattieni(JsonDataRecord jsonData)
        {
            // infila il dato in una pila
            pila.Push(jsonData);
            // se la pila raggiunge una certa dimensione crea un file coi dati e svuota la pila
            if (pila.Count >= 3) Archiviatore.Push(ref pila); // la pila viene passata per iferimento per poter essere manipolata
        }
    }
}