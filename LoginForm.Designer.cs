namespace Securentra_Management_System
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.label1 = new System.Windows.Forms.Label();
            this.TextBox_Username = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBox_Password = new Guna.UI2.WinForms.Guna2TextBox();
            this.ForgetPassword = new System.Windows.Forms.Label();
            this.Login_Exit = new System.Windows.Forms.Label();
            this.Button_Login = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(101)))));
            this.label1.Location = new System.Drawing.Point(534, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ready to Login";
            // 
            // TextBox_Username
            // 
            this.TextBox_Username.BackColor = System.Drawing.Color.Transparent;
            this.TextBox_Username.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.TextBox_Username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_Username.DefaultText = "";
            this.TextBox_Username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_Username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_Username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_Username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_Username.FillColor = System.Drawing.Color.WhiteSmoke;
            this.TextBox_Username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_Username.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_Username.ForeColor = System.Drawing.Color.Black;
            this.TextBox_Username.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_Username.IconLeft = global::Securentra_Management_System.Properties.Resources.icons8_male_user_24__1_;
            this.TextBox_Username.Location = new System.Drawing.Point(472, 136);
            this.TextBox_Username.Name = "TextBox_Username";
            this.TextBox_Username.PasswordChar = '\0';
            this.TextBox_Username.PlaceholderText = "Username";
            this.TextBox_Username.SelectedText = "";
            this.TextBox_Username.Size = new System.Drawing.Size(307, 33);
            this.TextBox_Username.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.TextBox_Username.TabIndex = 3;
            this.TextBox_Username.TextChanged += new System.EventHandler(this.TextBox_Username_TextChanged);
            // 
            // TextBox_Password
            // 
            this.TextBox_Password.BackColor = System.Drawing.Color.Transparent;
            this.TextBox_Password.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.TextBox_Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_Password.DefaultText = "";
            this.TextBox_Password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_Password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_Password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_Password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_Password.FillColor = System.Drawing.Color.WhiteSmoke;
            this.TextBox_Password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_Password.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_Password.ForeColor = System.Drawing.Color.Black;
            this.TextBox_Password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_Password.IconLeft = global::Securentra_Management_System.Properties.Resources.icons8_password_key_24__1_;
            this.TextBox_Password.Location = new System.Drawing.Point(472, 203);
            this.TextBox_Password.Name = "TextBox_Password";
            this.TextBox_Password.PasswordChar = '●';
            this.TextBox_Password.PlaceholderText = "Password";
            this.TextBox_Password.SelectedText = "";
            this.TextBox_Password.Size = new System.Drawing.Size(307, 33);
            this.TextBox_Password.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.TextBox_Password.TabIndex = 5;
            this.TextBox_Password.UseSystemPasswordChar = true;
            this.TextBox_Password.TextChanged += new System.EventHandler(this.TextBox_Password_TextChanged);
            // 
            // ForgetPassword
            // 
            this.ForgetPassword.AutoSize = true;
            this.ForgetPassword.BackColor = System.Drawing.Color.Transparent;
            this.ForgetPassword.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForgetPassword.ForeColor = System.Drawing.Color.Gray;
            this.ForgetPassword.Location = new System.Drawing.Point(652, 249);
            this.ForgetPassword.Name = "ForgetPassword";
            this.ForgetPassword.Size = new System.Drawing.Size(123, 17);
            this.ForgetPassword.TabIndex = 6;
            this.ForgetPassword.Text = "Forgot Password?";
            this.ForgetPassword.Click += new System.EventHandler(this.ForgetPassword_Click);
            this.ForgetPassword.MouseLeave += new System.EventHandler(this.ForgetPassword_MouseLeave);
            this.ForgetPassword.MouseHover += new System.EventHandler(this.ForgetPassword_MouseHover);
            // 
            // Login_Exit
            // 
            this.Login_Exit.AutoSize = true;
            this.Login_Exit.BackColor = System.Drawing.Color.Transparent;
            this.Login_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_Exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(64)))), ((int)(((byte)(123)))));
            this.Login_Exit.Location = new System.Drawing.Point(790, 9);
            this.Login_Exit.Name = "Login_Exit";
            this.Login_Exit.Size = new System.Drawing.Size(19, 18);
            this.Login_Exit.TabIndex = 8;
            this.Login_Exit.Text = "X";
            this.Login_Exit.Click += new System.EventHandler(this.Login_Exit_Click);
            this.Login_Exit.MouseEnter += new System.EventHandler(this.Login_Exit_MouseEnter);
            this.Login_Exit.MouseLeave += new System.EventHandler(this.Login_Exit_MouseLeave);
            // 
            // Button_Login
            // 
            this.Button_Login.BackColor = System.Drawing.Color.Transparent;
            this.Button_Login.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_Login.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_Login.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_Login.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_Login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_Login.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(101)))));
            this.Button_Login.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(101)))));
            this.Button_Login.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Login.ForeColor = System.Drawing.Color.White;
            this.Button_Login.Image = global::Securentra_Management_System.Properties.Resources.icons8_sign_in_48;
            this.Button_Login.Location = new System.Drawing.Point(472, 303);
            this.Button_Login.Name = "Button_Login";
            this.Button_Login.Size = new System.Drawing.Size(307, 35);
            this.Button_Login.TabIndex = 7;
            this.Button_Login.Text = "Log In";
            this.Button_Login.Click += new System.EventHandler(this.Button_Login_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(-39, 3);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(538, 451);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.Click += new System.EventHandler(this.guna2PictureBox1_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Securentra_Management_System.Properties.Resources._6e32878542a4a6b86e640204d951fbff__blue_wallpapers_blue_backgrounds;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(821, 427);
            this.Controls.Add(this.Login_Exit);
            this.Controls.Add(this.Button_Login);
            this.Controls.Add(this.ForgetPassword);
            this.Controls.Add(this.TextBox_Password);
            this.Controls.Add(this.TextBox_Username);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2PictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Indigo;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_Password;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_Username;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GradientButton Button_Login;
        private System.Windows.Forms.Label ForgetPassword;
        private System.Windows.Forms.Label Login_Exit;
    }
}

