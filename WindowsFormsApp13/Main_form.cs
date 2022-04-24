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
    }
}
