using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Eramake;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace CryptausEncryptaus
{
    public partial class CryptausFM : Form
    {
        YHTEYS yhteys = new YHTEYS(); // luodaan ilmentymä yhteys luokkaan.
        ASETUS asetus = new ASETUS();
        public CryptausFM()
        {
            InitializeComponent();
        }

        private void CryptaaBT_Click(object sender, EventArgs e)
        {
            
            MySqlCommand cmd = new MySqlCommand(); //Määritetään komento(cmd) MySqlCommad oliosta.
            String salattu = eCryptography.Encrypt(SalasanaTB.Text); // Määritetään käyttäjän antama salasana ja Encryptataan sen
            String kysely = "INSERT INTO salasana (salasana) VALUES (@ssa);"; // kerrotaan ohjelmalle minne se tieto tallennetaan
            cmd.Parameters.Add("@ssa", MySqlDbType.VarChar).Value = salattu; //kerrotaan tietokannalle tietoja lisättävästä tiedosta
            cmd.CommandText = kysely; //Hakee tai asettaa SQL-käskyn suoritettavaksi tietolähteessä.
            cmd.Connection = yhteys.otaYhteys(); //Hakee tai asettaa tämän MySqlCommand - esiintymän käyttämän MySqlConnectionin
            

            yhteys.openConnection();
            if(cmd.ExecuteNonQuery() == 1)
            {
                yhteys.closeConnection();
                MessageBox.Show("Salasanasi on tallennettu!");
                SalasanaTB.Text = ""; //Tyhjennetään salasana kenttä
                TiedotGB.DataSource = asetus.etsi();
                

            }
            else
            {
                yhteys.closeConnection();
                
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            /*TiedotGB.DataSource = asetus.etsi();
            TiedotGB.DisplayMember = "salasana";
            TiedotGB.ValueMember = "salasana";*/
            
        }

        private void NaytaBT_Click(object sender, EventArgs e)
        {
            String salasana = eCryptography.Decrypt(TiedotGB.SelectedValue.ToString());
            VastausLB.Text = "Salasanasi on: " + salasana;
            VastausLB.Visible = true;

        }

        private void CryptausFM_Load(object sender, EventArgs e)
        {
            TiedotGB.DataSource = asetus.etsi();
            TiedotGB.DisplayMember = "salasana";
            TiedotGB.ValueMember = "salasana";
        }
    }
}
