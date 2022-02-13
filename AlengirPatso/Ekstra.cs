using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlengirPatso
{
    public class Ekstra : Urun
    {
        public Ekstra(string ad, double fiyat) : base(ad, fiyat)
        {
            this.Ad = ad;
            this.Fiyat = fiyat;
        }
        public override string ToString()
        {
            return Ad + "     - " + Fiyat.ToString() + " TL";
        }
    }
}
