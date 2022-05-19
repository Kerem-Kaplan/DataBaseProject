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
    public partial class FrmOnOdemeliRezervasyon : Form
    {
        DataBaseConnection baglanti = new DataBaseConnection();
        public FrmOnOdemeliRezervasyon()
        {
            InitializeComponent();
        }
        private void FrmOnOdemeliRezervasyon_Load(object sender, EventArgs e)
        {

        //    DtpOnOdemeliBasTarihi.Value = DateTime.Now.AddDays(90);
            DtpOnOdemeliBasTarihi.MinDate= DateTime.Now.AddDays(90);
            DtpOnOdemeliBitisTarihi.MinDate = DateTime.Now.AddDays(90);
        //    DtpOnOdemeliBitisTarihi.Value = DateTime.Now.AddDays(90);
            

        }

        private void BtnRezYap_Click(object sender, EventArgs e)

        {

            baglanti.DbConnection();
            string insertCustomer = "insert into Customer(CustomerName,CustomerSurname,CustomerMail,CreditCardNumber)" +
                "values(@cusName,@cusSurname,@cusMail,@cusCard)";
            SqlCommand InsertCustomer = new SqlCommand(insertCustomer, baglanti.DbConnection());
            InsertCustomer.Parameters.AddWithValue("@cusName", TxtMusteriAd.Text);
            InsertCustomer.Parameters.AddWithValue("@cusSurname", TxtMusteriSoyad.Text);
            InsertCustomer.Parameters.AddWithValue("@cusMail", TxtMusteriMail.Text);
            InsertCustomer.Parameters.AddWithValue("@cusCard", TxtKrediKartiNo.Text);

            double rezSuresi = Math.Ceiling(RezarvasyonSuresi().TotalDays);
            double KalanSure = Math.Ceiling(GunKontrol().TotalDays);

            {
                TimeSpan timeSpan = DtpOnOdemeliBitisTarihi.Value - DtpOnOdemeliBasTarihi.Value;

                if (timeSpan.Days < 1)
                {
                    MessageBox.Show("Lütfen Gün bilgisini dogru giriniz");
                }
                else
                {
                    LblRezSure.Text = timeSpan.Days.ToString();
                    LblRezSure.Text = rezSuresi.ToString();
                    LblKalanSure.Text = KalanSure.ToString();
                    InsertCustomer.ExecuteNonQuery();
                }

                //string insertRez = "insert into Reservation(ReservationType,CustomerID,Price,RoomID,ReservationDate,ReservationTime,ReservationCreationDate)" +
                //    "values(@resType,@cusID,@price,@roomID,@resDate,@resTime,@resCreDate)";
                //SqlCommand InsertRez = new SqlCommand(insertRez, baglanti.DbConnection());
                //InsertRez.Parameters.AddWithValue("@resType", 1);
                //InsertRez.Parameters.AddWithValue("@cusID",)

                /*
                string getPrice = "select * from Hotel where LowestPriceID=@id";
                baglanti.DbConnection();

                SqlCommand GetPrice = new SqlCommand(getPrice, baglanti.DbConnection());
                GetPrice.Parameters.AddWithValue("@id", 1);
                SqlDataReader readerGetPrice = GetPrice.ExecuteReader();
                if (readerGetPrice.Read())
                {
                    LblTutar.Text = readerGetPrice["LowestPrice"].ToString();
                }
                readerGetPrice.Close();         //GÜN FARKINA GÖRE ÜCRETİN GÖSTERİLMESİ
                GetPrice.Dispose();
                baglanti.DbConnection().Close();*/
            }

            TimeSpan RezarvasyonSuresi()
            {
                TimeSpan Sure;
                Sure = DtpOnOdemeliBitisTarihi.Value - DtpOnOdemeliBasTarihi.Value;
                return Sure;
            }
            TimeSpan GunKontrol()
            {
                TimeSpan Fark;
                Fark = DtpOnOdemeliBasTarihi.Value - DateTime.Now;
                return Fark;
            }

        }
    }
}
