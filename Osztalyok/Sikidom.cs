using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osztalyok
{
    abstract class Sikidom
    {
        public string tipus;

        public Sikidom(string tipus)
        {
            this.tipus = tipus;
        }

        abstract public double Kerulet();

        abstract public double Terulet();
    }
}
