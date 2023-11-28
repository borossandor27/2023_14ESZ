using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime
{
    class Program
    {
        static void Main(string[] args)
        {
            //-- Bekérem az adatot
            int szam = adatBekeres();

            //-- megvizsgálom


            //-- Kiírom az eredményt
            Kiiratas(szam);
            Console.WriteLine("\nProgram vége!");
            Console.ReadLine();
        }

        private static void Kiiratas(int szam)
        {
            string eredmeny = "";
            if (prime(szam))
            {
                Console.WriteLine($"{szam} prím szám");
            }
            else
            {
                Console.WriteLine($"{szam} NEM prím");
            }
            
        }

        private static bool prime(int szam)
        {
            int osztokSzam = 0;
            for (int i = 1; i < szam; i++)
            {
                if (szam%i==0)
                {
                    osztokSzam++;
                }
            }
            return (osztokSzam < 2);
        }

        private static int adatBekeres()
        {
            int szam = 0;
            if (!int.TryParse(Console.ReadLine(),out szam))
            {
                Console.WriteLine("Nem megfelelő bemeneti érték");
                Environment.Exit(0);
            }
            return szam;
        }
    }
}
