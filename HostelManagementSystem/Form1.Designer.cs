namespace HostelManagementSystem
{
    partial class form_login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_username = new Guna.UI2.WinForms.Guna2TextBox();
            this.tb_password = new Guna.UI2.WinForms.Guna2TextBox();
            this.bt_signIn = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(143, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Welcome, please login.";
            // 
            // tb_username
            // 
            this.tb_username.BorderColor = System.Drawing.Color.Black;
            this.tb_username.BorderRadius = 22;
            this.tb_username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_username.DefaultText = "Xamurani";
            this.tb_username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_username.DisabledState.Parent = this.tb_username;
            this.tb_username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_username.FocusedState.Parent = this.tb_username;
            this.tb_username.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.tb_username.ForeColor = System.Drawing.Color.Black;
            this.tb_username.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_username.HoverState.Parent = this.tb_username;
            this.tb_username.Location = new System.Drawing.Point(74, 138);
            this.tb_username.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_username.Name = "tb_username";
            this.tb_username.PasswordChar = '\0';
            this.tb_username.PlaceholderForeColor = System.Drawing.Color.Black;
            this.tb_username.PlaceholderText = "Username";
            this.tb_username.SelectedText = "";
            this.tb_username.SelectionStart = 8;
            this.tb_username.ShadowDecoration.Parent = this.tb_username;
            this.tb_username.Size = new System.Drawing.Size(231, 46);
            this.tb_username.TabIndex = 2;
            // 
            // tb_password
            // 
            this.tb_password.BorderColor = System.Drawing.Color.Black;
            this.tb_password.BorderRadius = 22;
            this.tb_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_password.DefaultText = "pass";
            this.tb_password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_password.DisabledState.Parent = this.tb_password;
            this.tb_password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_password.FocusedState.Parent = this.tb_password;
            this.tb_password.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.tb_password.ForeColor = System.Drawing.Color.Black;
            this.tb_password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_password.HoverState.Parent = this.tb_password;
            this.tb_password.Location = new System.Drawing.Point(74, 200);
            this.tb_password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.PlaceholderForeColor = System.Drawing.Color.Black;
            this.tb_password.PlaceholderText = "Password";
            this.tb_password.SelectedText = "";
            this.tb_password.SelectionStart = 4;
            this.tb_password.ShadowDecoration.Parent = this.tb_password;
            this.tb_password.Size = new System.Drawing.Size(231, 46);
            this.tb_password.TabIndex = 3;
            // 
            // bt_signIn
            // 
            this.bt_signIn.BorderRadius = 22;
            this.bt_signIn.BorderThickness = 1;
            this.bt_signIn.CheckedState.Parent = this.bt_signIn;
            this.bt_signIn.CustomImages.Parent = this.bt_signIn;
            this.bt_signIn.FillColor = System.Drawing.Color.Black;
            this.bt_signIn.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_signIn.ForeColor = System.Drawing.Color.White;
            this.bt_signIn.HoverState.FillColor = System.Drawing.Color.White;
            this.bt_signIn.HoverState.ForeColor = System.Drawing.Color.Black;
            this.bt_signIn.HoverState.Parent = this.bt_signIn;
            this.bt_signIn.Location = new System.Drawing.Point(103, 263);
            this.bt_signIn.Name = "bt_signIn";
            this.bt_signIn.ShadowDecoration.Parent = this.bt_signIn;
            this.bt_signIn.Size = new System.Drawing.Size(171, 45);
            this.bt_signIn.TabIndex = 4;
            this.bt_signIn.Text = "SIGN IN";
            this.bt_signIn.Click += new System.EventHandler(this.bt_signIn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Forget password?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(155, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Don\'t have an account?";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(263, 333);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(51, 15);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Sign Up";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // form_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(384, 390);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bt_signIn);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox tb_username;
        private Guna.UI2.WinForms.Guna2TextBox tb_password;
        private Guna.UI2.WinForms.Guna2Button bt_signIn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}

