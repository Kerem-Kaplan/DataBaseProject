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
    public partial class FrmRezervasyonİptal : Form
    {
        public int[] id = new int[10];
        public FrmRezervasyonİptal()
        {
            InitializeComponent();
        }

        private void FrmRezervasyonİptal_Load(object sender, EventArgs e)
        {
            kayitGetir();
        }

        private void BtnIptal_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in dataGridView1.SelectedRows)
            {
                int id = Convert.ToInt32(drow.Cells[0].Value);
                kayitSil(id);
            }
            kayitGetir();
            MessageBox.Show("Kayıt Silinmiştir", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void kayitSil(int id)
        {
            DataBaseConnection baglanti = new DataBaseConnection();
            baglanti.DbConnection();
            string kayitSil = "delete from Reservation where ReservationID=@id";
            SqlCommand cmd = new SqlCommand(kayitSil, baglanti.DbConnection());
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            baglanti.DbConnection().Close();
            MessageBox.Show("Silindi");
        }
        private void kayitGetir()
        {
            DataBaseConnection baglanti = new DataBaseConnection();
            baglanti.DbConnection();
            string srmKayit = "select * from Reservation where CustomerID=@id";
            SqlCommand cmd = new SqlCommand(srmKayit, baglanti.DbConnection());
            cmd.Parameters.AddWithValue("@id", id[0]);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            baglanti.DbConnection().Close();
        }
    }
}
