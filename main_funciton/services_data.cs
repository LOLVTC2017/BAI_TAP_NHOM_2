using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace main_funciton
{
    public class services_data
    {
        data_connection database = new data_connection();
        public DataTable get_services_data()
        {
            string command = "SELECT * FROM SERVICES";
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command,database.data_base_connect());
            adapter.Fill(table);
            return table;
        }
        public DataTable get_services_infor(int id )
        {
            string command = String.Format("services_Infor {0}", id);
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command, database.data_base_connect());
            adapter.Fill(table);
            return table;          
        }
    }
}
