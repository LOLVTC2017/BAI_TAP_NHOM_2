namespace WindowsFormsApp13
{
    partial class ADD_SERVICES
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cbx_Suplier = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txt_services_name = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_services_price = new MaterialSkin.Controls.MaterialTextBox();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.qUANLY_KHACHHANGDataSet1 = new WindowsFormsApp13.QUANLY_KHACHHANGDataSet1();
            this.getInfrosupliernotinservicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.get_Infro_suplier_not_in_servicesTableAdapter = new WindowsFormsApp13.QUANLY_KHACHHANGDataSet1TableAdapters.Get_Infro_suplier_not_in_servicesTableAdapter();
            this.getInfrosupliernotinservicesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.qUANLY_KHACHHANGDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getInfrosupliernotinservicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getInfrosupliernotinservicesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbx_Suplier
            // 
            this.cbx_Suplier.AutoResize = false;
            this.cbx_Suplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbx_Suplier.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.getInfrosupliernotinservicesBindingSource1, "SUPPLIER_ID", true));
            this.cbx_Suplier.DataSource = this.getInfrosupliernotinservicesBindingSource;
            this.cbx_Suplier.Depth = 0;
            this.cbx_Suplier.DisplayMember = "SUPPLIER_NAME";
            this.cbx_Suplier.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbx_Suplier.DropDownHeight = 174;
            this.cbx_Suplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Suplier.DropDownWidth = 121;
            this.cbx_Suplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbx_Suplier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbx_Suplier.FormattingEnabled = true;
            this.cbx_Suplier.IntegralHeight = false;
            this.cbx_Suplier.ItemHeight = 43;
            this.cbx_Suplier.Location = new System.Drawing.Point(147, 99);
            this.cbx_Suplier.MaxDropDownItems = 4;
            this.cbx_Suplier.MouseState = MaterialSkin.MouseState.OUT;
            this.cbx_Suplier.Name = "cbx_Suplier";
            this.cbx_Suplier.Size = new System.Drawing.Size(267, 49);
            this.cbx_Suplier.StartIndex = 0;
            this.cbx_Suplier.TabIndex = 0;
            this.cbx_Suplier.ValueMember = "SUPPLIER_ID";
            this.cbx_Suplier.SelectedIndexChanged += new System.EventHandler(this.cbx_Suplier_SelectedIndexChanged);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(35, 129);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(50, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Suplier";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(35, 211);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(106, 19);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "Services Name";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(35, 287);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(99, 19);
            this.materialLabel3.TabIndex = 3;
            this.materialLabel3.Text = "Services Price";
            // 
            // txt_services_name
            // 
            this.txt_services_name.AnimateReadOnly = false;
            this.txt_services_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_services_name.Depth = 0;
            this.txt_services_name.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_services_name.LeadingIcon = null;
            this.txt_services_name.Location = new System.Drawing.Point(147, 180);
            this.txt_services_name.MaxLength = 50;
            this.txt_services_name.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_services_name.Multiline = false;
            this.txt_services_name.Name = "txt_services_name";
            this.txt_services_name.Size = new System.Drawing.Size(251, 50);
            this.txt_services_name.TabIndex = 5;
            this.txt_services_name.Text = "";
            this.txt_services_name.TrailingIcon = null;
            // 
            // txt_services_price
            // 
            this.txt_services_price.AnimateReadOnly = false;
            this.txt_services_price.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_services_price.Depth = 0;
            this.txt_services_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_services_price.LeadingIcon = null;
            this.txt_services_price.Location = new System.Drawing.Point(147, 256);
            this.txt_services_price.MaxLength = 50;
            this.txt_services_price.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_services_price.Multiline = false;
            this.txt_services_price.Name = "txt_services_price";
            this.txt_services_price.Size = new System.Drawing.Size(251, 50);
            this.txt_services_price.TabIndex = 6;
            this.txt_services_price.Text = "";
            this.txt_services_price.TrailingIcon = null;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSize = false;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(147, 345);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(144, 36);
            this.materialButton1.TabIndex = 7;
            this.materialButton1.TabStop = false;
            this.materialButton1.Text = "ADD SERVICES";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            // 
            // qUANLY_KHACHHANGDataSet1
            // 
            this.qUANLY_KHACHHANGDataSet1.DataSetName = "QUANLY_KHACHHANGDataSet1";
            this.qUANLY_KHACHHANGDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getInfrosupliernotinservicesBindingSource
            // 
            this.getInfrosupliernotinservicesBindingSource.DataMember = "Get_Infro_suplier_not_in_services";
            this.getInfrosupliernotinservicesBindingSource.DataSource = this.qUANLY_KHACHHANGDataSet1;
            // 
            // get_Infro_suplier_not_in_servicesTableAdapter
            // 
            this.get_Infro_suplier_not_in_servicesTableAdapter.ClearBeforeFill = true;
            // 
            // getInfrosupliernotinservicesBindingSource1
            // 
            this.getInfrosupliernotinservicesBindingSource1.DataMember = "Get_Infro_suplier_not_in_services";
            this.getInfrosupliernotinservicesBindingSource1.DataSource = this.qUANLY_KHACHHANGDataSet1;
            // 
            // ADD_SERVICES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 495);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.txt_services_price);
            this.Controls.Add(this.txt_services_name);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.cbx_Suplier);
            this.Name = "ADD_SERVICES";
            this.Text = "ADD_SERVICES";
            this.Load += new System.EventHandler(this.ADD_SERVICES_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qUANLY_KHACHHANGDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getInfrosupliernotinservicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getInfrosupliernotinservicesBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialComboBox cbx_Suplier;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialTextBox txt_services_name;
        private MaterialSkin.Controls.MaterialTextBox txt_services_price;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private QUANLY_KHACHHANGDataSet1 qUANLY_KHACHHANGDataSet1;
        private System.Windows.Forms.BindingSource getInfrosupliernotinservicesBindingSource;
        private QUANLY_KHACHHANGDataSet1TableAdapters.Get_Infro_suplier_not_in_servicesTableAdapter get_Infro_suplier_not_in_servicesTableAdapter;
        private System.Windows.Forms.BindingSource getInfrosupliernotinservicesBindingSource1;
    }
}