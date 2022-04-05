using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sivu_69
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valitse;
        alku:
            Console.WriteLine("Valitse suoritettava ohjelma alla:");
            Console.WriteLine("1. Käyttäjän ikä");
            Console.WriteLine("2. Toista luku");
            Console.WriteLine("3. Kirjain paikan vaihto");
            Console.WriteLine("4. Tarkistaa onko luku positiivinen vai negatiivinen");
            Console.WriteLine("5. Tulostaa lauseen pisimmän sanan");
            Console.WriteLine("6. Tulostaa parittomat luvut väliltä 1-99");
            Console.WriteLine("7. tulostaa kolmella jaolliset luvut väliltä 1-99");
            try
            {
                valitse = Int32.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Antamasi luvun pitää olla kokonaisluku");
                goto alku;
            }
            switch (valitse)
            {
                case 1:
                    Ika();
                    break;
                case 2:
                    Toista();
                    break;
                case 3:
                    Vaihto();
                    break;
                case 4:
                    PosNeg();
                    break;
                case 5:
                    Pisin();
                    break;
                case 6:
                    Riton();
                    break;
                case 7:
                    Jaollinen();
                    break;
                default:
                    Console.WriteLine("Valitse luku väliltä 1-7");
                    goto alku;
                    break;
            }
            void Ika()
            {
                string ika;
                Console.Write("Kerro ikäsi: ");
                ika = Console.ReadLine();
                Console.WriteLine("{0} näytät ikäistäsi nuoremmalat :)", ika);
            }
            void Toista()
            {
                int luku;
                talku:
                try
                {
                    Console.WriteLine("Anna luku joka on suurempi kun 10");
                    luku = Int32.Parse(Console.ReadLine());
                    if(luku < 10)
                    {
                        Console.WriteLine("Luvun pitää olla 10 tai suurempi");
                        goto talku;
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Luvun pitää olla kokonaisluku");
                    goto talku;
                }
                for(int i=0; i<luku; i++)
                {
                    for(int j=0; j<luku; j++)
                    {
                        Console.Write(luku + " ");
                    }
                    Console.WriteLine();
                    for(int k=0; k<luku; k++)
                    {
                        Console.Write(luku);
                    }
                    Console.WriteLine();
                }

            }
            void Vaihto()
            {
                string sana, uusi;
                int pituus;
                Console.WriteLine("Kirjoita sana, ohjelma vaihtaa sanan ensimmäisen ja viimeisen kirjaimen keskenään: ");
                sana = Console.ReadLine();
                pituus = sana.Length;
                char[] taulukko = new char[pituus];
                for(int i=0; i<pituus; i++)
                {
                    taulukko[i] = sana[i];
                }
                taulukko[0] = sana[pituus -1];
                taulukko[pituus - 1] = sana[0];
                uusi = String.Join("", taulukko);
                Console.WriteLine("Antamasi sana oli {0} sanan uusi muoto on {1}", sana, uusi);
            }
            void PosNeg()
            {
                int l1, l2;
            palku:
                Console.WriteLine("Anna ohjelmalle kaksi lukua ja se tarkastaa onko luvut positiivisia vai negatiivisia");
                try
                {
                    Console.WriteLine("anna eka luku: ");
                    l1 = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("anna toinen luku: ");
                    l2 = Int32.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Arvojen täytyy olla kokonaislukuja");
                    goto palku;
                }
                if (l1 >= 0 && l2 >= 0)
                {
                    Console.WriteLine("Luvut on positiivisia");
                }
                else if(l1 < 0 && l2 < 0)
                {
                    Console.WriteLine("Luvut on negatiivisia");
                }
                else
                {
                    Console.WriteLine("Luvuista toinen on positiivinen ja toinen negatiivinen");
                }
            }
            void Pisin()
            {
                Console.WriteLine("Tämä ohjelma pyytää käyttäjältä lauseen ja palauttaa tästä pisimmin sanan.");
                string lause;
                Console.Write("Anna lause: ");
                lause = Console.ReadLine();
                string[] taulu = lause.Split(' ');
                string pisin = taulu[0];
                for (int i = 1; i < taulu.Length; i++)
                {
                    if (taulu[i].Length > pisin.Length)
                    {
                        pisin = taulu[i];
                    }
                }
                Console.WriteLine("Antamasi lause oli {0}, jonka pisin sana oli {1}.", lause, pisin);
            }
            void Riton()
            {
                Console.WriteLine("Tämä ohjelma tulostaa parittomat luvut väliltä 1-99");
                for (int i = 1; i <= 99; i += 2)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
            void Jaollinen()
            {
                Console.WriteLine("Tämä ohjelma tulostaa kolmella jaolliset luvut väliltä 1-99.");
                for (int i = 3; i <= 99; i += 3)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
