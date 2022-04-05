using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Suositut_Nimet
{
    public partial class SuositutNimetFM : Form
    {
        public SuositutNimetFM()
        {
            InitializeComponent();
        }

        private void TarkastusBT_Click(object sender, EventArgs e)
        {
            VastausLB.Text = "";
            VastausLB.Visible = false;
            string[] pojat = File.ReadAllLines("C:/Users/Katri/source/repot/CeeSharp/Nimet/Pojat.txt");
            string[] tytot = File.ReadAllLines("C:/Users/Katri/source/repot/CeeSharp/Nimet/Tytöt.txt");
            string nimi = NimiTB.Text;
            int laskurip = 1;
            int laskurit = 1;
            foreach (string poika in pojat)
            {
                if(nimi == poika)
                {
                    VastausLB.Text = "Nimesi on " + laskurip + " suosituin poikien nimi vuonna 2020";
                    VastausLB.Visible = true;
                }
                laskurip++;
            }
            foreach (string tytto in tytot)
            {
                if(tytto == nimi)
                {
                    VastausLB.Text = "Nimesi on " + laskurit + " suosituin tyttöjen nimi vuonna 2020";
                    VastausLB.Visible = true;
                }
                laskurit++;
            }
            if (VastausLB.Visible == false)
            {
                VastausLB.Text = "Nimesi ei löytynyt suosituimpien nimien joukosta";
                VastausLB.Visible = true;
            }
        }
    }
}
