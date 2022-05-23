
namespace DataBaseProject
{
    partial class FrmTesvikRezervasyon
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
            this.LblToplamUcret = new System.Windows.Forms.Label();
            this.LblToplamTutar = new System.Windows.Forms.Label();
            this.LblRezSure = new System.Windows.Forms.Label();
            this.LblRezSuresi = new System.Windows.Forms.Label();
            this.LblRezBasTarihi = new System.Windows.Forms.Label();
            this.DtpTesRezBasTarihi = new System.Windows.Forms.DateTimePicker();
            this.LblUcret = new System.Windows.Forms.Label();
            this.LblTutar = new System.Windows.Forms.Label();
            this.BtnRezYap = new System.Windows.Forms.Button();
            this.LblRezBitisTarihi = new System.Windows.Forms.Label();
            this.DtpTesvikBitisTarihi = new System.Windows.Forms.DateTimePicker();
            this.TxtKrediKartNo = new System.Windows.Forms.TextBox();
            this.LblKrediKarti = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnGeri
            // 
            this.BtnGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGeri.Location = new System.Drawing.Point(551, 489);
            this.BtnGeri.Margin = new System.Windows.Forms.Padding(4);
            this.BtnGeri.Name = "BtnGeri";
            this.BtnGeri.Size = new System.Drawing.Size(241, 42);
            this.BtnGeri.TabIndex = 31;
            this.BtnGeri.Text = "Geri";
            this.BtnGeri.UseVisualStyleBackColor = true;
            this.BtnGeri.Click += new System.EventHandler(this.BtnGeri_Click);
            // 
            // LblToplamUcret
            // 
            this.LblToplamUcret.AutoSize = true;
            this.LblToplamUcret.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblToplamUcret.Location = new System.Drawing.Point(851, 280);
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
            this.LblToplamTutar.Location = new System.Drawing.Point(1029, 283);
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
            this.LblRezSure.Location = new System.Drawing.Point(851, 211);
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
            this.LblRezSuresi.Location = new System.Drawing.Point(1029, 211);
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
            this.LblRezBasTarihi.Location = new System.Drawing.Point(108, 216);
            this.LblRezBasTarihi.Name = "LblRezBasTarihi";
            this.LblRezBasTarihi.Size = new System.Drawing.Size(336, 29);
            this.LblRezBasTarihi.TabIndex = 24;
            this.LblRezBasTarihi.Text = "Rezervasyon Başlangıç Tarihi:";
            // 
            // DtpTesRezBasTarihi
            // 
            this.DtpTesRezBasTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpTesRezBasTarihi.Location = new System.Drawing.Point(473, 222);
            this.DtpTesRezBasTarihi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DtpTesRezBasTarihi.Name = "DtpTesRezBasTarihi";
            this.DtpTesRezBasTarihi.Size = new System.Drawing.Size(319, 22);
            this.DtpTesRezBasTarihi.TabIndex = 23;
            // 
            // LblUcret
            // 
            this.LblUcret.AutoSize = true;
            this.LblUcret.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUcret.Location = new System.Drawing.Point(108, 104);
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
            this.LblTutar.Location = new System.Drawing.Point(293, 104);
            this.LblTutar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTutar.Name = "LblTutar";
            this.LblTutar.Size = new System.Drawing.Size(66, 29);
            this.LblTutar.TabIndex = 21;
            this.LblTutar.Text = "label";
            // 
            // BtnRezYap
            // 
            this.BtnRezYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRezYap.Location = new System.Drawing.Point(551, 421);
            this.BtnRezYap.Margin = new System.Windows.Forms.Padding(4);
            this.BtnRezYap.Name = "BtnRezYap";
            this.BtnRezYap.Size = new System.Drawing.Size(241, 42);
            this.BtnRezYap.TabIndex = 19;
            this.BtnRezYap.Text = "Rezervasyon Yap";
            this.BtnRezYap.UseVisualStyleBackColor = true;
            this.BtnRezYap.Click += new System.EventHandler(this.BtnRezYap_Click);
            // 
            // LblRezBitisTarihi
            // 
            this.LblRezBitisTarihi.AutoSize = true;
            this.LblRezBitisTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRezBitisTarihi.Location = new System.Drawing.Point(108, 290);
            this.LblRezBitisTarihi.Name = "LblRezBitisTarihi";
            this.LblRezBitisTarihi.Size = new System.Drawing.Size(277, 29);
            this.LblRezBitisTarihi.TabIndex = 33;
            this.LblRezBitisTarihi.Text = "Rezervasyon Bitiş Tarihi:";
            // 
            // DtpTesvikBitisTarihi
            // 
            this.DtpTesvikBitisTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpTesvikBitisTarihi.Location = new System.Drawing.Point(473, 290);
            this.DtpTesvikBitisTarihi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DtpTesvikBitisTarihi.Name = "DtpTesvikBitisTarihi";
            this.DtpTesvikBitisTarihi.Size = new System.Drawing.Size(319, 22);
            this.DtpTesvikBitisTarihi.TabIndex = 32;
            // 
            // TxtKrediKartNo
            // 
            this.TxtKrediKartNo.Location = new System.Drawing.Point(473, 363);
            this.TxtKrediKartNo.Margin = new System.Windows.Forms.Padding(4);
            this.TxtKrediKartNo.MaxLength = 16;
            this.TxtKrediKartNo.Name = "TxtKrediKartNo";
            this.TxtKrediKartNo.Size = new System.Drawing.Size(319, 22);
            this.TxtKrediKartNo.TabIndex = 35;
            // 
            // LblKrediKarti
            // 
            this.LblKrediKarti.AutoSize = true;
            this.LblKrediKarti.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblKrediKarti.Location = new System.Drawing.Point(108, 363);
            this.LblKrediKarti.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblKrediKarti.Name = "LblKrediKarti";
            this.LblKrediKarti.Size = new System.Drawing.Size(170, 29);
            this.LblKrediKarti.TabIndex = 34;
            this.LblKrediKarti.Text = "Kredi Kartı No:";
            // 
            // FrmTesvikRezervasyon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1357, 720);
            this.Controls.Add(this.TxtKrediKartNo);
            this.Controls.Add(this.LblKrediKarti);
            this.Controls.Add(this.LblRezBitisTarihi);
            this.Controls.Add(this.DtpTesvikBitisTarihi);
            this.Controls.Add(this.BtnGeri);
            this.Controls.Add(this.LblToplamUcret);
            this.Controls.Add(this.LblToplamTutar);
            this.Controls.Add(this.LblRezSure);
            this.Controls.Add(this.LblRezSuresi);
            this.Controls.Add(this.LblRezBasTarihi);
            this.Controls.Add(this.DtpTesRezBasTarihi);
            this.Controls.Add(this.LblUcret);
            this.Controls.Add(this.LblTutar);
            this.Controls.Add(this.BtnRezYap);
            this.Name = "FrmTesvikRezervasyon";
            this.Text = "FrmTesvikRezervasyon";
            this.Load += new System.EventHandler(this.FrmTesvikRezervasyon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGeri;
        private System.Windows.Forms.Label LblToplamUcret;
        private System.Windows.Forms.Label LblToplamTutar;
        private System.Windows.Forms.Label LblRezSure;
        private System.Windows.Forms.Label LblRezSuresi;
        private System.Windows.Forms.Label LblRezBasTarihi;
        private System.Windows.Forms.DateTimePicker DtpTesRezBasTarihi;
        private System.Windows.Forms.Label LblUcret;
        private System.Windows.Forms.Label LblTutar;
        private System.Windows.Forms.Button BtnRezYap;
        private System.Windows.Forms.Label LblRezBitisTarihi;
        private System.Windows.Forms.DateTimePicker DtpTesvikBitisTarihi;
        private System.Windows.Forms.TextBox TxtKrediKartNo;
        private System.Windows.Forms.Label LblKrediKarti;
    }
}