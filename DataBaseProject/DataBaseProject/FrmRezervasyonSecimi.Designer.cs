
namespace DataBaseProject
{
    partial class FrmRezervasyonSecimi
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
            this.LblBİlgilendirme = new System.Windows.Forms.Label();
            this.BtnOnOdemeliRez = new System.Windows.Forms.Button();
            this.BtnStandartRez = new System.Windows.Forms.Button();
            this.BtnTesvikRez = new System.Windows.Forms.Button();
            this.Btn60GunOnceRez = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblBİlgilendirme
            // 
            this.LblBİlgilendirme.AutoSize = true;
            this.LblBİlgilendirme.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBİlgilendirme.Location = new System.Drawing.Point(269, 43);
            this.LblBİlgilendirme.Name = "LblBİlgilendirme";
            this.LblBİlgilendirme.Size = new System.Drawing.Size(203, 29);
            this.LblBİlgilendirme.TabIndex = 0;
            this.LblBİlgilendirme.Text = "İŞLEMİ SEÇİNİZ";
            // 
            // BtnOnOdemeliRez
            // 
            this.BtnOnOdemeliRez.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOnOdemeliRez.Location = new System.Drawing.Point(99, 166);
            this.BtnOnOdemeliRez.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnOnOdemeliRez.Name = "BtnOnOdemeliRez";
            this.BtnOnOdemeliRez.Size = new System.Drawing.Size(243, 110);
            this.BtnOnOdemeliRez.TabIndex = 1;
            this.BtnOnOdemeliRez.Text = "Ön Ödemeli Rezervasyon";
            this.BtnOnOdemeliRez.UseVisualStyleBackColor = true;
            this.BtnOnOdemeliRez.Click += new System.EventHandler(this.BtnOnOdemeliRez_Click);
            // 
            // BtnStandartRez
            // 
            this.BtnStandartRez.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStandartRez.Location = new System.Drawing.Point(421, 166);
            this.BtnStandartRez.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnStandartRez.Name = "BtnStandartRez";
            this.BtnStandartRez.Size = new System.Drawing.Size(243, 110);
            this.BtnStandartRez.TabIndex = 2;
            this.BtnStandartRez.Text = "Standart Rezervasyon";
            this.BtnStandartRez.UseVisualStyleBackColor = true;
            this.BtnStandartRez.Click += new System.EventHandler(this.BtnStandartRez_Click);
            // 
            // BtnTesvikRez
            // 
            this.BtnTesvikRez.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTesvikRez.Location = new System.Drawing.Point(421, 359);
            this.BtnTesvikRez.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnTesvikRez.Name = "BtnTesvikRez";
            this.BtnTesvikRez.Size = new System.Drawing.Size(243, 110);
            this.BtnTesvikRez.TabIndex = 3;
            this.BtnTesvikRez.Text = "Teşvik Rezervasyon";
            this.BtnTesvikRez.UseVisualStyleBackColor = true;
            this.BtnTesvikRez.Click += new System.EventHandler(this.BtnTesvikRez_Click);
            // 
            // Btn60GunOnceRez
            // 
            this.Btn60GunOnceRez.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn60GunOnceRez.Location = new System.Drawing.Point(99, 359);
            this.Btn60GunOnceRez.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn60GunOnceRez.Name = "Btn60GunOnceRez";
            this.Btn60GunOnceRez.Size = new System.Drawing.Size(243, 110);
            this.Btn60GunOnceRez.TabIndex = 4;
            this.Btn60GunOnceRez.Text = "60 Gün Önceden Rezervasyon";
            this.Btn60GunOnceRez.UseVisualStyleBackColor = true;
            this.Btn60GunOnceRez.Click += new System.EventHandler(this.Btn60GunOnceRez_Click);
            // 
            // FrmRezervasyonSecimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 581);
            this.Controls.Add(this.Btn60GunOnceRez);
            this.Controls.Add(this.BtnTesvikRez);
            this.Controls.Add(this.BtnStandartRez);
            this.Controls.Add(this.BtnOnOdemeliRez);
            this.Controls.Add(this.LblBİlgilendirme);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmRezervasyonSecimi";
            this.Text = "FrmReservationSelection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblBİlgilendirme;
        private System.Windows.Forms.Button BtnOnOdemeliRez;
        private System.Windows.Forms.Button BtnStandartRez;
        private System.Windows.Forms.Button BtnTesvikRez;
        private System.Windows.Forms.Button Btn60GunOnceRez;
    }
}