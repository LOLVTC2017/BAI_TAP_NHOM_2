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
            string command_text =
                "SELECT PERSONS.PERSONS_FIRST_NAME +' '+PERSONS.PERSONS_LAST_NAME AS CUSTOMER_NAME,PERSONS.PERSONS_ID,PERSONS_USER_ID,PERSONS_ADDRESS,PERSONS_PHONE_NUMBER FROM PERSONS";

            SqlDataAdapter adapter = new SqlDataAdapter(command_text, connection.data_base_connect());
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        public DataTable girdview_data(int id)
        {
            string command_text = String.Format("USER_GRID  {0}", id);
            SqlDataAdapter adapter = new SqlDataAdapter(command_text, connection.data_base_connect());
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public Boolean add_customer(string FirstName,string LastName,string PhoneNumber,string Address,string UserName,string PassWord)
        {
            string command_text = ("Insert_customter @FirstName,@LastName,@PhoneNumber,@Address,@UserName,@PassWord");

            SqlCommand commander = new SqlCommand(command_text, connection.data_base_connect());
            commander.Parameters.AddWithValue("@FirstName", FirstName);
            commander.Parameters.AddWithValue("@LastName", LastName);
            commander.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
            commander.Parameters.AddWithValue("@Address", Address);
            commander.Parameters.AddWithValue("@UserName", UserName);
            commander.Parameters.AddWithValue("@PassWord", PassWord);
            commander.Connection.Open();
            if(commander.ExecuteNonQuery() > 0) //neu no  >1 la insert con duoi 0 la chua insert > bug con me m :)) hao z wtf see?? bitchh??  lma
            {
                commander.Connection.Close();
                return true;
                
            }
            else if (commander.ExecuteNonQuery() <0)
            {
                commander.Connection.Close();
                return false;
               
            }
            else
            {
                return false; 
            }

        }
        public DataTable edit_selected_customer(int id )
        {
            string command_text = String.Format("Edit_User  {0}", id);
            SqlDataAdapter adapter = new SqlDataAdapter(command_text, connection.data_base_connect());
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        public Boolean Update_Customer(int id,string FirstName, string LastName, string PhoneNumber, string Address, string UserName, string PassWord)
        {
            string command_text = ("Update_User @ID,@FirstName,@LastName,@PhoneNumber,@Address,@UserName,@PassWord");

            SqlCommand commander = new SqlCommand(command_text, connection.data_base_connect());
            commander.Parameters.AddWithValue("@ID", id);
            commander.Parameters.AddWithValue("@FirstName", FirstName);
            commander.Parameters.AddWithValue("@LastName", LastName);
            commander.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
            commander.Parameters.AddWithValue("@Address", Address);
            commander.Parameters.AddWithValue("@UserName", UserName);
            commander.Parameters.AddWithValue("@PassWord", PassWord);
            commander.Connection.Open();
            if (commander.ExecuteNonQuery() == 1)
            {
                commander.Connection.Close();
                return true;

            }
            else
            {
                commander.Connection.Close();
                return false;

            }

        }
        public Boolean delelte_customer(int id)
        {
            bool delete = false;
            string command = String.Format("DELETE_CUSTOMER {0}", id);
            SqlCommand commander = new SqlCommand(command, connection.data_base_connect());
            commander.Connection.Open();
            if(commander.ExecuteNonQuery() >0)
            {
                commander.Connection.Close();
                return delete = true;

            }
            else if (commander.ExecuteNonQuery() < 0)
            {
                commander.Connection.Close();
                return delete = false;
            }
            return delete;

        }
    }
}
