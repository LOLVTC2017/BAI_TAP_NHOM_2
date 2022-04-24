using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using MaterialSkin;
using MaterialSkin.Controls;
namespace WindowsFormsApp13
{
    public partial class ADMIN_FORM : MaterialForm
    {
        public ADMIN_FORM()
        {
            InitializeComponent();
        }
        Hashtable Hash_Data = new Hashtable();
        private void ADMIN_FORM_Load(object sender, EventArgs e)
        {
            load_data();
        }
        public void load_data() //using to load another function
        {
          
            add_account();
        }
        public void check_login ()
        {
            
            if (Hash_Data.ContainsKey(this.txt_username.Text) == false)
            {

                MessageBox.Show("User Name Incorrect");
            }
            else if (Hash_Data.ContainsValue(this.txt_password.Text) == false)
            {
                MessageBox.Show("Password Incorrect");
            }

            else
            {
                MessageBox.Show("Welcome");
                Main_form System_Form = new Main_form();
                System_Form.Show();
                this.Hide();
              
            }
        }
        public void add_account ()
        {
            this.txt_username.Focus();
            Hash_Data.Add("admin", "123456789");

        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            check_login();
        }
    }
}
