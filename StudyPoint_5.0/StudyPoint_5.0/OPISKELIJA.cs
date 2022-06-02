using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;


namespace StudyPoint_5._0
{
    internal class OPISKELIJA
    {
        YHDISTA yhteys = new YHDISTA();

        



        public bool lisaaOppilas(String enimi, String snimi, String puh, String email, String lahos, String ptp, String pnro, String kayttis)
        {
            MySqlCommand cmd = new MySqlCommand();
            String lisaa = "INSERT INTO `opiskelija`(`etunimi`, `sukunimi`, `puhelin`, `sahkoposti`, `lahiosoite`, `postitoimipaikka`, `postinro`, `kayttaja`) VALUES (@en, @sn, @puh, @eml, @lah, @ptp, @pnro, @usr)";

            cmd.CommandText = lisaa;
            cmd.Connection = yhteys.otaYhteys();
            

            cmd.Parameters.Add("@en", MySqlDbType.VarChar).Value = enimi;
            cmd.Parameters.Add("@sn", MySqlDbType.VarChar).Value = snimi;
            cmd.Parameters.Add("@puh", MySqlDbType.VarChar).Value = puh;
            cmd.Parameters.Add("@eml", MySqlDbType.VarChar).Value = email;
            cmd.Parameters.Add("@lah", MySqlDbType.VarChar).Value = lahos;
            cmd.Parameters.Add("@ptp", MySqlDbType.VarChar).Value = ptp;
            cmd.Parameters.Add("@pnro", MySqlDbType.VarChar).Value = pnro;
            cmd.Parameters.Add("@usr", MySqlDbType.VarChar).Value = kayttis;

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

        public bool muokkaa(int oid, String enimi, String snimi, String puh, String email, int onro)//tietojen muokkaus
        {
            MySqlCommand cmd = new MySqlCommand();
            String muokkaa = "UPDATE `yhteystiedot` SET `etunimi` = @enm," + "`sukunimi` = @snm, `puhelin`=@puh,`sahkoposti`=@eml,`opiskelijanumero = @ono`" + "WHERE Oid=@oid";

            cmd.CommandText = muokkaa;
            cmd.Connection = yhteys.otaYhteys();

            cmd.Parameters.Add("@enm", MySqlDbType.VarChar).Value = enimi;
            cmd.Parameters.Add("@snm", MySqlDbType.VarChar).Value = snimi;
            cmd.Parameters.Add("@puh", MySqlDbType.VarChar).Value = puh;
            cmd.Parameters.Add("@eml", MySqlDbType.VarChar).Value = email;
            cmd.Parameters.Add("@ono", MySqlDbType.UInt32).Value = onro;
            cmd.Parameters.Add("@oid", MySqlDbType.UInt32).Value = oid;

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

        public DataTable getStudent()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM opiskelija", yhteys.otaYhteys());
            cmd.Connection = yhteys.otaYhteys();
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable etsiviesti()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM palaute", yhteys.otaYhteys());
            cmd.Connection = yhteys.otaYhteys();
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool poista(String kayttis)
        {
            MySqlCommand cmd = new MySqlCommand();
            String poista = "DELETE FROM opiskelija WHERE Oid = @oid";
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

        public bool poistaviesti(String palaute)
        {
            MySqlCommand cmd = new MySqlCommand();
            String poista1 = "DELETE FROM palaute WHERE viesti = @msg";
            cmd.CommandText = poista1;
            cmd.Connection = yhteys.otaYhteys();
            cmd.Parameters.Add("@msg", MySqlDbType.VarChar).Value = palaute;

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
