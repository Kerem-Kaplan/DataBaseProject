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
    public partial class FrmRezervasyonSecimi : Form
    {
        public FrmRezervasyonSecimi()
        {
            InitializeComponent();
        }

        private void BtnOnOdemeliRez_Click(object sender, EventArgs e)
        {
            FrmOnOdemeliRezervasyon frmOnOdemeliRezervasyon = new FrmOnOdemeliRezervasyon();
            frmOnOdemeliRezervasyon.Show();
            this.Hide();
        }
    }
}
