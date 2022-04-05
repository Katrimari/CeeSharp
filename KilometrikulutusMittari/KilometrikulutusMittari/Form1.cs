using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KilometrikulutusMittari
{
    public partial class KilometrikululaskuriFM : Form
    {
        public KilometrikululaskuriFM()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void VastausLB_Click(object sender, EventArgs e)
        {

        }

        private void KilometritCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            double laina, nesteet, vakuutus, pesut, huollot, renkaat, muut, kilsat, polttoaine, kustannukset;
            
         


            laina = Convert.ToDouble(LainaTB.Text);
            nesteet = Convert.ToDouble(NesteetTB.Text);
            vakuutus = Convert.ToDouble(VakuutusTB.Text);
            pesut = Convert.ToDouble(PesutTB.Text);
            huollot = Convert.ToDouble(HuollotTB.Text);
            renkaat = Convert.ToDouble(RenkaatTB.Text);
            muut = Convert.ToDouble(MuutKulutTB.Text);
            polttoaine = Convert.ToDouble(PolttoaineTB.Text);
            kilsat = Convert.ToDouble(KilometritCB.Text);
            

            kustannukset = (laina + nesteet + vakuutus + pesut + huollot + renkaat + muut + polttoaine) / (kilsat / 12);
            VastausLB.Text = "Kustannukset kilometsiä kohti ovat: " + kustannukset;
            VastausLB.Visible = true;
        }
    }
}
