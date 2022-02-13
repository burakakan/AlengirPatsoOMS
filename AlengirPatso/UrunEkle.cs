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
    public partial class UrunEkle : Form
    {
        public UrunEkle()
        {
            InitializeComponent();

            lstMenuler.DataSource = MenuListesi;
            lstMenuler.DisplayMember = "ForComboBox";
            lstEkstralar.DataSource = EkstraListesi;
            lstMenuler.SelectedIndex = -1;
            lstEkstralar.SelectedIndex = -1;
        }
        private void UrunEkle_Load(object sender, EventArgs e)
        {
            optMenu.Checked = true;
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            if (optMenu.Checked)
            {
                MenuListesi.Add(new Menu(txtAd.Text, Convert.ToDouble(txtFiyat.Text)));
                RefreshList(lstMenuler, MenuListesi);
            }
            else
            {
                EkstraListesi.Add(new Ekstra(txtAd.Text, Convert.ToDouble(txtFiyat.Text)));
                RefreshList(lstEkstralar, EkstraListesi);
            }

            string baslik = "Ürün Eklendi.";
            string mesaj = "Ürün Tipi: " + ((optMenu.Checked) ? "Menü" : "Ekstra") + "\nAdı: " + txtAd.Text + "\nFiyatı: " + txtFiyat.Text + " TL";

            Utilities.ResetAllControls(grpEkle);

            MessageBox.Show(mesaj, baslik, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCikar_Click(object sender, EventArgs e)
        {
            if (lstMenuler.SelectedIndex != -1)
                foreach (object entry in lstMenuler.SelectedItems)
                    MenuListesi.Remove((Menu)entry);

            RefreshList(lstMenuler, MenuListesi);

            if (lstEkstralar.SelectedIndex != -1)
                foreach (object entry in lstEkstralar.SelectedItems)
                    EkstraListesi.Remove((Ekstra)entry);

            RefreshList(lstEkstralar, EkstraListesi);
        }
        void RefreshList(ListBox listBox, BindingList<Menu> source)
        {
            source.RaiseListChangedEvents = true;
            source.ResetBindings();
            listBox.SelectedIndex = -1;
            source.RaiseListChangedEvents = false;
        }
        void RefreshList(ListBox listBox, BindingList<Ekstra> source)
        {
            source.RaiseListChangedEvents = true;
            source.ResetBindings();
            listBox.SelectedIndex = -1;
            source.RaiseListChangedEvents = false;
        }
    }
}