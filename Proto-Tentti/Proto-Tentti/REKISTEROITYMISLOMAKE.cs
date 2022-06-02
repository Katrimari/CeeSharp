using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Proto_Tentti
{
    public partial class REKISTEROITYMISLOMAKE : Form
    {
        YHTEYS yhteys = new YHTEYS();
        ASETUS asetus = new ASETUS();
        public REKISTEROITYMISLOMAKE()
        {
            InitializeComponent();
        }

        private void kirjauduLNK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            KIRJAUTUMISLOMAKE kirjaudu = new KIRJAUTUMISLOMAKE();
            this.Hide();
            kirjaudu.Show();
        }

        private void KirjauduBT_Click(object sender, EventArgs e)
        {
           

            string enimi = enimiTB.Text;
            string snimi = snimiTB.Text;
            string email = emailTB.Text;
            //string kayttis;
            string salis = salisTB.Text;
            string salisAgn = salisAgnTB.Text;
            int synt = DateTime.Today.Year - syntymaDTP.Value.Year;

            //label6.Text = ika.ToString();

            if (enimi.Trim().Equals("") || snimi.Trim().Equals("") || email.Trim().Equals(""))
            {
                MessageBox.Show("Täytyä Kaikki tiedot!!", "Tyhjä kenttä", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (salis.Trim().Equals(""))
            {
                MessageBox.Show("Täytyä salasana kenttä!!", "Tyhjä kenttä", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (salisAgn.Trim().Equals(""))
            {
                MessageBox.Show("salasana on syötettävä uudestaan!!", "Tyhjä kenttä", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (synt < 16)
            {
                MessageBox.Show("olet liian nuori!!", "Tyhjä kenttä", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (salis == salisAgn)
                {
                    Boolean lisaaoppilas = asetus.lisaakayttaja(enimi, snimi, email, salis);
                    {
                        if (lisaaoppilas)
                        {

                            MessageBox.Show("uusi opiskelija lisätty", "opiskelijan lisäys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            KIRJAUTUMISLOMAKE kirjaudu = new KIRJAUTUMISLOMAKE();
                            this.Hide();
                            kirjaudu.Show();

                        }
                        else
                        {
                            MessageBox.Show("Uutta opiskelijaa ei pysty lisäämään", "opiskelijan lisäys", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                }
                else
                {
                    MessageBox.Show("Salasanat eivät täsmää!", "Virhe salasanassa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                
            }
        }

        private void naytasalisCB_CheckedChanged(object sender, EventArgs e)
        {
            if (naytasalisCB.Checked)
            {
                salisTB.PasswordChar = '\0';
                salisAgnTB.PasswordChar = '\0';
            }
            else
            {
                salisTB.PasswordChar = '*';
                salisAgnTB.PasswordChar = '*';
            }
        }

        private void tyhjennaBT_Click(object sender, EventArgs e)
        {
            enimiTB.Text = "";
            snimiTB.Text = "";
            emailTB.Text = "";
            salisTB.Text = "";
            salisAgnTB.Text = "";
            syntymaDTP.Value = DateTime.Today;
        }
    }
}
