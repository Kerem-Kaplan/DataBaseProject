
namespace DataBaseProject
{
    partial class FrmGirisYap
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
            this.TxtMusSifre = new System.Windows.Forms.TextBox();
            this.TxtMusMail = new System.Windows.Forms.TextBox();
            this.LblMusSifre = new System.Windows.Forms.Label();
            this.LblMusMail = new System.Windows.Forms.Label();
            this.BtnGirisYap = new System.Windows.Forms.Button();
            this.BtnGeri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtMusSifre
            // 
            this.TxtMusSifre.Location = new System.Drawing.Point(253, 267);
            this.TxtMusSifre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtMusSifre.Name = "TxtMusSifre";
            this.TxtMusSifre.Size = new System.Drawing.Size(176, 20);
            this.TxtMusSifre.TabIndex = 10;
            // 
            // TxtMusMail
            // 
            this.TxtMusMail.Location = new System.Drawing.Point(253, 158);
            this.TxtMusMail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtMusMail.Name = "TxtMusMail";
            this.TxtMusMail.Size = new System.Drawing.Size(176, 20);
            this.TxtMusMail.TabIndex = 9;
            // 
            // LblMusSifre
            // 
            this.LblMusSifre.AutoSize = true;
            this.LblMusSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMusSifre.Location = new System.Drawing.Point(141, 266);
            this.LblMusSifre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblMusSifre.Name = "LblMusSifre";
            this.LblMusSifre.Size = new System.Drawing.Size(37, 16);
            this.LblMusSifre.TabIndex = 8;
            this.LblMusSifre.Text = "Şifre:";
            // 
            // LblMusMail
            // 
            this.LblMusMail.AutoSize = true;
            this.LblMusMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMusMail.Location = new System.Drawing.Point(141, 156);
            this.LblMusMail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblMusMail.Name = "LblMusMail";
            this.LblMusMail.Size = new System.Drawing.Size(37, 20);
            this.LblMusMail.TabIndex = 7;
            this.LblMusMail.Text = "Mail";
            // 
            // BtnGirisYap
            // 
            this.BtnGirisYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGirisYap.Location = new System.Drawing.Point(304, 315);
            this.BtnGirisYap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnGirisYap.Name = "BtnGirisYap";
            this.BtnGirisYap.Size = new System.Drawing.Size(123, 39);
            this.BtnGirisYap.TabIndex = 11;
            this.BtnGirisYap.Text = "Giriş Yap";
            this.BtnGirisYap.UseVisualStyleBackColor = true;
            this.BtnGirisYap.Click += new System.EventHandler(this.BtnGirisYap_Click);
            // 
            // BtnGeri
            // 
            this.BtnGeri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGeri.Location = new System.Drawing.Point(304, 373);
            this.BtnGeri.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnGeri.Name = "BtnGeri";
            this.BtnGeri.Size = new System.Drawing.Size(123, 39);
            this.BtnGeri.TabIndex = 12;
            this.BtnGeri.Text = "Geri";
            this.BtnGeri.UseVisualStyleBackColor = false;
            // 
            // FrmGirisYap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 488);
            this.Controls.Add(this.BtnGeri);
            this.Controls.Add(this.BtnGirisYap);
            this.Controls.Add(this.TxtMusSifre);
            this.Controls.Add(this.TxtMusMail);
            this.Controls.Add(this.LblMusSifre);
            this.Controls.Add(this.LblMusMail);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmGirisYap";
            this.Text = "FrmGirisYap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtMusSifre;
        private System.Windows.Forms.TextBox TxtMusMail;
        private System.Windows.Forms.Label LblMusSifre;
        private System.Windows.Forms.Label LblMusMail;
        private System.Windows.Forms.Button BtnGirisYap;
        private System.Windows.Forms.Button BtnGeri;
    }
}