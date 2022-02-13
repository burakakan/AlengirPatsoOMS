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
            Buyuk
        }
        public Menu(string ad, double bazFiyat) : base(ad, bazFiyat)
        {
            Ad = ad;
            Fiyat = bazFiyat;
        }
        public Menu(string ad, double bazFiyat, Boy boySecimi) : base(ad, bazFiyat)
        {
            Ad = ad;
            Fiyat = bazFiyat;
            BoySecimi = boySecimi;
        }
        public Boy BoySecimi { get; set; }
        public double SonFiyat => Fiyat + (BoySecimi.GetHashCode() * 2);
        public override string ToString() => Ad + " (" + BoyStr(BoySecimi) + ") - " + SonFiyat.ToString() + " TL";
        public string ForComboBox => Ad + "       - " + Fiyat.ToString() + " TL";
        public static string BoyStr(Menu.Boy b)
        {
            switch (b)
            {
                case Boy.Kucuk:
                    return "Küçük";
                case Boy.Orta:
                    return "Orta";
                case Boy.Buyuk:
                    return "Büyük";
                default:
                    return "";
            }
        }
    }
}
