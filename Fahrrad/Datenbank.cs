using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fahrrad
{
    public class Datenbank
    {
        MySqlConnection conn = null;
        MySqlCommand com;

        private void Oeffnen()
        {
            try
            {
                conn = new MySqlConnection("SERVER=localhost;UID=root;PASSWORD='';DATABASE=fahrrad");
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Schliessen()
        {
            if (conn != null)
                conn.Close();
        }
        public List<Rohware> holeRohware()
        {
            List<Rohware> liPers = new List<Rohware>();

            try
            {
                Oeffnen();
                com = conn.CreateCommand();
                com.CommandText = "SELECT * FROM Rohware;";

                MySqlDataReader reader = com.ExecuteReader();

                while (reader.Read())
                {
                    liPers.Add(
                        new Rohware(
                            reader.IsDBNull(0) ? -1 : reader.GetInt32(0),
                            reader.IsDBNull(1) ? "" : reader.GetString(1),
                            reader.IsDBNull(2) ? 0.0 : reader.GetDouble(2)
                        )
                        );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Schliessen();
            }

            return liPers;
        }
        public void speichereRohware(Rohware f)
        {
            try
            {
                Oeffnen();
                com = conn.CreateCommand();

                string p = f.RwPreis.ToString("#0.00").Replace(',', '.');
                com.CommandText = "INSERT INTO Rohware " +
                                    "VALUES( NULL, \"" +
                                    f.RwBezeichnung + "\", " +
                                    p + ");";
                com.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Schliessen();
            }
        }
        public List<Fertigware> holeFertigware()
        {
            List<Fertigware> liPers = new List<Fertigware>();

            try
            {
                Oeffnen();
                com = conn.CreateCommand();
                com.CommandText = "SELECT * FROM Fertigware;";

                MySqlDataReader reader = com.ExecuteReader();

                while (reader.Read())
                {
                    liPers.Add(
                        new Fertigware(
                            reader.IsDBNull(0) ? -1 : reader.GetInt32(0), 
                            reader.IsDBNull(1) ? "" : reader.GetString(1),  
                            reader.IsDBNull(2) ? 0.0 : reader.GetDouble(2)  
                        )
                        );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Schliessen();
            }

            return liPers;
        }
        public void speichereFertigware(Fertigware f)
        {
            try
            {
                Oeffnen();
                com = conn.CreateCommand();

                string p = f.FwPreis.ToString("#0.00").Replace(',', '.');
                com.CommandText = "INSERT INTO Fertigware " +
                                    "VALUES( NULL, \"" +
                                    f.FwModell + "\", " +
                                    p + ");";
                com.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Schliessen();
            }
        }
        public void speichereFwRw(FwRw f)
        {
            try
            {
                Oeffnen();
                com = conn.CreateCommand();

                com.CommandText = "INSERT INTO FwRw " +
                                    "VALUES( NULL, " +
                                    f.FwNr.ToString() + ", " +
                                    f.RwNr.ToString() + ", " +
                                    f.Menge.ToString() + ");";

                com.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Schliessen();
            }
        }
        public void saveLagerbestand(Lager l)
        {
            try
            {
                Oeffnen();
                com = conn.CreateCommand();
       
                com.CommandText = "INSERT INTO Lager " +
                                    "VALUES( " +
                                    l.Lnr + ", " +
                                    l.Lbestand + ");";
                com.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Schliessen();
            }
        }
        public List<Lager> getLagerbestand()
        {
            List<Lager> lilag = new List<Lager>();

            try
            {
                Oeffnen();
                com = conn.CreateCommand();
                com.CommandText = "SELECT lrwnr, SUM(lbestand) FROM Lager " +
                    "GROUP BY lrwnr;";

                MySqlDataReader reader = com.ExecuteReader();

                while (reader.Read())
                {
                    lilag.Add(
                        new Lager(
                            reader.IsDBNull(0) ? -1 : reader.GetInt32(0),
                            reader.IsDBNull(1) ? 0 : reader.GetInt32(1)
                                )
                        );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Schliessen();
            }

            return lilag;
        }
        public List<DispRw> holeRwzuFw( int fwnr)
        {
            List<DispRw> liPers = new List<DispRw>();

            try
            {
                Oeffnen();
                com = conn.CreateCommand();
                com.CommandText = "SELECT * FROM vFwRw " +
                    "WHERE ftfwnr = " + fwnr.ToString() + ";";

                MySqlDataReader reader = com.ExecuteReader();

                while (reader.Read())
                {
                    liPers.Add(
                        new DispRw(
                            reader.IsDBNull(0) ? -1 : reader.GetInt32(0), // FwNr
                            reader.IsDBNull(3) ? -1 : reader.GetInt32(3), // RwNr
                            reader.IsDBNull(4) ? "" : reader.GetString(4), // bez
                            reader.IsDBNull(9) ? 0 : reader.GetInt32(9),     // menge                       
                            reader.IsDBNull(5) ? 0.0 : reader.GetDouble(5) // preis
                        )
                        );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Schliessen();
            }

            return liPers;
        }
        
    }
}
