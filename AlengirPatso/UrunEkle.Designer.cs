
namespace AlengirPatso
{
    partial class UrunEkle
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
            this.optMenu = new System.Windows.Forms.RadioButton();
            this.optEkstra = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.btnUrunEkle = new System.Windows.Forms.Button();
            this.lstMenuler = new System.Windows.Forms.ListBox();
            this.lstEkstralar = new System.Windows.Forms.ListBox();
            this.btnCikar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grpEkle = new System.Windows.Forms.GroupBox();
            this.grpEkle.SuspendLayout();
            this.SuspendLayout();
            // 
            // optMenu
            // 
            this.optMenu.AutoSize = true;
            this.optMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.optMenu.Location = new System.Drawing.Point(13, 61);
            this.optMenu.Name = "optMenu";
            this.optMenu.Size = new System.Drawing.Size(59, 20);
            this.optMenu.TabIndex = 0;
            this.optMenu.TabStop = true;
            this.optMenu.Text = "Menü";
            this.optMenu.UseVisualStyleBackColor = true;
            // 
            // optEkstra
            // 
            this.optEkstra.AutoSize = true;
            this.optEkstra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.optEkstra.Location = new System.Drawing.Point(101, 61);
            this.optEkstra.Name = "optEkstra";
            this.optEkstra.Size = new System.Drawing.Size(64, 20);
            this.optEkstra.TabIndex = 1;
            this.optEkstra.TabStop = true;
            this.optEkstra.Text = "Ekstra";
            this.optEkstra.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(9, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ürün Tipi";
            // 
            // txtAd
            // 
            this.txtAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.Location = new System.Drawing.Point(12, 120);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(218, 22);
            this.txtAd.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(10, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ürün Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(10, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ürün Fiyatı";
            // 
            // txtFiyat
            // 
            this.txtFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFiyat.Location = new System.Drawing.Point(13, 177);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(217, 22);
            this.txtFiyat.TabIndex = 5;
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunEkle.Location = new System.Drawing.Point(12, 219);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(218, 33);
            this.btnUrunEkle.TabIndex = 7;
            this.btnUrunEkle.Text = "Ekle";
            this.btnUrunEkle.UseVisualStyleBackColor = true;
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // lstMenuler
            // 
            this.lstMenuler.FormattingEnabled = true;
            this.lstMenuler.Location = new System.Drawing.Point(260, 36);
            this.lstMenuler.Name = "lstMenuler";
            this.lstMenuler.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstMenuler.Size = new System.Drawing.Size(208, 433);
            this.lstMenuler.TabIndex = 8;
            // 
            // lstEkstralar
            // 
            this.lstEkstralar.FormattingEnabled = true;
            this.lstEkstralar.Location = new System.Drawing.Point(478, 36);
            this.lstEkstralar.Name = "lstEkstralar";
            this.lstEkstralar.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstEkstralar.Size = new System.Drawing.Size(208, 433);
            this.lstEkstralar.TabIndex = 9;
            // 
            // btnCikar
            // 
            this.btnCikar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikar.Location = new System.Drawing.Point(23, 346);
            this.btnCikar.Name = "btnCikar";
            this.btnCikar.Size = new System.Drawing.Size(218, 33);
            this.btnCikar.TabIndex = 11;
            this.btnCikar.Text = "Seçilen Ürünleri Çıkar";
            this.btnCikar.UseVisualStyleBackColor = true;
            this.btnCikar.Click += new System.EventHandler(this.btnCikar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(271, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Menüler";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(482, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Ekstralar";
            // 
            // grpEkle
            // 
            this.grpEkle.Controls.Add(this.label1);
            this.grpEkle.Controls.Add(this.optMenu);
            this.grpEkle.Controls.Add(this.optEkstra);
            this.grpEkle.Controls.Add(this.txtAd);
            this.grpEkle.Controls.Add(this.label2);
            this.grpEkle.Controls.Add(this.txtFiyat);
            this.grpEkle.Controls.Add(this.btnUrunEkle);
            this.grpEkle.Controls.Add(this.label3);
            this.grpEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpEkle.Location = new System.Drawing.Point(12, 17);
            this.grpEkle.Name = "grpEkle";
            this.grpEkle.Size = new System.Drawing.Size(242, 266);
            this.grpEkle.TabIndex = 14;
            this.grpEkle.TabStop = false;
            this.grpEkle.Text = "Ürün Ekle";
            // 
            // UrunEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 481);
            this.Controls.Add(this.grpEkle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCikar);
            this.Controls.Add(this.lstEkstralar);
            this.Controls.Add(this.lstMenuler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UrunEkle";
            this.Text = "UrunEkle";
            this.Load += new System.EventHandler(this.UrunEkle_Load);
            this.grpEkle.ResumeLayout(false);
            this.grpEkle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton optMenu;
        private System.Windows.Forms.RadioButton optEkstra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.Button btnUrunEkle;
        private System.Windows.Forms.ListBox lstMenuler;
        private System.Windows.Forms.ListBox lstEkstralar;
        private System.Windows.Forms.Button btnCikar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grpEkle;
    }
}