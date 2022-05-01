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
        suplier_data suplier = new suplier_data();
        services_data services_function = new services_data();
        history_data data = new history_data();
        private void Main_form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qUANLY_KHACHHANGDataSet.SERVICES' table. You can move, or remove it, as needed.
            this.sERVICESTableAdapter.Fill(this.qUANLY_KHACHHANGDataSet.SERVICES);
            // TODO: This line of code loads data into the 'qUANLY_KHACHHANGDataSet.SERVICES' table. You can move, or remove it, as needed.
            this.sERVICESTableAdapter.Fill(this.qUANLY_KHACHHANGDataSet.SERVICES);
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
            services_index_change();
            //history_tab
            load_data_grid();
            total();
        }
        //user_function
        private void Load_user_data()
        {
        
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
           
            if (cbx_username.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                int id = Convert.ToInt32(cbx_username.SelectedValue);
                grid_data1.DataSource = users_function.girdview_data(id);
            }

        }
        //suplier_function
        private void Load_suplier_data()
        {
           
            cbx_suplier_name.DataSource = suplier.get_suplier_data();
            cbx_suplier_name.DisplayMember = "SUPPLIER_NAME";
            cbx_suplier_name.ValueMember = "SUPPLIER_ID";
        }
        private void delete_suplier()
        {
            int id = Convert.ToInt32(cbx_suplier_name.SelectedValue);
          
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
       
            if (cbx_suplier_name.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                int id = Convert.ToInt32(cbx_suplier_name.SelectedValue);
                grid_data1.DataSource = users_function.girdview_data(id);
                grid_data2.DataSource = suplier.get_suplier_grid(id);
            }
           
        }
        //services_function
        private void services_index_change()
        {
            int id = Convert.ToInt16(list_services.SelectedValue);
            services_data services = new services_data();
            DataTable data =  services.get_infor_services_change(id);
            services_id_number.DataBindings.Clear();
            services_suplier.DataBindings.Clear();
            services_suplier_addess.DataBindings.Clear();
            services_suplier_phone.DataBindings.Clear();
            services_prices.DataBindings.Clear();
            services_id_number.DataBindings.Add("text", data, "SERVICES_ID_NUMBER");
            services_suplier.DataBindings.Add("text", data, "SUPPLIER_NAME");
            services_suplier_addess.DataBindings.Add("text", data, "SUPPLIER_ADDRESS");
            services_suplier_phone.DataBindings.Add("text", data, "SUPPLIER_NUMBER");
            services_prices.DataBindings.Add("text", data, "SERVICE_PRICES");
            cbx_customer_buy.DataSource = services.get_persons_order(id);
            cbx_customer_buy.DisplayMember = "name";
        }
        //history_function 
        private void load_data_grid ()
        {
            grid_data_3.DataSource = data.data_grid();
           
        }
        private void total()
        {
            int amount = 0;
            for (int i = 0; i < grid_data_3.RowCount -1; i++)
            {
                amount += Convert.ToInt32(grid_data_3.Rows[i].Cells[2].Value);
            }
            txt_total_all_payment.Text = amount.ToString();
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

        private void list_servicesToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.sERVICESTableAdapter.List_services(this.qUANLY_KHACHHANGDataSet.SERVICES);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void list_services_SelectedIndexChanged(object sender, EventArgs e)
        {
            services_index_change();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void materialButton5_Click(object sender, EventArgs e)
        {
            ADD_SERVICES sERVICES = new ADD_SERVICES();
            sERVICES.Show();
        }

        private void materialLabel12_Click(object sender, EventArgs e)
        {

        }
    }
}
