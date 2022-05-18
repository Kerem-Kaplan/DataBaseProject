
namespace DataBaseProject
{
    partial class FrmBaslangıcSayfa
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
            this.BtnMusGirisYap = new System.Windows.Forms.Button();
            this.BtnMusKayitOl = new System.Windows.Forms.Button();
            this.BtnYoneticiGiris = new System.Windows.Forms.Button();
            this.BtnCalisanGiris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnMusGirisYap
            // 
            this.BtnMusGirisYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMusGirisYap.Location = new System.Drawing.Point(134, 222);
            this.BtnMusGirisYap.Name = "BtnMusGirisYap";
            this.BtnMusGirisYap.Size = new System.Drawing.Size(228, 68);
            this.BtnMusGirisYap.TabIndex = 0;
            this.BtnMusGirisYap.Text = "Giriş Yap";
            this.BtnMusGirisYap.UseVisualStyleBackColor = true;
            this.BtnMusGirisYap.Click += new System.EventHandler(this.BtnGirisYap_Click);
            // 
            // BtnMusKayitOl
            // 
            this.BtnMusKayitOl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMusKayitOl.Location = new System.Drawing.Point(134, 387);
            this.BtnMusKayitOl.Name = "BtnMusKayitOl";
            this.BtnMusKayitOl.Size = new System.Drawing.Size(228, 68);
            this.BtnMusKayitOl.TabIndex = 1;
            this.BtnMusKayitOl.Text = "Kayıt Ol";
            this.BtnMusKayitOl.UseVisualStyleBackColor = true;
            this.BtnMusKayitOl.Click += new System.EventHandler(this.BtnKayitOl_Click);
            // 
            // BtnYoneticiGiris
            // 
            this.BtnYoneticiGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnYoneticiGiris.Location = new System.Drawing.Point(610, 222);
            this.BtnYoneticiGiris.Name = "BtnYoneticiGiris";
            this.BtnYoneticiGiris.Size = new System.Drawing.Size(228, 68);
            this.BtnYoneticiGiris.TabIndex = 2;
            this.BtnYoneticiGiris.Text = "Yönetici Giriş";
            this.BtnYoneticiGiris.UseVisualStyleBackColor = true;
            // 
            // BtnCalisanGiris
            // 
            this.BtnCalisanGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalisanGiris.Location = new System.Drawing.Point(610, 387);
            this.BtnCalisanGiris.Name = "BtnCalisanGiris";
            this.BtnCalisanGiris.Size = new System.Drawing.Size(228, 68);
            this.BtnCalisanGiris.TabIndex = 3;
            this.BtnCalisanGiris.Text = "Çalışan Giriş";
            this.BtnCalisanGiris.UseVisualStyleBackColor = true;
            // 
            // FrmBaslangıcSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 700);
            this.Controls.Add(this.BtnCalisanGiris);
            this.Controls.Add(this.BtnYoneticiGiris);
            this.Controls.Add(this.BtnMusKayitOl);
            this.Controls.Add(this.BtnMusGirisYap);
            this.Name = "FrmBaslangıcSayfa";
            this.Text = "Ana Sayfa";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnMusGirisYap;
        private System.Windows.Forms.Button BtnMusKayitOl;
        private System.Windows.Forms.Button BtnYoneticiGiris;
        private System.Windows.Forms.Button BtnCalisanGiris;
    }
}