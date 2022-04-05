using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ikälaskin_tehtävät_1_4_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MinuuttiaLB_Click(object sender, EventArgs e)
        {

        }

        private void LaskeBT_Click(object sender, EventArgs e)
        {
            DateTime synttarit = SynttaritDT.Value;
            DateTime nyt = DateTime.Now;
            double erotus = Math.Round((nyt - synttarit).TotalDays);
            VuottaLB.Text = Math.Ceiling(erotus / 365.25) + " vuotta";
            KuukauttaLB.Text = Math.Ceiling(erotus * 12 / 365.25) + " kuukautta";
            PaivaaLB.Text = erotus + " päivää";
            TuntiaLB.Text = (erotus * 24) + " tuntia";
            MinuuttiaLB.Text = (erotus * 24 * 60) + " Minuuttia";
            SekuntiaLB.Text = (erotus * 24 * 60 * 60) + " sekuntia";
            VuottaLB.Visible = true;
            KuukauttaLB.Visible = true;
            PaivaaLB.Visible = true;
            TuntiaLB.Visible = true;
            MinuuttiaLB.Visible = true;
            SekuntiaLB.Visible = true;
        }
    }
}
