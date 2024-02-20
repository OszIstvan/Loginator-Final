using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace LOGINATOR___ProjectMunka
{
    static class ABKezelo
    {
        static SqlConnection connection;
        static SqlCommand command;

        static ABKezelo()
        {
            try
            {
                command = new SqlCommand();
                connection = new SqlConnection();
                connection.ConnectionString = ConfigurationManager.ConnectionStrings["ABEleres"].ConnectionString;
                connection.Open();
                command.Connection = connection;
            }
            catch (Exception ex)
            {

                throw new ABKivetel("A kapcsolódás sikertelen!", ex);
            }
        }

        public static void KapcsolatBontasa()
        {
            try
            {
                connection.Close();
                command.Dispose();
            }
            catch (Exception ex)
            {

                throw new ABKivetel("A kapcsolat bontása sikertelen!", ex);
            }
        }

        public static List<Termekek> Olvasas()
        {
            try
            {
                command.Parameters.Clear();
                List<Termekek> termekek = new List<Termekek>();
                command.CommandText = "SELECT * FROM [Termekek] INNER JOIN [Frissaru] ON [Termekek].[Cikkszam]=[Frissaru].[Cikkszam]";
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        termekek.Add(new Frissaru(reader["Cikkszam"].ToString(), reader["Megnevezes"].ToString(), (int)reader["Db"], (int)reader["Ar"], (FrTermekTipus)(byte)reader["Tipus"], (int)reader["Suly"], (DateTime)reader["SzavIdo"]));
                    }
                    reader.Close();
                }
                command.CommandText = "SELECT * FROM [Termekek] INNER JOIN [Melyhutott] ON [Termekek].[Cikkszam]=[Melyhutott].[Cikkszam]";
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        termekek.Add(new MelyhutottAru(reader["Cikkszam"].ToString(), reader["Megnevezes"].ToString(), (int)reader["Db"], (int)reader["Ar"], (FTermekTipus)(byte)reader["Tipus"], (DateTime)reader["SzavIdo"]));
                    }
                    reader.Close();
                }
                command.CommandText = "SELECT * FROM [Termekek] INNER JOIN [Muszaki] ON [Termekek].[Cikkszam]=[Muszaki].[Cikkszam]";
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        termekek.Add(new MuszakiCikk(reader["Cikkszam"].ToString(), reader["Megnevezes"].ToString(), (int)reader["Db"], (int)reader["Ar"], (MTermekTipus)(byte)reader["Tipus"], (Besorolas)(byte)reader["Tipus"]));
                    }
                    reader.Close();
                }
                command.CommandText = "SELECT * FROM [Termekek] INNER JOIN [Szarazaru] ON [Termekek].[Cikkszam]=[Szarazaru].[Cikkszam]";
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        termekek.Add(new Szarazaru(reader["Cikkszam"].ToString(), reader["Megnevezes"].ToString(), (int)reader["Db"], (int)reader["Ar"], (SzTermekek)(byte)reader["Tipus"], (int)reader["Suly"], (DateTime)reader["SzavIdo"]));
                    }
                    reader.Close();
                }
                command.CommandText = "SELECT * FROM [Termekek] INNER JOIN [Tejtermek] ON [Termekek].[Cikkszam]=[Tejtermek].[Cikkszam]";
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        termekek.Add(new Tejtermek(reader["Cikkszam"].ToString(), reader["Megnevezes"].ToString(), (int)reader["Db"], (int)reader["Ar"], (TTermekTipus)(byte)reader["Tipus"], (int)reader["Liter"], (DateTime)reader["SzavIdo"]));
                    }
                    reader.Close();
                }
                return termekek;
            }
            catch (Exception ex)
            {

                throw new ABKivetel("A kiolvasás sikertelen!", ex);
            }
        }

        public static void Beszuras(Termekek uj)
        {
            try
            {
                command.Parameters.Clear();
                command.Transaction = connection.BeginTransaction("Beszuras");
                command.CommandText = "INSERT INTO [Termekek] VALUES(@cikk, @megn, @db, @ar)";
                command.Parameters.AddWithValue("@cikk", uj.Cikkszam);
                command.Parameters.AddWithValue("@megn", uj.Megnevezes);
                command.Parameters.AddWithValue("@db", uj.Db);
                command.Parameters.AddWithValue("@ar", uj.Ar);
                command.ExecuteNonQuery();
                command.Parameters.Clear();
                if (uj is Frissaru)
                {
                    command.CommandText = "INSERT INTO [Frissaru] VALUES(@cikk, @tip, @suly, @szav)";
                    command.Parameters.AddWithValue("@cikk", uj.Cikkszam);
                    command.Parameters.AddWithValue("@tip", (int)(uj as Frissaru).Tipus);
                    command.Parameters.AddWithValue("@suly", (uj as Frissaru).Suly);
                    command.Parameters.AddWithValue("@szav", (uj as Frissaru).Szavido);
                }
                else if (uj is MelyhutottAru)
                {
                    command.CommandText = "INSERT INTO [Melyhutott] VALUES(@cikk, @tip, @szav)";
                    command.Parameters.AddWithValue("@cikk", uj.Cikkszam);
                    command.Parameters.AddWithValue("@tip", (uj as MelyhutottAru).Ftipus);
                    command.Parameters.AddWithValue("@szav", (uj as MelyhutottAru).Szavido);
                }
                else if (uj is MuszakiCikk)
                {
                    command.CommandText = "INSERT INTO [Muszaki] VALUES(@cikk, @tip, @bes)";
                    command.Parameters.AddWithValue("@cikk", uj.Cikkszam);
                    command.Parameters.AddWithValue("@tip", (int)(uj as MuszakiCikk).Mtipus);
                    command.Parameters.AddWithValue("@bes", (int)(uj as MuszakiCikk).Besorolas);
                }
                else if (uj is Szarazaru)
                {
                    command.CommandText = "INSERT INTO [Szarazaru] VALUES(@cikk, @tip, @suly, @szav)";
                    command.Parameters.AddWithValue("@cikk", uj.Cikkszam);
                    command.Parameters.AddWithValue("@tip", (int)(uj as Szarazaru).Sztipus);
                    command.Parameters.AddWithValue("@suly", (uj as Szarazaru).Suly);
                    command.Parameters.AddWithValue("@szav", (uj as Szarazaru).Szavido);
                }
                else if (uj is Tejtermek)
                {
                    command.CommandText = "INSERT INTO [Tejtermek] VALUES(@cikk, @tip, @lit, @szav)";
                    command.Parameters.AddWithValue("@cikk", uj.Cikkszam);
                    command.Parameters.AddWithValue("@tip", (int)(uj as Tejtermek).Ttipus);
                    command.Parameters.AddWithValue("@lit", (uj as Tejtermek).Liter);
                    command.Parameters.AddWithValue("@szav", (uj as Tejtermek).Szavido);
                }

                command.ExecuteNonQuery();
                command.Transaction.Commit();
            }
            catch (Exception ex)
            {
                command.Transaction.Rollback();
                throw new ABKivetel("A beszúrás sikertelen", ex);
            }
        }

        public static void Torol(Termekek torol)
        {
            SqlTransaction transaction = null;
            try
            {
                command.Parameters.Clear();
                transaction = connection.BeginTransaction("Torles");
                command.Transaction = transaction;
                command.Parameters.AddWithValue("@cikk", torol.Cikkszam);
                if (torol is Frissaru)
                {
                    command.CommandText = "DELETE FROM [Frissaru] WHERE [Cikkszam]=@cikk; DELETE FROM [Termekek] WHERE [Cikkszam]=@cikk";
                }
                else if (torol is MelyhutottAru)
                {
                    command.CommandText = "DELETE FROM [Melyhutott] WHERE [Cikkszam]=@cikk; DELETE FROM [Termekek] WHERE [Cikkszam]=@cikk";
                }
                else if (torol is MuszakiCikk)
                {
                    command.CommandText = "DELETE FROM [Muszaki] WHERE [Cikkszam]=@cikk; DELETE FROM [Termekek] WHERE [Cikkszam]=@cikk";
                }
                else if (torol is Szarazaru)
                {
                    command.CommandText = "DELETE FROM [Szarazaru] WHERE [Cikkszam]=@cikk; DELETE FROM [Termekek] WHERE [Cikkszam]=@cikk";
                }
                else if (torol is Tejtermek)
                {
                    command.CommandText = "DELETE FROM [Tejtermek] WHERE [Cikkszam]=@cikk; DELETE FROM [Termekek] WHERE [Cikkszam]=@cikk";
                }
                command.ExecuteNonQuery();
                transaction.Commit();
            }
            catch (Exception ex)
            {

                command.Transaction.Rollback();
                throw new ABKivetel("A törlés sikertelen", ex);
            }
        }
    }
}

