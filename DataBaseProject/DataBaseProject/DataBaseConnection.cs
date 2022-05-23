using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseProject
{
    public class DataBaseConnection
    {
        public SqlConnection DbConnection()
        {
            SqlConnection connection = new SqlConnection("Data Source = DESKTOP; Initial Catalog = DbDataBaseProject; Integrated Security = True");
            connection.Open();
            return connection;
        }
    }
}
