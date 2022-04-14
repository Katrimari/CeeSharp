using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Oppilastietojarjestelma
{
    class OPISKELIJA
    {
        YHDISTA yhteys = new YHDISTA(); //Luodaan ilmentymä/olio YHDISTA luokasta jossa luotiin metodeja kuten otaYhteys(), openConnection()...

        public bool lisaaOppilas(String enimi, String snimi, String puh, String email, int onro)
        {
            String kayttis = enimi.Substring(0, 3).ToLower() + snimi.Substring(0, 4).ToLower();//Luodaan käyttäjätunnuts jossa etunimen 3 ekaa kirjainta ja sukunimen 4 ekaa kirjainta.
            String salis = salisS();
            MySqlCommand cmd = new MySqlCommand();
            String kysely = "INSERT INTO yhteystiedot " +
                "(etunimi, sukunimi, puhelin, sahkoposti, opiskelijanumero, kayttis, salasana) " +
                "VALUES (@enm, @snm, @puh, @eml, @ono, @usr, @ssa); ";
            
            cmd.Parameters.Add("@enm", MySqlDbType.VarChar).Value = enimi;
            cmd.Parameters.Add("@snm", MySqlDbType.VarChar).Value = snimi;
            cmd.Parameters.Add("@puh", MySqlDbType.VarChar).Value = puh;
            cmd.Parameters.Add("@eml", MySqlDbType.VarChar).Value = email;
            cmd.Parameters.Add("@ono", MySqlDbType.UInt32).Value = onro;
            cmd.Parameters.Add("@usr", MySqlDbType.VarChar).Value = kayttis;
            cmd.Parameters.Add("@ssa", MySqlDbType.VarChar).Value = salis;
            cmd.CommandText = kysely;
            cmd.Connection = yhteys.otaYhteys();
            MessageBox.Show("Käyttäjätunnuksesi: " + kayttis + "\nSalasanasi: " + salis + "\n Kirjoita nämä talteen kirjautumista varten!");

            yhteys.openConnection();
            if(cmd.ExecuteNonQuery() == 1) //jos toteutettava komento (cmd) toimii
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

        public String salisS()
        {
            char[] merkit = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
            String salis = "";
            Random rand = new Random();
            for(int i = 0; i < 10; i++)
            {
                int randInt = rand.Next(0, 61);
                salis += merkit[randInt];
            }
            return salis;
        }

        public DataTable etsiOppilas() //etsi oppilas
        {
            MySqlCommand cmd = new MySqlCommand("SELECT oid,etunimi,sukunimi,puhelin,sahkoposti,opiskelijanumero FROM yhteystiedot", yhteys.otaYhteys());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable taulu = new DataTable();
            adapter.SelectCommand = cmd;
            adapter.Fill(taulu);
            return taulu;
        }

        public bool muokkaa(int oid, String enimi, String snimi, String puh, String email, int onro)//tietojen muokkaus
        {
            MySqlCommand cmd = new MySqlCommand();
            String muokkaa = "UPDATE `yhteystiedot` SET `etunimi` = @enm," + "`sukunimi` = @snm, `puhelin`=@puh,`sahkoposti`=@eml,`opiskelijanumero = @ono`" + "WHERE Oid=@oid";

            cmd.Parameters.Add("@enm", MySqlDbType.VarChar).Value = enimi;
            cmd.Parameters.Add("@snm", MySqlDbType.VarChar).Value = snimi;
            cmd.Parameters.Add("@puh", MySqlDbType.VarChar).Value = puh;
            cmd.Parameters.Add("@eml", MySqlDbType.VarChar).Value = email;
            cmd.Parameters.Add("@ono", MySqlDbType.UInt32).Value = onro;
            cmd.Parameters.Add("@oid", MySqlDbType.UInt32).Value = oid;

            yhteys.openConnection();
            if(cmd.ExecuteNonQuery() == 1)
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

        public bool poista(String kayttis)
        {
            MySqlCommand cmd = new MySqlCommand();
            String poista = "DELETE FROM yhteystiedot WHERE Oid = @usr";
            cmd.CommandText = poista;
            cmd.Connection = yhteys.otaYhteys();
            cmd.Parameters.Add("@usr", MySqlDbType.UInt32).Value = kayttis;

            yhteys.openConnection();
            if (cmd.ExecuteNonQuery() == 1)
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
