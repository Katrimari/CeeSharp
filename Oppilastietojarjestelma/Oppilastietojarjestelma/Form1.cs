using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oppilastietojarjestelma
{
    public partial class Form1 : Form
    {
        OPISKELIJA oppilas = new OPISKELIJA(); // luodaan ilmentymä/olio OPISKELIJA luokasta
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TiedotDG.DataSource = oppilas.etsiOppilas(); // hakee oppilastiedot ja palauttaa nr tietotaulussa
        }

        private void PaivitaBT_Click(object sender, EventArgs e) //Päivitys painike
        {
            palku:
            String enimi = EnimiTB.Text; //määritetään muuttujia
            String snimi = SnimiTB.Text;
            String puh = PuhTB.Text;
            String email = EmailTB.Text;
           
             int oNro = Int32.Parse(OpnroTB.Text);
             int oid = Int32.Parse(IdTB.Text);
           

            if(enimi.Trim().Equals("") || snimi.Trim().Equals("") || puh.Trim().Equals("") || email.Trim().Equals("") || oNro.Equals(""))
            {
                MessageBox.Show("Täytyä kaikki kentät!", "Tyhjä kenttä", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Boolean lisaaoppilas = oppilas.muokkaa(oid, enimi, snimi, puh, email, oNro);
                if (lisaaoppilas)
                {
                    MessageBox.Show("Opiskelijan tiedot päivitetty", "Tietojen päivitys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Opiskelijan tiedoja ei päivitetty", "Tietojen päivitys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                TiedotDG.DataSource = oppilas.etsiOppilas();
            }
        }

        private void TallennaBT_Click(object sender, EventArgs e)
        {
            String enimi = EnimiTB.Text;
            String snimi = SnimiTB.Text;
            String puh = PuhTB.Text;
            String email = EmailTB.Text;
            int oNro = Int32.Parse(OpnroTB.Text);
            
            if (enimi.Trim().Equals("") || snimi.Trim().Equals("") || puh.Trim().Equals("") || email.Trim().Equals("") || oNro.Equals(""))
            {
                MessageBox.Show("Täytyä kaikki kentät!","Tyhjä kenttä", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
            }
            else
            {
                Boolean lisaaoppilas = oppilas.lisaaOppilas(enimi, snimi, puh, email, oNro);
                {
                    if (lisaaoppilas)
                    {
                        MessageBox.Show("uusi opiskelija lisätty", "opiskelijan lisäys", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Uutta opiskelijaa ei pysty lisäämään", "opiskelijan lisäys", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    TiedotDG.DataSource = oppilas.etsiOppilas();
                }
            }
            
            
        }

        private void TyhjennaBT_Click(object sender, EventArgs e)
        {
            EnimiTB.Text = "";
            SnimiTB.Text = "";
            PuhTB.Text = "";
            EmailTB.Text = "";
            OpnroTB.Text = "";
        }

        private void PoistaBT_Click(object sender, EventArgs e)
        {
            String kayttis = IdTB.Text;
            if (oppilas.poista(kayttis))
            {
                TiedotDG.DataSource=oppilas.etsiOppilas();
                MessageBox.Show("Opiskelijan tiedot poistettu", "Tietojen poisto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Tietoja ei pystytty poistamaan", "Tietojen poisto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            TyhjennaBT.PerformClick();
        }

        private void TiedotDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IdTB.Text = TiedotDG.CurrentRow.Cells[0].Value.ToString();
            EnimiTB.Text = TiedotDG.CurrentRow.Cells[1].Value.ToString();
            SnimiTB.Text = TiedotDG.CurrentRow.Cells[2].Value.ToString();
            PuhTB.Text = TiedotDG.CurrentRow.Cells[3].Value.ToString();
            EmailTB.Text = TiedotDG.CurrentRow.Cells[4].Value.ToString();
            OpnroTB.Text = TiedotDG.CurrentRow.Cells[5].Value.ToString();
            
        }
    }
}
