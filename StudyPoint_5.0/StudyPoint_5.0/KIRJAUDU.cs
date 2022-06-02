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
using System.Diagnostics;
using MySql.Data.MySqlClient;

namespace StudyPoint_5._0
{
    public partial class KIRJAUDU : UserControl
    {
        YHDISTA yhteys = new YHDISTA();

        
        
        public KIRJAUDU()
        {
            InitializeComponent();
        }

        private void KIRJAUDU_Load(object sender, EventArgs e)
        {
           
        }

        

        /*public TextBox tbText
        {
            get
            {
                return KayttajatnsTB;
            }
        }*/

        private void KirjauduBT01_Click(object sender, EventArgs e)
        {
            alku:
            try
            {



                String usr = KayttajatnsTB.Text;
                String pass = SalasanaTB.Text;

                MySqlDataAdapter adapter = new MySqlDataAdapter();
                DataTable dt = new DataTable();
                MySqlCommand cmd = new MySqlCommand();

                String kysely = "SELECT * FROM `opiskelija` WHERE `kayttaja` = @usn and `salasana` = @pss";
                String kysely2 = "SELECT * FROM `admin` WHERE `kayttaja` = @usn and `salasana` = @pss";
                cmd.Connection = yhteys.otaYhteys();
                if (usr == "admin")
                {
                    cmd.CommandText = kysely2;
                    
                }
                else
                {
                    cmd.CommandText = kysely;
                    
                
                }
                

                cmd.Parameters.Add("@usn", MySqlDbType.VarChar).Value = usr;
                cmd.Parameters.Add("@pss", MySqlDbType.VarChar).Value = pass;

                adapter.SelectCommand = cmd;

                adapter.Fill(dt);

          

                // Tarkastetaan löytyykö käyttäjää tietokannasta.
                if (dt.Rows.Count > 0)
                {
                    KayttajaForm form2 = new KayttajaForm();
                    AdminForm adminForm = new AdminForm();
                    

                    
                    if(usr == "admin")
                    {
                        

                        adminForm.Show();
                        ((Form1)this.TopLevelControl).Hide();
                    }
                    else
                    {
                        form2.Show();
                        ((Form1)this.TopLevelControl).Hide();
                    }

                     
                 


                }
                else
                {
                    if (usr.Trim().Equals(""))
                    {
                        MessageBox.Show("Kirjoita käyttäjätunnus", "Virheellinen käyttäjätunnus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (pass.Trim().Equals(""))
                    {
                        MessageBox.Show("Kirjoita salasana", "Virheellinen salasana", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("väärä käyttäjätunnus tai salasana", "Virhe sisäänkirjautumisessa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("jokin meni vikaan", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                goto alku;
            }

            
        }

       /* public string send
        {
            get
            {

                return KayttajatnsTB.Text;
            }
        }*/

    }
}
