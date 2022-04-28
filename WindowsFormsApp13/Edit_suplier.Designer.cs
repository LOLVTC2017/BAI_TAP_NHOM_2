namespace WindowsFormsApp13
{
    partial class Edit_suplier
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
            this.btn_suplier_edit = new MaterialSkin.Controls.MaterialButton();
            this.txt_address = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.txt_number = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.txt_name = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // btn_suplier_edit
            // 
            this.btn_suplier_edit.AutoSize = false;
            this.btn_suplier_edit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_suplier_edit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_suplier_edit.Depth = 0;
            this.btn_suplier_edit.HighEmphasis = true;
            this.btn_suplier_edit.Icon = null;
            this.btn_suplier_edit.Location = new System.Drawing.Point(161, 428);
            this.btn_suplier_edit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_suplier_edit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_suplier_edit.Name = "btn_suplier_edit";
            this.btn_suplier_edit.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_suplier_edit.Size = new System.Drawing.Size(158, 36);
            this.btn_suplier_edit.TabIndex = 25;
            this.btn_suplier_edit.Text = "Edit Suplier";
            this.btn_suplier_edit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_suplier_edit.UseAccentColor = false;
            this.btn_suplier_edit.UseVisualStyleBackColor = true;
            // 
            // txt_address
            // 
            this.txt_address.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_address.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_address.Depth = 0;
            this.txt_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_address.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txt_address.Location = new System.Drawing.Point(161, 342);
            this.txt_address.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(250, 39);
            this.txt_address.TabIndex = 24;
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
            this.txt_number.Location = new System.Drawing.Point(161, 226);
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
            this.txt_number.TabIndex = 23;
            this.txt_number.TabStop = false;
            this.txt_number.Text = " ";
            this.txt_number.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_number.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_number.TrailingIcon = null;
            this.txt_number.UseSystemPasswordChar = false;
            this.txt_number.ValidatingType = null;
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
            this.txt_name.Location = new System.Drawing.Point(161, 103);
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
            this.txt_name.TabIndex = 22;
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
            this.materialLabel4.Location = new System.Drawing.Point(45, 362);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(58, 19);
            this.materialLabel4.TabIndex = 21;
            this.materialLabel4.Text = "Address";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(45, 255);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(106, 19);
            this.materialLabel3.TabIndex = 20;
            this.materialLabel3.Text = "Phone Number";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(45, 132);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(43, 19);
            this.materialLabel1.TabIndex = 19;
            this.materialLabel1.Text = "Name";
            // 
            // Edit_suplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 508);
            this.Controls.Add(this.btn_suplier_edit);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.txt_number);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel1);
            this.Name = "Edit_suplier";
            this.Text = "Edit_suplier";
            this.Load += new System.EventHandler(this.Edit_suplier_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btn_suplier_edit;
        private MaterialSkin.Controls.MaterialMultiLineTextBox txt_address;
        private MaterialSkin.Controls.MaterialMaskedTextBox txt_number;
        private MaterialSkin.Controls.MaterialMaskedTextBox txt_name;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}