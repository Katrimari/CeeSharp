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
    public partial class tervetuloaFM : Form
    {
        KIRJAUTUMISLOMAKE kirjaudu = new KIRJAUTUMISLOMAKE();
        REKISTEROITYMISLOMAKE rekisteroi = new REKISTEROITYMISLOMAKE();
        public tervetuloaFM()
        {
            InitializeComponent();
        }

        private void KirjauduBT_Click(object sender, EventArgs e)
        {
            this.Hide();
            kirjaudu.Show();
        }

        private void Rekisteröidy_Click(object sender, EventArgs e)
        {
            this.Hide();
            rekisteroi.Show();
        }
    }
}
