
namespace AlengirPatso
{
    partial class FormSiparisAl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboMenuSecim = new System.Windows.Forms.ComboBox();
            this.Kucuk = new System.Windows.Forms.RadioButton();
            this.Orta = new System.Windows.Forms.RadioButton();
            this.Buyuk = new System.Windows.Forms.RadioButton();
            this.lblEkstralar = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSonlandir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnIptal = new System.Windows.Forms.Button();
            this.lstSiparisler = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboMenuSecim
            // 
            this.cboMenuSecim.FormattingEnabled = true;
            this.cboMenuSecim.Location = new System.Drawing.Point(12, 221);
            this.cboMenuSecim.Name = "cboMenuSecim";
            this.cboMenuSecim.Size = new System.Drawing.Size(281, 21);
            this.cboMenuSecim.TabIndex = 1;
            this.cboMenuSecim.Text = "Menü Seçin";
            // 
            // Kucuk
            // 
            this.Kucuk.AutoSize = true;
            this.Kucuk.Location = new System.Drawing.Point(42, 265);
            this.Kucuk.Name = "Kucuk";
            this.Kucuk.Size = new System.Drawing.Size(56, 17);
            this.Kucuk.TabIndex = 2;
            this.Kucuk.TabStop = true;
            this.Kucuk.Text = "Küçük";
            this.Kucuk.UseVisualStyleBackColor = true;
            // 
            // Orta
            // 
            this.Orta.AutoSize = true;
            this.Orta.Location = new System.Drawing.Point(125, 265);
            this.Orta.Name = "Orta";
            this.Orta.Size = new System.Drawing.Size(45, 17);
            this.Orta.TabIndex = 3;
            this.Orta.TabStop = true;
            this.Orta.Text = "Orta";
            this.Orta.UseVisualStyleBackColor = true;
            // 
            // Buyuk
            // 
            this.Buyuk.AutoSize = true;
            this.Buyuk.Location = new System.Drawing.Point(208, 265);
            this.Buyuk.Name = "Buyuk";
            this.Buyuk.Size = new System.Drawing.Size(55, 17);
            this.Buyuk.TabIndex = 4;
            this.Buyuk.TabStop = true;
            this.Buyuk.Text = "Büyük";
            this.Buyuk.UseVisualStyleBackColor = true;
            // 
            // lblEkstralar
            // 
            this.lblEkstralar.AutoSize = true;
            this.lblEkstralar.Location = new System.Drawing.Point(39, 312);
            this.lblEkstralar.Name = "lblEkstralar";
            this.lblEkstralar.Size = new System.Drawing.Size(48, 13);
            this.lblEkstralar.TabIndex = 8;
            this.lblEkstralar.Text = "Ekstralar";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(12, 435);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(281, 34);
            this.btnEkle.TabIndex = 10;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSonlandir
            // 
            this.btnSonlandir.Location = new System.Drawing.Point(510, 435);
            this.btnSonlandir.Name = "btnSonlandir";
            this.btnSonlandir.Size = new System.Drawing.Size(175, 34);
            this.btnSonlandir.TabIndex = 11;
            this.btnSonlandir.Text = "Siparişi Sonlandır";
            this.btnSonlandir.UseVisualStyleBackColor = true;
            this.btnSonlandir.Click += new System.EventHandler(this.btnSonlandir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::AlengirPatso.Properties.Resources.branchs__LTiLV9ss7Ug8ExhDRXS_products__LTiO773B4TnSdAa_dE3_QKhQoWK6T0ceAPZiBCQngZYaQB13;
            this.pictureBox1.Location = new System.Drawing.Point(12, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(281, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(321, 435);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(175, 34);
            this.btnIptal.TabIndex = 12;
            this.btnIptal.Text = "Seçilenleri İptal Et";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // lstSiparisler
            // 
            this.lstSiparisler.FormattingEnabled = true;
            this.lstSiparisler.Location = new System.Drawing.Point(6, 19);
            this.lstSiparisler.Name = "lstSiparisler";
            this.lstSiparisler.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstSiparisler.Size = new System.Drawing.Size(352, 394);
            this.lstSiparisler.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstSiparisler);
            this.groupBox1.Location = new System.Drawing.Point(321, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 420);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Eklenen Ürünler";
            // 
            // FormSiparisAl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 481);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnSonlandir);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lblEkstralar);
            this.Controls.Add(this.Buyuk);
            this.Controls.Add(this.Orta);
            this.Controls.Add(this.Kucuk);
            this.Controls.Add(this.cboMenuSecim);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSiparisAl";
            this.Text = "FormSiparisAl";
            this.Load += new System.EventHandler(this.FormSiparisAl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cboMenuSecim;
        private System.Windows.Forms.RadioButton Kucuk;
        private System.Windows.Forms.RadioButton Orta;
        private System.Windows.Forms.RadioButton Buyuk;
        private System.Windows.Forms.Label lblEkstralar;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSonlandir;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.ListBox lstSiparisler;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}