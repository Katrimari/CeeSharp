using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3_s._24_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kluku1;
            int luku1;

        alku:
            Console.WriteLine("Ohjelma pyysttä sinulta luvun jonka muuttaa sanaksi. luvun pitää olla väliltä 1-9");
            Console.Write("Anna luku:");
            kluku1 = Console.ReadLine();
            try
            {
                luku1 = Int32.Parse(kluku1);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("antamasi luku ei ollut kokonaisluku");
                goto alku;
            }
            switch (luku1)
            {
                case 1:
                    Console.WriteLine("Yksi");
                    break;
                case 2:
                    Console.WriteLine("Kaksi");
                    break ;
                case 3:
                    Console.WriteLine("Kolme");
                    break;
                case 4:
                    Console.WriteLine("Neljä");
                    break;
                case 5:
                    Console.WriteLine("viisi");
                    break;
                case 6:
                    Console.WriteLine("Kuusi");
                    break;
                case 7:
                    Console.WriteLine("Seitsemän");
                    break;
                case 8:
                    Console.WriteLine("Kahdeksan");
                    break;
                case 9:
                    Console.WriteLine("Yhdeksän");
                    break;
                default:
                    Console.WriteLine("Antamasi arvo ei ollut väliltä 1-9");
                    goto alku;

            }
            Console.Read();
        }
    }
}
