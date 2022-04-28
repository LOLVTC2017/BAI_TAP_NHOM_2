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
        form_validate validate = new form_validate();
        public Add_customer()
        {
            InitializeComponent();
        }

        private void Add_customer_Load(object sender, EventArgs e)
        {

        }
        // fix check empty check empty??? :)) à oke, vậy là check con text nó có rỗng hay không à? oke
        private void ADD_CUSTOMER()
        {
            string LastName = txt_lastname.Text;
            string FirstName = txt_firstname.Text;
            string Address = txt_address.Text;
            string PhoneNumber = txt_number.Text;
            string UserName = txt_username.Text;
            string Password = txt_password.Text;
            user_data add_customer = new user_data();
            string [] allText = {LastName, FirstName, Address, PhoneNumber, UserName, Password}; 
            if (validate.CheckEmpty(allText) == true)
            {
                if (add_customer.add_customer(FirstName, LastName, PhoneNumber, Address, UserName, Password) == true)
                {
                    MessageBox.Show("Add success");
                    txt_lastname.Text = "";
                    txt_firstname.Text = "";
                    txt_address.Text = "";
                    txt_number.Text = "";
                    txt_username.Text = "";
                    txt_password.Text = "";
                }
                else
                {
                    MessageBox.Show("Add Failed");
                }
            }
            else if (validate.CheckEmpty(allText) == false)
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
