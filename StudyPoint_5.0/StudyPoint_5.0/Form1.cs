using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyPoint_5._0
{
    public partial class Form1 : Form
    {
        KayttajaForm form2 = new KayttajaForm();
     
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            etusivu1.BringToFront();
        }

        private void KirjauduBT_Click(object sender, EventArgs e)
        {
            
            
            kirjaudu1.BringToFront();
            kirjaudu1.Show();
            rekisteroidy1.Hide();
        }

        private void RekisteroidyBT_Click(object sender, EventArgs e)
        {
            rekisteroidy1.BringToFront();
            rekisteroidy1.Show();
            kirjaudu1.Hide();
        }

        private void OrganiBT_Click(object sender, EventArgs e)
        {
            organisaatiomme1.BringToFront();
        }

        private void PalveluBT_Click(object sender, EventArgs e)
        {
            palvelumme1.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void OtayhteyttaBT_Click(object sender, EventArgs e)
        {
            
        }

        private void etusivu1_Load(object sender, EventArgs e)
        {

        }

        private void GalleriaBT_Click(object sender, EventArgs e)
        {
            galleria1.BringToFront();
        }

        private void Palaute_Click(object sender, EventArgs e)
        {
            palaute1.BringToFront();
        }
    }
}
