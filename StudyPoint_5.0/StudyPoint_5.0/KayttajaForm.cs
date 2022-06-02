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
    public partial class KayttajaForm : Form
    {
        DataTable valinta = new DataTable();

        public KayttajaForm()
        {
            InitializeComponent();
            
        }
        
        private void etusivu1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            etusivu1.BringToFront();
        }

        private void OrganiBT_Click(object sender, EventArgs e)
        {
            organisaatiomme1.BringToFront();
        }

        private void PalveluBT_Click(object sender, EventArgs e)
        {
            palvelumme1.BringToFront();
        }

        private void KayttajaForm_Load(object sender, EventArgs e)
        {
            etusivu1.BringToFront();
            
        }

        

        private void SalasanaBT_Click(object sender, EventArgs e)
        {
            salasana1.BringToFront();
        }

        private void ulosBT_Click(object sender, EventArgs e)
        {
            DialogResult Exit;

            try
            {
                Exit = MessageBox.Show("Haluatko varmasti poistua?", "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (Exit == DialogResult.Yes)
                {
                    Application.Exit();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GalleriaBT_Click(object sender, EventArgs e)
        {
            galleria1.BringToFront();
        }

        private void OhjeBT_Click(object sender, EventArgs e)
        {
            ohjeita1.BringToFront();
        }

        private void LataukseBT_Click(object sender, EventArgs e)
        {

        }

        private void PalauteBT_Click(object sender, EventArgs e)
        {
            palaute1.BringToFront();
        }

        
    }
}
