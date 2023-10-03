using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osztalyok
{
    class Negyzet : Sikidom
    {
        int oldalA;

        public Negyzet(int oldal) : base("négyzet")
        {
            OldalA = oldal;
        }

        public int OldalA { get => oldalA; 
            set {
                if (value>0)
                {
                    oldalA = value;
                }
                else
                {
                    throw new Exception();
                }
            } 
        }

        public override double Kerulet()
        {
            return 4 * this.oldalA;
        }

        public override double Terulet()
        {
            return this.oldalA * this.oldalA;
        }
    }
}
