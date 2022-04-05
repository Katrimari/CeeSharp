using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2_s._24_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] luvut = new int[3];
        alku:
            try
            {
                Console.WriteLine("Anna 1. kokonaisluku: ");
                luvut[0] = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Anna 2. kokonaisluku: ");
                luvut[1] = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Anna 3. kokonaisluku: ");
                luvut[2] = Int32.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("syötä kokonaislukuja!");
                goto alku;
            }

            Array.Sort(luvut);
            int viimeinen = luvut.Length;
            Console.WriteLine("Suurin luku oli: " + luvut[viimeinen - 1]);
            Console.Read();
        }
    }
}
