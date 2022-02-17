using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t6_s._16_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String luku1, luku2;
            int summa;
            Console.Write("Anna eka luku: ");
            luku1 = Console.ReadLine();
            Console.Write("Anna Toka luku: ");
            luku2 = Console.ReadLine();
            summa = Int32.Parse(luku1) +int.Parse(luku2);
            Console.WriteLine(summa);
            Console.Read();
        }
    }
}
