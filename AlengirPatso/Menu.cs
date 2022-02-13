using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlengirPatso
{
    public class Menu : Urun
    {
        public enum Boy
        {
            Kucuk,
            Orta,
            Buyuk,
        }
        public Menu(string ad, double bazFiyat) : base(ad, bazFiyat)
        {
            this.Ad = ad;
            this.Fiyat = bazFiyat;
        }
        public Menu(string ad, double bazFiyat, Boy boySecimi) : base(ad, bazFiyat)
        {
            this.Ad = ad;
            this.Fiyat = bazFiyat;
            this.BoySecimi = boySecimi;
        }
        public Boy BoySecimi { get; set; }

        public double SonFiyat
        {
            get { return Fiyat + (BoySecimi.GetHashCode() * 2); }
        }
        public override string ToString()
        {
            return Ad + " (" + BoySecimi + ") - " + SonFiyat.ToString() + " TL";
        }
        public string ToString(bool comboBox)
        {
            return Ad + "       - " + Fiyat.ToString() + " TL";
        }
        public string ForComboBox { get { return ToString(true); } }
    }
}
