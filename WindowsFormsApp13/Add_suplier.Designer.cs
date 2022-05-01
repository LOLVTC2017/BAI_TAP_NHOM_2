namespace WindowsFormsApp13
{
    partial class Add_suplier
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
            this.txt_address = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.txt_number = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.txt_name = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btn_suplier_add = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.TXT_SERVICE_NAME = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.TXT_SERVICE_PRICE = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.SuspendLayout();
            // 
            // txt_address
            // 
            this.txt_address.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_address.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_address.Depth = 0;
            this.txt_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_address.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txt_address.Location = new System.Drawing.Point(141, 315);
            this.txt_address.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(250, 39);
            this.txt_address.TabIndex = 17;
            this.txt_address.Text = "";
            // 
            // txt_number
            // 
            this.txt_number.AllowPromptAsInput = true;
            this.txt_number.AnimateReadOnly = false;
            this.txt_number.AsciiOnly = false;
            this.txt_number.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_number.BeepOnError = false;
            this.txt_number.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_number.Depth = 0;
            this.txt_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_number.HidePromptOnLeave = false;
            this.txt_number.HideSelection = true;
            this.txt_number.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txt_number.LeadingIcon = null;
            this.txt_number.Location = new System.Drawing.Point(141, 209);
            this.txt_number.Mask = "";
            this.txt_number.MaxLength = 32767;
            this.txt_number.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_number.Name = "txt_number";
            this.txt_number.PasswordChar = '\0';
            this.txt_number.PrefixSuffixText = null;
            this.txt_number.PromptChar = '_';
            this.txt_number.ReadOnly = false;
            this.txt_number.RejectInputOnFirstFailure = false;
            this.txt_number.ResetOnPrompt = true;
            this.txt_number.ResetOnSpace = true;
            this.txt_number.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_number.SelectedText = "";
            this.txt_number.SelectionLength = 0;
            this.txt_number.SelectionStart = 0;
            this.txt_number.ShortcutsEnabled = true;
            this.txt_number.Size = new System.Drawing.Size(250, 48);
            this.txt_number.SkipLiterals = true;
            this.txt_number.TabIndex = 16;
            this.txt_number.TabStop = false;
            this.txt_number.Text = " ";
            this.txt_number.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_number.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_number.TrailingIcon = null;
            this.txt_number.UseSystemPasswordChar = false;
            this.txt_number.ValidatingType = null;
            this.txt_number.Click += new System.EventHandler(this.txt_number_Click);
            this.txt_number.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_number_KeyPress);
            // 
            // txt_name
            // 
            this.txt_name.AllowPromptAsInput = true;
            this.txt_name.AnimateReadOnly = false;
            this.txt_name.AsciiOnly = false;
            this.txt_name.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_name.BeepOnError = false;
            this.txt_name.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_name.Depth = 0;
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_name.HidePromptOnLeave = false;
            this.txt_name.HideSelection = true;
            this.txt_name.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txt_name.LeadingIcon = null;
            this.txt_name.Location = new System.Drawing.Point(141, 86);
            this.txt_name.Mask = "";
            this.txt_name.MaxLength = 32767;
            this.txt_name.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_name.Name = "txt_name";
            this.txt_name.PasswordChar = '\0';
            this.txt_name.PrefixSuffixText = null;
            this.txt_name.PromptChar = '_';
            this.txt_name.ReadOnly = false;
            this.txt_name.RejectInputOnFirstFailure = false;
            this.txt_name.ResetOnPrompt = true;
            this.txt_name.ResetOnSpace = true;
            this.txt_name.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_name.SelectedText = "";
            this.txt_name.SelectionLength = 0;
            this.txt_name.SelectionStart = 0;
            this.txt_name.ShortcutsEnabled = true;
            this.txt_name.Size = new System.Drawing.Size(250, 48);
            this.txt_name.SkipLiterals = true;
            this.txt_name.TabIndex = 15;
            this.txt_name.TabStop = false;
            this.txt_name.Text = " ";
            this.txt_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_name.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_name.TrailingIcon = null;
            this.txt_name.UseSystemPasswordChar = false;
            this.txt_name.ValidatingType = null;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(25, 335);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(58, 19);
            this.materialLabel4.TabIndex = 14;
            this.materialLabel4.Text = "Address";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(25, 238);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(106, 19);
            this.materialLabel3.TabIndex = 13;
            this.materialLabel3.Text = "Phone Number";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(25, 115);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(43, 19);
            this.materialLabel1.TabIndex = 12;
            this.materialLabel1.Text = "Name";
            // 
            // btn_suplier_add
            // 
            this.btn_suplier_add.AutoSize = false;
            this.btn_suplier_add.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_suplier_add.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_suplier_add.Depth = 0;
            this.btn_suplier_add.HighEmphasis = true;
            this.btn_suplier_add.Icon = null;
            this.btn_suplier_add.Location = new System.Drawing.Point(141, 599);
            this.btn_suplier_add.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_suplier_add.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_suplier_add.Name = "btn_suplier_add";
            this.btn_suplier_add.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_suplier_add.Size = new System.Drawing.Size(158, 36);
            this.btn_suplier_add.TabIndex = 18;
            this.btn_suplier_add.Text = "Add Suplier";
            this.btn_suplier_add.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_suplier_add.UseAccentColor = false;
            this.btn_suplier_add.UseVisualStyleBackColor = true;
            this.btn_suplier_add.Click += new System.EventHandler(this.btn_suplier_add_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(25, 424);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(52, 19);
            this.materialLabel2.TabIndex = 19;
            this.materialLabel2.Text = "Service";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(25, 519);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(99, 19);
            this.materialLabel5.TabIndex = 21;
            this.materialLabel5.Text = "Services Price";
            // 
            // TXT_SERVICE_NAME
            // 
            this.TXT_SERVICE_NAME.AllowPromptAsInput = true;
            this.TXT_SERVICE_NAME.AnimateReadOnly = false;
            this.TXT_SERVICE_NAME.AsciiOnly = false;
            this.TXT_SERVICE_NAME.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TXT_SERVICE_NAME.BeepOnError = false;
            this.TXT_SERVICE_NAME.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.TXT_SERVICE_NAME.Depth = 0;
            this.TXT_SERVICE_NAME.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TXT_SERVICE_NAME.HidePromptOnLeave = false;
            this.TXT_SERVICE_NAME.HideSelection = true;
            this.TXT_SERVICE_NAME.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.TXT_SERVICE_NAME.LeadingIcon = null;
            this.TXT_SERVICE_NAME.Location = new System.Drawing.Point(141, 395);
            this.TXT_SERVICE_NAME.Mask = "";
            this.TXT_SERVICE_NAME.MaxLength = 32767;
            this.TXT_SERVICE_NAME.MouseState = MaterialSkin.MouseState.OUT;
            this.TXT_SERVICE_NAME.Name = "TXT_SERVICE_NAME";
            this.TXT_SERVICE_NAME.PasswordChar = '\0';
            this.TXT_SERVICE_NAME.PrefixSuffixText = null;
            this.TXT_SERVICE_NAME.PromptChar = '_';
            this.TXT_SERVICE_NAME.ReadOnly = false;
            this.TXT_SERVICE_NAME.RejectInputOnFirstFailure = false;
            this.TXT_SERVICE_NAME.ResetOnPrompt = true;
            this.TXT_SERVICE_NAME.ResetOnSpace = true;
            this.TXT_SERVICE_NAME.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TXT_SERVICE_NAME.SelectedText = "";
            this.TXT_SERVICE_NAME.SelectionLength = 0;
            this.TXT_SERVICE_NAME.SelectionStart = 0;
            this.TXT_SERVICE_NAME.ShortcutsEnabled = true;
            this.TXT_SERVICE_NAME.Size = new System.Drawing.Size(250, 48);
            this.TXT_SERVICE_NAME.SkipLiterals = true;
            this.TXT_SERVICE_NAME.TabIndex = 23;
            this.TXT_SERVICE_NAME.TabStop = false;
            this.TXT_SERVICE_NAME.Text = " ";
            this.TXT_SERVICE_NAME.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_SERVICE_NAME.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.TXT_SERVICE_NAME.TrailingIcon = null;
            this.TXT_SERVICE_NAME.UseSystemPasswordChar = false;
            this.TXT_SERVICE_NAME.ValidatingType = null;
            // 
            // TXT_SERVICE_PRICE
            // 
            this.TXT_SERVICE_PRICE.AllowPromptAsInput = true;
            this.TXT_SERVICE_PRICE.AnimateReadOnly = false;
            this.TXT_SERVICE_PRICE.AsciiOnly = false;
            this.TXT_SERVICE_PRICE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TXT_SERVICE_PRICE.BeepOnError = false;
            this.TXT_SERVICE_PRICE.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.TXT_SERVICE_PRICE.Depth = 0;
            this.TXT_SERVICE_PRICE.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TXT_SERVICE_PRICE.HidePromptOnLeave = false;
            this.TXT_SERVICE_PRICE.HideSelection = true;
            this.TXT_SERVICE_PRICE.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.TXT_SERVICE_PRICE.LeadingIcon = null;
            this.TXT_SERVICE_PRICE.Location = new System.Drawing.Point(141, 490);
            this.TXT_SERVICE_PRICE.Mask = "";
            this.TXT_SERVICE_PRICE.MaxLength = 32767;
            this.TXT_SERVICE_PRICE.MouseState = MaterialSkin.MouseState.OUT;
            this.TXT_SERVICE_PRICE.Name = "TXT_SERVICE_PRICE";
            this.TXT_SERVICE_PRICE.PasswordChar = '\0';
            this.TXT_SERVICE_PRICE.PrefixSuffixText = null;
            this.TXT_SERVICE_PRICE.PromptChar = '_';
            this.TXT_SERVICE_PRICE.ReadOnly = false;
            this.TXT_SERVICE_PRICE.RejectInputOnFirstFailure = false;
            this.TXT_SERVICE_PRICE.ResetOnPrompt = true;
            this.TXT_SERVICE_PRICE.ResetOnSpace = true;
            this.TXT_SERVICE_PRICE.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TXT_SERVICE_PRICE.SelectedText = "";
            this.TXT_SERVICE_PRICE.SelectionLength = 0;
            this.TXT_SERVICE_PRICE.SelectionStart = 0;
            this.TXT_SERVICE_PRICE.ShortcutsEnabled = true;
            this.TXT_SERVICE_PRICE.Size = new System.Drawing.Size(250, 48);
            this.TXT_SERVICE_PRICE.SkipLiterals = true;
            this.TXT_SERVICE_PRICE.TabIndex = 24;
            this.TXT_SERVICE_PRICE.TabStop = false;
            this.TXT_SERVICE_PRICE.Text = " ";
            this.TXT_SERVICE_PRICE.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_SERVICE_PRICE.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.TXT_SERVICE_PRICE.TrailingIcon = null;
            this.TXT_SERVICE_PRICE.UseSystemPasswordChar = false;
            this.TXT_SERVICE_PRICE.ValidatingType = null;
            // 
            // Add_suplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 705);
            this.Controls.Add(this.TXT_SERVICE_PRICE);
            this.Controls.Add(this.TXT_SERVICE_NAME);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.btn_suplier_add);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.txt_number);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel1);
            this.Name = "Add_suplier";
            this.Text = "Add_suplier";
            this.Load += new System.EventHandler(this.Add_suplier_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialMultiLineTextBox txt_address;
        private MaterialSkin.Controls.MaterialMaskedTextBox txt_number;
        private MaterialSkin.Controls.MaterialMaskedTextBox txt_name;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton btn_suplier_add;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialMaskedTextBox TXT_SERVICE_NAME;
        private MaterialSkin.Controls.MaterialMaskedTextBox TXT_SERVICE_PRICE;
    }
}