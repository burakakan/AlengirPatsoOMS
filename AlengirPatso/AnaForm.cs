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
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }
        internal void tsmSiparisAl_Click(object sender, EventArgs e)
        {
            FormSiparisAl SiparisAl1 = new FormSiparisAl
            {
                MdiParent = this,
                Dock = DockStyle.Fill
            };
            SiparisAl1.Show();
        }

        private void tsmSiparisleriGoster_Click(object sender, EventArgs e)
        {
            TumSiparisler tumSiparisler = new TumSiparisler
            {
                MdiParent = this,
                Dock = DockStyle.Fill
            };
            tumSiparisler.Show();
        }

        private void ürünEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UrunEkle urunEkle = new UrunEkle
            {
                MdiParent = this,
                Dock = DockStyle.Fill
            };
            urunEkle.Show();
        }
        public static BindingList<Menu> MenuListesi = new BindingList<Menu>
            { new Menu("Menü Seçilmedi", 0),
              new Menu("Klasik Patso", 15),
              new Menu("Sosisli Patso", 20),
              new Menu("Goralı", 17) };

        public static BindingList<Ekstra> EkstraListesi = new BindingList<Ekstra>
            { new Ekstra("Turşu",6),
              new Ekstra("Biber",6),
              new Ekstra("Amerikan",6) };

        private void AnaForm_Load(object sender, EventArgs e)
        {
            MenuListesi.RaiseListChangedEvents = false;
            EkstraListesi.RaiseListChangedEvents = false;
        }
    }
}
