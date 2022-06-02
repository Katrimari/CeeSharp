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
    public partial class PALAUTE : UserControl
    {
        YHDISTA yhteys = new YHDISTA();
        public PALAUTE()
        {
            InitializeComponent();
        }

        private void lahetaBT_Click(object sender, EventArgs e)
        {
            string enimi = EnimiTB.Text;
            string snimi = SnimiTB.Text;
            string email = EmailTB.Text;
            
            string viesti = richTextBox.Text;

            MySqlCommand cmd = new MySqlCommand();


            String kysely = "INSERT INTO palaute (etunimi, sukunimi, email, /*aihe,*/ viesti) VALUES (@enm, @snm, @eml, /*@sub,*/ @msg);";
            cmd.Connection = yhteys.otaYhteys();
            cmd.CommandText = kysely;

            cmd.Parameters.Add("@enm", MySqlDbType.VarChar).Value = enimi;
            cmd.Parameters.Add("@snm", MySqlDbType.VarChar).Value = snimi;
            cmd.Parameters.Add("@eml", MySqlDbType.VarChar).Value = email;
           
            cmd.Parameters.Add("@msg", MySqlDbType.VarChar).Value = viesti;

            if (enimi.Trim().Equals("") || snimi.Trim().Equals("") || email.Trim().Equals("") || viesti.Trim().Equals(""))
            {
                MessageBox.Show("Täytyä kaikki kentät!", "Tyhjä kenttä", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                yhteys.openConnection();
                if (cmd.ExecuteNonQuery() == 1) 
                {
                    yhteys.closeConnection();
                    EnimiTB.Text = "";
                    SnimiTB.Text = "";
                  
                    EmailTB.Text = "";
                    richTextBox.Text = "";

                    MessageBox.Show("Viesti lähetetty!");

                }
                else
                {
                    yhteys.closeConnection();
                    MessageBox.Show("Viestiä ei lähetetty!");
                }
            }

           
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            DialogResult Exit;

            try
            {
                Exit = MessageBox.Show("Haluatko varmasti poistua ja peruuttaa viestin lähettämisen?", "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (Exit == DialogResult.Yes)
                {
                    Application.Exit();

                    EnimiTB.Text = "";
                    SnimiTB.Text = "";
                  
                    EmailTB.Text = "";
                    richTextBox.Text = "";
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    
}
