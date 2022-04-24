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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_form));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbx_suplier = new MaterialSkin.Controls.MaterialTabControl();
            this.page_users = new System.Windows.Forms.TabPage();
            this.grid_data1 = new System.Windows.Forms.DataGridView();
            this.materialButton3 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.cbx_username = new MaterialSkin.Controls.MaterialComboBox();
            this.page_supplier = new System.Windows.Forms.TabPage();
            this.page_services = new System.Windows.Forms.TabPage();
            this.page_history = new System.Windows.Forms.TabPage();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.grid_data2 = new System.Windows.Forms.DataGridView();
            this.btx_delete_suplier = new MaterialSkin.Controls.MaterialButton();
            this.btx_edit_suplier = new MaterialSkin.Controls.MaterialButton();
            this.btx_add_suplier = new MaterialSkin.Controls.MaterialButton();
            this.cbx_suplier_name = new MaterialSkin.Controls.MaterialComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.list_services = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.cbx_customer_buy = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbx_suplier.SuspendLayout();
            this.page_users.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_data1)).BeginInit();
            this.page_supplier.SuspendLayout();
            this.page_services.SuspendLayout();
            this.page_history.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_data2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbx_suplier
            // 
            this.cbx_suplier.Controls.Add(this.page_users);
            this.cbx_suplier.Controls.Add(this.page_supplier);
            this.cbx_suplier.Controls.Add(this.page_services);
            this.cbx_suplier.Controls.Add(this.page_history);
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_data1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
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
            this.materialButton2.Text = "Edit User";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
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
            this.materialButton1.Text = "Add User";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
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
            // page_history
            // 
            this.page_history.BackColor = System.Drawing.Color.White;
            this.page_history.Controls.Add(this.dataGridView1);
            this.page_history.Controls.Add(this.materialLabel12);
            this.page_history.ImageKey = "6107230.png";
            this.page_history.Location = new System.Drawing.Point(4, 53);
            this.page_history.Name = "page_history";
            this.page_history.Padding = new System.Windows.Forms.Padding(3);
            this.page_history.Size = new System.Drawing.Size(985, 497);
            this.page_history.TabIndex = 1;
            this.page_history.Text = "History payment";
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_data2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
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
            this.list_services.Dock = System.Windows.Forms.DockStyle.Left;
            this.list_services.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.list_services.FormattingEnabled = true;
            this.list_services.ItemHeight = 15;
            this.list_services.Location = new System.Drawing.Point(3, 16);
            this.list_services.Name = "list_services";
            this.list_services.Size = new System.Drawing.Size(188, 478);
            this.list_services.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbx_customer_buy);
            this.groupBox2.Controls.Add(this.materialLabel11);
            this.groupBox2.Controls.Add(this.materialLabel10);
            this.groupBox2.Controls.Add(this.materialLabel9);
            this.groupBox2.Controls.Add(this.materialLabel8);
            this.groupBox2.Controls.Add(this.materialLabel7);
            this.groupBox2.Controls.Add(this.materialLabel6);
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
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(6, 31);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(139, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Service ID Number :";
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
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(307, 31);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(107, 19);
            this.materialLabel6.TabIndex = 5;
            this.materialLabel6.Text = "materialLabel6";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.Location = new System.Drawing.Point(307, 79);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(107, 19);
            this.materialLabel7.TabIndex = 6;
            this.materialLabel7.Text = "materialLabel7";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.Location = new System.Drawing.Point(307, 135);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(107, 19);
            this.materialLabel8.TabIndex = 7;
            this.materialLabel8.Text = "materialLabel8";
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.Location = new System.Drawing.Point(307, 188);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(107, 19);
            this.materialLabel9.TabIndex = 8;
            this.materialLabel9.Text = "materialLabel9";
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel10.Location = new System.Drawing.Point(302, 243);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(116, 19);
            this.materialLabel10.TabIndex = 9;
            this.materialLabel10.Text = "materialLabel10";
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
            // cbx_customer_buy
            // 
            this.cbx_customer_buy.AutoResize = false;
            this.cbx_customer_buy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbx_customer_buy.Depth = 0;
            this.cbx_customer_buy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbx_customer_buy.DropDownHeight = 174;
            this.cbx_customer_buy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_customer_buy.DropDownWidth = 121;
            this.cbx_customer_buy.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
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
            this.materialLabel12.Text = "materialLabel12";
            this.materialLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(3, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(979, 405);
            this.dataGridView1.TabIndex = 1;
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
            this.page_services.ResumeLayout(false);
            this.page_history.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_data2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
    }
}

