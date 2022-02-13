using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlengirPatso
{
    public partial class TumSiparisler : Form
    {
        public static List<Siparis> tamamlanmisSiparisler = new List<Siparis>();
        public TumSiparisler()
        {
            InitializeComponent();
        }
        private void TumSiparisler_Load(object sender, EventArgs e)
        {
            lstSiparisler.DataSource = tamamlanmisSiparisler;

            lblCiro.Text = tamamlanmisSiparisler.Sum(s => s.Tutar).ToString() + " TL";

            lblToplamSipSayisi.Text = tamamlanmisSiparisler.Count().ToString();

            lblSatilanUrunSayisi.Text = tamamlanmisSiparisler.Sum(s => s.Ekstralar.Count() + s.Menuler.Count()).ToString();
        }
    }
}
