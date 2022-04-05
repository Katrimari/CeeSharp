using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LukujenJarjestys
{
    public partial class JarjestaLuvutFM : Form
    {
        
        List<int> jono = new List<int>();
        public JarjestaLuvutFM()
        {
            InitializeComponent();
        }
        
        private void uusiLukuTB_KeyPress(object sender, KeyPressEventArgs e)
        {
        //alku:
            string kluku;
            int luku;
            kluku = uusiLukuTB.Text;
            try
            {
                luku = Int32.Parse(kluku);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Tapahtui virhe!");
                //uusiLukuTB_KeyPress(object sender, KeyPressEventArgs e);
                //goto alku;
            }
            if(e.KeyChar == (char)Keys.Enter)
            {
                if(uusiLukuTB.Text == "-999")
                {
                    VastausLB.Text = "";
                    int[] taulukko = jono.ToArray();
                    Array.Sort(taulukko);
                    foreach(var jasen in taulukko)
                    {
                        VastausLB.Text += jasen + " ";
                    }
                    VastausLB.Visible = true;
                }
                else
                {
                    jono.Add(Int32.Parse(uusiLukuTB.Text));
                    uusiLukuTB.Text = "";
                }
            }
            if(e.KeyChar == (char)Keys.Escape)
            {
                TyhjaaLomake();
            }
        }
        private void TyhjaaLomake()
        {
            uusiLukuTB.Text = "";
        }
    }
    
}
