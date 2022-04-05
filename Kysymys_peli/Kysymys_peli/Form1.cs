using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kysymys_peli
{
    public partial class VastauslomakeFM : Form
    {
        string[] vastaukset = new string[11];
        string[] oikeat = new string[] { "", "B", "D", "A", "A", "C", "A", "B", "A", "C", "D"};
        int laskuri = 0;
        int oikein = 0;
        public VastauslomakeFM()
        {
            InitializeComponent();
            VastausARB.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void VastauslomakeFM_Load(object sender, EventArgs e)
        {

        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if( sender is RadioButton && laskuri <= 10)
            {
                RadioButton radioButton = (RadioButton) sender; //tallennetaan vastaus senderistä radiobuttoniin
                vastaukset[laskuri] = radioButton.Text; // tallennetaan vastaus(a b c d) laskuriin
                laskuri++; //kasvatetaan laskuriA
                KysymysLB.Text = "Vastaus " + laskuri + ". kysymykseen:"; //muutetaan kysymys tekstiä
            }
            else
            {
                VastausLB.Text = ""; //Tyhjätään vastaus LB
                VastausARB.Enabled = false; //Poistetaan radiobuttoneiden "aktiivisuus" ettei pysty vastata.
                VastausBRB.Enabled = false;
                VastausCRB.Enabled = false;
                VastausDRB.Enabled = false;
                for(int j=1; j<=10; j++) //tarkistetaan vastauksia
                {
                    if(vastaukset[j] == oikeat[j]) //Verrataan vastauksia
                    {
                        oikein++;
                    }
                }
                VastausLB.Text = "Oikeita vastauksia oli: " + oikein;
                VastausLB.Visible = true;
            }
            TyhjaaVastaus();
        }

        private void TyhjaaVastaus()
        {
            if(VastausARB.Checked == true) // Suoritetaan jos kyseinen RB on valittu
            {
                VastausARB.Checked = false; // Muutetaan radioButtonin tila "tyhjäksi"
                laskuri--; // vähennetään laskurista
            }
            if (VastausBRB.Checked == true)
            {
                VastausBRB.Checked = false;
                laskuri--;
            }
            if (VastausCRB.Checked == true)
            {
                VastausCRB.Checked = false;
                laskuri--;
            }
            if (VastausDRB.Checked == true)
            {
                VastausDRB.Checked = false;
                laskuri--;
            }
        }
    }
}
