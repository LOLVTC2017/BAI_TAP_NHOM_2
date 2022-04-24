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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_form));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.materialComboBox1 = new MaterialSkin.Controls.MaterialComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.materialListBox1 = new MaterialSkin.Controls.MaterialListBox();
            this.cbx_suplier.SuspendLayout();
            this.page_users.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_data1)).BeginInit();
            this.page_supplier.SuspendLayout();
            this.page_services.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_data2)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.grid_data1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_data1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.grid_data1.Location = new System.Drawing.Point(6, 84);
            this.grid_data1.Name = "grid_data1";
            this.grid_data1.Size = new System.Drawing.Size(973, 407);
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
            this.page_supplier.Controls.Add(this.materialComboBox1);
            this.page_supplier.ImageKey = "3632552.png";
            this.page_supplier.Location = new System.Drawing.Point(4, 53);
            this.page_supplier.Name = "page_supplier";
            this.page_supplier.Size = new System.Drawing.Size(985, 497);
            this.page_supplier.TabIndex = 2;
            this.page_supplier.Text = "Supplier";
            // 
            // page_services
            // 
            this.page_services.BackColor = System.Drawing.Color.White;
            this.page_services.Controls.Add(this.groupBox1);
            this.page_services.ImageKey = "1924785.png";
            this.page_services.Location = new System.Drawing.Point(4, 53);
            this.page_services.Name = "page_services";
            this.page_services.Size = new System.Drawing.Size(985, 497);
            this.page_services.TabIndex = 3;
            this.page_services.Text = "Services";
            // 
            // page_history
            // 
            this.page_history.BackColor = System.Drawing.Color.Gainsboro;
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
            // materialComboBox1
            // 
            this.materialComboBox1.AutoResize = false;
            this.materialComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBox1.Depth = 0;
            this.materialComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBox1.DropDownHeight = 174;
            this.materialComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox1.DropDownWidth = 121;
            this.materialComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBox1.ForeColor = System.Drawing.Color.White;
            this.materialComboBox1.FormattingEnabled = true;
            this.materialComboBox1.IntegralHeight = false;
            this.materialComboBox1.ItemHeight = 43;
            this.materialComboBox1.Location = new System.Drawing.Point(6, 12);
            this.materialComboBox1.MaxDropDownItems = 4;
            this.materialComboBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBox1.Name = "materialComboBox1";
            this.materialComboBox1.Size = new System.Drawing.Size(302, 49);
            this.materialComboBox1.StartIndex = 0;
            this.materialComboBox1.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.materialListBox1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 491);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LIST SUPLIER";
            // 
            // materialListBox1
            // 
            this.materialListBox1.BackColor = System.Drawing.Color.White;
            this.materialListBox1.BorderColor = System.Drawing.Color.LightGray;
            this.materialListBox1.Depth = 0;
            this.materialListBox1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialListBox1.Location = new System.Drawing.Point(3, 19);
            this.materialListBox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialListBox1.Name = "materialListBox1";
            this.materialListBox1.SelectedIndex = -1;
            this.materialListBox1.SelectedItem = null;
            this.materialListBox1.Size = new System.Drawing.Size(191, 466);
            this.materialListBox1.TabIndex = 0;
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
            ((System.ComponentModel.ISupportInitialize)(this.grid_data2)).EndInit();
            this.groupBox1.ResumeLayout(false);
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
        private MaterialSkin.Controls.MaterialComboBox materialComboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialListBox materialListBox1;
    }
}

