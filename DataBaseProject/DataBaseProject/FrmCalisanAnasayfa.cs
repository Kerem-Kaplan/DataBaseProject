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
    public partial class FrmCalisanAnasayfa : Form
    {
        public FrmCalisanAnasayfa()
        {
            InitializeComponent();
        }

        private void BtnGelenRapor_Click(object sender, EventArgs e)
        {
            FrmGunlukGelenRapor frmGunlukGelenRapor = new FrmGunlukGelenRapor();
            frmGunlukGelenRapor.Show();
            this.Hide();
        }
    }
}
