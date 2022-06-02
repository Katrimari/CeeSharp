using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace StudyPoint_5._0
{
    internal class YHDISTA
    {
        private MySqlConnection yhteys = new MySqlConnection("datasource=localhost; port=3306;username=root;password=;database=studypoint;SSL Mode = None");

        public MySqlConnection otaYhteys()//tällä funktiolla otetaan yhteys MySql:ään
        {
            return yhteys;
        }

        public void openConnection() //tällä funktiolla avataan yhteys MySql:ään. (void koska ei palauta mitään)
        {
            if (yhteys.State == ConnectionState.Closed)
            {
                yhteys.Open(); //Muista lisätä using System.Data että toimii!
            }
        }

        public void closeConnection() //Suljetaan yhteys
        {
            if (yhteys.State == ConnectionState.Open)
            {
                yhteys.Close();
            }
        }
    }
}
