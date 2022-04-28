using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Data.SqlClient;
using main_funciton;


namespace WindowsFormsApp13
{
    public partial class Edit_Customer : MaterialForm
    {
        DataTable data;
        form_validate validate = new form_validate();
        public Edit_Customer(DataTable table)
        {
            InitializeComponent();
            data= table;

        }
        public void binding_data()
        {
            
            txt_firstname.DataBindings.Add("Text",data,"PERSONS_FIRST_NAME");
            txt_lastname.DataBindings.Add("text",data,"PERSONS_LAST_NAME");
            txt_number.DataBindings.Add("text", data, "PERSONS_PHONE_NUMBER");
            txt_address.DataBindings.Add("text", data, "PERSONS_ADDRESS");
            txt_username.DataBindings.Add("text", data, "PERSONS_USER_NAME");
            txt_password.DataBindings.Add("text", data, "PERSONS_USER_PASSWORD");
            
        }
       
        private void update_customer()
        {
            string LastName = txt_lastname.Text.Trim();
            string FirstName = txt_firstname.Text.Trim();
            string Address = txt_address.Text.Trim();
            string PhoneNumber = txt_number.Text.Trim();
            string UserName = txt_username.Text.Trim();
            string Password = txt_password.Text.Trim();
            int id = Convert.ToInt32(data.Rows[0][0]);
            user_data add_customer = new user_data();
            //check empty
           string [] array = {LastName, FirstName, Address, PhoneNumber, UserName, Password};

            if (validate.CheckEmpty(array) == true)
            {
                if (add_customer.Update_Customer(id, FirstName, LastName, PhoneNumber, Address, UserName, Password) == true)
                {
                    MessageBox.Show("update success");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("update failed check your Field");
                }
            }
            else if (validate.CheckEmpty(array) == false)
            {
                MessageBox.Show("Do Not empty");
            }
                      
        }
       
        private void Edit_Customer_Load(object sender, EventArgs e)
        {
            binding_data();

        }

        private void btn_customer_Click(object sender, EventArgs e)
        {
            update_customer();
        }
    }
}
