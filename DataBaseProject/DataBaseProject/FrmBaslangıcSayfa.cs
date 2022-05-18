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
    public partial class FrmBaslangıcSayfa : Form
    {
        public FrmBaslangıcSayfa()
        {
            InitializeComponent();
        }

        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            FrmGirisYap frmGirisYap = new FrmGirisYap();
            frmGirisYap.Show();
            this.Hide();
        }

        private void BtnKayitOl_Click(object sender, EventArgs e)
        {
            FrmKayitOl frmKayitOl = new FrmKayitOl();
            frmKayitOl.Show();
            this.Hide();
        }
    }
}
