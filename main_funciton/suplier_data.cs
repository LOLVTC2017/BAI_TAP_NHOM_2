using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace main_funciton
{
    public  class suplier_data
    {
        data_connection database = new data_connection();
        public DataTable get_suplier_data()
        {
            string COMMAND = "SELECT * FROM SUPPLIER ";

            SqlDataAdapter adapter = new SqlDataAdapter(COMMAND,database.data_base_connect());

            DataTable table = new DataTable();

            adapter.Fill(table);

            return table;
        }
        public DataTable get_suplier_grid(int id)
        {
            string command = String.Format("suplier_grid {0}", id);
            SqlDataAdapter adapter = new SqlDataAdapter(command,database.data_base_connect());
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public void add_suplier()
        {

        }

        public void edit_suplier()
        {

        }
        public void delette_suplier()
        {

        }
    }
}
