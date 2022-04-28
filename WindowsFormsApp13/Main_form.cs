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
        suplier_data suplier_function = new suplier_data();
        services_data services_function = new services_data();  
        private void Main_form_Load(object sender, EventArgs e)
        {
            load_fucntion();
        }
        //THIS LOAD_FUNCTION GROUP ALL FUNCTION NEED TO RUN WITH FORM LOAD 
        private void load_fucntion ()
        {
            //load data first before load gird
            //user tab 
            Load_user_data();
            Load_grid_userdata();
            //suplier tab 
            Load_suplier_data();
            Load_grid_suplier();
            //services tab
            fill_list_services();


        }
        //user_function
        private void Load_user_data()
        {
            user_data users_function = new user_data();
            cbx_username.DataSource = users_function.Get_User();
            cbx_username.DisplayMember = "CUSTOMER_NAME";
            cbx_username.ValueMember = "PERSONS_ID";
        }
        private void delete_customer ()
        {
            int id = Convert.ToInt16(cbx_username.SelectedValue);

            DialogResult dialogResult = MessageBox.Show("This Action will delele  payment and purchase history", "DELETE CUSTOMER", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
             

                if (users_function.delelte_customer(id) == true)
                {
                    MessageBox.Show("Delete Success");
                }
                else if (users_function.delelte_customer(id) == false)
                {
                    MessageBox.Show("Delete Failed");
                }
                Load_user_data();
            }
            else if (dialogResult == DialogResult.No)
            {
              
            }
        }

        private void Load_grid_userdata()
        {
            user_data users_function = new user_data();
            if (cbx_username.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                int id = Convert.ToInt32(cbx_username.SelectedValue);
                grid_data1.DataSource = users_function.girdview_data(id);
            }

        }
        //suplier_function
        private void Load_suplier_data()
        {
            suplier_data suplier = new suplier_data();
            cbx_suplier_name.DataSource = suplier.get_suplier_data();
            cbx_suplier_name.DisplayMember = "SUPPLIER_NAME";
            cbx_suplier_name.ValueMember = "SUPPLIER_ID";
        }
        private void delete_suplier()
        {
            int id = Convert.ToInt32(cbx_suplier_name.SelectedValue);
            suplier_data suplier = new suplier_data();
            DialogResult dialogResult = MessageBox.Show("This Action will delele THE SERVICES PRODUCT AND ALL PURCHASE HISTORY", "DELETE SUPLIER", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                if (suplier.delete_suplier(id) == true) { MessageBox.Show("Delete success"); load_fucntion(); }
                else if (suplier.delete_suplier(id) == false) MessageBox.Show("delete failed");
                Load_user_data();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }
        private void Load_grid_suplier()
        {
            suplier_data suplier = new suplier_data();
            if (cbx_suplier_name.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                int id = Convert.ToInt32(cbx_suplier_name.SelectedValue);
                grid_data1.DataSource = users_function.girdview_data(id);
                grid_data2.DataSource = suplier.get_suplier_grid(id);
            }
           
        }
        //services_function
        private void fill_list_services()
        {
            services_data services = new services_data();
            list_services.Items.Clear();
            foreach(DataRow dr in services.get_services_data().Rows )
            {
                list_services.Items.Add(dr["services_name"].ToString());
            }
        }

        private void fill_infor_services()
        {

        }
        //event
        private void page_users_Click(object sender, EventArgs e)
        {

        }

        private void cbx_username_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load_grid_userdata();
        }

        private void page_supplier_Click(object sender, EventArgs e)
        {

        }

        private void cbx_suplier_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load_grid_suplier();
        }

        private void page_services_Click(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            Add_customer customer = new Add_customer();
            customer.Show();
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32( cbx_username.SelectedValue);
            user_data pass_data = new user_data();
            Edit_Customer form = new Edit_Customer(pass_data.edit_selected_customer(id));
            form.Show();      
            
        }
        
        private void materialButton3_Click(object sender, EventArgs e)
        {
            delete_customer();
        }

        private void btx_delete_suplier_Click(object sender, EventArgs e)
        {
            delete_suplier();
        }

        private void btx_add_suplier_Click(object sender, EventArgs e)
        {
            Add_suplier suplier = new Add_suplier();
            suplier.Show();
        }

        private void btx_edit_suplier_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(cbx_suplier_name.SelectedValue);
            suplier_data pass_data = new suplier_data();
            Edit_suplier form = new Edit_suplier(pass_data.edit_selected_suplier(id));
            form.Show();
        }
    }
}
