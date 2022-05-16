using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseProject
{
    public partial class FrmAnasayfa : Form
    {
        public FrmAnasayfa()
        {
            InitializeComponent();
        }

        private void BtnRezervasyon_Click(object sender, EventArgs e)
        {
            FrmRezervasyonSecimi frmRezervasyonSecimi = new FrmRezervasyonSecimi();
            frmRezervasyonSecimi.Show();
            this.Hide();
        }

        private void BtnYoneticiGiris_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnCalisanGiris_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnRezervasyonGetir_Click(object sender, EventArgs e)
        {

        }
    }
}
