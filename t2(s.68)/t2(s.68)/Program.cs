using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t2_s._68_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("muunnettava celsius: ");
            double c = Convert.ToDouble(Console.ReadLine());
            double f = ((c * 1.8) + 32);
            Console.WriteLine(c + " celsiuc asteen lämpötila on Fahrenheit asteina: " + f);
            Console.Read();
        }
    }
}
