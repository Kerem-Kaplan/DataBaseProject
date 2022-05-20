
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
            this.BtnRezervasyonGetir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnRezervasyon
            // 
            this.BtnRezervasyon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRezervasyon.Location = new System.Drawing.Point(128, 189);
            this.BtnRezervasyon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnRezervasyon.Name = "BtnRezervasyon";
            this.BtnRezervasyon.Size = new System.Drawing.Size(184, 69);
            this.BtnRezervasyon.TabIndex = 0;
            this.BtnRezervasyon.Text = "Rezervasyon Yap";
            this.BtnRezervasyon.UseVisualStyleBackColor = true;
            this.BtnRezervasyon.Click += new System.EventHandler(this.BtnRezervasyon_Click);
            // 
            // BtnRezervasyonGetir
            // 
            this.BtnRezervasyonGetir.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRezervasyonGetir.Location = new System.Drawing.Point(596, 189);
            this.BtnRezervasyonGetir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnRezervasyonGetir.Name = "BtnRezervasyonGetir";
            this.BtnRezervasyonGetir.Size = new System.Drawing.Size(158, 69);
            this.BtnRezervasyonGetir.TabIndex = 3;
            this.BtnRezervasyonGetir.Text = "Rezervasyon Getir";
            this.BtnRezervasyonGetir.UseVisualStyleBackColor = true;
            this.BtnRezervasyonGetir.Click += new System.EventHandler(this.BtnRezervasyonGetir_Click);
            // 
            // FrmAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 589);
            this.Controls.Add(this.BtnRezervasyonGetir);
            this.Controls.Add(this.BtnRezervasyon);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmAnasayfa";
            this.Text = "AnaSayfa";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnRezervasyon;
        private System.Windows.Forms.Button BtnRezervasyonGetir;
    }
}

