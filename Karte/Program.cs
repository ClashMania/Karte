using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karte
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int karta = 0, zbroj = 0;
            do
            {
                Console.WriteLine("Unesi broj od 1 do 13: ");
                karta = Convert.ToInt32(Console.ReadLine());
                if (karta >= 1 && karta <= 13)
                {
                    zbroj += karta;
                }
            }
            while (zbroj < 31);
            if (zbroj == 31)
            {
                Console.WriteLine("Pobjedili ste");
            }
            else
            {
                Console.WriteLine("Izgubili ste");
            }
            Console.ReadKey();

        }
    }
}