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
        public int[] id = new int[10];
        DataBaseConnection baglanti = new DataBaseConnection();
        public FrmOnOdemeliRezervasyon()
        {
            InitializeComponent();
        }
        private void FrmOnOdemeliRezervasyon_Load(object sender, EventArgs e)
        {

            //    DtpOnOdemeliBasTarihi.Value = DateTime.Now.AddDays(90);
            DtpOnOdemeliBasTarihi.MinDate = DateTime.Now.AddDays(90);
            DtpOnOdemeliBitisTarihi.MinDate = DateTime.Now.AddDays(90);
            //    DtpOnOdemeliBitisTarihi.Value = DateTime.Now.AddDays(90);


        }

        private void BtnRezYap_Click(object sender, EventArgs e)

        {
            double rezSuresi = Math.Ceiling(RezarvasyonSuresi().TotalDays);
            double KalanSure = Math.Ceiling(GunKontrol().TotalDays);

            {
                TimeSpan timeSpan = DtpOnOdemeliBitisTarihi.Value - DtpOnOdemeliBasTarihi.Value;

                //string insertRez = "insert into Reservation(ReservationType,CustomerID,Price,RoomID,ReservationDate,ReservationTime,ReservationCreationDate)" +
                //    "values(@resType,@cusID,@price,@roomID,@resDate,@resTime,@resCreDate)";
                //SqlCommand InsertRez = new SqlCommand(insertRez, baglanti.DbConnection());
                //InsertRez.Parameters.AddWithValue("@resType", 1);
                //InsertRez.Parameters.AddWithValue("@cusID",)
                string insertCustomer = "update Customer set CreditCardNumber=@cardNo where CustomerID=@id";
                SqlCommand InsertCustomer = new SqlCommand(insertCustomer, baglanti.DbConnection());
                InsertCustomer.Parameters.AddWithValue("@cardNo", TxtKrediKartNo.Text);
                InsertCustomer.Parameters.AddWithValue("@id", id[0]);
                InsertCustomer.ExecuteNonQuery();

                string getPrice = "select * from Hotel where LowestPriceID=@id";
                baglanti.DbConnection();

                SqlCommand GetPrice = new SqlCommand(getPrice, baglanti.DbConnection());
                GetPrice.Parameters.AddWithValue("@id", 1);
                SqlDataReader readerGetPrice = GetPrice.ExecuteReader();
                if (readerGetPrice.Read())
                {
                    LblTutar.Text = (Convert.ToInt32(readerGetPrice["LowestPrice"].ToString()) * (0.75)).ToString();
                }
                //GÜN FARKINA GÖRE ÜCRETİN GÖSTERİLMESİ

                if (timeSpan.Days < 1)
                {
                    MessageBox.Show("Lütfen Gün bilgisini dogru giriniz");
                }
                else
                {
                    LblRezSure.Text = timeSpan.Days.ToString();
                    LblRezSure.Text = rezSuresi.ToString();
                    LblKalanSure.Text = KalanSure.ToString();
                    LblToplamTutar.Text = ((Convert.ToDouble(readerGetPrice["LowestPrice"].ToString())) * (0.75) * (rezSuresi)).ToString();       //-->Toplam ücret gösterimi

                    baglanti.DbConnection();
                    string insertReservation = "insert into Reservation(ReservationType,CustomerID,Price,ReservationDate,ReservationTime,ReservationCreationDate)" +
                       "values(@resType,@cusID,@price,@resDate,@resTime,@resCreDate)";
                    SqlCommand InsertReservation = new SqlCommand(insertReservation, baglanti.DbConnection());
                    InsertReservation.Parameters.AddWithValue("@resType", 1);
                    InsertReservation.Parameters.AddWithValue("@cusID", id[0]);
                    InsertReservation.Parameters.AddWithValue("@price", Convert.ToInt32(LblToplamTutar.Text));
                    InsertReservation.Parameters.AddWithValue("@resDate", DtpOnOdemeliBasTarihi.Value);
                    InsertReservation.Parameters.AddWithValue("@resTime", Convert.ToInt32(LblRezSure.Text));
                    InsertReservation.Parameters.AddWithValue("@resCreDate", DateTime.Now);
                    InsertReservation.ExecuteNonQuery();
                    MessageBox.Show("Rezervasyon alındı");
                }
                readerGetPrice.Close();
                GetPrice.Dispose();
                baglanti.DbConnection().Close();
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

        private void BtnGeri_Click(object sender, EventArgs e)
        {
            FrmRezervasyonSecimi frmRezervasyonSecimi = new FrmRezervasyonSecimi();
            frmRezervasyonSecimi.id[0] = this.id[0];
            frmRezervasyonSecimi.Show();
            this.Hide();
        }

        private void TxtKrediKartNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
