namespace Securentra_Management_System
{
    partial class ResetPassword
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnMin = new Guna.UI2.WinForms.Guna2Button();
            this.Topic = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnClose = new Guna.UI2.WinForms.Guna2Button();
            this.RP_NewPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.RP_CurrentPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.RP_ReNewPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.Btn_ResetPW = new Guna.UI2.WinForms.Guna2GradientButton();
            this.panel3.SuspendLayout();
            this.Topic.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(101)))));
            this.panel3.Controls.Add(this.BtnMin);
            this.panel3.Controls.Add(this.Topic);
            this.panel3.Controls.Add(this.BtnClose);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(964, 50);
            this.panel3.TabIndex = 66;
            // 
            // BtnMin
            // 
            this.BtnMin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnMin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnMin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnMin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnMin.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnMin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(101)))));
            this.BtnMin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnMin.ForeColor = System.Drawing.Color.White;
            this.BtnMin.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(101)))));
            this.BtnMin.Image = global::Securentra_Management_System.Properties.Resources.minimize;
            this.BtnMin.ImageSize = new System.Drawing.Size(17, 17);
            this.BtnMin.Location = new System.Drawing.Point(864, 0);
            this.BtnMin.Name = "BtnMin";
            this.BtnMin.Size = new System.Drawing.Size(50, 50);
            this.BtnMin.TabIndex = 1;
            this.BtnMin.Click += new System.EventHandler(this.BtnMin_Click);
            // 
            // Topic
            // 
            this.Topic.AutoSize = true;
            this.Topic.Controls.Add(this.label1);
            this.Topic.Location = new System.Drawing.Point(277, 3);
            this.Topic.Name = "Topic";
            this.Topic.Size = new System.Drawing.Size(402, 44);
            this.Topic.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(101, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create New Password";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnClose
            // 
            this.BtnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(101)))));
            this.BtnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnClose.ForeColor = System.Drawing.Color.White;
            this.BtnClose.HoverState.FillColor = System.Drawing.Color.Crimson;
            this.BtnClose.Image = global::Securentra_Management_System.Properties.Resources.kindpng_1103522;
            this.BtnClose.ImageSize = new System.Drawing.Size(15, 15);
            this.BtnClose.Location = new System.Drawing.Point(914, 0);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(50, 50);
            this.BtnClose.TabIndex = 0;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // RP_NewPassword
            // 
            this.RP_NewPassword.BackColor = System.Drawing.Color.Transparent;
            this.RP_NewPassword.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.RP_NewPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RP_NewPassword.DefaultText = "";
            this.RP_NewPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.RP_NewPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.RP_NewPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RP_NewPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RP_NewPassword.FillColor = System.Drawing.Color.WhiteSmoke;
            this.RP_NewPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RP_NewPassword.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RP_NewPassword.ForeColor = System.Drawing.Color.Black;
            this.RP_NewPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RP_NewPassword.Location = new System.Drawing.Point(329, 266);
            this.RP_NewPassword.Name = "RP_NewPassword";
            this.RP_NewPassword.PasswordChar = '●';
            this.RP_NewPassword.PlaceholderText = "Enter Your New Password";
            this.RP_NewPassword.SelectedText = "";
            this.RP_NewPassword.Size = new System.Drawing.Size(307, 33);
            this.RP_NewPassword.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.RP_NewPassword.TabIndex = 68;
            this.RP_NewPassword.UseSystemPasswordChar = true;
            // 
            // RP_CurrentPassword
            // 
            this.RP_CurrentPassword.BackColor = System.Drawing.Color.Transparent;
            this.RP_CurrentPassword.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.RP_CurrentPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RP_CurrentPassword.DefaultText = "";
            this.RP_CurrentPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.RP_CurrentPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.RP_CurrentPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RP_CurrentPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RP_CurrentPassword.FillColor = System.Drawing.Color.WhiteSmoke;
            this.RP_CurrentPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RP_CurrentPassword.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RP_CurrentPassword.ForeColor = System.Drawing.Color.Black;
            this.RP_CurrentPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RP_CurrentPassword.Location = new System.Drawing.Point(329, 197);
            this.RP_CurrentPassword.Name = "RP_CurrentPassword";
            this.RP_CurrentPassword.PasswordChar = '\0';
            this.RP_CurrentPassword.PlaceholderText = "Enter Your Current Password";
            this.RP_CurrentPassword.SelectedText = "";
            this.RP_CurrentPassword.Size = new System.Drawing.Size(307, 33);
            this.RP_CurrentPassword.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.RP_CurrentPassword.TabIndex = 67;
            // 
            // RP_ReNewPassword
            // 
            this.RP_ReNewPassword.BackColor = System.Drawing.Color.Transparent;
            this.RP_ReNewPassword.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.RP_ReNewPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RP_ReNewPassword.DefaultText = "";
            this.RP_ReNewPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.RP_ReNewPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.RP_ReNewPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RP_ReNewPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RP_ReNewPassword.FillColor = System.Drawing.Color.WhiteSmoke;
            this.RP_ReNewPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RP_ReNewPassword.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RP_ReNewPassword.ForeColor = System.Drawing.Color.Black;
            this.RP_ReNewPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RP_ReNewPassword.Location = new System.Drawing.Point(329, 335);
            this.RP_ReNewPassword.Name = "RP_ReNewPassword";
            this.RP_ReNewPassword.PasswordChar = '●';
            this.RP_ReNewPassword.PlaceholderText = "Confirm Your New Password";
            this.RP_ReNewPassword.SelectedText = "";
            this.RP_ReNewPassword.Size = new System.Drawing.Size(307, 33);
            this.RP_ReNewPassword.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.RP_ReNewPassword.TabIndex = 69;
            this.RP_ReNewPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(101)))));
            this.label2.Location = new System.Drawing.Point(282, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(400, 20);
            this.label2.TabIndex = 72;
            this.label2.Text = "Create a new password and more safe your account";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.BackColor = System.Drawing.Color.Transparent;
            this.ID.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.ForeColor = System.Drawing.Color.White;
            this.ID.Location = new System.Drawing.Point(838, 124);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(53, 17);
            this.ID.TabIndex = 73;
            this.ID.Text = "Your ID";
            this.ID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ID.Visible = false;
            // 
            // Btn_ResetPW
            // 
            this.Btn_ResetPW.BackColor = System.Drawing.Color.Transparent;
            this.Btn_ResetPW.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_ResetPW.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_ResetPW.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_ResetPW.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_ResetPW.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_ResetPW.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(101)))));
            this.Btn_ResetPW.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(101)))));
            this.Btn_ResetPW.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ResetPW.ForeColor = System.Drawing.Color.White;
            this.Btn_ResetPW.Image = global::Securentra_Management_System.Properties.Resources.icons8_password_key_30;
            this.Btn_ResetPW.Location = new System.Drawing.Point(329, 427);
            this.Btn_ResetPW.Name = "Btn_ResetPW";
            this.Btn_ResetPW.Size = new System.Drawing.Size(307, 35);
            this.Btn_ResetPW.TabIndex = 70;
            this.Btn_ResetPW.Text = "Reset Password";
            this.Btn_ResetPW.Click += new System.EventHandler(this.Btn_ResetPW_Click);
            // 
            // ResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Securentra_Management_System.Properties.Resources._6e32878542a4a6b86e640204d951fbff__blue_wallpapers_blue_backgrounds;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(964, 626);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btn_ResetPW);
            this.Controls.Add(this.RP_ReNewPassword);
            this.Controls.Add(this.RP_NewPassword);
            this.Controls.Add(this.RP_CurrentPassword);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ResetPassword";
            this.Text = "ResetPassword";
            this.Load += new System.EventHandler(this.ResetPassword_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.Topic.ResumeLayout(false);
            this.Topic.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2Button BtnMin;
        private System.Windows.Forms.Panel Topic;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button BtnClose;
        private Guna.UI2.WinForms.Guna2TextBox RP_NewPassword;
        private Guna.UI2.WinForms.Guna2TextBox RP_CurrentPassword;
        private Guna.UI2.WinForms.Guna2TextBox RP_ReNewPassword;
        private Guna.UI2.WinForms.Guna2GradientButton Btn_ResetPW;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ID;
    }
}