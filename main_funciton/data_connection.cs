using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace main_funciton
{
    public class data_connection
    {
        public SqlConnection data_base_connect()
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=phu;Initial Catalog=QUANLY_KHACHHANG;Integrated Security=True");
            return sqlConnection;
        }
    }
}
