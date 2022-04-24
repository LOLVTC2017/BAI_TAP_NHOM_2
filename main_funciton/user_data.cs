using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace main_funciton
{
    public class user_data
    {
        data_connection connection = new data_connection();
        public DataTable Get_User ()
        {
            string command =
                "SELECT PERSONS.PERSONS_FIRST_NAME +' '+PERSONS.PERSONS_LAST_NAME AS CUSTOMER_NAME,PERSONS.PERSONS_ID,PERSONS_USER_ID,PERSONS_ADDRESS,PERSONS_PHONE_NUMBER FROM PERSONS";

            SqlDataAdapter adapter = new SqlDataAdapter(command,connection.data_base_connect());
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        public DataTable girdview_data(int id)
        {
            string command = String.Format("USER_GRID  {0}", id);
            SqlDataAdapter adapter = new SqlDataAdapter(command, connection.data_base_connect());
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
    }
}
