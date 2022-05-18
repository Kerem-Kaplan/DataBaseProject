
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
            this.TxtMusSifre.Location = new System.Drawing.Point(337, 329);
            this.TxtMusSifre.Name = "TxtMusSifre";
            this.TxtMusSifre.Size = new System.Drawing.Size(233, 22);
            this.TxtMusSifre.TabIndex = 10;
            // 
            // TxtMusMail
            // 
            this.TxtMusMail.Location = new System.Drawing.Point(337, 194);
            this.TxtMusMail.Name = "TxtMusMail";
            this.TxtMusMail.Size = new System.Drawing.Size(233, 22);
            this.TxtMusMail.TabIndex = 9;
            // 
            // LblMusSifre
            // 
            this.LblMusSifre.AutoSize = true;
            this.LblMusSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMusSifre.Location = new System.Drawing.Point(188, 327);
            this.LblMusSifre.Name = "LblMusSifre";
            this.LblMusSifre.Size = new System.Drawing.Size(81, 25);
            this.LblMusSifre.TabIndex = 8;
            this.LblMusSifre.Text = "Soyisim";
            // 
            // LblMusMail
            // 
            this.LblMusMail.AutoSize = true;
            this.LblMusMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMusMail.Location = new System.Drawing.Point(188, 192);
            this.LblMusMail.Name = "LblMusMail";
            this.LblMusMail.Size = new System.Drawing.Size(48, 25);
            this.LblMusMail.TabIndex = 7;
            this.LblMusMail.Text = "Mail";
            // 
            // BtnGirisYap
            // 
            this.BtnGirisYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGirisYap.Location = new System.Drawing.Point(406, 388);
            this.BtnGirisYap.Name = "BtnGirisYap";
            this.BtnGirisYap.Size = new System.Drawing.Size(164, 48);
            this.BtnGirisYap.TabIndex = 11;
            this.BtnGirisYap.Text = "Giriş Yap";
            this.BtnGirisYap.UseVisualStyleBackColor = true;
            this.BtnGirisYap.Click += new System.EventHandler(this.BtnGirisYap_Click);
            // 
            // BtnGeri
            // 
            this.BtnGeri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGeri.Location = new System.Drawing.Point(406, 459);
            this.BtnGeri.Name = "BtnGeri";
            this.BtnGeri.Size = new System.Drawing.Size(164, 48);
            this.BtnGeri.TabIndex = 12;
            this.BtnGeri.Text = "Geri";
            this.BtnGeri.UseVisualStyleBackColor = false;
            // 
            // FrmGirisYap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 600);
            this.Controls.Add(this.BtnGeri);
            this.Controls.Add(this.BtnGirisYap);
            this.Controls.Add(this.TxtMusSifre);
            this.Controls.Add(this.TxtMusMail);
            this.Controls.Add(this.LblMusSifre);
            this.Controls.Add(this.LblMusMail);
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