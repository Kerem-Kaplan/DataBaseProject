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
    public partial class FrmOnOdemeliRezervasyon : Form
    {
        public FrmOnOdemeliRezervasyon()
        {
            InitializeComponent();
        }
        private void FrmOnOdemeliRezervasyon_Load(object sender, EventArgs e)
        {
            DtpOnOdemeliBasTarihi.Value = DateTime.Now.AddDays(90);
            DtpOnOdemeliBitisTarihi.Value = DateTime.Now.AddDays(90);
        }

        private void BtnRezYap_Click(object sender, EventArgs e)
        {
            double rezSuresi = Math.Ceiling(RezarvasyonSuresi().TotalDays);

            label1.Text = rezSuresi.ToString();

            double KalanSure = Math.Ceiling(GunKontrol().TotalDays);
            label4.Text = KalanSure.ToString();
        }

        public TimeSpan RezarvasyonSuresi()
        {
            TimeSpan Sure;
            Sure = DtpOnOdemeliBitisTarihi.Value - DtpOnOdemeliBasTarihi.Value;
            return Sure;
        }
        public TimeSpan GunKontrol()
        {
            TimeSpan Fark;
            Fark = DtpOnOdemeliBasTarihi.Value - DateTime.Now;
            return Fark;
        }


    }
}
