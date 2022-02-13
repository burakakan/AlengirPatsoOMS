using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlengirPatso
{
    public class Siparis
    {
        public Siparis(List<Menu> menuler, List<Ekstra> ekstralar)
        {
            Menuler = menuler;
            Ekstralar = ekstralar;
        }
        public List<Menu> Menuler { get; set; }
        public List<Ekstra> Ekstralar { get; set; }
        public double Tutar
        {
            get
            {
                double toplam = 0;
                foreach (Menu menu in Menuler)
                    toplam += menu.SonFiyat;

                foreach (Ekstra ekstra in Ekstralar)
                    toplam += ekstra.Fiyat;
                return toplam;
            }
        }
        public override string ToString()
        {
            string str = "";
            foreach (Menu menu in Menuler)
                str += menu.Ad + " (" + Menu.BoyStr(menu.BoySecimi) + "), ";
            
            foreach (Ekstra ekstra in Ekstralar)
                str += ekstra.Ad + ", ";
            
            try
            {
                return str.Remove(str.Length - 2);
            }
            catch
            {
                return "";
            }
        }
    }
}
