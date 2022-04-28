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
        public Boolean add_suplier(string name ,string address,string number)
        {
            bool add_suplier = false;
            string command = "insert_suplier @name,@address,@number ";
            SqlCommand commander = new SqlCommand(command, database.data_base_connect());
            commander.Parameters.AddWithValue("name", name);
            commander.Parameters.AddWithValue("address", address);
            commander.Parameters.AddWithValue("number", number);
            commander.Connection.Open();
            if (commander.ExecuteNonQuery()>0)
            {
                commander.Connection.Close();
                return add_suplier = true;
            }
            else if(commander.ExecuteNonQuery()<0) 
            {
                commander.Connection.Close();
                return add_suplier = false;
            }
            else
            {
                return add_suplier;
            }

        }
        public DataTable edit_selected_suplier(int id)
        {
            string command = String.Format("get_suplier {0}", id);
            SqlDataAdapter adapter = new SqlDataAdapter(command, database.data_base_connect());
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public Boolean update_suplier(int id,string name, string address,string number)
        {
            string command = "update_suplier @id,@name,@address,@number ";
            SqlCommand commander = new SqlCommand(command, database.data_base_connect());
            commander.Parameters.AddWithValue("@name", name);
            commander.Parameters.AddWithValue ("@address", address);
            commander.Parameters.AddWithValue("@number", number);
            commander.Parameters.AddWithValue("@id", id);
            commander.Connection.Open();
            if (commander.ExecuteNonQuery() > 0)
            {
                commander.Connection.Close();
                return true;
            }
            else if (commander.ExecuteNonQuery() < 0)
            {
                return false;
            }
            else return false;



        }
        //need to fix inside sql
        public Boolean delete_suplier(int id)
        {
            string command = String.Format("delete_suplier {0}",id);
            SqlCommand commander = new SqlCommand(command, database.data_base_connect());
            if (commander.ExecuteNonQuery() > 0) return true;
            else if (commander.ExecuteNonQuery() < 0) return false;
            else return false;
        }
    }
}
