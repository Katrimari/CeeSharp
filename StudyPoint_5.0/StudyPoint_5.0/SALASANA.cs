using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace StudyPoint_5._0
{
    public partial class SALASANA : UserControl
    {
        YHDISTA yhteys = new YHDISTA();
        public SALASANA()
        {
            InitializeComponent();
        }

       /* public DataTable etsiOppilas() //etsi oppilas
        {
            MySqlCommand cmd = new MySqlCommand("SELECT oid,etunimi,sukunimi,puhelin,sahkoposti,opiskelijanumero FROM yhteystiedot", yhteys.otaYhteys());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable taulu = new DataTable();
            adapter.SelectCommand = cmd;
            adapter.Fill(taulu);
            //return taulu;
        }*/

        private void VaihdaBT_Click(object sender, EventArgs e)
        {
            String pass = PassOldTB.Text;
            String newp = PassNewTB.Text;
            String newAg = PssNewAgTB.Text;

            MySqlCommand cmd = new MySqlCommand("SELECT salasana FROM opiskelija", yhteys.otaYhteys());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable taulu = new DataTable();
            adapter.SelectCommand = cmd;
            adapter.Fill(taulu);

            if (newp == newAg)
            {
                
                String muokkaa = "UPDATE `opiskelija` SET `salasana` = @newpss WHERE `salasana` = @pss";

                cmd.Parameters.Add("@newpss", MySqlDbType.VarChar).Value = newp;
                cmd.Parameters.Add("@pss", MySqlDbType.VarChar).Value = pass;


                cmd.CommandText = muokkaa;
                cmd.Connection = yhteys.otaYhteys();
                if (newp == "" || newAg == "" || pass == "")
                {
                    MessageBox.Show("Täytä kaikki kentät", "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    yhteys.openConnection();
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        yhteys.closeConnection();
                        PassOldTB.Text = "";
                        PassNewTB.Text = "";
                        PssNewAgTB.Text = "";
                        MessageBox.Show("Salasanasi on päivitetty");
                    }
                    else
                    {
                        yhteys.closeConnection();
                        MessageBox.Show("Salasanaasi ei voitu päivittää", "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                
            }
            else
            {
                MessageBox.Show("Jokin meni vikaan! Tarkasta oikein kirjoitus");
            }

        }

    }
}
