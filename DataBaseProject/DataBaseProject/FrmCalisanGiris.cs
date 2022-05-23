using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseProject
{
    public partial class FrmCalisanGiris : Form
    {
        public FrmCalisanGiris()
        {
            InitializeComponent();
        }

        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            DataBaseConnection baglanti = new DataBaseConnection();
            string getWorker = "select * from Workers where WorkerMail=@mail and WorkerPassword=@password";
            SqlCommand GetCustomer = new SqlCommand(getWorker, baglanti.DbConnection());
            GetCustomer.Parameters.AddWithValue("@mail", TxtCalisanMail.Text);
            GetCustomer.Parameters.AddWithValue("@password", TxtCalisanSifre.Text);
            SqlDataReader readerGetCustomer = GetCustomer.ExecuteReader();
            if (readerGetCustomer.Read())
            {
                MessageBox.Show("Giriş Başarılı");
                FrmCalisanAnasayfa frmCalisanAnasayfa = new FrmCalisanAnasayfa();
                frmCalisanAnasayfa.Show();
                this.Hide();
            }
        }
    }
}
