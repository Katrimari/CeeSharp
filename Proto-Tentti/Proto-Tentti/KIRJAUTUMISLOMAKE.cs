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


namespace Proto_Tentti
{
    
    public partial class KIRJAUTUMISLOMAKE : Form
    {
        YHTEYS yhteys = new YHTEYS();

        string a;
        public KIRJAUTUMISLOMAKE()
        {
            InitializeComponent();
        }

        private void RekistLNK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            REKISTEROITYMISLOMAKE rekisteroi = new REKISTEROITYMISLOMAKE();
            this.Hide();
            rekisteroi.Show();
        }

        private void naytasalisCB_CheckedChanged(object sender, EventArgs e)
        {
            if (naytasalisCB.Checked)
            {
                salisTB.PasswordChar = '\0';
            }
            else
            {
                salisTB.PasswordChar = '*';
            }
        }

        

        private void tyhjennaBT_Click(object sender, EventArgs e)
        {
            kaytTB.Text = "";
            salisTB.Text = "";
        }

        private void KirjauduBT_Click(object sender, EventArgs e)
        {
            alku:
            try
            {
                String usr = kaytTB.Text;
                String pass = salisTB.Text;

                MySqlDataAdapter adapter = new MySqlDataAdapter();
                DataTable dt = new DataTable();
                MySqlCommand cmd = new MySqlCommand();

                String kysely = "SELECT * FROM `koetiedot` WHERE `kayttaja` = @usn and `salasana` = @pss";
                
                cmd.Connection = yhteys.otaYhteys();
                cmd.CommandText = kysely;

                cmd.Parameters.Add("@usn", MySqlDbType.VarChar).Value = usr;
                cmd.Parameters.Add("@pss", MySqlDbType.VarChar).Value = pass;

                adapter.SelectCommand = cmd;
                adapter.Fill(dt);



                
                if (dt.Rows.Count > 0)
                {
                    EtusivuPL.Visible = true;
                    terLB.Text = "Tervetuloa " + usr + "!";
                }
                else
                {
                    if (usr.Trim().Equals(""))
                    {
                        MessageBox.Show("Kirjoita käyttäjätunnus", "Virheellinen käyttäjätunnus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (pass.Trim().Equals(""))
                    {
                        MessageBox.Show("Kirjoita salasana", "Virheellinen salasana", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("väärä käyttäjätunnus tai salasana", "Virhe sisäänkirjautumisessa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("jokin meni vikaan", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                goto alku;
            }
        }

        private void LahetaBT_Click(object sender, EventArgs e)
        {
            string checkBoxarvo = "";
            string radiobuttonarvo = "";
            string drop = kielicombo.Text;
            string palaute = palauteTB.Text;
            DateTime aika = DateTime.Now;




            if (prototyyppiCB.Checked == true)
            {
                checkBoxarvo = "Ohjelmiston prototyyppi";
            }
            else if (tuotantoversioCB.Checked == true)
            {
                checkBoxarvo = "Ohjelmiston tuotantoversio";
            }
            else if (käyttöCB.Checked == true)
            {
                checkBoxarvo = "Kehitysympäristön käyttö";
            }
            else
            {
                if (checkBoxarvo.Trim().Equals(""))
                {
                    MessageBox.Show("Et valinnut Kurssia", "Virhe kurssin valinnassa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (pvm1RB.Checked == true)
            {
                radiobuttonarvo = "26.4.2022";
            }
            else if (pvm2RB.Checked == true)
            {
                radiobuttonarvo = "26.8.2022";
            }
            else if (pvm3RB.Checked == true)
            {
                radiobuttonarvo = "18.12.2022";
            }
            else
            {
                MessageBox.Show("Et valinnut tentin ajankohtaa", "Virhe Tenttiajan valinnassa", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            
            if (drop == "JavaScript")
            {
                drop = "JavaScript";
            }
            else if (drop == "C#")
            {
                drop = "C#";
            }
            else
            {
                
                    MessageBox.Show("Valitse ohjelmointi kieli", "Virhe kielen valinnassa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                

            }
            String usr = kaytTB.Text;
            

            
            if (checkBoxarvo.Trim().Equals("") || radiobuttonarvo.Trim().Equals("") || drop.Trim().Equals(""))
            {
                MessageBox.Show("Täytyä kaikki kentät!", "Tyhjä kenttä", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            if(checkBoxarvo != "" && radiobuttonarvo != "" && drop != "")
            {
                MySqlCommand cmd = new MySqlCommand();

                String kysely = "UPDATE koetiedot SET kurssi = @kur, tentti = @ten, kieli = @kie, palaute = @pal, aika = @aik WHERE kayttaja = @usr";
                cmd.Connection = yhteys.otaYhteys();
                cmd.CommandText = kysely;

                cmd.Parameters.Add("@kur", MySqlDbType.VarChar).Value = checkBoxarvo;
                cmd.Parameters.Add("@ten", MySqlDbType.VarChar).Value = radiobuttonarvo;
                cmd.Parameters.Add("@kie", MySqlDbType.VarChar).Value = drop;
                cmd.Parameters.Add("@pal", MySqlDbType.VarChar).Value = palaute;
                cmd.Parameters.Add("@usr", MySqlDbType.VarChar).Value = usr;
                cmd.Parameters.Add("@aik", MySqlDbType.VarChar).Value = aika;



                yhteys.openConnection();
                if (cmd.ExecuteNonQuery() == 1) //jos toteutettava komento (cmd) toimii
                {
                    yhteys.closeConnection();

                    KIITOS kiitos = new KIITOS();
                    this.Hide();
                    kiitos.Show();


                }
                else
                {
                    yhteys.closeConnection();
                    MessageBox.Show("Lomakkeen lähetyksessä tapahtui virhe!");
                }
            }
            else
            {
                MessageBox.Show("jokin meni vikaan", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                

           

        }

       
    }
    
}
