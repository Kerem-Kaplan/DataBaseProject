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

        }

        private void BtnRezYap_Click(object sender, EventArgs e)
        {   
            TimeSpan timeSpan = DtpOnOdemeliBitisTarihi.Value - DtpOnOdemeliBasTarihi.Value;
            label1.Text = timeSpan.Days.ToString();

        }
    }
}
