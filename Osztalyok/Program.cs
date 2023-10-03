using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osztalyok
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Sikidom> sikidoms = new List<Sikidom>();
            sikidoms.Add(new Negyzet(4));
            sikidoms.Add(new Teglalap(3, 7));
            sikidoms.Add(new Negyzet(5));
            sikidoms.Add(new Teglalap(2, 4));
            sikidoms.Add(new Negyzet(5));
            sikidoms.Add(new Teglalap(5, 3));
            sikidoms.Add(new Negyzet(12));
            sikidoms.Add(new Teglalap(2, 7));
            sikidoms.Add(new Haromszog(4, 4, 4));
            sikidoms.Add(new Haromszog(5, 5, 3));
            sikidoms.Add(new Haromszog(2, 3, 4));

            foreach (Sikidom item in sikidoms)
            {
                if (item.GetType().Equals(typeof(Haromszog)))
                {
                    Haromszog haromszog = (Haromszog)item;
                    Console.WriteLine("\n" + haromszog.haromszogTipusa);
                }
                Console.WriteLine($"A {item.tipus} kerülete: {item.Kerulet()}, területe: {item.Terulet()}");

            }

            Console.ReadLine();

        }
    }
}
