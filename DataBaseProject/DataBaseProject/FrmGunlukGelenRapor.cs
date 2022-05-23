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
    public partial class FrmGunlukGelenRapor : Form
    {
        public FrmGunlukGelenRapor()
        {
            InitializeComponent();
        }

        private void FrmGunlukGelenRapor_Load(object sender, EventArgs e)
        {
            DataBaseConnection baglanti = new DataBaseConnection();
            baglanti.DbConnection();
            string getCustomerNow = "select * from Reservation where CONVERT(date,ReservationDate)=convert(date,GETDATE())";
            SqlCommand cmd = new SqlCommand(getCustomerNow, baglanti.DbConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            baglanti.DbConnection().Close();
        }
    }
}
