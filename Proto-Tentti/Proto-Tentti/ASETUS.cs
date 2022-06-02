using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;


namespace Proto_Tentti
{
    internal class ASETUS
    {
        YHTEYS yhteys = new YHTEYS();
        public bool lisaakayttaja(String enimi, String snimi, String email, String salis)
        {
            MySqlCommand cmd = new MySqlCommand();
            String kayttis = enimi.Substring(0, 3).ToLower() + snimi.Substring(0, 5).ToLower();  //Luodaan käyttäjätunnuts
            
            String kysely = "INSERT INTO koetiedot (etunimi, sukunimi, sahkoposti, kayttaja, salasana) VALUES (@enm, @snm, @eml, @usr, @ssa);"; //Yhteyslause
            cmd.Connection = yhteys.otaYhteys();
            cmd.CommandText = kysely;

            cmd.Parameters.Add("@enm", MySqlDbType.VarChar).Value = enimi;
            cmd.Parameters.Add("@snm", MySqlDbType.VarChar).Value = snimi;
            cmd.Parameters.Add("@eml", MySqlDbType.VarChar).Value = email;
            cmd.Parameters.Add("@usr", MySqlDbType.VarChar).Value = kayttis;
            cmd.Parameters.Add("@ssa", MySqlDbType.VarChar).Value = salis;

            MessageBox.Show("Käyttäjätunnuksesi: " + kayttis + "\nSalasanasi: " + salis + "\n Kirjoita nämä talteen kirjautumista varten!");

            yhteys.openConnection();
            if (cmd.ExecuteNonQuery() == 1) //jos toteutettava komento (cmd) toimii
            {
                yhteys.closeConnection();
                return true;
            }
            else
            {
                yhteys.closeConnection();
                return false;
            }



        }

       



    }
}
