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
    public partial class ADD_SERVICES : MaterialForm
    {
        public ADD_SERVICES()
        {
            InitializeComponent();
        }
        services_data services_Data = new services_data();
        //private void load_infor_suplier_combobox()
        //{
         
        //    DataTable data = services_Data.Get_Infro_suplier_not_in_services();
        //    cbx_Suplier.DataSource = data;
        //    cbx_Suplier.DisplayMember = "SUPPLIER_NAME";
        //    cbx_Suplier.ValueMember = "SUPPLIER_ID";
        //}
        private void load_services_infor_by_id()
        {
            int id = Convert.ToInt32(cbx_Suplier.SelectedValue);
            DataTable data = services_Data.get_services_infor_by_id_suplier(id);
            txt_services_name.DataBindings.Clear();
            txt_services_price.DataBindings.Clear();
            txt_services_name.DataBindings.Add("TEXT", data, "SUPPLIER_SERVICE_NAME");
            txt_services_price.DataBindings.Add("TEXT", data, "SUPPLIER_SERVICE_PRICE");
           
        }


        private void ADD_SERVICES_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qUANLY_KHACHHANGDataSet1.Get_Infro_suplier_not_in_services' table. You can move, or remove it, as needed.
            this.get_Infro_suplier_not_in_servicesTableAdapter.Fill(this.qUANLY_KHACHHANGDataSet1.Get_Infro_suplier_not_in_services);
            //load_infor_suplier_combobox();
            load_services_infor_by_id();
        }

        private void cbx_Suplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            load_services_infor_by_id();
        }
    }
}
