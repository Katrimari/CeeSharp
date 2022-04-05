using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6_s._24_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ibonus;
        alku:
            Console.Write("Anna bonusten määrä: (1-9): ");
            try
            {
                ibonus = Int32.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Antamasi arvo ei ollut kokonaisluku!");
                goto alku;
            }
            switch (ibonus)
            {
                case 1:
                case 2:
                case 3:
                    ibonus *= 3;
                    break;
                case 4:
                case 5:
                case 6:
                    ibonus *= 100;
                    break;
                case 7:
                case 8:
                case 9:
                    ibonus *= 1000;
                    break;
                default:
                    Console.WriteLine("Antamasi arvo ei ole välillä 1-9.");
                    goto alku;
                    break;
            }
            Console.WriteLine("Bonus saldosi on: " + ibonus);
            Console.Read();
        }
    }
}
