
namespace DataBaseProject
{
    partial class FrmOnOdemeliRezervasyon
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
            this.BtnRezYap = new System.Windows.Forms.Button();
            this.LblTutar = new System.Windows.Forms.Label();
            this.LblUcret = new System.Windows.Forms.Label();
            this.DtpOnOdemeliBasTarihi = new System.Windows.Forms.DateTimePicker();
            this.LblUyari = new System.Windows.Forms.Label();
            this.LblRezBasTarihi = new System.Windows.Forms.Label();
            this.DtpOnOdemeliBitisTarihi = new System.Windows.Forms.DateTimePicker();
            this.LblRezBitisTarihi = new System.Windows.Forms.Label();
            this.LblKrediKartNo = new System.Windows.Forms.Label();
            this.TxtKrediKartiNo = new System.Windows.Forms.TextBox();
            this.LblMusteriSoyad = new System.Windows.Forms.Label();
            this.LblMusteriAd = new System.Windows.Forms.Label();
            this.TxtMusteriAd = new System.Windows.Forms.TextBox();
            this.TxtMusteriSoyad = new System.Windows.Forms.TextBox();
            this.TxtMusteriMail = new System.Windows.Forms.TextBox();
            this.LblMusteriMail = new System.Windows.Forms.Label();
            this.LblRezSure = new System.Windows.Forms.Label();
            this.LblRezSuresi = new System.Windows.Forms.Label();
            this.LblRezKalanSure = new System.Windows.Forms.Label();
            this.LblKalanSure = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnRezYap
            // 
            this.BtnRezYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRezYap.Location = new System.Drawing.Point(170, 564);
            this.BtnRezYap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnRezYap.Name = "BtnRezYap";
            this.BtnRezYap.Size = new System.Drawing.Size(183, 51);
            this.BtnRezYap.TabIndex = 5;
            this.BtnRezYap.Text = "Rezervasyon Yap";
            this.BtnRezYap.UseVisualStyleBackColor = true;
            this.BtnRezYap.Click += new System.EventHandler(this.BtnRezYap_Click);
            // 
            // LblTutar
            // 
            this.LblTutar.AutoSize = true;
            this.LblTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTutar.Location = new System.Drawing.Point(113, 118);
            this.LblTutar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblTutar.Name = "LblTutar";
            this.LblTutar.Size = new System.Drawing.Size(60, 24);
            this.LblTutar.TabIndex = 4;
            this.LblTutar.Text = "label2";
            // 
            // LblUcret
            // 
            this.LblUcret.AutoSize = true;
            this.LblUcret.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUcret.Location = new System.Drawing.Point(52, 118);
            this.LblUcret.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblUcret.Name = "LblUcret";
            this.LblUcret.Size = new System.Drawing.Size(59, 24);
            this.LblUcret.TabIndex = 3;
            this.LblUcret.Text = "Ücret:";
            // 
            // DtpOnOdemeliBasTarihi
            // 
            this.DtpOnOdemeliBasTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpOnOdemeliBasTarihi.Location = new System.Drawing.Point(324, 189);
            this.DtpOnOdemeliBasTarihi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DtpOnOdemeliBasTarihi.Name = "DtpOnOdemeliBasTarihi";
            this.DtpOnOdemeliBasTarihi.Size = new System.Drawing.Size(171, 20);
            this.DtpOnOdemeliBasTarihi.TabIndex = 6;
            // 
            // LblUyari
            // 
            this.LblUyari.AutoSize = true;
            this.LblUyari.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUyari.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblUyari.Location = new System.Drawing.Point(52, 42);
            this.LblUyari.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblUyari.Name = "LblUyari";
            this.LblUyari.Size = new System.Drawing.Size(418, 48);
            this.LblUyari.TabIndex = 7;
            this.LblUyari.Text = "Uyarı: Seçtiğiniz rezervasyon başlangıç tarihinin\r\nbugünden en az 90 sonra olması" +
    "na dikkat ediniz.";
            // 
            // LblRezBasTarihi
            // 
            this.LblRezBasTarihi.AutoSize = true;
            this.LblRezBasTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRezBasTarihi.Location = new System.Drawing.Point(50, 184);
            this.LblRezBasTarihi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblRezBasTarihi.Name = "LblRezBasTarihi";
            this.LblRezBasTarihi.Size = new System.Drawing.Size(262, 24);
            this.LblRezBasTarihi.TabIndex = 8;
            this.LblRezBasTarihi.Text = "Rezervasyon Başlangıç Tarihi:";
            // 
            // DtpOnOdemeliBitisTarihi
            // 
            this.DtpOnOdemeliBitisTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpOnOdemeliBitisTarihi.Location = new System.Drawing.Point(324, 256);
            this.DtpOnOdemeliBitisTarihi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DtpOnOdemeliBitisTarihi.Name = "DtpOnOdemeliBitisTarihi";
            this.DtpOnOdemeliBitisTarihi.Size = new System.Drawing.Size(171, 20);
            this.DtpOnOdemeliBitisTarihi.TabIndex = 9;
            // 
            // LblRezBitisTarihi
            // 
            this.LblRezBitisTarihi.AutoSize = true;
            this.LblRezBitisTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRezBitisTarihi.Location = new System.Drawing.Point(50, 256);
            this.LblRezBitisTarihi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblRezBitisTarihi.Name = "LblRezBitisTarihi";
            this.LblRezBitisTarihi.Size = new System.Drawing.Size(214, 24);
            this.LblRezBitisTarihi.TabIndex = 10;
            this.LblRezBitisTarihi.Text = "Rezervasyon Bitiş Tarihi:";
            // 
            // LblKrediKartNo
            // 
            this.LblKrediKartNo.AutoSize = true;
            this.LblKrediKartNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblKrediKartNo.Location = new System.Drawing.Point(52, 504);
            this.LblKrediKartNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblKrediKartNo.Name = "LblKrediKartNo";
            this.LblKrediKartNo.Size = new System.Drawing.Size(130, 24);
            this.LblKrediKartNo.TabIndex = 11;
            this.LblKrediKartNo.Text = "Kredi Kartı No:";
            // 
            // TxtKrediKartiNo
            // 
            this.TxtKrediKartiNo.Location = new System.Drawing.Point(324, 509);
            this.TxtKrediKartiNo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtKrediKartiNo.MaxLength = 19;
            this.TxtKrediKartiNo.Name = "TxtKrediKartiNo";
            this.TxtKrediKartiNo.Size = new System.Drawing.Size(171, 20);
            this.TxtKrediKartiNo.TabIndex = 12;
            // 
            // LblMusteriSoyad
            // 
            this.LblMusteriSoyad.AutoSize = true;
            this.LblMusteriSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMusteriSoyad.Location = new System.Drawing.Point(50, 375);
            this.LblMusteriSoyad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblMusteriSoyad.Name = "LblMusteriSoyad";
            this.LblMusteriSoyad.Size = new System.Drawing.Size(80, 24);
            this.LblMusteriSoyad.TabIndex = 13;
            this.LblMusteriSoyad.Text = "Soyisim:";
            // 
            // LblMusteriAd
            // 
            this.LblMusteriAd.AutoSize = true;
            this.LblMusteriAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMusteriAd.Location = new System.Drawing.Point(52, 317);
            this.LblMusteriAd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblMusteriAd.Name = "LblMusteriAd";
            this.LblMusteriAd.Size = new System.Drawing.Size(48, 24);
            this.LblMusteriAd.TabIndex = 14;
            this.LblMusteriAd.Text = "İsim:";
            // 
            // TxtMusteriAd
            // 
            this.TxtMusteriAd.Location = new System.Drawing.Point(324, 323);
            this.TxtMusteriAd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtMusteriAd.MaxLength = 19;
            this.TxtMusteriAd.Name = "TxtMusteriAd";
            this.TxtMusteriAd.Size = new System.Drawing.Size(171, 20);
            this.TxtMusteriAd.TabIndex = 15;
            // 
            // TxtMusteriSoyad
            // 
            this.TxtMusteriSoyad.Location = new System.Drawing.Point(324, 380);
            this.TxtMusteriSoyad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtMusteriSoyad.MaxLength = 19;
            this.TxtMusteriSoyad.Name = "TxtMusteriSoyad";
            this.TxtMusteriSoyad.Size = new System.Drawing.Size(171, 20);
            this.TxtMusteriSoyad.TabIndex = 16;
            // 
            // TxtMusteriMail
            // 
            this.TxtMusteriMail.Location = new System.Drawing.Point(324, 441);
            this.TxtMusteriMail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtMusteriMail.MaxLength = 19;
            this.TxtMusteriMail.Name = "TxtMusteriMail";
            this.TxtMusteriMail.Size = new System.Drawing.Size(171, 20);
            this.TxtMusteriMail.TabIndex = 18;
            // 
            // LblMusteriMail
            // 
            this.LblMusteriMail.AutoSize = true;
            this.LblMusteriMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMusteriMail.Location = new System.Drawing.Point(52, 436);
            this.LblMusteriMail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblMusteriMail.Name = "LblMusteriMail";
            this.LblMusteriMail.Size = new System.Drawing.Size(49, 24);
            this.LblMusteriMail.TabIndex = 17;
            this.LblMusteriMail.Text = "Mail:";
            // 
            // LblRezSure
            // 
            this.LblRezSure.AutoSize = true;
            this.LblRezSure.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblRezSure.Location = new System.Drawing.Point(689, 275);
            this.LblRezSure.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblRezSure.Name = "LblRezSure";
            this.LblRezSure.Size = new System.Drawing.Size(95, 36);
            this.LblRezSure.TabIndex = 19;
            this.LblRezSure.Text = "label1";
            // 
            // LblRezSuresi
            // 
            this.LblRezSuresi.AutoSize = true;
            this.LblRezSuresi.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblRezSuresi.Location = new System.Drawing.Point(530, 275);
            this.LblRezSuresi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblRezSuresi.Name = "LblRezSuresi";
            this.LblRezSuresi.Size = new System.Drawing.Size(161, 36);
            this.LblRezSuresi.TabIndex = 20;
            this.LblRezSuresi.Text = "RezSüresi:";
            // 
            // LblRezKalanSure
            // 
            this.LblRezKalanSure.AutoSize = true;
            this.LblRezKalanSure.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblRezKalanSure.Location = new System.Drawing.Point(499, 184);
            this.LblRezKalanSure.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblRezKalanSure.Name = "LblRezKalanSure";
            this.LblRezKalanSure.Size = new System.Drawing.Size(247, 36);
            this.LblRezKalanSure.TabIndex = 22;
            this.LblRezKalanSure.Text = "Reze Kalan Süre:";
            // 
            // LblKalanSure
            // 
            this.LblKalanSure.AutoSize = true;
            this.LblKalanSure.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblKalanSure.Location = new System.Drawing.Point(740, 184);
            this.LblKalanSure.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblKalanSure.Name = "LblKalanSure";
            this.LblKalanSure.Size = new System.Drawing.Size(95, 36);
            this.LblKalanSure.TabIndex = 21;
            this.LblKalanSure.Text = "label4";
            // 
            // FrmOnOdemeliRezervasyon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 625);
            this.Controls.Add(this.LblRezKalanSure);
            this.Controls.Add(this.LblKalanSure);
            this.Controls.Add(this.LblRezSuresi);
            this.Controls.Add(this.LblRezSure);
            this.Controls.Add(this.TxtMusteriMail);
            this.Controls.Add(this.LblMusteriMail);
            this.Controls.Add(this.TxtMusteriSoyad);
            this.Controls.Add(this.TxtMusteriAd);
            this.Controls.Add(this.LblMusteriAd);
            this.Controls.Add(this.LblMusteriSoyad);
            this.Controls.Add(this.TxtKrediKartiNo);
            this.Controls.Add(this.LblKrediKartNo);
            this.Controls.Add(this.LblRezBitisTarihi);
            this.Controls.Add(this.DtpOnOdemeliBitisTarihi);
            this.Controls.Add(this.LblRezBasTarihi);
            this.Controls.Add(this.LblUyari);
            this.Controls.Add(this.DtpOnOdemeliBasTarihi);
            this.Controls.Add(this.BtnRezYap);
            this.Controls.Add(this.LblTutar);
            this.Controls.Add(this.LblUcret);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmOnOdemeliRezervasyon";
            this.Text = "FrmOnOdemeliRezervasyon";
            this.Load += new System.EventHandler(this.FrmOnOdemeliRezervasyon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnRezYap;
        private System.Windows.Forms.Label LblTutar;
        private System.Windows.Forms.Label LblUcret;
        private System.Windows.Forms.DateTimePicker DtpOnOdemeliBasTarihi;
        private System.Windows.Forms.Label LblUyari;
        private System.Windows.Forms.Label LblRezBasTarihi;
        private System.Windows.Forms.DateTimePicker DtpOnOdemeliBitisTarihi;
        private System.Windows.Forms.Label LblRezBitisTarihi;
        private System.Windows.Forms.Label LblKrediKartNo;
        private System.Windows.Forms.TextBox TxtKrediKartiNo;
        private System.Windows.Forms.Label LblMusteriSoyad;
        private System.Windows.Forms.Label LblMusteriAd;
        private System.Windows.Forms.TextBox TxtMusteriAd;
        private System.Windows.Forms.TextBox TxtMusteriSoyad;
        private System.Windows.Forms.TextBox TxtMusteriMail;
        private System.Windows.Forms.Label LblMusteriMail;
        private System.Windows.Forms.Label LblRezSure;
        private System.Windows.Forms.Label LblRezSuresi;
        private System.Windows.Forms.Label LblRezKalanSure;
        private System.Windows.Forms.Label LblKalanSure;
    }
}