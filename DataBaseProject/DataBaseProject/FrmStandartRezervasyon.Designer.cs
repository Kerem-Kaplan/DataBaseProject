
namespace DataBaseProject
{
    partial class FrmStandartRezervasyon
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
            this.BtnGeri = new System.Windows.Forms.Button();
            this.TxtGunSayisi = new System.Windows.Forms.TextBox();
            this.LblGunSayisi = new System.Windows.Forms.Label();
            this.LblToplamUcret = new System.Windows.Forms.Label();
            this.LblToplamTutar = new System.Windows.Forms.Label();
            this.LblRezSure = new System.Windows.Forms.Label();
            this.LblRezSuresi = new System.Windows.Forms.Label();
            this.LblRezBasTarihi = new System.Windows.Forms.Label();
            this.DtpTarih = new System.Windows.Forms.DateTimePicker();
            this.LblUcret = new System.Windows.Forms.Label();
            this.LblTutar = new System.Windows.Forms.Label();
            this.TxtİstenenMail = new System.Windows.Forms.TextBox();
            this.BtnRezYap = new System.Windows.Forms.Button();
            this.LblİletisimMail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnGeri
            // 
            this.BtnGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGeri.Location = new System.Drawing.Point(527, 508);
            this.BtnGeri.Margin = new System.Windows.Forms.Padding(4);
            this.BtnGeri.Name = "BtnGeri";
            this.BtnGeri.Size = new System.Drawing.Size(241, 42);
            this.BtnGeri.TabIndex = 31;
            this.BtnGeri.Text = "Geri";
            this.BtnGeri.UseVisualStyleBackColor = true;
            this.BtnGeri.Click += new System.EventHandler(this.BtnGeri_Click);
            // 
            // TxtGunSayisi
            // 
            this.TxtGunSayisi.Location = new System.Drawing.Point(463, 392);
            this.TxtGunSayisi.Margin = new System.Windows.Forms.Padding(4);
            this.TxtGunSayisi.Name = "TxtGunSayisi";
            this.TxtGunSayisi.Size = new System.Drawing.Size(319, 22);
            this.TxtGunSayisi.TabIndex = 30;
            // 
            // LblGunSayisi
            // 
            this.LblGunSayisi.AutoSize = true;
            this.LblGunSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGunSayisi.Location = new System.Drawing.Point(98, 386);
            this.LblGunSayisi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblGunSayisi.Name = "LblGunSayisi";
            this.LblGunSayisi.Size = new System.Drawing.Size(127, 29);
            this.LblGunSayisi.TabIndex = 29;
            this.LblGunSayisi.Text = "Gün Sayisi";
            // 
            // LblToplamUcret
            // 
            this.LblToplamUcret.AutoSize = true;
            this.LblToplamUcret.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblToplamUcret.Location = new System.Drawing.Point(841, 318);
            this.LblToplamUcret.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblToplamUcret.Name = "LblToplamUcret";
            this.LblToplamUcret.Size = new System.Drawing.Size(165, 29);
            this.LblToplamUcret.TabIndex = 28;
            this.LblToplamUcret.Text = "Toplam Ucret:";
            // 
            // LblToplamTutar
            // 
            this.LblToplamTutar.AutoSize = true;
            this.LblToplamTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblToplamTutar.Location = new System.Drawing.Point(1019, 321);
            this.LblToplamTutar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblToplamTutar.Name = "LblToplamTutar";
            this.LblToplamTutar.Size = new System.Drawing.Size(66, 29);
            this.LblToplamTutar.TabIndex = 27;
            this.LblToplamTutar.Text = "label";
            // 
            // LblRezSure
            // 
            this.LblRezSure.AutoSize = true;
            this.LblRezSure.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRezSure.Location = new System.Drawing.Point(841, 249);
            this.LblRezSure.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblRezSure.Name = "LblRezSure";
            this.LblRezSure.Size = new System.Drawing.Size(112, 29);
            this.LblRezSure.TabIndex = 26;
            this.LblRezSure.Text = "RezSure:";
            // 
            // LblRezSuresi
            // 
            this.LblRezSuresi.AutoSize = true;
            this.LblRezSuresi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRezSuresi.Location = new System.Drawing.Point(1019, 249);
            this.LblRezSuresi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblRezSuresi.Name = "LblRezSuresi";
            this.LblRezSuresi.Size = new System.Drawing.Size(66, 29);
            this.LblRezSuresi.TabIndex = 25;
            this.LblRezSuresi.Text = "label";
            // 
            // LblRezBasTarihi
            // 
            this.LblRezBasTarihi.AutoSize = true;
            this.LblRezBasTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRezBasTarihi.Location = new System.Drawing.Point(98, 315);
            this.LblRezBasTarihi.Name = "LblRezBasTarihi";
            this.LblRezBasTarihi.Size = new System.Drawing.Size(336, 29);
            this.LblRezBasTarihi.TabIndex = 24;
            this.LblRezBasTarihi.Text = "Rezervasyon Başlangıç Tarihi:";
            // 
            // DtpTarih
            // 
            this.DtpTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpTarih.Location = new System.Drawing.Point(463, 321);
            this.DtpTarih.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DtpTarih.Name = "DtpTarih";
            this.DtpTarih.Size = new System.Drawing.Size(319, 22);
            this.DtpTarih.TabIndex = 23;
            // 
            // LblUcret
            // 
            this.LblUcret.AutoSize = true;
            this.LblUcret.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUcret.Location = new System.Drawing.Point(98, 142);
            this.LblUcret.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblUcret.Name = "LblUcret";
            this.LblUcret.Size = new System.Drawing.Size(157, 29);
            this.LblUcret.TabIndex = 22;
            this.LblUcret.Text = "Günlük Ücret:";
            // 
            // LblTutar
            // 
            this.LblTutar.AutoSize = true;
            this.LblTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTutar.Location = new System.Drawing.Point(283, 142);
            this.LblTutar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTutar.Name = "LblTutar";
            this.LblTutar.Size = new System.Drawing.Size(66, 29);
            this.LblTutar.TabIndex = 21;
            this.LblTutar.Text = "label";
            // 
            // TxtİstenenMail
            // 
            this.TxtİstenenMail.Location = new System.Drawing.Point(463, 256);
            this.TxtİstenenMail.Margin = new System.Windows.Forms.Padding(4);
            this.TxtİstenenMail.Name = "TxtİstenenMail";
            this.TxtİstenenMail.Size = new System.Drawing.Size(319, 22);
            this.TxtİstenenMail.TabIndex = 20;
            // 
            // BtnRezYap
            // 
            this.BtnRezYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRezYap.Location = new System.Drawing.Point(527, 440);
            this.BtnRezYap.Margin = new System.Windows.Forms.Padding(4);
            this.BtnRezYap.Name = "BtnRezYap";
            this.BtnRezYap.Size = new System.Drawing.Size(241, 42);
            this.BtnRezYap.TabIndex = 19;
            this.BtnRezYap.Text = "Rezervasyon Yap";
            this.BtnRezYap.UseVisualStyleBackColor = true;
            this.BtnRezYap.Click += new System.EventHandler(this.BtnRezYap_Click);
            // 
            // LblİletisimMail
            // 
            this.LblİletisimMail.AutoSize = true;
            this.LblİletisimMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblİletisimMail.Location = new System.Drawing.Point(98, 249);
            this.LblİletisimMail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblİletisimMail.Name = "LblİletisimMail";
            this.LblİletisimMail.Size = new System.Drawing.Size(64, 29);
            this.LblİletisimMail.TabIndex = 18;
            this.LblİletisimMail.Text = "Mail:";
            // 
            // FrmStandartRezervasyon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1396, 712);
            this.Controls.Add(this.BtnGeri);
            this.Controls.Add(this.TxtGunSayisi);
            this.Controls.Add(this.LblGunSayisi);
            this.Controls.Add(this.LblToplamUcret);
            this.Controls.Add(this.LblToplamTutar);
            this.Controls.Add(this.LblRezSure);
            this.Controls.Add(this.LblRezSuresi);
            this.Controls.Add(this.LblRezBasTarihi);
            this.Controls.Add(this.DtpTarih);
            this.Controls.Add(this.LblUcret);
            this.Controls.Add(this.LblTutar);
            this.Controls.Add(this.TxtİstenenMail);
            this.Controls.Add(this.BtnRezYap);
            this.Controls.Add(this.LblİletisimMail);
            this.Name = "FrmStandartRezervasyon";
            this.Text = "FrmStandartRezervasyon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGeri;
        private System.Windows.Forms.TextBox TxtGunSayisi;
        private System.Windows.Forms.Label LblGunSayisi;
        private System.Windows.Forms.Label LblToplamUcret;
        private System.Windows.Forms.Label LblToplamTutar;
        private System.Windows.Forms.Label LblRezSure;
        private System.Windows.Forms.Label LblRezSuresi;
        private System.Windows.Forms.Label LblRezBasTarihi;
        private System.Windows.Forms.DateTimePicker DtpTarih;
        private System.Windows.Forms.Label LblUcret;
        private System.Windows.Forms.Label LblTutar;
        private System.Windows.Forms.TextBox TxtİstenenMail;
        private System.Windows.Forms.Button BtnRezYap;
        private System.Windows.Forms.Label LblİletisimMail;
    }
}