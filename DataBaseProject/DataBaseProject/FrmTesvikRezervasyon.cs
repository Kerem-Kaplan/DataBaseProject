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
    public partial class FrmTesvikRezervasyon : Form
    {
        public int[] id = new int[10];
        public FrmTesvikRezervasyon()
        {
            InitializeComponent();
        }
        DataBaseConnection baglanti = new DataBaseConnection();
        SqlDataReader reader;
        SqlCommand GetInfoRes;
        private void FrmTesvikRezervasyon_Load(object sender, EventArgs e)
        {
            DtpTesRezBasTarihi.MinDate = DateTime.Now.AddDays(0);
            DtpTesvikBitisTarihi.MinDate = DateTime.Now.AddDays(1);
            string getPrice = "select * from Hotel where LowestPriceID=@id";
            baglanti.DbConnection();
            SqlCommand GetPrice = new SqlCommand(getPrice, baglanti.DbConnection());
            GetPrice.Parameters.AddWithValue("@id", 1);
            reader = GetPrice.ExecuteReader();


            string getInfoRes = "select COUNT(*) from Reservation where ReservationTime<30";
            baglanti.DbConnection();
            GetInfoRes = new SqlCommand(getInfoRes, baglanti.DbConnection());
            if (reader.Read())
            {
                if (Convert.ToInt32(GetInfoRes.ExecuteScalar()) < 23)
                {
                    LblTutar.Text = (Convert.ToInt32(reader["LowestPrice"].ToString()) * (0.80)).ToString();
                }
                else
                {
                    LblTutar.Text = (Convert.ToInt32(reader["LowestPrice"].ToString()) * (1)).ToString();
                }
            }


        }
        TimeSpan RezarvasyonSuresi()
        {
            TimeSpan Sure;
            Sure = DtpTesvikBitisTarihi.Value - DtpTesRezBasTarihi.Value;
            return Sure;
        }
        private void BtnGeri_Click(object sender, EventArgs e)
        {
            FrmRezervasyonSecimi frmRezervasyonSecimi = new FrmRezervasyonSecimi();
            frmRezervasyonSecimi.id[0] = this.id[0];
        }

        private void TxtGunSayisi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void BtnRezYap_Click(object sender, EventArgs e)
        {
            double rezSuresi = Math.Ceiling(RezarvasyonSuresi().TotalDays);

            LblRezSuresi.Text = rezSuresi.ToString();

            if (Convert.ToInt32(GetInfoRes.ExecuteScalar()) < 23)
            {
                LblToplamTutar.Text = (Convert.ToInt32(reader["LowestPrice"].ToString()) * (0.80) * (rezSuresi)).ToString();        //-->Toplam ücret gösterimi
            }
            else
            {
                LblToplamTutar.Text = (Convert.ToInt32(reader["LowestPrice"].ToString()) * (1) * (rezSuresi)).ToString();
            }

            string insertCustomer = "update Customer set CreditCardNumber=@cardNo where CustomerID=@id";
            SqlCommand InsertCustomer = new SqlCommand(insertCustomer, baglanti.DbConnection());
            InsertCustomer.Parameters.AddWithValue("@cardNo", TxtKrediKartNo.Text);
            InsertCustomer.Parameters.AddWithValue("@id", id[0]);
            InsertCustomer.ExecuteNonQuery();


            baglanti.DbConnection();
            string insertReservation = "insert into Reservation(ReservationType,CustomerID,Price,ReservationDate,ReservationTime,ReservationCreationDate)" +
               "values(@resType,@cusID,@price,@resDate,@resTime,@resCreDate)";
            SqlCommand InsertReservation = new SqlCommand(insertReservation, baglanti.DbConnection());
            InsertReservation.Parameters.AddWithValue("@resType", 4);
            InsertReservation.Parameters.AddWithValue("@cusID", id[0]);
            InsertReservation.Parameters.AddWithValue("@price", Convert.ToInt32(LblToplamTutar.Text));
            InsertReservation.Parameters.AddWithValue("@resDate", DtpTesRezBasTarihi.Value);
            InsertReservation.Parameters.AddWithValue("@resTime", Convert.ToInt32(LblRezSuresi.Text));
            InsertReservation.Parameters.AddWithValue("@resCreDate", DateTime.Now);
            InsertReservation.ExecuteNonQuery();
            MessageBox.Show("Rezervasyon alındı");

        }
    }
}
