namespace WindowsFormsApp13
{
    partial class client_page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(client_page));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.txt_firstname = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_lastname = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_phonenumber = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_address = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.btn_update = new MaterialSkin.Controls.MaterialButton();
            this.txt_accountpassword = new MaterialSkin.Controls.MaterialTextBox();
            this.account_password = new MaterialSkin.Controls.MaterialLabel();
            this.txt_accountusername = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.list_services = new MaterialSkin.Controls.MaterialListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.materialButton3 = new MaterialSkin.Controls.MaterialButton();
            this.btn_purchase = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialButton4 = new MaterialSkin.Controls.MaterialButton();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1069, 537);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.materialButton1);
            this.tabPage1.Controls.Add(this.txt_accountusername);
            this.tabPage1.Controls.Add(this.materialLabel1);
            this.tabPage1.Controls.Add(this.txt_accountpassword);
            this.tabPage1.Controls.Add(this.account_password);
            this.tabPage1.Controls.Add(this.btn_update);
            this.tabPage1.Controls.Add(this.materialButton2);
            this.tabPage1.Controls.Add(this.txt_address);
            this.tabPage1.Controls.Add(this.txt_phonenumber);
            this.tabPage1.Controls.Add(this.txt_lastname);
            this.tabPage1.Controls.Add(this.txt_firstname);
            this.tabPage1.Controls.Add(this.materialLabel5);
            this.tabPage1.Controls.Add(this.materialLabel4);
            this.tabPage1.Controls.Add(this.materialLabel3);
            this.tabPage1.Controls.Add(this.materialLabel2);
            this.tabPage1.ImageIndex = 4;
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1061, 494);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Account";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.ImageIndex = 5;
            this.tabPage2.Location = new System.Drawing.Point(4, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1061, 494);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Purchase";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.Controls.Add(this.materialLabel12);
            this.tabPage3.ImageIndex = 1;
            this.tabPage3.Location = new System.Drawing.Point(4, 39);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1061, 494);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "History Payment";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(18, 49);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(148, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Account First Name :";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(18, 137);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(148, 19);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "Account Last Name :";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(18, 235);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(176, 19);
            this.materialLabel4.TabIndex = 3;
            this.materialLabel4.Text = "Account Phone Number :";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(588, 21);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(128, 19);
            this.materialLabel5.TabIndex = 4;
            this.materialLabel5.Text = "Account Address :";
            // 
            // txt_firstname
            // 
            this.txt_firstname.AnimateReadOnly = false;
            this.txt_firstname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_firstname.Depth = 0;
            this.txt_firstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_firstname.LeadingIcon = null;
            this.txt_firstname.Location = new System.Drawing.Point(219, 18);
            this.txt_firstname.MaxLength = 50;
            this.txt_firstname.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_firstname.Multiline = false;
            this.txt_firstname.Name = "txt_firstname";
            this.txt_firstname.Size = new System.Drawing.Size(297, 50);
            this.txt_firstname.TabIndex = 5;
            this.txt_firstname.Text = "";
            this.txt_firstname.TrailingIcon = null;
            // 
            // txt_lastname
            // 
            this.txt_lastname.AnimateReadOnly = false;
            this.txt_lastname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_lastname.Depth = 0;
            this.txt_lastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_lastname.LeadingIcon = null;
            this.txt_lastname.Location = new System.Drawing.Point(219, 106);
            this.txt_lastname.MaxLength = 50;
            this.txt_lastname.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_lastname.Multiline = false;
            this.txt_lastname.Name = "txt_lastname";
            this.txt_lastname.Size = new System.Drawing.Size(297, 50);
            this.txt_lastname.TabIndex = 6;
            this.txt_lastname.Text = "";
            this.txt_lastname.TrailingIcon = null;
            // 
            // txt_phonenumber
            // 
            this.txt_phonenumber.AnimateReadOnly = false;
            this.txt_phonenumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_phonenumber.Depth = 0;
            this.txt_phonenumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_phonenumber.LeadingIcon = null;
            this.txt_phonenumber.Location = new System.Drawing.Point(219, 204);
            this.txt_phonenumber.MaxLength = 50;
            this.txt_phonenumber.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_phonenumber.Multiline = false;
            this.txt_phonenumber.Name = "txt_phonenumber";
            this.txt_phonenumber.Size = new System.Drawing.Size(297, 50);
            this.txt_phonenumber.TabIndex = 7;
            this.txt_phonenumber.Text = "";
            this.txt_phonenumber.TrailingIcon = null;
            // 
            // txt_address
            // 
            this.txt_address.AnimateReadOnly = false;
            this.txt_address.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_address.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_address.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_address.Depth = 0;
            this.txt_address.HideSelection = true;
            this.txt_address.Location = new System.Drawing.Point(591, 56);
            this.txt_address.MaxLength = 32767;
            this.txt_address.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_address.Name = "txt_address";
            this.txt_address.PasswordChar = '\0';
            this.txt_address.ReadOnly = false;
            this.txt_address.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_address.SelectedText = "";
            this.txt_address.SelectionLength = 0;
            this.txt_address.SelectionStart = 0;
            this.txt_address.ShortcutsEnabled = true;
            this.txt_address.Size = new System.Drawing.Size(437, 100);
            this.txt_address.TabIndex = 8;
            this.txt_address.TabStop = false;
            this.txt_address.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_address.UseSystemPasswordChar = false;
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSize = false;
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(836, 197);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(192, 36);
            this.materialButton2.TabIndex = 10;
            this.materialButton2.Text = "Delete Account ";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            // 
            // btn_update
            // 
            this.btn_update.AutoSize = false;
            this.btn_update.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_update.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_update.Depth = 0;
            this.btn_update.HighEmphasis = true;
            this.btn_update.Icon = null;
            this.btn_update.Location = new System.Drawing.Point(590, 197);
            this.btn_update.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_update.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_update.Name = "btn_update";
            this.btn_update.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_update.Size = new System.Drawing.Size(192, 36);
            this.btn_update.TabIndex = 11;
            this.btn_update.Text = "update information";
            this.btn_update.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_update.UseAccentColor = false;
            this.btn_update.UseVisualStyleBackColor = true;
            // 
            // txt_accountpassword
            // 
            this.txt_accountpassword.AnimateReadOnly = false;
            this.txt_accountpassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_accountpassword.Depth = 0;
            this.txt_accountpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_accountpassword.LeadingIcon = null;
            this.txt_accountpassword.Location = new System.Drawing.Point(219, 393);
            this.txt_accountpassword.MaxLength = 50;
            this.txt_accountpassword.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_accountpassword.Multiline = false;
            this.txt_accountpassword.Name = "txt_accountpassword";
            this.txt_accountpassword.Size = new System.Drawing.Size(297, 50);
            this.txt_accountpassword.TabIndex = 13;
            this.txt_accountpassword.Text = "";
            this.txt_accountpassword.TrailingIcon = null;
            // 
            // account_password
            // 
            this.account_password.AutoSize = true;
            this.account_password.Depth = 0;
            this.account_password.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.account_password.Location = new System.Drawing.Point(18, 424);
            this.account_password.MouseState = MaterialSkin.MouseState.HOVER;
            this.account_password.Name = "account_password";
            this.account_password.Size = new System.Drawing.Size(141, 19);
            this.account_password.TabIndex = 12;
            this.account_password.Text = "Account Password :";
            // 
            // txt_accountusername
            // 
            this.txt_accountusername.AnimateReadOnly = false;
            this.txt_accountusername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_accountusername.Depth = 0;
            this.txt_accountusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_accountusername.LeadingIcon = null;
            this.txt_accountusername.Location = new System.Drawing.Point(219, 296);
            this.txt_accountusername.MaxLength = 50;
            this.txt_accountusername.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_accountusername.Multiline = false;
            this.txt_accountusername.Name = "txt_accountusername";
            this.txt_accountusername.Size = new System.Drawing.Size(297, 50);
            this.txt_accountusername.TabIndex = 15;
            this.txt_accountusername.Text = "";
            this.txt_accountusername.TrailingIcon = null;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(18, 327);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(144, 19);
            this.materialLabel1.TabIndex = 14;
            this.materialLabel1.Text = "Account User Name:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1061, 405);
            this.dataGridView1.TabIndex = 3;
            // 
            // materialLabel12
            // 
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel12.Location = new System.Drawing.Point(0, 0);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(1061, 83);
            this.materialLabel12.TabIndex = 2;
            this.materialLabel12.Text = "History Payment";
            this.materialLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSize = false;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(590, 271);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(192, 36);
            this.materialButton1.TabIndex = 16;
            this.materialButton1.Text = "logout";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "686317.png");
            this.imageList1.Images.SetKeyName(1, "6107230.png");
            this.imageList1.Images.SetKeyName(2, "3632552.png");
            this.imageList1.Images.SetKeyName(3, "1924785.png");
            this.imageList1.Images.SetKeyName(4, "1144760.png");
            this.imageList1.Images.SetKeyName(5, "1374128.png");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.list_services);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 488);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Purchased Services";
            // 
            // list_services
            // 
            this.list_services.BackColor = System.Drawing.Color.White;
            this.list_services.BorderColor = System.Drawing.Color.LightGray;
            this.list_services.Depth = 0;
            this.list_services.Dock = System.Windows.Forms.DockStyle.Left;
            this.list_services.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.list_services.Location = new System.Drawing.Point(3, 16);
            this.list_services.MouseState = MaterialSkin.MouseState.HOVER;
            this.list_services.Name = "list_services";
            this.list_services.SelectedIndex = -1;
            this.list_services.SelectedItem = null;
            this.list_services.Size = new System.Drawing.Size(170, 469);
            this.list_services.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.materialButton4);
            this.groupBox2.Controls.Add(this.materialLabel8);
            this.groupBox2.Controls.Add(this.materialLabel7);
            this.groupBox2.Controls.Add(this.btn_purchase);
            this.groupBox2.Controls.Add(this.materialButton3);
            this.groupBox2.Controls.Add(this.dataGridView3);
            this.groupBox2.Controls.Add(this.materialLabel6);
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(209, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(849, 488);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Order";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 48);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(846, 150);
            this.dataGridView2.TabIndex = 0;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(6, 26);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(82, 19);
            this.materialLabel6.TabIndex = 1;
            this.materialLabel6.Text = "All Services";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView3.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(0, 256);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(846, 150);
            this.dataGridView3.TabIndex = 2;
            // 
            // materialButton3
            // 
            this.materialButton3.AutoSize = false;
            this.materialButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton3.Depth = 0;
            this.materialButton3.HighEmphasis = true;
            this.materialButton3.Icon = null;
            this.materialButton3.Location = new System.Drawing.Point(684, 443);
            this.materialButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton3.Name = "materialButton3";
            this.materialButton3.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton3.Size = new System.Drawing.Size(158, 36);
            this.materialButton3.TabIndex = 3;
            this.materialButton3.Text = "PAY";
            this.materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton3.UseAccentColor = false;
            this.materialButton3.UseVisualStyleBackColor = true;
            // 
            // btn_purchase
            // 
            this.btn_purchase.AutoSize = false;
            this.btn_purchase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_purchase.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_purchase.Depth = 0;
            this.btn_purchase.HighEmphasis = true;
            this.btn_purchase.Icon = null;
            this.btn_purchase.Location = new System.Drawing.Point(490, 443);
            this.btn_purchase.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_purchase.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_purchase.Name = "btn_purchase";
            this.btn_purchase.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_purchase.Size = new System.Drawing.Size(158, 36);
            this.btn_purchase.TabIndex = 4;
            this.btn_purchase.Text = "order";
            this.btn_purchase.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_purchase.UseAccentColor = false;
            this.btn_purchase.UseVisualStyleBackColor = true;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.Location = new System.Drawing.Point(6, 453);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(46, 19);
            this.materialLabel7.TabIndex = 5;
            this.materialLabel7.Text = "Total :";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.Location = new System.Drawing.Point(58, 454);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(107, 19);
            this.materialLabel8.TabIndex = 6;
            this.materialLabel8.Text = "materialLabel8";
            // 
            // materialButton4
            // 
            this.materialButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton4.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton4.Depth = 0;
            this.materialButton4.HighEmphasis = true;
            this.materialButton4.Icon = null;
            this.materialButton4.Location = new System.Drawing.Point(638, 207);
            this.materialButton4.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton4.Name = "materialButton4";
            this.materialButton4.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton4.Size = new System.Drawing.Size(64, 36);
            this.materialButton4.TabIndex = 7;
            this.materialButton4.Text = "ADD";
            this.materialButton4.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton4.UseAccentColor = false;
            this.materialButton4.UseVisualStyleBackColor = true;
            // 
            // client_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 604);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerTabControl = this.materialTabControl1;
            this.Name = "client_page";
            this.Text = "client_page";
            this.Load += new System.EventHandler(this.client_page_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private MaterialSkin.Controls.MaterialButton btn_update;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txt_address;
        private MaterialSkin.Controls.MaterialTextBox txt_phonenumber;
        private MaterialSkin.Controls.MaterialTextBox txt_lastname;
        private MaterialSkin.Controls.MaterialTextBox txt_firstname;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox txt_accountusername;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox txt_accountpassword;
        private MaterialSkin.Controls.MaterialLabel account_password;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialButton materialButton4;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialButton btn_purchase;
        private MaterialSkin.Controls.MaterialButton materialButton3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialListBox list_services;
    }
}