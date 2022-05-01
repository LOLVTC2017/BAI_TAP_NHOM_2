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
    public partial class Edit_suplier : MaterialForm
    {
        DataTable  data;
        form_validate validate = new form_validate();
        public Edit_suplier(DataTable table)
        {
            InitializeComponent();
            data = table;
        }
        private void suplier_edit_binding ()
        {
            txt_name.DataBindings.Add("text", data, "SUPLIER_NAME");
            txt_address.DataBindings.Add("text", data, "SUPPLIER_ADDRESS");
            txt_number.DataBindings.Add("text", data, "SUPPLIER_NUMBER");
        }
        private void UPDATE_SUPLIER ()
        {
            int id = Convert.ToInt32(data.Rows[0][0]);
            string name = txt_name.Text;
            string address = txt_address.Text;
            string number = txt_number.Text;
            suplier_data SUPLIER = new suplier_data();
            string service_name = TXT_SERVICE_NAME.Text;
            float service_price = float.Parse(TXT_SERVICE_PRICE.Text);
            string[] array = { name, address, number, service_name, service_price.ToString() };
            if (validate.CheckEmpty(array)== true)
                { 
                if (SUPLIER.update_suplier(id, name, address, number, service_name,service_price) == true)
                {
                    MessageBox.Show("update success");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("update failed");
                }
            }
            else if (validate.CheckEmpty(array) == false)
            {
                MessageBox.Show("do not empty");
            }

        }

        private void Edit_suplier_Load(object sender, EventArgs e)
        {

        }

        private void btn_suplier_edit_Click(object sender, EventArgs e)
        {

        }
    }
}
