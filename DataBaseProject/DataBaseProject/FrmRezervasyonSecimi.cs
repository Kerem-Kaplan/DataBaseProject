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
        public int[] id = new int[10];
        public FrmRezervasyonSecimi()
        {
            InitializeComponent();
        }

        private void BtnOnOdemeliRez_Click(object sender, EventArgs e)
        {
            FrmOnOdemeliRezervasyon frmOnOdemeliRezervasyon = new FrmOnOdemeliRezervasyon();
            frmOnOdemeliRezervasyon.id[0] = this.id[0];
            frmOnOdemeliRezervasyon.Show();
            this.Hide();
        }

        private void Btn60GunOnceRez_Click(object sender, EventArgs e)
        {
            Frm60GunOncedenRezervasyon frm60GunOncedenRezervasyon = new Frm60GunOncedenRezervasyon();
            frm60GunOncedenRezervasyon.id[0] = this.id[0];
            frm60GunOncedenRezervasyon.Show();
            this.Hide();
        }

        private void BtnTesvikRez_Click(object sender, EventArgs e)
        {
            FrmTesvikRezervasyon frmTesvikRezervasyon = new FrmTesvikRezervasyon();
            frmTesvikRezervasyon.id[0] = this.id[0];
            frmTesvikRezervasyon.Show();
            this.Hide();
        }
    }
}
