using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AlengirPatso.AnaForm;

namespace AlengirPatso
{
    public partial class FormSiparisAl : Form
    {
        public static List<Menu> eklenmisMenuler = new List<Menu>();
        public static List<Ekstra> eklenmisEkstralar = new List<Ekstra>();
        public FormSiparisAl()
        {
            InitializeComponent();
        }

        private void FormSiparisAl_Load(object sender, EventArgs e)
        {
            cboMenuSecim.DataSource = MenuListesi;
            cboMenuSecim.DisplayMember = "ForComboBox";

            Kucuk.Tag = 0;
            Orta.Tag = 1;
            Buyuk.Tag = 2;
            Orta.Checked = true;

            for (int i = 0; i < EkstraListesi.Count; i++)
            {
                CheckBox box = new CheckBox();
                box.Tag = EkstraListesi.ElementAt(i);
                box.Text = EkstraListesi.ElementAt(i).Ad;
                box.Location = new Point(42 + (i % 3) * 83, 342 + (i / 3) * 30);       //temp. solution
                box.AutoSize = true;
                this.Controls.Add(box);
            }
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (cboMenuSecim.SelectedIndex != 0)
            {
                Menu m = (Menu)cboMenuSecim.SelectedItem;

                Menu.Boy boySecimi = (Menu.Boy)Controls.OfType<RadioButton>().FirstOrDefault(opt => opt.Checked).Tag;

                Menu secilmisMenu = new Menu(m.Ad, m.Fiyat, boySecimi);

                eklenmisMenuler.Add(secilmisMenu);
                lstSiparisler.Items.Add(secilmisMenu);
            }
            foreach (CheckBox box in Controls.OfType<CheckBox>())
            {
                if (box.Checked)
                {
                    Ekstra ekstra = (Ekstra)box.Tag;
                    eklenmisEkstralar.Add(ekstra);
                    lstSiparisler.Items.Add(ekstra);
                }
            }
            Utilities.ResetAllControls(this);
            Orta.Checked = true;
        }

        private void btnSonlandir_Click(object sender, EventArgs e)
        {
            Siparis siparis = new Siparis(eklenmisMenuler, eklenmisEkstralar);
            TumSiparisler.tamamlanmisSiparisler.Add(siparis);

            Utilities.ResetAllControls(this);
            Utilities.ResetAllControls(groupBox1);
            Orta.Checked = true;

            string baslik = "Sipariş Alındı.";
            string mesaj = String.Format("{0} menü ve {1} ekstra siparişi alındı.\nTutar: {2} TL", eklenmisMenuler.Count(), eklenmisEkstralar.Count(), siparis.Tutar);

            MessageBox.Show(mesaj, baslik, MessageBoxButtons.OK, MessageBoxIcon.Information);

            eklenmisMenuler = new List<Menu>();
            eklenmisEkstralar = new List<Ekstra>();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            List<object> cikarilacaklar = new List<object>();
            if (lstSiparisler.SelectedIndex != -1)
                foreach (object entry in lstSiparisler.SelectedItems)
                {
                    if (entry is Ekstra)
                        eklenmisEkstralar.Remove((Ekstra)entry);
                    else if(entry is Menu)
                        eklenmisMenuler.Remove((Menu)entry);

                    cikarilacaklar.Add(entry);
                }
            foreach (object urun in cikarilacaklar)
                lstSiparisler.Items.Remove(urun);
        }
    }
}