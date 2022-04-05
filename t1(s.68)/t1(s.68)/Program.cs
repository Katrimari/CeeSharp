using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1_s._68_
{
    internal class Program
    {
        static void Main(string[] args)
        {
             int laskeyhteen(int x, int y)
            {
                return (x + y);
            }
            int luku1, luku2, summa;
            Console.Write("Anna ensimmäinen Yhteenlaskettava luku: ");
            luku1 = int.Parse(Console.ReadLine());
            Console.Write("Anna toinen yhteenlaskettava luku: ");
            luku2 = int.Parse(Console.ReadLine());
            summa = laskeyhteen(luku2, luku1);
            Console.WriteLine(summa);
            Console.Read();
        }
    }
}
