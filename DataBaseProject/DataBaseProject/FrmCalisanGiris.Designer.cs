
namespace DataBaseProject
{
    partial class FrmCalisanGiris
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
            this.BtnGirisYap = new System.Windows.Forms.Button();
            this.TxtCalisanSifre = new System.Windows.Forms.TextBox();
            this.TxtCalisanMail = new System.Windows.Forms.TextBox();
            this.LblMusSifre = new System.Windows.Forms.Label();
            this.LblMusMail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnGeri
            // 
            this.BtnGeri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGeri.Location = new System.Drawing.Point(426, 335);
            this.BtnGeri.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnGeri.Name = "BtnGeri";
            this.BtnGeri.Size = new System.Drawing.Size(164, 48);
            this.BtnGeri.TabIndex = 18;
            this.BtnGeri.Text = "Geri";
            this.BtnGeri.UseVisualStyleBackColor = false;
            // 
            // BtnGirisYap
            // 
            this.BtnGirisYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGirisYap.Location = new System.Drawing.Point(426, 264);
            this.BtnGirisYap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnGirisYap.Name = "BtnGirisYap";
            this.BtnGirisYap.Size = new System.Drawing.Size(164, 48);
            this.BtnGirisYap.TabIndex = 17;
            this.BtnGirisYap.Text = "Giriş Yap";
            this.BtnGirisYap.UseVisualStyleBackColor = true;
            this.BtnGirisYap.Click += new System.EventHandler(this.BtnGirisYap_Click);
            // 
            // TxtCalisanSifre
            // 
            this.TxtCalisanSifre.Location = new System.Drawing.Point(358, 205);
            this.TxtCalisanSifre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtCalisanSifre.Name = "TxtCalisanSifre";
            this.TxtCalisanSifre.Size = new System.Drawing.Size(233, 22);
            this.TxtCalisanSifre.TabIndex = 16;
            // 
            // TxtCalisanMail
            // 
            this.TxtCalisanMail.Location = new System.Drawing.Point(358, 70);
            this.TxtCalisanMail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtCalisanMail.Name = "TxtCalisanMail";
            this.TxtCalisanMail.Size = new System.Drawing.Size(233, 22);
            this.TxtCalisanMail.TabIndex = 15;
            // 
            // LblMusSifre
            // 
            this.LblMusSifre.AutoSize = true;
            this.LblMusSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMusSifre.Location = new System.Drawing.Point(209, 203);
            this.LblMusSifre.Name = "LblMusSifre";
            this.LblMusSifre.Size = new System.Drawing.Size(58, 25);
            this.LblMusSifre.TabIndex = 14;
            this.LblMusSifre.Text = "Şifre:";
            // 
            // LblMusMail
            // 
            this.LblMusMail.AutoSize = true;
            this.LblMusMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMusMail.Location = new System.Drawing.Point(209, 68);
            this.LblMusMail.Name = "LblMusMail";
            this.LblMusMail.Size = new System.Drawing.Size(48, 25);
            this.LblMusMail.TabIndex = 13;
            this.LblMusMail.Text = "Mail";
            // 
            // FrmCalisanGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 624);
            this.Controls.Add(this.BtnGeri);
            this.Controls.Add(this.BtnGirisYap);
            this.Controls.Add(this.TxtCalisanSifre);
            this.Controls.Add(this.TxtCalisanMail);
            this.Controls.Add(this.LblMusSifre);
            this.Controls.Add(this.LblMusMail);
            this.Name = "FrmCalisanGiris";
            this.Text = "FrmCalisanGiris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGeri;
        private System.Windows.Forms.Button BtnGirisYap;
        private System.Windows.Forms.TextBox TxtCalisanSifre;
        private System.Windows.Forms.TextBox TxtCalisanMail;
        private System.Windows.Forms.Label LblMusSifre;
        private System.Windows.Forms.Label LblMusMail;
    }
}