using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t3_s._68_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            alku:
            string kluku;
            int luku;
            Console.WriteLine("Valitse suoritettava ohjelma:");
            Console.WriteLine("3. 4 laskutoimitusta.");
            Console.WriteLine("4. laske jakojäännös");
            Console.WriteLine("5. Kerro nimesi");
            Console.WriteLine("6. Muutetaan lasketaan kaksi numeroa yhteen");
            Console.WriteLine("7. Muutetaan Celciukset Fahrenheiteiksi");
            Console.WriteLine("8. lasketaan 4 laskutoimitusta, käyttäjän asettamalla arvolla");
            Console.WriteLine("9. Lasketaan kahden käyttäjän antaman arvon jakojäännös");
            Console.WriteLine("10. anna luku, ohjelma kertoo kertotaulun");
            try
            {
                kluku = Console.ReadLine();
                luku = Int32.Parse(kluku);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine("antamasi syöte on virheellinen");
                goto alku;
            }
            switch (luku)
            {
                case 3:
                    Peruslaskut(8, 5);
                    break;
                case 4:
                    JakoJaannos(5, 2);
                    break;
                case 5:
                    Nimi();
                    break;
                case 6:
                    KayttajanLasku();
                    break;
                case 7:
                    Celsius();
                    break;
                case 8:
                    Laskut();
                    break;
                case 9:
                    KayttajanJakoJaannos();
                    break;
                case 10:
                    Kertotaulu();
                    break;
                    default:
                    Console.WriteLine("Et antanut lukua väliltä 3-10");
                    goto alku;
            }
             void Peruslaskut(int a, int b)
            {
                int summa, tulo, erotus;
                double jako;
                summa = a + b;
                tulo = a * b;
                erotus = a - b;
                jako = (double)a / b;
                Console.WriteLine("lukujen " + a + " sekä " + b);
                Console.WriteLine("summa " + summa);
                Console.WriteLine("erotus " + erotus);
                Console.WriteLine("tulo " + tulo);
                Console.WriteLine("Osamäärä " + jako);
            }
            void JakoJaannos(int a, int b)
            {
                int jakoj = a % b;
                Console.WriteLine("Lukujen " + a + " ja " + b);
                Console.WriteLine("Jakojäännös on " + jakoj);
            }
            void Nimi()
            {
               //Tähän pitää keksia try catch
                string nimi;
                Console.WriteLine("kerro minulle nimesi ja saat viestin.");
                nimi = Console.ReadLine();
                Console.WriteLine("Hei " + nimi + " tänään on kiva päivä");
            }
            void KayttajanLasku(){
                int luku1, luku2, summa;
                Console.WriteLine("Kerro minulle 2 lukua ja lasken ne yhteen");
                xalku:
                try
                {
                    Console.Write("Anna ensimmäinen luku: ");
                    luku1 = Int32.Parse(Console.ReadLine());
                    Console.Write("Anna toinen luku: ");
                    luku2 = Int32.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Antamasi luku/luvut eivät olleet kokonaislukuja");
                    goto xalku;
                }
                summa = luku1 + luku2;
                Console.WriteLine("antamiesi lukujen summa on " + summa);
            }
            void Celsius()
            {
                double cluku, fluku;
                Console.WriteLine("Muuta antamasi Celsiusaste Fahrenheiteiksi.");
            falku:
                try
                {
                    Console.WriteLine("Anna muutettava celssiusaste :");
                    cluku = Double.Parse(Console.ReadLine());
                }
                catch(Exception ex)
                {
                    Console.WriteLine (ex.Message);
                    Console.WriteLine("Anna arvo numeroina (esim. 1)");
                    goto falku;
                }
                fluku = (cluku * 1.8) + 32;
                Console.WriteLine(cluku + " astetta celssiusta on " + fluku + "Farenheit astetta");
            }
            void Laskut()
            {
                Console.WriteLine("Tämä ohjelma laskee peruslaskutoimitukset luvuista jotka määrität");
                int l1, l2, summa, erotus, tulo;
                double osamaara;
                lalku:
                try
                {
                    Console.Write("Anna ensimmäinen kokonaisluku: ");
                    l1 = Int32.Parse(Console.ReadLine());
                    Console.Write("Anna toinen kokonaisluku: ");
                    l2 = Int32.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Antamasi luvujen täytyy olla kokonaislukuja.");
                    goto lalku;
                }
                summa = l1 + l2;
                erotus = l1 - l2;
                tulo = l1 * l2;
                osamaara = (double)l1 / l2;
                Console.WriteLine("Lukujen " + l1 + "ja " + l2 + " laskutoimitusten tulokset ovat: ");
                Console.WriteLine("Summa: " + summa);
                Console.WriteLine("Erotus: " + erotus);
                Console.WriteLine("Tulo: " + tulo);
                Console.WriteLine("Osamäärä: " + osamaara);
            }
            void KayttajanJakoJaannos()
            {
                Console.WriteLine("Ohjelma laskee jakojäännöksen antamistasi luvuista.");
                int jl1, jl2, jakoj;
            kjalku:
                try
                {
                    Console.Write("Anna jaettava luku: ");
                    jl1 = Int32.Parse(Console.ReadLine());
                    Console.Write("Anna jakava luku: ");
                    jl2 = Int32.Parse(Console.ReadLine());
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Luvut jotka annoit eivät ole kokonaislukuja.");
                    goto kjalku;
                }
                jakoj = jl1 % jl2;
                Console.WriteLine("Lukujen " + jl1 + " & " + jl2 + "jakojäännös on " + jakoj);
            }
            void Kertotaulu()
            {
                Console.WriteLine("Anna kokonaisluku niin muutan sen kertotauluksi");
                int yluku;
            kalku:
                try
                {
                    yluku = Int32.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Antamasi luku ei ollut kokonaisluku. anna uusi luku");
                    goto kalku;
                }
                Console.WriteLine(" 1 x " + yluku + " = " + (1 * yluku));
                Console.WriteLine(" 2 x " + yluku + " = " + (2 * yluku));
                Console.WriteLine(" 3 x " + yluku + " = " + (3 * yluku));
                Console.WriteLine(" 4 x " + yluku + " = " + (4 * yluku));
                Console.WriteLine(" 5 x " + yluku + " = " + (5 * yluku));
                Console.WriteLine(" 6 x " + yluku + " = " + (6 * yluku));
                Console.WriteLine(" 7 x " + yluku + " = " + (7 * yluku));
                Console.WriteLine(" 8 x " + yluku + " = " + (8 * yluku));
                Console.WriteLine(" 9 x " + yluku + " = " + (9 * yluku));
                Console.WriteLine("10 x " + yluku + " = " + (10 * yluku));
            }

            Console.Read();
        }
    }
}
