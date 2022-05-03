namespace WindowsFormsApp13
{
    partial class Main_form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_form));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.cbx_suplier = new MaterialSkin.Controls.MaterialTabControl();
            this.page_users = new System.Windows.Forms.TabPage();
            this.grid_data1 = new System.Windows.Forms.DataGridView();
            this.materialButton3 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.cbx_username = new MaterialSkin.Controls.MaterialComboBox();
            this.page_supplier = new System.Windows.Forms.TabPage();
            this.grid_data2 = new System.Windows.Forms.DataGridView();
            this.btx_delete_suplier = new MaterialSkin.Controls.MaterialButton();
            this.btx_edit_suplier = new MaterialSkin.Controls.MaterialButton();
            this.btx_add_suplier = new MaterialSkin.Controls.MaterialButton();
            this.cbx_suplier_name = new MaterialSkin.Controls.MaterialComboBox();
            this.page_services = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.materialButton5 = new MaterialSkin.Controls.MaterialButton();
            this.cbx_customer_buy = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.services_prices = new MaterialSkin.Controls.MaterialLabel();
            this.services_suplier_phone = new MaterialSkin.Controls.MaterialLabel();
            this.services_suplier_addess = new MaterialSkin.Controls.MaterialLabel();
            this.services_suplier = new MaterialSkin.Controls.MaterialLabel();
            this.services_id_number = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.list_services = new System.Windows.Forms.ListBox();
            this.sERVICESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qUANLYKHACHHANGDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qUANLY_KHACHHANGDataSet = new WindowsFormsApp13.QUANLY_KHACHHANGDataSet();
            this.sERVICESBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.page_history = new System.Windows.Forms.TabPage();
            this.txt_total_all_payment = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.grid_data_3 = new System.Windows.Forms.DataGridView();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.sERVICESTableAdapter = new WindowsFormsApp13.QUANLY_KHACHHANGDataSetTableAdapters.SERVICESTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.qUANLY_KHACHHANGDataSet3 = new WindowsFormsApp13.QUANLY_KHACHHANGDataSet3();
            this.reportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportTableAdapter = new WindowsFormsApp13.QUANLY_KHACHHANGDataSet3TableAdapters.reportTableAdapter();
            this.cbx_suplier.SuspendLayout();
            this.page_users.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_data1)).BeginInit();
            this.page_supplier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_data2)).BeginInit();
            this.page_services.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sERVICESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYKHACHHANGDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLY_KHACHHANGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sERVICESBindingSource1)).BeginInit();
            this.page_history.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_data_3)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLY_KHACHHANGDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cbx_suplier
            // 
            this.cbx_suplier.Controls.Add(this.page_users);
            this.cbx_suplier.Controls.Add(this.page_supplier);
            this.cbx_suplier.Controls.Add(this.page_services);
            this.cbx_suplier.Controls.Add(this.page_history);
            this.cbx_suplier.Controls.Add(this.tabPage1);
            this.cbx_suplier.Depth = 0;
            this.cbx_suplier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbx_suplier.ImageList = this.imageList2;
            this.cbx_suplier.Location = new System.Drawing.Point(3, 64);
            this.cbx_suplier.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbx_suplier.Multiline = true;
            this.cbx_suplier.Name = "cbx_suplier";
            this.cbx_suplier.Padding = new System.Drawing.Point(10, 10);
            this.cbx_suplier.SelectedIndex = 0;
            this.cbx_suplier.Size = new System.Drawing.Size(993, 554);
            this.cbx_suplier.TabIndex = 0;
            // 
            // page_users
            // 
            this.page_users.BackColor = System.Drawing.Color.White;
            this.page_users.Controls.Add(this.grid_data1);
            this.page_users.Controls.Add(this.materialButton3);
            this.page_users.Controls.Add(this.materialButton2);
            this.page_users.Controls.Add(this.materialButton1);
            this.page_users.Controls.Add(this.cbx_username);
            this.page_users.ForeColor = System.Drawing.SystemColors.ControlText;
            this.page_users.ImageKey = "686317.png";
            this.page_users.Location = new System.Drawing.Point(4, 53);
            this.page_users.Name = "page_users";
            this.page_users.Padding = new System.Windows.Forms.Padding(3);
            this.page_users.Size = new System.Drawing.Size(985, 497);
            this.page_users.TabIndex = 0;
            this.page_users.Text = "Customers";
            this.page_users.Click += new System.EventHandler(this.page_users_Click);
            // 
            // grid_data1
            // 
            this.grid_data1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_data1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.grid_data1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid_data1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_data1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_data1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_data1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grid_data1.GridColor = System.Drawing.Color.WhiteSmoke;
            this.grid_data1.Location = new System.Drawing.Point(3, 87);
            this.grid_data1.Name = "grid_data1";
            this.grid_data1.Size = new System.Drawing.Size(979, 407);
            this.grid_data1.TabIndex = 5;
            // 
            // materialButton3
            // 
            this.materialButton3.AutoSize = false;
            this.materialButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton3.Depth = 0;
            this.materialButton3.ForeColor = System.Drawing.Color.White;
            this.materialButton3.HighEmphasis = true;
            this.materialButton3.Icon = null;
            this.materialButton3.Location = new System.Drawing.Point(764, 28);
            this.materialButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton3.Name = "materialButton3";
            this.materialButton3.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton3.Size = new System.Drawing.Size(158, 36);
            this.materialButton3.TabIndex = 4;
            this.materialButton3.Text = "Delete User";
            this.materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton3.UseAccentColor = false;
            this.materialButton3.UseVisualStyleBackColor = true;
            this.materialButton3.Click += new System.EventHandler(this.materialButton3_Click);
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSize = false;
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(574, 28);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(158, 36);
            this.materialButton2.TabIndex = 3;
            this.materialButton2.Text = "Edit Customer";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            this.materialButton2.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSize = false;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(381, 28);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(145, 36);
            this.materialButton1.TabIndex = 2;
            this.materialButton1.Text = "Add Customer";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // cbx_username
            // 
            this.cbx_username.AutoResize = false;
            this.cbx_username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbx_username.Depth = 0;
            this.cbx_username.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbx_username.DropDownHeight = 174;
            this.cbx_username.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_username.DropDownWidth = 121;
            this.cbx_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbx_username.ForeColor = System.Drawing.Color.White;
            this.cbx_username.FormattingEnabled = true;
            this.cbx_username.IntegralHeight = false;
            this.cbx_username.ItemHeight = 43;
            this.cbx_username.Location = new System.Drawing.Point(6, 18);
            this.cbx_username.MaxDropDownItems = 4;
            this.cbx_username.MouseState = MaterialSkin.MouseState.OUT;
            this.cbx_username.Name = "cbx_username";
            this.cbx_username.Size = new System.Drawing.Size(302, 49);
            this.cbx_username.StartIndex = 0;
            this.cbx_username.TabIndex = 0;
            this.cbx_username.SelectedIndexChanged += new System.EventHandler(this.cbx_username_SelectedIndexChanged);
            // 
            // page_supplier
            // 
            this.page_supplier.BackColor = System.Drawing.Color.White;
            this.page_supplier.Controls.Add(this.grid_data2);
            this.page_supplier.Controls.Add(this.btx_delete_suplier);
            this.page_supplier.Controls.Add(this.btx_edit_suplier);
            this.page_supplier.Controls.Add(this.btx_add_suplier);
            this.page_supplier.Controls.Add(this.cbx_suplier_name);
            this.page_supplier.ImageKey = "3632552.png";
            this.page_supplier.Location = new System.Drawing.Point(4, 53);
            this.page_supplier.Name = "page_supplier";
            this.page_supplier.Size = new System.Drawing.Size(985, 497);
            this.page_supplier.TabIndex = 2;
            this.page_supplier.Text = "Supplier";
            this.page_supplier.Click += new System.EventHandler(this.page_supplier_Click);
            // 
            // grid_data2
            // 
            this.grid_data2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_data2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_data2.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.grid_data2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid_data2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_data2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grid_data2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_data2.Location = new System.Drawing.Point(6, 78);
            this.grid_data2.Name = "grid_data2";
            this.grid_data2.Size = new System.Drawing.Size(973, 407);
            this.grid_data2.TabIndex = 10;
            // 
            // btx_delete_suplier
            // 
            this.btx_delete_suplier.AutoSize = false;
            this.btx_delete_suplier.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btx_delete_suplier.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btx_delete_suplier.Depth = 0;
            this.btx_delete_suplier.ForeColor = System.Drawing.Color.White;
            this.btx_delete_suplier.HighEmphasis = true;
            this.btx_delete_suplier.Icon = null;
            this.btx_delete_suplier.Location = new System.Drawing.Point(764, 22);
            this.btx_delete_suplier.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btx_delete_suplier.MouseState = MaterialSkin.MouseState.HOVER;
            this.btx_delete_suplier.Name = "btx_delete_suplier";
            this.btx_delete_suplier.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btx_delete_suplier.Size = new System.Drawing.Size(158, 36);
            this.btx_delete_suplier.TabIndex = 9;
            this.btx_delete_suplier.Text = "Delete Suplier";
            this.btx_delete_suplier.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btx_delete_suplier.UseAccentColor = false;
            this.btx_delete_suplier.UseVisualStyleBackColor = true;
            this.btx_delete_suplier.Click += new System.EventHandler(this.btx_delete_suplier_Click);
            // 
            // btx_edit_suplier
            // 
            this.btx_edit_suplier.AutoSize = false;
            this.btx_edit_suplier.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btx_edit_suplier.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btx_edit_suplier.Depth = 0;
            this.btx_edit_suplier.HighEmphasis = true;
            this.btx_edit_suplier.Icon = null;
            this.btx_edit_suplier.Location = new System.Drawing.Point(574, 22);
            this.btx_edit_suplier.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btx_edit_suplier.MouseState = MaterialSkin.MouseState.HOVER;
            this.btx_edit_suplier.Name = "btx_edit_suplier";
            this.btx_edit_suplier.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btx_edit_suplier.Size = new System.Drawing.Size(158, 36);
            this.btx_edit_suplier.TabIndex = 8;
            this.btx_edit_suplier.Text = "Edit Suplier";
            this.btx_edit_suplier.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btx_edit_suplier.UseAccentColor = false;
            this.btx_edit_suplier.UseVisualStyleBackColor = true;
            this.btx_edit_suplier.Click += new System.EventHandler(this.btx_edit_suplier_Click);
            // 
            // btx_add_suplier
            // 
            this.btx_add_suplier.AutoSize = false;
            this.btx_add_suplier.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btx_add_suplier.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btx_add_suplier.Depth = 0;
            this.btx_add_suplier.HighEmphasis = true;
            this.btx_add_suplier.Icon = null;
            this.btx_add_suplier.Location = new System.Drawing.Point(381, 22);
            this.btx_add_suplier.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btx_add_suplier.MouseState = MaterialSkin.MouseState.HOVER;
            this.btx_add_suplier.Name = "btx_add_suplier";
            this.btx_add_suplier.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btx_add_suplier.Size = new System.Drawing.Size(158, 36);
            this.btx_add_suplier.TabIndex = 7;
            this.btx_add_suplier.Text = "Add Suplier";
            this.btx_add_suplier.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btx_add_suplier.UseAccentColor = false;
            this.btx_add_suplier.UseVisualStyleBackColor = true;
            this.btx_add_suplier.Click += new System.EventHandler(this.btx_add_suplier_Click);
            // 
            // cbx_suplier_name
            // 
            this.cbx_suplier_name.AutoResize = false;
            this.cbx_suplier_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbx_suplier_name.Depth = 0;
            this.cbx_suplier_name.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbx_suplier_name.DropDownHeight = 174;
            this.cbx_suplier_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_suplier_name.DropDownWidth = 121;
            this.cbx_suplier_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbx_suplier_name.ForeColor = System.Drawing.Color.White;
            this.cbx_suplier_name.FormattingEnabled = true;
            this.cbx_suplier_name.IntegralHeight = false;
            this.cbx_suplier_name.ItemHeight = 43;
            this.cbx_suplier_name.Location = new System.Drawing.Point(6, 12);
            this.cbx_suplier_name.MaxDropDownItems = 4;
            this.cbx_suplier_name.MouseState = MaterialSkin.MouseState.OUT;
            this.cbx_suplier_name.Name = "cbx_suplier_name";
            this.cbx_suplier_name.Size = new System.Drawing.Size(302, 49);
            this.cbx_suplier_name.StartIndex = 0;
            this.cbx_suplier_name.TabIndex = 6;
            this.cbx_suplier_name.SelectedIndexChanged += new System.EventHandler(this.cbx_suplier_name_SelectedIndexChanged);
            // 
            // page_services
            // 
            this.page_services.BackColor = System.Drawing.Color.White;
            this.page_services.Controls.Add(this.groupBox2);
            this.page_services.Controls.Add(this.groupBox1);
            this.page_services.ImageKey = "1924785.png";
            this.page_services.Location = new System.Drawing.Point(4, 53);
            this.page_services.Name = "page_services";
            this.page_services.Size = new System.Drawing.Size(985, 497);
            this.page_services.TabIndex = 3;
            this.page_services.Text = "Services";
            this.page_services.Click += new System.EventHandler(this.page_services_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.materialButton5);
            this.groupBox2.Controls.Add(this.cbx_customer_buy);
            this.groupBox2.Controls.Add(this.materialLabel11);
            this.groupBox2.Controls.Add(this.services_prices);
            this.groupBox2.Controls.Add(this.services_suplier_phone);
            this.groupBox2.Controls.Add(this.services_suplier_addess);
            this.groupBox2.Controls.Add(this.services_suplier);
            this.groupBox2.Controls.Add(this.services_id_number);
            this.groupBox2.Controls.Add(this.materialLabel5);
            this.groupBox2.Controls.Add(this.materialLabel4);
            this.groupBox2.Controls.Add(this.materialLabel3);
            this.groupBox2.Controls.Add(this.materialLabel2);
            this.groupBox2.Controls.Add(this.materialLabel1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(200, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(785, 497);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "services detail";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // materialButton5
            // 
            this.materialButton5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton5.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton5.Depth = 0;
            this.materialButton5.HighEmphasis = true;
            this.materialButton5.Icon = null;
            this.materialButton5.Location = new System.Drawing.Point(7, 378);
            this.materialButton5.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton5.Name = "materialButton5";
            this.materialButton5.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton5.Size = new System.Drawing.Size(112, 36);
            this.materialButton5.TabIndex = 13;
            this.materialButton5.Text = "Add Service";
            this.materialButton5.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton5.UseAccentColor = false;
            this.materialButton5.UseVisualStyleBackColor = true;
            this.materialButton5.Click += new System.EventHandler(this.materialButton5_Click);
            // 
            // cbx_customer_buy
            // 
            this.cbx_customer_buy.AutoResize = false;
            this.cbx_customer_buy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cbx_customer_buy.Depth = 0;
            this.cbx_customer_buy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbx_customer_buy.DropDownHeight = 174;
            this.cbx_customer_buy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_customer_buy.DropDownWidth = 121;
            this.cbx_customer_buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbx_customer_buy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbx_customer_buy.FormattingEnabled = true;
            this.cbx_customer_buy.IntegralHeight = false;
            this.cbx_customer_buy.ItemHeight = 43;
            this.cbx_customer_buy.Location = new System.Drawing.Point(219, 273);
            this.cbx_customer_buy.MaxDropDownItems = 4;
            this.cbx_customer_buy.MouseState = MaterialSkin.MouseState.OUT;
            this.cbx_customer_buy.Name = "cbx_customer_buy";
            this.cbx_customer_buy.Size = new System.Drawing.Size(283, 49);
            this.cbx_customer_buy.StartIndex = 0;
            this.cbx_customer_buy.TabIndex = 11;
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel11.Location = new System.Drawing.Point(6, 303);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(184, 19);
            this.materialLabel11.TabIndex = 10;
            this.materialLabel11.Text = "Customer buy this Service";
            // 
            // services_prices
            // 
            this.services_prices.AutoSize = true;
            this.services_prices.Depth = 0;
            this.services_prices.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.services_prices.Location = new System.Drawing.Point(307, 243);
            this.services_prices.MouseState = MaterialSkin.MouseState.HOVER;
            this.services_prices.Name = "services_prices";
            this.services_prices.Size = new System.Drawing.Size(10, 19);
            this.services_prices.TabIndex = 9;
            this.services_prices.Text = "1";
            // 
            // services_suplier_phone
            // 
            this.services_suplier_phone.AutoSize = true;
            this.services_suplier_phone.Depth = 0;
            this.services_suplier_phone.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.services_suplier_phone.Location = new System.Drawing.Point(307, 188);
            this.services_suplier_phone.MouseState = MaterialSkin.MouseState.HOVER;
            this.services_suplier_phone.Name = "services_suplier_phone";
            this.services_suplier_phone.Size = new System.Drawing.Size(10, 19);
            this.services_suplier_phone.TabIndex = 8;
            this.services_suplier_phone.Text = "1";
            // 
            // services_suplier_addess
            // 
            this.services_suplier_addess.AutoSize = true;
            this.services_suplier_addess.Depth = 0;
            this.services_suplier_addess.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.services_suplier_addess.Location = new System.Drawing.Point(307, 135);
            this.services_suplier_addess.MouseState = MaterialSkin.MouseState.HOVER;
            this.services_suplier_addess.Name = "services_suplier_addess";
            this.services_suplier_addess.Size = new System.Drawing.Size(10, 19);
            this.services_suplier_addess.TabIndex = 7;
            this.services_suplier_addess.Text = "1";
            // 
            // services_suplier
            // 
            this.services_suplier.AutoSize = true;
            this.services_suplier.Depth = 0;
            this.services_suplier.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.services_suplier.Location = new System.Drawing.Point(307, 79);
            this.services_suplier.MouseState = MaterialSkin.MouseState.HOVER;
            this.services_suplier.Name = "services_suplier";
            this.services_suplier.Size = new System.Drawing.Size(10, 19);
            this.services_suplier.TabIndex = 6;
            this.services_suplier.Text = "1";
            // 
            // services_id_number
            // 
            this.services_id_number.AutoSize = true;
            this.services_id_number.Depth = 0;
            this.services_id_number.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.services_id_number.Location = new System.Drawing.Point(307, 31);
            this.services_id_number.MouseState = MaterialSkin.MouseState.HOVER;
            this.services_id_number.Name = "services_id_number";
            this.services_id_number.Size = new System.Drawing.Size(10, 19);
            this.services_id_number.TabIndex = 5;
            this.services_id_number.Text = "1";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(6, 243);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(107, 19);
            this.materialLabel5.TabIndex = 4;
            this.materialLabel5.Text = "Service Prices :";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(6, 188);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(222, 19);
            this.materialLabel4.TabIndex = 3;
            this.materialLabel4.Text = "Service Suplier Phone Number :";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(6, 135);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(174, 19);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "Service Suplier Address :";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(6, 79);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(113, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Service Suplier :";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(6, 31);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(139, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Service ID Number :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.list_services);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 497);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LIST_SERVICES";
            // 
            // list_services
            // 
            this.list_services.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.list_services.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.sERVICESBindingSource, "SERVICES_ID", true));
            this.list_services.DataSource = this.sERVICESBindingSource1;
            this.list_services.DisplayMember = "SERVICES_NAME";
            this.list_services.Dock = System.Windows.Forms.DockStyle.Left;
            this.list_services.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.list_services.FormattingEnabled = true;
            this.list_services.ItemHeight = 15;
            this.list_services.Location = new System.Drawing.Point(3, 16);
            this.list_services.Name = "list_services";
            this.list_services.Size = new System.Drawing.Size(188, 478);
            this.list_services.TabIndex = 1;
            this.list_services.ValueMember = "SERVICES_ID";
            this.list_services.SelectedIndexChanged += new System.EventHandler(this.list_services_SelectedIndexChanged);
            // 
            // sERVICESBindingSource
            // 
            this.sERVICESBindingSource.DataMember = "SERVICES";
            this.sERVICESBindingSource.DataSource = this.qUANLYKHACHHANGDataSetBindingSource;
            // 
            // qUANLYKHACHHANGDataSetBindingSource
            // 
            this.qUANLYKHACHHANGDataSetBindingSource.DataSource = this.qUANLY_KHACHHANGDataSet;
            this.qUANLYKHACHHANGDataSetBindingSource.Position = 0;
            // 
            // qUANLY_KHACHHANGDataSet
            // 
            this.qUANLY_KHACHHANGDataSet.DataSetName = "QUANLY_KHACHHANGDataSet";
            this.qUANLY_KHACHHANGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sERVICESBindingSource1
            // 
            this.sERVICESBindingSource1.DataMember = "SERVICES";
            this.sERVICESBindingSource1.DataSource = this.qUANLYKHACHHANGDataSetBindingSource;
            // 
            // page_history
            // 
            this.page_history.BackColor = System.Drawing.Color.White;
            this.page_history.Controls.Add(this.txt_total_all_payment);
            this.page_history.Controls.Add(this.grid_data_3);
            this.page_history.Controls.Add(this.materialLabel12);
            this.page_history.ImageKey = "6107230.png";
            this.page_history.Location = new System.Drawing.Point(4, 53);
            this.page_history.Name = "page_history";
            this.page_history.Padding = new System.Windows.Forms.Padding(3);
            this.page_history.Size = new System.Drawing.Size(985, 497);
            this.page_history.TabIndex = 1;
            this.page_history.Text = "History payment";
            // 
            // txt_total_all_payment
            // 
            this.txt_total_all_payment.AllowPromptAsInput = true;
            this.txt_total_all_payment.AnimateReadOnly = false;
            this.txt_total_all_payment.AsciiOnly = false;
            this.txt_total_all_payment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_total_all_payment.BeepOnError = false;
            this.txt_total_all_payment.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_total_all_payment.Depth = 0;
            this.txt_total_all_payment.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_total_all_payment.HidePromptOnLeave = false;
            this.txt_total_all_payment.HideSelection = true;
            this.txt_total_all_payment.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txt_total_all_payment.LeadingIcon = null;
            this.txt_total_all_payment.Location = new System.Drawing.Point(568, 18);
            this.txt_total_all_payment.Mask = "";
            this.txt_total_all_payment.MaxLength = 32767;
            this.txt_total_all_payment.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_total_all_payment.Name = "txt_total_all_payment";
            this.txt_total_all_payment.PasswordChar = '\0';
            this.txt_total_all_payment.PrefixSuffixText = null;
            this.txt_total_all_payment.PromptChar = '_';
            this.txt_total_all_payment.ReadOnly = false;
            this.txt_total_all_payment.RejectInputOnFirstFailure = false;
            this.txt_total_all_payment.ResetOnPrompt = true;
            this.txt_total_all_payment.ResetOnSpace = true;
            this.txt_total_all_payment.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_total_all_payment.SelectedText = "";
            this.txt_total_all_payment.SelectionLength = 0;
            this.txt_total_all_payment.SelectionStart = 0;
            this.txt_total_all_payment.ShortcutsEnabled = true;
            this.txt_total_all_payment.Size = new System.Drawing.Size(233, 48);
            this.txt_total_all_payment.SkipLiterals = true;
            this.txt_total_all_payment.TabIndex = 2;
            this.txt_total_all_payment.TabStop = false;
            this.txt_total_all_payment.Text = "materialMaskedTextBox1";
            this.txt_total_all_payment.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_total_all_payment.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_total_all_payment.TrailingIcon = null;
            this.txt_total_all_payment.UseSystemPasswordChar = false;
            this.txt_total_all_payment.ValidatingType = null;
            // 
            // grid_data_3
            // 
            this.grid_data_3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_data_3.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.grid_data_3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid_data_3.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grid_data_3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_data_3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grid_data_3.Location = new System.Drawing.Point(3, 89);
            this.grid_data_3.Name = "grid_data_3";
            this.grid_data_3.Size = new System.Drawing.Size(979, 405);
            this.grid_data_3.TabIndex = 1;
            // 
            // materialLabel12
            // 
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel12.Location = new System.Drawing.Point(3, 3);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(979, 83);
            this.materialLabel12.TabIndex = 0;
            this.materialLabel12.Text = "TOTAL REVENUE";
            this.materialLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.materialLabel12.Click += new System.EventHandler(this.materialLabel12_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.reportViewer1);
            this.tabPage1.ImageKey = "3094851.png";
            this.tabPage1.Location = new System.Drawing.Point(4, 53);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(985, 497);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Text = "Report";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "686317.png");
            this.imageList2.Images.SetKeyName(1, "6107230.png");
            this.imageList2.Images.SetKeyName(2, "3632552.png");
            this.imageList2.Images.SetKeyName(3, "1924785.png");
            this.imageList2.Images.SetKeyName(4, "1144760.png");
            this.imageList2.Images.SetKeyName(5, "3094851.png");
            // 
            // sERVICESTableAdapter
            // 
            this.sERVICESTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.reportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp13.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(985, 497);
            this.reportViewer1.TabIndex = 0;
            // 
            // qUANLY_KHACHHANGDataSet3
            // 
            this.qUANLY_KHACHHANGDataSet3.DataSetName = "QUANLY_KHACHHANGDataSet3";
            this.qUANLY_KHACHHANGDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportBindingSource
            // 
            this.reportBindingSource.DataMember = "report";
            this.reportBindingSource.DataSource = this.qUANLY_KHACHHANGDataSet3;
            // 
            // reportTableAdapter
            // 
            this.reportTableAdapter.ClearBeforeFill = true;
            // 
            // Main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 621);
            this.Controls.Add(this.cbx_suplier);
            this.DrawerTabControl = this.cbx_suplier;
            this.Name = "Main_form";
            this.Text = "Admin_Page";
            this.Load += new System.EventHandler(this.Main_form_Load);
            this.cbx_suplier.ResumeLayout(false);
            this.page_users.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_data1)).EndInit();
            this.page_supplier.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_data2)).EndInit();
            this.page_services.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sERVICESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYKHACHHANGDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLY_KHACHHANGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sERVICESBindingSource1)).EndInit();
            this.page_history.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_data_3)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.qUANLY_KHACHHANGDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl cbx_suplier;
        private System.Windows.Forms.TabPage page_users;
        private System.Windows.Forms.TabPage page_supplier;
        private System.Windows.Forms.TabPage page_services;
        private System.Windows.Forms.TabPage page_history;
        private System.Windows.Forms.ImageList imageList2;
        private MaterialSkin.Controls.MaterialComboBox cbx_username;
        private MaterialSkin.Controls.MaterialButton materialButton3;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private System.Windows.Forms.DataGridView grid_data1;
        private System.Windows.Forms.DataGridView grid_data2;
        private MaterialSkin.Controls.MaterialButton btx_delete_suplier;
        private MaterialSkin.Controls.MaterialButton btx_edit_suplier;
        private MaterialSkin.Controls.MaterialButton btx_add_suplier;
        private MaterialSkin.Controls.MaterialComboBox cbx_suplier_name;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox list_services;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialComboBox cbx_customer_buy;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialLabel services_prices;
        private MaterialSkin.Controls.MaterialLabel services_suplier_phone;
        private MaterialSkin.Controls.MaterialLabel services_suplier_addess;
        private MaterialSkin.Controls.MaterialLabel services_suplier;
        private MaterialSkin.Controls.MaterialLabel services_id_number;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.DataGridView grid_data_3;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private MaterialSkin.Controls.MaterialButton materialButton5;
        private System.Windows.Forms.BindingSource qUANLYKHACHHANGDataSetBindingSource;
        private QUANLY_KHACHHANGDataSet qUANLY_KHACHHANGDataSet;
        private System.Windows.Forms.BindingSource sERVICESBindingSource;
        private QUANLY_KHACHHANGDataSetTableAdapters.SERVICESTableAdapter sERVICESTableAdapter;
        private System.Windows.Forms.BindingSource sERVICESBindingSource1;
        private MaterialSkin.Controls.MaterialMaskedTextBox txt_total_all_payment;
        private System.Windows.Forms.TabPage tabPage1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private QUANLY_KHACHHANGDataSet3 qUANLY_KHACHHANGDataSet3;
        private System.Windows.Forms.BindingSource reportBindingSource;
        private QUANLY_KHACHHANGDataSet3TableAdapters.reportTableAdapter reportTableAdapter;
    }
}

