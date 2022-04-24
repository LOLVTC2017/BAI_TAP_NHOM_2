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
    public partial class Main_form : MaterialForm
    {
        public Main_form()
        {
            InitializeComponent();
        }
        user_data users_function = new user_data();
        private void Main_form_Load(object sender, EventArgs e)
        {
            load_fucntion();
        }
        private void load_fucntion ()
        {
            Load_user_data();
            Load_gridata();
        }
        private void Load_user_data()
        {
            
            cbx_username.DataSource = users_function.Get_User();
            cbx_username.DisplayMember = "CUSTOMER_NAME";
            cbx_username.ValueMember = "PERSONS_ID";
        }

        private void Load_gridata()
        {
            
             if(cbx_username.SelectedValue.ToString() != "System.Data.DataRowView")
                {
                int id = Convert.ToInt32(cbx_username.SelectedValue);

                grid_data1.DataSource = users_function.girdview_data(id);
                }
          
        }
      
        private void page_users_Click(object sender, EventArgs e)
        {

        }

        private void cbx_username_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load_gridata();
        }
    }
}
