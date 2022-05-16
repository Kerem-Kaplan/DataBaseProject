
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnRezYap
            // 
            this.BtnRezYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRezYap.Location = new System.Drawing.Point(227, 694);
            this.BtnRezYap.Name = "BtnRezYap";
            this.BtnRezYap.Size = new System.Drawing.Size(244, 63);
            this.BtnRezYap.TabIndex = 5;
            this.BtnRezYap.Text = "Rezervasyon Yap";
            this.BtnRezYap.UseVisualStyleBackColor = true;
            this.BtnRezYap.Click += new System.EventHandler(this.BtnRezYap_Click);
            // 
            // LblTutar
            // 
            this.LblTutar.AutoSize = true;
            this.LblTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTutar.Location = new System.Drawing.Point(151, 145);
            this.LblTutar.Name = "LblTutar";
            this.LblTutar.Size = new System.Drawing.Size(79, 29);
            this.LblTutar.TabIndex = 4;
            this.LblTutar.Text = "label2";
            // 
            // LblUcret
            // 
            this.LblUcret.AutoSize = true;
            this.LblUcret.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUcret.Location = new System.Drawing.Point(69, 145);
            this.LblUcret.Name = "LblUcret";
            this.LblUcret.Size = new System.Drawing.Size(76, 29);
            this.LblUcret.TabIndex = 3;
            this.LblUcret.Text = "Ücret:";
            // 
            // DtpOnOdemeliBasTarihi
            // 
            this.DtpOnOdemeliBasTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpOnOdemeliBasTarihi.Location = new System.Drawing.Point(432, 233);
            this.DtpOnOdemeliBasTarihi.Name = "DtpOnOdemeliBasTarihi";
            this.DtpOnOdemeliBasTarihi.Size = new System.Drawing.Size(227, 22);
            this.DtpOnOdemeliBasTarihi.TabIndex = 6;
            // 
            // LblUyari
            // 
            this.LblUyari.AutoSize = true;
            this.LblUyari.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUyari.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblUyari.Location = new System.Drawing.Point(69, 52);
            this.LblUyari.Name = "LblUyari";
            this.LblUyari.Size = new System.Drawing.Size(530, 58);
            this.LblUyari.TabIndex = 7;
            this.LblUyari.Text = "Uyarı: Seçtiğiniz rezervasyon başlangıç tarihinin\r\nbugünden en az 90 sonra olması" +
    "na dikkat ediniz.";
            // 
            // LblRezBasTarihi
            // 
            this.LblRezBasTarihi.AutoSize = true;
            this.LblRezBasTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRezBasTarihi.Location = new System.Drawing.Point(66, 226);
            this.LblRezBasTarihi.Name = "LblRezBasTarihi";
            this.LblRezBasTarihi.Size = new System.Drawing.Size(336, 29);
            this.LblRezBasTarihi.TabIndex = 8;
            this.LblRezBasTarihi.Text = "Rezervasyon Başlangıç Tarihi:";
            // 
            // DtpOnOdemeliBitisTarihi
            // 
            this.DtpOnOdemeliBitisTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpOnOdemeliBitisTarihi.Location = new System.Drawing.Point(432, 315);
            this.DtpOnOdemeliBitisTarihi.Name = "DtpOnOdemeliBitisTarihi";
            this.DtpOnOdemeliBitisTarihi.Size = new System.Drawing.Size(227, 22);
            this.DtpOnOdemeliBitisTarihi.TabIndex = 9;
            // 
            // LblRezBitisTarihi
            // 
            this.LblRezBitisTarihi.AutoSize = true;
            this.LblRezBitisTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRezBitisTarihi.Location = new System.Drawing.Point(66, 315);
            this.LblRezBitisTarihi.Name = "LblRezBitisTarihi";
            this.LblRezBitisTarihi.Size = new System.Drawing.Size(277, 29);
            this.LblRezBitisTarihi.TabIndex = 10;
            this.LblRezBitisTarihi.Text = "Rezervasyon Bitiş Tarihi:";
            // 
            // LblKrediKartNo
            // 
            this.LblKrediKartNo.AutoSize = true;
            this.LblKrediKartNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblKrediKartNo.Location = new System.Drawing.Point(69, 620);
            this.LblKrediKartNo.Name = "LblKrediKartNo";
            this.LblKrediKartNo.Size = new System.Drawing.Size(170, 29);
            this.LblKrediKartNo.TabIndex = 11;
            this.LblKrediKartNo.Text = "Kredi Kartı No:";
            // 
            // TxtKrediKartiNo
            // 
            this.TxtKrediKartiNo.Location = new System.Drawing.Point(432, 627);
            this.TxtKrediKartiNo.MaxLength = 19;
            this.TxtKrediKartiNo.Name = "TxtKrediKartiNo";
            this.TxtKrediKartiNo.Size = new System.Drawing.Size(227, 22);
            this.TxtKrediKartiNo.TabIndex = 12;
            // 
            // LblMusteriSoyad
            // 
            this.LblMusteriSoyad.AutoSize = true;
            this.LblMusteriSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMusteriSoyad.Location = new System.Drawing.Point(66, 461);
            this.LblMusteriSoyad.Name = "LblMusteriSoyad";
            this.LblMusteriSoyad.Size = new System.Drawing.Size(104, 29);
            this.LblMusteriSoyad.TabIndex = 13;
            this.LblMusteriSoyad.Text = "Soyisim:";
            // 
            // LblMusteriAd
            // 
            this.LblMusteriAd.AutoSize = true;
            this.LblMusteriAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMusteriAd.Location = new System.Drawing.Point(69, 390);
            this.LblMusteriAd.Name = "LblMusteriAd";
            this.LblMusteriAd.Size = new System.Drawing.Size(63, 29);
            this.LblMusteriAd.TabIndex = 14;
            this.LblMusteriAd.Text = "İsim:";
            // 
            // TxtMusteriAd
            // 
            this.TxtMusteriAd.Location = new System.Drawing.Point(432, 397);
            this.TxtMusteriAd.MaxLength = 19;
            this.TxtMusteriAd.Name = "TxtMusteriAd";
            this.TxtMusteriAd.Size = new System.Drawing.Size(227, 22);
            this.TxtMusteriAd.TabIndex = 15;
            // 
            // TxtMusteriSoyad
            // 
            this.TxtMusteriSoyad.Location = new System.Drawing.Point(432, 468);
            this.TxtMusteriSoyad.MaxLength = 19;
            this.TxtMusteriSoyad.Name = "TxtMusteriSoyad";
            this.TxtMusteriSoyad.Size = new System.Drawing.Size(227, 22);
            this.TxtMusteriSoyad.TabIndex = 16;
            // 
            // TxtMusteriMail
            // 
            this.TxtMusteriMail.Location = new System.Drawing.Point(432, 543);
            this.TxtMusteriMail.MaxLength = 19;
            this.TxtMusteriMail.Name = "TxtMusteriMail";
            this.TxtMusteriMail.Size = new System.Drawing.Size(227, 22);
            this.TxtMusteriMail.TabIndex = 18;
            // 
            // LblMusteriMail
            // 
            this.LblMusteriMail.AutoSize = true;
            this.LblMusteriMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMusteriMail.Location = new System.Drawing.Point(69, 536);
            this.LblMusteriMail.Name = "LblMusteriMail";
            this.LblMusteriMail.Size = new System.Drawing.Size(64, 29);
            this.LblMusteriMail.TabIndex = 17;
            this.LblMusteriMail.Text = "Mail:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(919, 339);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 44);
            this.label1.TabIndex = 19;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(707, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 44);
            this.label2.TabIndex = 20;
            this.label2.Text = "RezSüresi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(665, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(316, 44);
            this.label3.TabIndex = 22;
            this.label3.Text = "Reze Kalan Süre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(987, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 44);
            this.label4.TabIndex = 21;
            this.label4.Text = "label4";
            // 
            // FrmOnOdemeliRezervasyon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1395, 769);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}