using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CryptausEncryptaus
{
    internal class YHTEYS
    {
        private MySqlConnection yhteys = new MySqlConnection("datasource=localhost; port=3306; username=root; password=;database=salasana; SSL Mode=None");
        // datasourse=tietokannan sijainti; port=tietokannan portti; username=Käyttäjä tietokantaan; password=salasana tietokantaan; database=Käytetyn tiedoston sijainti tietokannassa; SSL Mode= salatunyhteyden tila;

        public MySqlConnection otaYhteys()//tällä funktiolla otetaan yhteys MySql tietokantaan
        {
            return yhteys;
            
        }

        public void openConnection() //tällä funktiolla avataan yhteys MySql tiewtokantaan. (void koska ei palauta mitään)
        {
            if (yhteys.State == ConnectionState.Closed) //jos yhteys on suljettu, avataan yhteys.
            {
                yhteys.Open(); //Muista lisätä using System.Data että toimii!

            }
        }

        public void closeConnection() //Suljetaan yhteys tietokantaan.
        {
            if (yhteys.State == ConnectionState.Open) //jos yhteys on avoinna, suljetaan se.
            {
                yhteys.Close();
            }
        }
    }
}
