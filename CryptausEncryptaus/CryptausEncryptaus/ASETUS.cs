using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace CryptausEncryptaus
{
    internal class ASETUS
    {
        YHTEYS yhteys = new YHTEYS();

        public DataTable etsi()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM salasana", yhteys.otaYhteys()); 
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);
            DataRow itemrow = dt.NewRow();
            itemrow[1] = "valitse";
            dt.Rows.InsertAt(itemrow, 0);
            return dt;
            
        }
    }
}
