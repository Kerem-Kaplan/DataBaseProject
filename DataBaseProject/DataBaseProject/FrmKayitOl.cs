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
    public partial class FrmKayitOl : Form
    {
        public FrmKayitOl()
        {
            InitializeComponent();
        }

        DataBaseConnection connection = new DataBaseConnection();
        private void BtnMusKayitOl_Click(object sender, EventArgs e)
        {
            if (TxtMusİsim.Text == "")
            {
                MessageBox.Show("Lütfen İsim Giriniz");
            }
            else if (TxtMusSoyisim.Text == "")
            {
                MessageBox.Show("Lütfen Soyisim Giriniz");
            }
            else if (TxtMusMail.Text == "")
            {
                MessageBox.Show("Lütfen Mail Giriniz");
            }
            else if (TxtMusSifre.Text == "" || TxtMusSifreTekrar.Text == "")
            {
                MessageBox.Show("Lütfen Şifre Giriniz");
            }
            else if (TxtMusSifre.Text != TxtMusSifreTekrar.Text)
            {
                MessageBox.Show("Şifreleri Aynı Giriniz");
            }
            else if (TxtKrediKartNo.Text == "")
            {
                MessageBox.Show("Lütfen Kredi Kartı Giriniz");
            }

            else
            {
                connection.DbConnection();
                string insertCustomer = "insert into Customer(CustomerName,CustomerSurname,CustomerMail,CustomerPassword,CreditCardNumber)" +
                    "values (@cusName,@cusSurname,@cusMail,@cusPassword,@cusCard)";
                SqlCommand InsertCustomer = new SqlCommand(insertCustomer, connection.DbConnection());
                InsertCustomer.Parameters.AddWithValue("@cusName", TxtMusİsim.Text);
                InsertCustomer.Parameters.AddWithValue("@cusSurname", TxtMusSoyisim.Text);
                InsertCustomer.Parameters.AddWithValue("@cusMail", TxtMusMail.Text);
                InsertCustomer.Parameters.AddWithValue("@cusPassword", TxtMusSifre.Text);
                InsertCustomer.Parameters.AddWithValue("@cusCard", TxtKrediKartNo.Text);
                InsertCustomer.ExecuteNonQuery();
                MessageBox.Show("Kayıt Başarılı");
                FrmGirisYap frmGirisYap = new FrmGirisYap();
                frmGirisYap.Show();
                this.Hide();
            }

        }
    }
}
