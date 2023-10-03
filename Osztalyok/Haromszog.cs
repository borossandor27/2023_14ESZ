using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osztalyok
{
    class Haromszog : Sikidom
    {
        public int oldalA,oldalB,oldalC;

        public string haromszogTipusa;
        public Haromszog(int oldalA, int oldalB, int oldalC) :base("háromszög")
        {
            this.oldalA = oldalA;
            this.oldalB = oldalB;
            this.oldalC = oldalC;
            if (oldalA==oldalB && oldalB==oldalC)
            {
                haromszogTipusa = "egyenlő oldalú";
            }
            else if ((oldalA==oldalB && oldalB !=oldalC) || (oldalA==oldalC && oldalC!=oldalB)|| (oldalB==oldalC && oldalC !=oldalA))
            {
                haromszogTipusa = "egyenlő szárú";
            }
            else
            {
                haromszogTipusa = "általános háromszög";
            }
        }

        public override double Terulet()
        {
            double s = (this.oldalA + this.oldalB + this.oldalC) / 2;
            double T = Math.Sqrt(s * (s - this.oldalA) * (s - this.oldalB) * (s - this.oldalC));
            return T;
        }

        public override double Kerulet()
        {
            return this.oldalA + this.oldalB + this.oldalC;
        }
    }
}
