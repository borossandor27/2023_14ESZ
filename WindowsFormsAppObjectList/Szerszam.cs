using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppObjectList
{
    class Szerszam
    {
        public int szerszamId;
        public string megnevezes;
        public decimal egysegar;
        public decimal darabszam;

        public Szerszam(int szerszamId, string megnevezes, decimal egysegar, decimal darabszam)
        {
            this.szerszamId = szerszamId;
            this.megnevezes = megnevezes;
            this.egysegar = egysegar;
            this.darabszam = darabszam;
        }
        public override string ToString()
        {
            return $"{megnevezes} ({darabszam} db)";
        }
        public string toCSV()
        {
            return $"{szerszamId};{megnevezes};{egysegar};{darabszam}";
        }
    }
}
