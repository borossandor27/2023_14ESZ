using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osztalyok
{
    class Teglalap : Sikidom
    {
        int oldalA;
        int oldalB;

        public Teglalap(int oldalA, int oldalB) : base("téglalap")
        {
            this.OldalA = oldalA;
            this.OldalB = oldalB;
        }

        public int OldalA { get => oldalA; set => oldalA = value; }
        public int OldalB { get => oldalB; set => oldalB = value; }



        public override double Kerulet()
        {
            return 2 * this.oldalA + 2 * oldalB;
        }

        public override double Terulet()
        {
            return this.oldalA * this.oldalB;
        }
    }
}
