
namespace DataBaseProject
{
    partial class FrmCalisanAnasayfa
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
            this.BtnDolulukRapor = new System.Windows.Forms.Button();
            this.BtnGelenRapor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnDolulukRapor
            // 
            this.BtnDolulukRapor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDolulukRapor.ForeColor = System.Drawing.Color.Coral;
            this.BtnDolulukRapor.Location = new System.Drawing.Point(81, 165);
            this.BtnDolulukRapor.Name = "BtnDolulukRapor";
            this.BtnDolulukRapor.Size = new System.Drawing.Size(156, 113);
            this.BtnDolulukRapor.TabIndex = 0;
            this.BtnDolulukRapor.Text = "Günlük Doluluk Oranı";
            this.BtnDolulukRapor.UseVisualStyleBackColor = true;
            // 
            // BtnGelenRapor
            // 
            this.BtnGelenRapor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGelenRapor.ForeColor = System.Drawing.Color.Coral;
            this.BtnGelenRapor.Location = new System.Drawing.Point(422, 165);
            this.BtnGelenRapor.Name = "BtnGelenRapor";
            this.BtnGelenRapor.Size = new System.Drawing.Size(156, 113);
            this.BtnGelenRapor.TabIndex = 2;
            this.BtnGelenRapor.Text = "Günlük Gelen Rapor";
            this.BtnGelenRapor.UseVisualStyleBackColor = true;
            this.BtnGelenRapor.Click += new System.EventHandler(this.BtnGelenRapor_Click);
            // 
            // FrmCalisanAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 585);
            this.Controls.Add(this.BtnGelenRapor);
            this.Controls.Add(this.BtnDolulukRapor);
            this.Name = "FrmCalisanAnasayfa";
            this.Text = "FrmCalisanAnasayfa";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnDolulukRapor;
        private System.Windows.Forms.Button BtnGelenRapor;
    }
}