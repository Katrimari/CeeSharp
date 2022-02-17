using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KayttajanNimi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Kerro etu nimesi");
            string nimi = Console.ReadLine();
            Console.Write("Hei " + nimi);
            Console.Read();
        }
    }
}
