using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlausurLebedeva
{
    class Produkt
    {
        private int nr;
        private string bez;
        private double preis;
        private int lagerbest;

        public Produkt(int nr, string bez, double preis, int lagerbest)
        {
            this.nr = nr;
            this.bez = bez;
            this.preis = preis;
            this.lagerbest = lagerbest;
        }

        public string getBez()
        {
            return this.bez;
        }

        public double getPreis()
        {
            return this.preis;
        }

        public int getLagerbest()
        {
            return this.lagerbest;
        }

        public void setLagerbest(int lagerbest)
        {
            this.lagerbest = lagerbest;
        }

        public override string ToString()
        {
            return this.nr.ToString() + "|" + this.bez +
                "|" + this.preis.ToString() + "|" + this.lagerbest.ToString();
        }
    }
}
