using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4_s._24_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] luvut = new int[5];
        alku:
            try
            {
                Console.WriteLine("Anna 1. kokonaisluku: ");
                luvut[0] = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Anna 2. kokonaisluku: ");
                luvut[1] = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Anna 3. kokonaisluku: ");
                luvut[2] = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Anna 4. kokonaisluku: ");
                luvut[3] = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Anna 5. kokonaisluku: ");
                luvut[4] = Int32.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Antamasi luvut eivät olleet kokonaislukuja!");
                goto alku;
            }

            Array.Sort(luvut);
            int viimeinen = luvut.Length;
            Console.WriteLine("Suurin luku oli: " + luvut[viimeinen - 1]);
            Console.Read();
        }
    }
}

