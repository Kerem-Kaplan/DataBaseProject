
namespace DataBaseProject
{
    partial class FrmAnasayfa
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
            this.BtnRezervasyon = new System.Windows.Forms.Button();
            this.BtnCalisanGiris = new System.Windows.Forms.Button();
            this.BtnYoneticiGiris = new System.Windows.Forms.Button();
            this.BtnRezervasyonGetir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnRezervasyon
            // 
            this.BtnRezervasyon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRezervasyon.Location = new System.Drawing.Point(171, 233);
            this.BtnRezervasyon.Name = "BtnRezervasyon";
            this.BtnRezervasyon.Size = new System.Drawing.Size(246, 85);
            this.BtnRezervasyon.TabIndex = 0;
            this.BtnRezervasyon.Text = "Rezervasyon Yap";
            this.BtnRezervasyon.UseVisualStyleBackColor = true;
            // 
            // BtnCalisanGiris
            // 
            this.BtnCalisanGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalisanGiris.Location = new System.Drawing.Point(841, 233);
            this.BtnCalisanGiris.Name = "BtnCalisanGiris";
            this.BtnCalisanGiris.Size = new System.Drawing.Size(211, 85);
            this.BtnCalisanGiris.TabIndex = 1;
            this.BtnCalisanGiris.Text = "Çalışan Giriş";
            this.BtnCalisanGiris.UseVisualStyleBackColor = true;
            // 
            // BtnYoneticiGiris
            // 
            this.BtnYoneticiGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnYoneticiGiris.Location = new System.Drawing.Point(486, 233);
            this.BtnYoneticiGiris.Name = "BtnYoneticiGiris";
            this.BtnYoneticiGiris.Size = new System.Drawing.Size(211, 85);
            this.BtnYoneticiGiris.TabIndex = 2;
            this.BtnYoneticiGiris.Text = "Yönetici Giriş";
            this.BtnYoneticiGiris.UseVisualStyleBackColor = true;
            // 
            // BtnRezervasyonGetir
            // 
            this.BtnRezervasyonGetir.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRezervasyonGetir.Location = new System.Drawing.Point(486, 392);
            this.BtnRezervasyonGetir.Name = "BtnRezervasyonGetir";
            this.BtnRezervasyonGetir.Size = new System.Drawing.Size(211, 85);
            this.BtnRezervasyonGetir.TabIndex = 3;
            this.BtnRezervasyonGetir.Text = "Rezervasyon Getir";
            this.BtnRezervasyonGetir.UseVisualStyleBackColor = true;
            // 
            // FrmAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1443, 725);
            this.Controls.Add(this.BtnRezervasyonGetir);
            this.Controls.Add(this.BtnYoneticiGiris);
            this.Controls.Add(this.BtnCalisanGiris);
            this.Controls.Add(this.BtnRezervasyon);
            this.Name = "FrmAnasayfa";
            this.Text = "AnaSayfa";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnRezervasyon;
        private System.Windows.Forms.Button BtnCalisanGiris;
        private System.Windows.Forms.Button BtnYoneticiGiris;
        private System.Windows.Forms.Button BtnRezervasyonGetir;
    }
}

