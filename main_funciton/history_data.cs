using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace main_funciton
{
    public class history_data
    {
        data_connection database = new data_connection();
        public DataTable data_grid ()
        {
            string command = "history_payment";
            SqlDataAdapter adapter = new SqlDataAdapter(command, database.data_base_connect());
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
