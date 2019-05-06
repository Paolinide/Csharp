using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Accesso_tradizionale
{
    class DBProprietari
    {
        public string Errore { get; set; }
        public string StringDiConnessione { get; }
        public DBProprietari()
        {
            Errore = string.Empty;
            StringDiConnessione = ConfigurationSettings.AppSettings["StringDiConnessione"];
        }
        public List<Proprietario> RecuperaTutti()
        {
            //restituisce una lista di tutti i proprietari
            //inizializzo la lista da ritornare al chaiamnte
            List<Proprietario> elenco = new List<Proprietario>();
            //si deve prevedere il verificarsi di errori run time
            try
            {
                using (SqlConnection con = new SqlConnection(StringDiConnessione))
                {
                    con.Open();
                    string query = "SELECT * FROM Proprietari INNER JOIN Automobili ON Proprietari.CodiceFiscale = Automobili.CodiceFiscaleProprietario ORDER BY Proprietari.CodiceFiscale";
                    //creo il comando da inviare al db
                    SqlCommand cmd = new SqlCommand(query, con);
                    //eseguo il comando ed ottengoi dati in una istanza di sqldataReader
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Proprietario c = new Proprietario();
                        c.CodiceFiscale = null;
                        string CodicefiscaleCorrente = (string)reader["CodiceFiscale"];
                        if (!CodicefiscaleCorrente.Equals(c.CodiceFiscale))
                        {
                            c = new Proprietario();
                            elenco.Add(c);
                            c.CodiceFiscale = (string)reader["CodiceFiscale"];
                            c.Nome = (string)reader["nome"];
                            c.CittaResidenza = (string)reader["CittaResidenza"];
                            c.AnnoPatente = (int)reader["AnnoPatente"];
                            c.ListaAutomobili = new List<Automobile>();
                        }
                        Automobile a = new Automobile();
                        a.Targa = (string)reader["Targa"];
                        a.Modello = (string)reader["Modello"];
                        a.Cilindrata = (int)reader["Cilindrata"];
                        a.CodiceProprietario = (string)reader["codicefiscaleproprietario"];
                        a.proprietario = c;
                        c.ListaAutomobili.Add(a);
                    }
                    reader.Close();
                }

            }
            catch (Exception ex)
            {
                Errore = ex.Message;
                Console.Write(ex.Message);

            }
            return elenco;

        }
        public int Aggiungi(Proprietario unProprietario)
        {
            int n = 0;
            try
            {
                using (SqlConnection con = new SqlConnection(StringDiConnessione))
                {
                    con.Open();
                    string query = "INSERT INTO Proprietari(CodiceFiscale, Nome, CittaResidenza, AnnoPatente)" +
                        " VALUES(@codice, @nome, @citta, @anno)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@codice", unProprietario.CodiceFiscale);
                    cmd.Parameters.AddWithValue("@nome", unProprietario.Nome);
                    cmd.Parameters.AddWithValue("@citta", unProprietario.CittaResidenza);
                    cmd.Parameters.AddWithValue("@anno", unProprietario.AnnoPatente);
                    n = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Errore = ex.Message;


            }
            return n;
        }
    }
}
