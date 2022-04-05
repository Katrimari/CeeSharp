using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Heita_Noppaa
{
    public partial class HeitanoppaaFM : Form
    {
        public HeitanoppaaFM()
        {
            InitializeComponent();
        }

        private void HeitaBT_Click(object sender, EventArgs e)
        {
            piirraNoppa(noppa01PB);
            piirraNoppa(noppa02PB);
        }

        private void piirraNoppa(PictureBox NoppaBoxi)
        {
            Random sattuma = new Random();
            int noppa01 = sattuma.Next(1, 7);
            //int noppa02 = sattuma.Next(1, 7);
            int arvo, yhteensa;

            switch (noppa01)
            {
                case 1:
                    NoppaBoxi.Image = Properties.Resources.dice01;
                    arvo = 1;
                    break;
                case 2:
                    NoppaBoxi.Image = Properties.Resources.dice02;
                    arvo = 2;
                    break;
                case 3:
                    NoppaBoxi.Image = Properties.Resources.dice03;
                    arvo = 3;
                    break;
                case 4:
                    NoppaBoxi.Image = Properties.Resources.dice04;
                    arvo = 4;
                    break;
                case 5:
                    NoppaBoxi.Image = Properties.Resources.dice05;
                    arvo = 5;
                    break;
                case 6:
                    NoppaBoxi.Image = Properties.Resources.dice06;
                    arvo = 6;
                    break;
                default:
                    TekstiLB.Text = "Jokin meni vikaan";
                    TekstiLB.Visible = true;
                    break;
            }
            
            
        }   
    }
}
