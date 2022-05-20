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
    public partial class FrmGirisYap : Form
    {
        public int[] id = new int[10];
        public FrmGirisYap()
        {
            InitializeComponent();
        }

        DataBaseConnection connection = new DataBaseConnection();
        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            connection.DbConnection();
            string getCustomer = "select * from Customer where CustomerMail=@mail and CustomerPassword=@password";
            SqlCommand GetCustomer = new SqlCommand(getCustomer, connection.DbConnection());
            GetCustomer.Parameters.AddWithValue("@mail", TxtMusMail.Text);
            GetCustomer.Parameters.AddWithValue("@password", TxtMusSifre.Text);
            SqlDataReader readerGetCustomer = GetCustomer.ExecuteReader();
            if (readerGetCustomer.Read())
            {
                id[0] = Convert.ToInt32(readerGetCustomer["CustomerID"].ToString());
                MessageBox.Show(id[0].ToString());
                MessageBox.Show("Giriş Başarılı");
                FrmAnasayfa frmAnasayfa = new FrmAnasayfa();
                frmAnasayfa.id[0] = this.id[0];
                frmAnasayfa.Show();
                this.Hide();
            }
        }
    }
}
