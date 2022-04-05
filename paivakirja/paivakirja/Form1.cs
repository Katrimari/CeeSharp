using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paivakirja
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string teksti = File.ReadAllText("C:\\Users\\Katri\\source\\repot\\CeeSharp\\paivakirja\\paivakirja.txt");
            SyoteTB.Text = teksti;
        }


        private void TallennaBT_Click(object sender, EventArgs e)
        {
            string teksti = "";
            teksti += SyoteTB.Text;
            teksti += " " + DateTime.Now.ToString("dd.MM.yyyy HH:mm") + "\n";
            TextWriter text = new StreamWriter("C:\\Users\\Katri\\source\\repot\\CeeSharp\\paivakirja\\paivakirja.txt");
            text.Write(teksti);
            text.Close();
            Application.Exit();
        }
    }
}
