using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AlengirPatso.AnaForm;

namespace AlengirPatso
{
    public class Urun
    {
        public Urun(string ad, double fiyat)
        {
            Ad = ad;
            Fiyat = fiyat;
        }
        public double Fiyat { get; set; }
        public string Ad { get; set; }
        //public int UrunID
        //{
        //    get { return MenuListesi.Count() + EkstraListesi.Count(); }
        //    set { UrunID = value; }
        //}
    }
}
