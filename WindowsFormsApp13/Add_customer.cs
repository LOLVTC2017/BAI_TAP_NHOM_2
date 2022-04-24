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
    public partial class Add_customer : MaterialForm
    {
        public Add_customer()
        {
            InitializeComponent();
        }

        private void Add_customer_Load(object sender, EventArgs e)
        {

        }
        public Boolean CheckEmpty()
        {
            bool empty = false;
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    TextBox textBox = c as TextBox;
                    if (textBox.Text == string.Empty)
                    {
                        return empty;
                    }
                    else
                    {
                        return empty= true;
                    }
                }
            }
            return empty;
           
        }
        private void ADD_CUSTOMER()
        {
            string LastName = txt_lastname.Text.Trim();
            string FirstName = txt_firstname.Text.Trim();
            string Address = txt_address.Text.Trim();
            string PhoneNumber = txt_number.Text.Trim();
            string UserName = txt_username.Text.Trim();
            string Password = txt_password.Text.Trim();
            user_data add_customer = new user_data();
            //check empty
            if (CheckEmpty() == true)
            {
                if (add_customer.add_customer(FirstName, LastName, PhoneNumber, Address, UserName, Password) == true)
                {
                    MessageBox.Show("Add success");
                    foreach (Control c in this.Controls)
                    {

                        if (c is TextBox)
                        {
                            ((TextBox)c).Text = String.Empty;
                        }
                    }

                }
            }
            else
            {
                MessageBox.Show("Do Not Empty");
            }
            
        }
        private void btn_customer_Click(object sender, EventArgs e)
        {
            ADD_CUSTOMER();
        }

        private void txt_number_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
