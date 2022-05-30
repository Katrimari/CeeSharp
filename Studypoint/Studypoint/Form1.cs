using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Studypoint
{
    public partial class EtusivuFM : Form
    {
        public EtusivuFM()
        {
            InitializeComponent();
        }

        private void LogInBT_Click(object sender, EventArgs e)
        {
            LogInPL.Visible = true;
            EtusivuPL.Visible = false;
        }

        private void EtusivuBT_Click(object sender, EventArgs e)
        {
            LogInPL.Visible=false;
            EtusivuPL.Visible=true;
        }

        private void RegistrationBT_Click(object sender, EventArgs e)
        {
            RekisteroidyPL.Visible = true;
            EtusivuPL.Visible = false;
        }

        private void Etusivu02BT_Click(object sender, EventArgs e)
        {
            RekisteroidyPL.Visible=false;
            EtusivuPL.Visible=true;
        }

        private void Registration02BT_Click(object sender, EventArgs e)
        {
            RekisteroidyPL.Visible = true;
            LogInPL.Visible = false;
        }
    }
}
