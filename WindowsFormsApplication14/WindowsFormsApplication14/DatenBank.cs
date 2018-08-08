using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication14
{
    public class DatenBank
    {
        MySqlConnection conn = new MySqlConnection("SSLMode = none;SERVER=localhost;UID=root;password=root;DATABASE=mydb;");

        public void dbOeffnen()
        {
            conn.Open();
            MessageBox.Show("Datenban geöffnet");
        }

        public string PassHolen( string pw)
        {
            string passw = "";

            dbOeffnen();
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "SELECT Passwort FROM Spieler WHERE UserName = '" + pw + "';";

            MySqlDataReader reader = comm.ExecuteReader();

            if (reader.Read())
            {
                passw = reader.GetString(0);
               
            }

            reader.Close();
            dbSchliessen();

            return passw;
        }
         public List<Land> Laenderholen()
        {
            List<Land> LiLa = new List<Land>();
            dbOeffnen();
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "SELECT * FROM Laender ORDER BY rand();";

            MySqlDataReader reader = comm.ExecuteReader();
            while (reader.Read())
            {
                Land L = new Land(reader.GetString(1), reader.GetString(2), reader.GetString(3));
                LiLa.Add(L);
            }
            reader.Close();
            dbSchliessen();
            return LiLa;

        }
        public void dbSchliessen()
        {
            conn.Close();
        }
    }

}
