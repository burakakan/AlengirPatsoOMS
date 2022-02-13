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
            Ad = ad;
            Fiyat = fiyat;
        }
        public override string ToString() => Ad + "     - " + Fiyat.ToString() + " TL";
    }
}
