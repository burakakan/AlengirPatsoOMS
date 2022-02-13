
namespace AlengirPatso
{
    partial class TumSiparisler
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
            this.lstSiparisler = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCiro = new System.Windows.Forms.Label();
            this.lblToplamSipSayisi = new System.Windows.Forms.Label();
            this.lblSatilanUrunSayisi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstSiparisler
            // 
            this.lstSiparisler.FormattingEnabled = true;
            this.lstSiparisler.HorizontalScrollbar = true;
            this.lstSiparisler.Location = new System.Drawing.Point(20, 46);
            this.lstSiparisler.Name = "lstSiparisler";
            this.lstSiparisler.Size = new System.Drawing.Size(367, 420);
            this.lstSiparisler.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(413, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ciro:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(413, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Toplam Sipariş Sayısı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(413, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Satılan Ürün Sayısı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(17, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Sipariş Listesi";
            // 
            // lblCiro
            // 
            this.lblCiro.AutoSize = true;
            this.lblCiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCiro.Location = new System.Drawing.Point(413, 69);
            this.lblCiro.Name = "lblCiro";
            this.lblCiro.Size = new System.Drawing.Size(46, 16);
            this.lblCiro.TabIndex = 5;
            this.lblCiro.Text = "lblCiro";
            // 
            // lblToplamSipSayisi
            // 
            this.lblToplamSipSayisi.AutoSize = true;
            this.lblToplamSipSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamSipSayisi.Location = new System.Drawing.Point(413, 148);
            this.lblToplamSipSayisi.Name = "lblToplamSipSayisi";
            this.lblToplamSipSayisi.Size = new System.Drawing.Size(126, 16);
            this.lblToplamSipSayisi.TabIndex = 6;
            this.lblToplamSipSayisi.Text = "lblToplamSipSayisi";
            // 
            // lblSatilanUrunSayisi
            // 
            this.lblSatilanUrunSayisi.AutoSize = true;
            this.lblSatilanUrunSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSatilanUrunSayisi.Location = new System.Drawing.Point(413, 241);
            this.lblSatilanUrunSayisi.Name = "lblSatilanUrunSayisi";
            this.lblSatilanUrunSayisi.Size = new System.Drawing.Size(128, 16);
            this.lblSatilanUrunSayisi.TabIndex = 7;
            this.lblSatilanUrunSayisi.Text = "lblSatilanUrunSayisi";
            // 
            // TumSiparisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 481);
            this.Controls.Add(this.lblSatilanUrunSayisi);
            this.Controls.Add(this.lblToplamSipSayisi);
            this.Controls.Add(this.lblCiro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstSiparisler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TumSiparisler";
            this.Text = "TumSiparisler";
            this.Load += new System.EventHandler(this.TumSiparisler_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstSiparisler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCiro;
        private System.Windows.Forms.Label lblToplamSipSayisi;
        private System.Windows.Forms.Label lblSatilanUrunSayisi;
    }
}