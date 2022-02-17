using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1_sivu_24_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kluku1, kluku2;
            int luku1, luku2;
            ljalku:
            Console.WriteLine("Ohjelma pyytää sinulta kahta kokonaislukua ja tulostaa ne suuruus järjestyksessä");
            Console.WriteLine("anna eka luku: ");
            kluku1 = Console.ReadLine();
            Console.WriteLine("anna toka luku: ");
            kluku2 = Console.ReadLine();
            try
            {
                luku1 = Int32.Parse(kluku1);
                luku2 = Int32.Parse(kluku2);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Antamasi arvot eivät olleet kokonaislukuja");
                goto ljalku;
            }
            if(luku1 < luku2)
            {
                Console.WriteLine("lukujen järjestys {0}, {1}", luku1, luku2);
            }
            else
            {
                Console.WriteLine("lukujen järjestys {0}, {1}", luku2, luku1);
            }
            Console.ReadLine();
        }
    }
}
