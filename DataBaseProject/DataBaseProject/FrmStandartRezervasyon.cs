using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DataBaseProject
{
    public partial class FrmStandartRezervasyon : Form
    {
        DataBaseConnection baglanti = new DataBaseConnection();

        public int[] id = new int[1];

        public FrmStandartRezervasyon()
        {
            InitializeComponent();
        }

<<<<<<< HEAD
        private void FrmStandartRezervasyon_Load(object sender, EventArgs e)
        {
            DtpTarih.MinDate = DateTime.Now;
        }

        private void BtnRezYap_Click(object sender, EventArgs e)
        {
            string getPrice = "select * from Hotel where LowestPriceID=@id";
            baglanti.DbConnection();

            SqlCommand GetPrice = new SqlCommand(getPrice, baglanti.DbConnection());
            GetPrice.Parameters.AddWithValue("@id", 1);
            SqlDataReader readerGetPrice = GetPrice.ExecuteReader();
            if (readerGetPrice.Read())
            {
                LblUcret.Text = (Convert.ToInt32(readerGetPrice["LowestPrice"].ToString())).ToString();
            }

            string insertCustomer = "update Customer set CustomerİnformationMail=@cusInfoMail where CustomerID=@id";

            if (Convert.ToInt32(TxtGunSayisi.Text) < 1)
            {
                MessageBox.Show("Lutfen 1 ve daha fazla gün sayısı giriniz");
            }
            else
            {
                LblRezSuresi.Text = TxtGunSayisi.Text;
                LblToplamTutar.Text = ((Convert.ToDouble(readerGetPrice["LowestPrice"].ToString())) * (Convert.ToInt32(TxtGunSayisi.Text))).ToString();
                SqlCommand InsertCustomer = new SqlCommand(insertCustomer, baglanti.DbConnection());
                InsertCustomer.Parameters.AddWithValue("@cusInfoMail", TxtİstenenMail.Text);
                InsertCustomer.Parameters.AddWithValue("@id", id[0]);
                InsertCustomer.ExecuteNonQuery();

                baglanti.DbConnection();
                string insertReservation = "insert into Reservation(ReservationType,CustomerID,Price,ReservationDate,ReservationTime,ReservationCreationDate)" +
                   "values(@resType,@cusID,@price,@resDate,@resTime,@resCreDate)";
                SqlCommand InsertReservation = new SqlCommand(insertReservation, baglanti.DbConnection());
                InsertReservation.Parameters.AddWithValue("@resType", 2);
                InsertReservation.Parameters.AddWithValue("@cusID", id[0]);
                InsertReservation.Parameters.AddWithValue("@price", Convert.ToInt32(LblToplamTutar.Text));
                InsertReservation.Parameters.AddWithValue("@resDate", DtpTarih.Value);
                InsertReservation.Parameters.AddWithValue("@resTime", Convert.ToInt32(TxtGunSayisi.Text));
                InsertReservation.Parameters.AddWithValue("@resCreDate", DateTime.Now);
                InsertReservation.ExecuteNonQuery();
                baglanti.DbConnection().Close();
                MessageBox.Show("Rezervasyon alındı");
            }
        }
=======
        
>>>>>>> eaa6f0aa9e7a65bfc93a96b84e8bad6e478a9aac
    }
}
