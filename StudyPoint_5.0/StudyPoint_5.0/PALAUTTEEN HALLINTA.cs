using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace StudyPoint_5._0
{
    public partial class PALAUTTEEN_HALLINTA : UserControl
    {
        
        public PALAUTTEEN_HALLINTA()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idLB.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            EnimiLB.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            SnimiLB.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            emailLB.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            viestiTB.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void PALAUTTEEN_HALLINTA_Load(object sender, EventArgs e)
        {
            OPISKELIJA oppilas = new OPISKELIJA();
            YHDISTA yhteys = new YHDISTA();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM `palaute`", yhteys.otaYhteys());
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = oppilas.etsiviesti();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PoistaBT_Click(object sender, EventArgs e)
        {
            OPISKELIJA oppilas = new OPISKELIJA();
            String palaute = viestiTB.Text;
            if (oppilas.poistaviesti(palaute))
            {

                MessageBox.Show("Palaute poistettu", "Palautteen poisto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                idLB.Text = "ID";
                EnimiLB.Text = "Etunimi";
                SnimiLB.Text = "Sukunimi";
                emailLB.Text = "Sähköposti";
                viestiTB.Text = "";
            }
            else
            {
                MessageBox.Show("Palautetta ei pystytty poistamaan", "Palautteen poisto poisto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            dataGridView1.DataSource = oppilas.etsiviesti();
        }



    }
        
    
}
