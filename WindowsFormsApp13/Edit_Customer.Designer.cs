namespace WindowsFormsApp13
{
    partial class Edit_Customer
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
            this.btn_customer = new MaterialSkin.Controls.MaterialButton();
            this.txt_address = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.txt_password = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.txt_username = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.txt_number = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.txt_lastname = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.txt_firstname = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // btn_customer
            // 
            this.btn_customer.AutoSize = false;
            this.btn_customer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_customer.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_customer.Depth = 0;
            this.btn_customer.HighEmphasis = true;
            this.btn_customer.Icon = null;
            this.btn_customer.Location = new System.Drawing.Point(200, 568);
            this.btn_customer.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_customer.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_customer.Name = "btn_customer";
            this.btn_customer.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_customer.Size = new System.Drawing.Size(158, 36);
            this.btn_customer.TabIndex = 25;
            this.btn_customer.Text = "Update ";
            this.btn_customer.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_customer.UseAccentColor = false;
            this.btn_customer.UseVisualStyleBackColor = true;
            this.btn_customer.Click += new System.EventHandler(this.btn_customer_Click);
            // 
            // txt_address
            // 
            this.txt_address.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_address.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_address.Depth = 0;
            this.txt_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_address.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txt_address.Location = new System.Drawing.Point(200, 325);
            this.txt_address.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(250, 39);
            this.txt_address.TabIndex = 24;
            this.txt_address.Text = "";
            // 
            // txt_password
            // 
            this.txt_password.AllowPromptAsInput = true;
            this.txt_password.AnimateReadOnly = false;
            this.txt_password.AsciiOnly = false;
            this.txt_password.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_password.BeepOnError = false;
            this.txt_password.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_password.Depth = 0;
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_password.HidePromptOnLeave = false;
            this.txt_password.HideSelection = true;
            this.txt_password.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txt_password.LeadingIcon = null;
            this.txt_password.Location = new System.Drawing.Point(200, 486);
            this.txt_password.Mask = "";
            this.txt_password.MaxLength = 32767;
            this.txt_password.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '\0';
            this.txt_password.PrefixSuffixText = null;
            this.txt_password.PromptChar = '_';
            this.txt_password.ReadOnly = false;
            this.txt_password.RejectInputOnFirstFailure = false;
            this.txt_password.ResetOnPrompt = true;
            this.txt_password.ResetOnSpace = true;
            this.txt_password.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_password.SelectedText = "";
            this.txt_password.SelectionLength = 0;
            this.txt_password.SelectionStart = 0;
            this.txt_password.ShortcutsEnabled = true;
            this.txt_password.Size = new System.Drawing.Size(250, 48);
            this.txt_password.SkipLiterals = true;
            this.txt_password.TabIndex = 23;
            this.txt_password.TabStop = false;
            this.txt_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_password.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_password.TrailingIcon = null;
            this.txt_password.UseSystemPasswordChar = false;
            this.txt_password.ValidatingType = null;
            // 
            // txt_username
            // 
            this.txt_username.AllowPromptAsInput = true;
            this.txt_username.AnimateReadOnly = false;
            this.txt_username.AsciiOnly = false;
            this.txt_username.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_username.BeepOnError = false;
            this.txt_username.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_username.Depth = 0;
            this.txt_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_username.HidePromptOnLeave = false;
            this.txt_username.HideSelection = true;
            this.txt_username.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txt_username.LeadingIcon = null;
            this.txt_username.Location = new System.Drawing.Point(200, 398);
            this.txt_username.Mask = "";
            this.txt_username.MaxLength = 32767;
            this.txt_username.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_username.Name = "txt_username";
            this.txt_username.PasswordChar = '\0';
            this.txt_username.PrefixSuffixText = null;
            this.txt_username.PromptChar = '_';
            this.txt_username.ReadOnly = false;
            this.txt_username.RejectInputOnFirstFailure = false;
            this.txt_username.ResetOnPrompt = true;
            this.txt_username.ResetOnSpace = true;
            this.txt_username.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_username.SelectedText = "";
            this.txt_username.SelectionLength = 0;
            this.txt_username.SelectionStart = 0;
            this.txt_username.ShortcutsEnabled = true;
            this.txt_username.Size = new System.Drawing.Size(250, 48);
            this.txt_username.SkipLiterals = true;
            this.txt_username.TabIndex = 22;
            this.txt_username.TabStop = false;
            this.txt_username.Text = " ";
            this.txt_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_username.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_username.TrailingIcon = null;
            this.txt_username.UseSystemPasswordChar = false;
            this.txt_username.ValidatingType = null;
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
            this.txt_number.Location = new System.Drawing.Point(200, 243);
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
            this.txt_number.TabIndex = 21;
            this.txt_number.TabStop = false;
            this.txt_number.Text = " ";
            this.txt_number.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_number.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_number.TrailingIcon = null;
            this.txt_number.UseSystemPasswordChar = false;
            this.txt_number.ValidatingType = null;
            // 
            // txt_lastname
            // 
            this.txt_lastname.AllowPromptAsInput = true;
            this.txt_lastname.AnimateReadOnly = false;
            this.txt_lastname.AsciiOnly = false;
            this.txt_lastname.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_lastname.BeepOnError = false;
            this.txt_lastname.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_lastname.Depth = 0;
            this.txt_lastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_lastname.HidePromptOnLeave = false;
            this.txt_lastname.HideSelection = true;
            this.txt_lastname.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txt_lastname.LeadingIcon = null;
            this.txt_lastname.Location = new System.Drawing.Point(200, 168);
            this.txt_lastname.Mask = "";
            this.txt_lastname.MaxLength = 32767;
            this.txt_lastname.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_lastname.Name = "txt_lastname";
            this.txt_lastname.PasswordChar = '\0';
            this.txt_lastname.PrefixSuffixText = null;
            this.txt_lastname.PromptChar = '_';
            this.txt_lastname.ReadOnly = false;
            this.txt_lastname.RejectInputOnFirstFailure = false;
            this.txt_lastname.ResetOnPrompt = true;
            this.txt_lastname.ResetOnSpace = true;
            this.txt_lastname.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_lastname.SelectedText = "";
            this.txt_lastname.SelectionLength = 0;
            this.txt_lastname.SelectionStart = 0;
            this.txt_lastname.ShortcutsEnabled = true;
            this.txt_lastname.Size = new System.Drawing.Size(250, 48);
            this.txt_lastname.SkipLiterals = true;
            this.txt_lastname.TabIndex = 20;
            this.txt_lastname.TabStop = false;
            this.txt_lastname.Text = " ";
            this.txt_lastname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_lastname.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_lastname.TrailingIcon = null;
            this.txt_lastname.UseSystemPasswordChar = false;
            this.txt_lastname.ValidatingType = null;
            // 
            // txt_firstname
            // 
            this.txt_firstname.AllowPromptAsInput = true;
            this.txt_firstname.AnimateReadOnly = false;
            this.txt_firstname.AsciiOnly = false;
            this.txt_firstname.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_firstname.BeepOnError = false;
            this.txt_firstname.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_firstname.Depth = 0;
            this.txt_firstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_firstname.HidePromptOnLeave = false;
            this.txt_firstname.HideSelection = true;
            this.txt_firstname.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txt_firstname.LeadingIcon = null;
            this.txt_firstname.Location = new System.Drawing.Point(200, 86);
            this.txt_firstname.Mask = "";
            this.txt_firstname.MaxLength = 32767;
            this.txt_firstname.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_firstname.Name = "txt_firstname";
            this.txt_firstname.PasswordChar = '\0';
            this.txt_firstname.PrefixSuffixText = null;
            this.txt_firstname.PromptChar = '_';
            this.txt_firstname.ReadOnly = false;
            this.txt_firstname.RejectInputOnFirstFailure = false;
            this.txt_firstname.ResetOnPrompt = true;
            this.txt_firstname.ResetOnSpace = true;
            this.txt_firstname.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_firstname.SelectedText = "";
            this.txt_firstname.SelectionLength = 0;
            this.txt_firstname.SelectionStart = 0;
            this.txt_firstname.ShortcutsEnabled = true;
            this.txt_firstname.Size = new System.Drawing.Size(250, 48);
            this.txt_firstname.SkipLiterals = true;
            this.txt_firstname.TabIndex = 19;
            this.txt_firstname.TabStop = false;
            this.txt_firstname.Text = " ";
            this.txt_firstname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_firstname.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_firstname.TrailingIcon = null;
            this.txt_firstname.UseSystemPasswordChar = false;
            this.txt_firstname.ValidatingType = null;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(84, 515);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(71, 19);
            this.materialLabel6.TabIndex = 18;
            this.materialLabel6.Text = "Password";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(83, 427);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(72, 19);
            this.materialLabel5.TabIndex = 17;
            this.materialLabel5.Text = "Username";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(84, 345);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(58, 19);
            this.materialLabel4.TabIndex = 16;
            this.materialLabel4.Text = "Address";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(84, 272);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(106, 19);
            this.materialLabel3.TabIndex = 15;
            this.materialLabel3.Text = "Phone Number";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(84, 197);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(78, 19);
            this.materialLabel2.TabIndex = 14;
            this.materialLabel2.Text = "Last Name";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(84, 115);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(78, 19);
            this.materialLabel1.TabIndex = 13;
            this.materialLabel1.Text = "First Name";
            // 
            // Edit_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 626);
            this.Controls.Add(this.btn_customer);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.txt_number);
            this.Controls.Add(this.txt_lastname);
            this.Controls.Add(this.txt_firstname);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Name = "Edit_Customer";
            this.Text = "Edit_Customer";
            this.Load += new System.EventHandler(this.Edit_Customer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btn_customer;
        private MaterialSkin.Controls.MaterialMultiLineTextBox txt_address;
        private MaterialSkin.Controls.MaterialMaskedTextBox txt_password;
        private MaterialSkin.Controls.MaterialMaskedTextBox txt_username;
        private MaterialSkin.Controls.MaterialMaskedTextBox txt_number;
        private MaterialSkin.Controls.MaterialMaskedTextBox txt_lastname;
        private MaterialSkin.Controls.MaterialMaskedTextBox txt_firstname;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}