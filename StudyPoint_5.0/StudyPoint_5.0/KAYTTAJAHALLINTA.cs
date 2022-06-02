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
    public partial class KAYTTAJAHALLINTA : UserControl
    {
        YHDISTA yhteys = new YHDISTA();
        OPISKELIJA oppilas = new OPISKELIJA(); 
        
        
        public KAYTTAJAHALLINTA()
        {
            InitializeComponent();
        }
        
        private void ExitBT_Click(object sender, EventArgs e)
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

        private void ResetBT_Click(object sender, EventArgs e)
        {
            EnimiTB.Text = "";
            SnimiTB.Text = "";
            PuhTB.Text = "";
            EmailTB.Text = "";
            LahOsTB.Text = "";
            PtpTB.Text = "";
            PosNroTB.Text = "";
            UserTB.Text = "";
            passTB.Text = "";
            idTB.Text = "";

            
        }


        private void LisaaBT_Click(object sender, EventArgs e)
        {
            string enimi = EnimiTB.Text;
            string snimi = SnimiTB.Text;
            string puh = PuhTB.Text;
            string email = EmailTB.Text;
            string lahos = LahOsTB.Text;
            string ptp = PtpTB.Text;
            string pnro = PosNroTB.Text;
            string kayttaja = UserTB.Text;
            string salasana = passTB.Text;


            MySqlCommand cmd = new MySqlCommand();
            

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
            cmd.Parameters.Add("@usr", MySqlDbType.VarChar).Value = kayttaja;
            cmd.Parameters.Add("@ssa", MySqlDbType.VarChar).Value = salasana;




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
                UserTB.Text = "";
                passTB.Text = "";
                idTB.Text = "";
            }
            else
            {
                yhteys.closeConnection();
                
            }
            TiedotDG.DataSource = oppilas.getStudent();

        }

    

        private void paivitaBT_Click(object sender, EventArgs e)
        {
            
            MySqlCommand cmd = new MySqlCommand();
            String muokkaa = "UPDATE `opiskelija` SET `etunimi` = @enm, `sukunimi` = @snm, `puhelin` = @puh,`sahkoposti` = @eml, `lahiosoite` = @lahos, `postitoimipaikka` = @ptp, `postinro`  =@pnro,`kayttaja` = @kayt, `salasana`= @ssa WHERE Oid=@oid";

            cmd.Connection = yhteys.otaYhteys();
            cmd.CommandText = muokkaa;

            int oid = Int32.Parse(idTB.Text);
            string enimi = EnimiTB.Text;
            string snimi = SnimiTB.Text;
            string puh = PuhTB.Text;
            string email = EmailTB.Text;
            string lahos = LahOsTB.Text;
            string ptp = PtpTB.Text;
            string pnro = PosNroTB.Text;
            string kayttaja = UserTB.Text;
            string salasana = passTB.Text;

            if (enimi.Trim().Equals("") || snimi.Trim().Equals("") || puh.Trim().Equals("") || email.Trim().Equals("") || lahos.Trim().Equals("") || ptp.Trim().Equals("") || pnro.Trim().Equals("") || kayttaja.Trim().Equals("") || salasana.Trim().Equals(""))
            {
                MessageBox.Show("Täytyä kaikki kentät!", "Tyhjä kenttä", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                

                cmd.Parameters.Add("@oid", MySqlDbType.UInt32).Value = oid;
                cmd.Parameters.Add("@enm", MySqlDbType.VarChar).Value = enimi;
                cmd.Parameters.Add("@snm", MySqlDbType.VarChar).Value = snimi;
                cmd.Parameters.Add("@puh", MySqlDbType.VarChar).Value = puh;
                cmd.Parameters.Add("@eml", MySqlDbType.VarChar).Value = email;
                cmd.Parameters.Add("@lahos", MySqlDbType.VarChar).Value = lahos;
                cmd.Parameters.Add("@ptp", MySqlDbType.VarChar).Value = ptp;
                cmd.Parameters.Add("@pnro", MySqlDbType.VarChar).Value = pnro;
                cmd.Parameters.Add("@kayt", MySqlDbType.VarChar).Value = kayttaja;
                cmd.Parameters.Add("@ssa", MySqlDbType.VarChar).Value = salasana;

                yhteys.openConnection();
                if (cmd.ExecuteNonQuery() == 1)
                {
                    yhteys.closeConnection();
                    idTB.Text = "";
                    EnimiTB.Text = "";
                    SnimiTB.Text = "";
                    PuhTB.Text = "";
                    EmailTB.Text = "";
                    LahOsTB.Text = "";
                    PtpTB.Text = "";
                    PosNroTB.Text = "";
                    UserTB.Text = "";
                    passTB.Text = "";


                }
                else
                {
                    yhteys.closeConnection();

                }
                TiedotDG.DataSource = oppilas.getStudent();
            }
        }

        private void PoistaBT_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand();
            String kayttis = idTB.Text;
            if (oppilas.poista(kayttis))
            {
                
                MessageBox.Show("Opiskelijan tiedot poistettu", "Tietojen poisto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                idTB.Text = "";
                EnimiTB.Text = "";
                SnimiTB.Text = "";
                PuhTB.Text = "";
                EmailTB.Text = "";
                LahOsTB.Text = "";
                PtpTB.Text = "";
                PosNroTB.Text = "";
                UserTB.Text = "";
                passTB.Text = "";
            }
            else
            {
                MessageBox.Show("Tietoja ei pystytty poistamaan", "Tietojen poisto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            TiedotDG.DataSource = oppilas.getStudent();
        }

        private void KAYTTAJAHALLINTA_Load(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT `oid`, `etunimi`,`sukunimi`,`puhelin`,`sahkoposti`,`lahiosoite`,`postitoimipaikka`, `postinro`, `kayttaja`,`salasana` FROM `opiskelija`", yhteys.otaYhteys());
            TiedotDG.ReadOnly = true;
            TiedotDG.DataSource = oppilas.getStudent();
        }

       

        private void TiedotDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idTB.Text = TiedotDG.CurrentRow.Cells[0].Value.ToString();
            EnimiTB.Text = TiedotDG.CurrentRow.Cells[1].Value.ToString();
            SnimiTB.Text = TiedotDG.CurrentRow.Cells[2].Value.ToString();
            PuhTB.Text = TiedotDG.CurrentRow.Cells[3].Value.ToString();
            EmailTB.Text = TiedotDG.CurrentRow.Cells[4].Value.ToString();
            LahOsTB.Text = TiedotDG.CurrentRow.Cells[5].Value.ToString();
            PtpTB.Text = TiedotDG.CurrentRow.Cells[6].Value.ToString();
            PosNroTB.Text = TiedotDG.CurrentRow.Cells[7].Value.ToString();
            UserTB.Text = TiedotDG.CurrentRow.Cells[8].Value.ToString();
            passTB.Text = TiedotDG.CurrentRow.Cells[9].Value.ToString();
        }

        private void TiedotDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
