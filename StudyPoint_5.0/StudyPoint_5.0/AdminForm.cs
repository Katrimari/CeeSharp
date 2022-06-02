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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void PoistuBT_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            etusivu1.BringToFront();
        }

        private void KayttajaBT_Click(object sender, EventArgs e)
        {
            kayttajahallinta1.BringToFront();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            etusivu1.BringToFront();
        }

        private void KyselytBT_Click(object sender, EventArgs e)
        {
            
        }

        private void PalauteHallintaBT_Click(object sender, EventArgs e)
        {
            palautteeN_HALLINTA1.BringToFront();
        }
    }
}
