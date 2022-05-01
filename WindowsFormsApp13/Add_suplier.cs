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
using main_funciton;
namespace WindowsFormsApp13
{
    public partial class Add_suplier : MaterialForm
    {

        form_validate validate = new form_validate();
        public Add_suplier()
        {
            InitializeComponent();
        }

        private void Add_suplier_Load(object sender, EventArgs e)
        {

        }
        private void add_suplier ()
        {
            suplier_data suplier = new suplier_data();
            string name = txt_name.Text;
            string address = txt_address.Text;
            string number = txt_number.Text;
            string service_name = TXT_SERVICE_NAME.Text;
            float service_price = float.Parse(TXT_SERVICE_PRICE.Text);
            string[] array = { name, address, number, service_name, service_price.ToString()};

            if (validate.CheckEmpty(array) == true)
            {
                if (suplier.add_suplier(name, address, number,service_name,service_price) == true)
                {
                    MessageBox.Show("add success");
                    txt_name.Text = "";
                    txt_address.Text = "";
                    txt_number.Text = "";

                }
                else
                {
                    MessageBox.Show("add failed");
                }
            }
            else if (validate.CheckEmpty(array) == false)
            {
                MessageBox.Show("Do Not Empty");
            }


        }
      
        private void btn_suplier_add_Click(object sender, EventArgs e)
        {
            add_suplier();
        }

        private void txt_number_Click(object sender, EventArgs e)
        {

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
