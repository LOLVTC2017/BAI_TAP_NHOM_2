namespace WindowsFormsApp13
{
    partial class client_login
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
            this.lable_username = new MaterialSkin.Controls.MaterialLabel();
            this.materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            this.lable_userpassword = new MaterialSkin.Controls.MaterialLabel();
            this.txt_userpassword = new MaterialSkin.Controls.MaterialTextBox();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // lable_username
            // 
            this.lable_username.AutoSize = true;
            this.lable_username.Depth = 0;
            this.lable_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lable_username.Location = new System.Drawing.Point(342, 84);
            this.lable_username.MouseState = MaterialSkin.MouseState.HOVER;
            this.lable_username.Name = "lable_username";
            this.lable_username.Size = new System.Drawing.Size(78, 19);
            this.lable_username.TabIndex = 0;
            this.lable_username.Text = "User Name";
            // 
            // materialTextBox1
            // 
            this.materialTextBox1.AnimateReadOnly = false;
            this.materialTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox1.Depth = 0;
            this.materialTextBox1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox1.LeadingIcon = null;
            this.materialTextBox1.Location = new System.Drawing.Point(174, 153);
            this.materialTextBox1.MaxLength = 50;
            this.materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox1.Multiline = false;
            this.materialTextBox1.Name = "materialTextBox1";
            this.materialTextBox1.Size = new System.Drawing.Size(415, 50);
            this.materialTextBox1.TabIndex = 1;
            this.materialTextBox1.Text = "";
            this.materialTextBox1.TrailingIcon = null;
            // 
            // lable_userpassword
            // 
            this.lable_userpassword.AutoSize = true;
            this.lable_userpassword.Depth = 0;
            this.lable_userpassword.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lable_userpassword.Location = new System.Drawing.Point(338, 238);
            this.lable_userpassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.lable_userpassword.Name = "lable_userpassword";
            this.lable_userpassword.Size = new System.Drawing.Size(87, 19);
            this.lable_userpassword.TabIndex = 2;
            this.lable_userpassword.Text = "PASSWORD";
            // 
            // txt_userpassword
            // 
            this.txt_userpassword.AnimateReadOnly = false;
            this.txt_userpassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_userpassword.Depth = 0;
            this.txt_userpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_userpassword.LeadingIcon = null;
            this.txt_userpassword.Location = new System.Drawing.Point(174, 292);
            this.txt_userpassword.MaxLength = 50;
            this.txt_userpassword.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_userpassword.Multiline = false;
            this.txt_userpassword.Name = "txt_userpassword";
            this.txt_userpassword.Password = true;
            this.txt_userpassword.Size = new System.Drawing.Size(415, 50);
            this.txt_userpassword.TabIndex = 3;
            this.txt_userpassword.Text = "";
            this.txt_userpassword.TrailingIcon = null;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSize = false;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(287, 378);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(189, 36);
            this.materialButton1.TabIndex = 4;
            this.materialButton1.Text = "Login";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            // 
            // client_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.txt_userpassword);
            this.Controls.Add(this.lable_userpassword);
            this.Controls.Add(this.materialTextBox1);
            this.Controls.Add(this.lable_username);
            this.Name = "client_login";
            this.Text = "client_login";
            this.Load += new System.EventHandler(this.client_login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lable_username;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
        private MaterialSkin.Controls.MaterialLabel lable_userpassword;
        private MaterialSkin.Controls.MaterialTextBox txt_userpassword;
        private MaterialSkin.Controls.MaterialButton materialButton1;
    }
}