using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Ajastin
{
    public partial class AjastinFM : Form
    {
        private int kokonaisaika;
        public AjastinFM()
        {
            InitializeComponent();
        }

        private void AjastinFM_Load(object sender, EventArgs e)
        {
            StopBT.Enabled = false; //poistaa stop buttonin käytöstä
            for(int i = 0; i < 60; i++)
            {
                MinuutitCB.Items.Add(i.ToString()); //lisätään pudotusvalikkoon numerot
                SekunnitCB.Items.Add(i.ToString()); //lisätään pudotusvalikkoon numerot
            }
            MinuutitCB.SelectedIndex = 15;
            SekunnitCB.SelectedIndex = 15; //Määritetään oletus arvo
        }

        private void StartBT_Click(object sender, EventArgs e)
        {
            StartBT.Enabled = false; //poistetaan button käytöstä
            StopBT.Enabled = true; // otetaan button käyttöön
            int min = int.Parse(MinuutitCB.SelectedItem.ToString());
            int sek = int.Parse(SekunnitCB.SelectedItem.ToString());
            kokonaisaika = (min * 60) + sek;
            AjastinTM.Enabled = true;
        }

        private void StopBT_Click(object sender, EventArgs e)
        {
            StartBT.Enabled = true;
            StopBT.Enabled = false;
            kokonaisaika = 0;
            AjastinTM.Enabled = false;
            AikaLB.Text = "00:00";
        }

        private void AjastinTM_Tick(object sender, EventArgs e)
        {
            if(kokonaisaika > 0)
            {
                kokonaisaika--;
                int min = kokonaisaika / 60;
                int sek = kokonaisaika - (min * 60);
                AikaLB.Text = min.ToString() + ":" + sek.ToString();
            }
            else
            {
                AjastinTM.Stop();
                MessageBox.Show("Aika päättynyt!");
            }
        }
    }
}
