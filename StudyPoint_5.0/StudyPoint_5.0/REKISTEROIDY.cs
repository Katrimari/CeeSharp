using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;

namespace StudyPoint_5._0
{
    public partial class REKISTEROIDY : UserControl
    {
        //OPISKELIJA oppilas = new OPISKELIJA();
        YHDISTA yhteys = new YHDISTA();
        public REKISTEROIDY()
        {
            InitializeComponent();
        }

        private void REKISTEROIDY_Load(object sender, EventArgs e)
        {
            
        }
        public bool lisaaopiskelija(String enimi, String snimi, String puh, String email, String lahos, String ptp, string pnro)
        {
            MySqlCommand cmd = new MySqlCommand();
            String kayttis = enimi.Substring(0, 3).ToLower() + snimi.Substring(0, 4).ToLower();//Luodaan käyttäjätunnuts jossa etunimen 3 ekaa kirjainta ja sukunimen 4 ekaa kirjainta.
            String salis = salisS();
            String kysely = "INSERT INTO opiskelija (etunimi, sukunimi, puhelin, sahkoposti, lahiosoite, postitoimipaikka, postinro, kayttaja, salasana) VALUES (@enm, @snm, @puh, @eml, @lahos, @ptp, @pnro, @usr, @ssa);";
            cmd.Connection = yhteys.otaYhteys();
            cmd.CommandText = kysely;

            cmd.Parameters.Add("@enm", MySqlDbType.VarChar).Value = enimi;
            cmd.Parameters.Add("@snm", MySqlDbType.VarChar).Value = snimi;
            cmd.Parameters.Add("@puh", MySqlDbType.VarChar).Value = puh;
            cmd.Parameters.Add("@eml", MySqlDbType.VarChar).Value = email;
            cmd.Parameters.Add("@lahos", MySqlDbType.VarChar).Value = lahos;
            cmd.Parameters.Add("@ptp", MySqlDbType.VarChar).Value = ptp;
            cmd.Parameters.Add("@pnro", MySqlDbType.VarChar).Value = pnro;
            cmd.Parameters.Add("@usr", MySqlDbType.VarChar).Value = kayttis;
            cmd.Parameters.Add("@ssa", MySqlDbType.VarChar).Value = salis;

            MessageBox.Show("Käyttäjätunnuksesi: " + kayttis + "\nSalasanasi: " + salis + "\n Kirjoita nämä talteen kirjautumista varten!");

            yhteys.openConnection();
            if (cmd.ExecuteNonQuery() == 1) //jos toteutettava komento (cmd) toimii
            {
                yhteys.closeConnection();
                EnimiTB.Text = "";
                SnimiTB.Text = "";
                PuhTB.Text = "";
                EmailTB.Text = "";
                LahOsTB.Text = "";
                PtpTB.Text = "";
                PosNroTB.Text = "";

                return true;
            }
            else
            {
                yhteys.closeConnection();
                return false;
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            
            String enimi = EnimiTB.Text;
            String snimi = SnimiTB.Text;
            String puh = PuhTB.Text;
            String email = EmailTB.Text;
            String lahos = LahOsTB.Text;
            String ptp = PtpTB.Text;
            String pnro = PosNroTB.Text;
            
                
            if (enimi.Trim().Equals("") || snimi.Trim().Equals("") || puh.Trim().Equals("") || email.Trim().Equals("") || lahos.Trim().Equals("") || ptp.Trim().Equals("") || pnro.Equals(""))
            {
                MessageBox.Show("Täytyä kaikki kentät!", "Tyhjä kenttä", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            else
            {
                  Boolean lisaaoppilas = lisaaopiskelija(enimi, snimi, puh, email, lahos, ptp, pnro);
                {
                   if (lisaaoppilas)
                   {
                        MessageBox.Show("uusi opiskelija lisätty", "opiskelijan lisäys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   }
                   else
                   {
                        MessageBox.Show("Uutta opiskelijaa ei pysty lisäämään", "opiskelijan lisäys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   }
                }
               
            }

        }

       

        public String salisS()
        {
            char[] merkit = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'j', 'k', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
            String salis = "";
            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                int randInt = rand.Next(0, 59);
                salis += merkit[randInt];
            }
            return salis;
        }

        

    }
}
