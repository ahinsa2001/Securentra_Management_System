namespace Securentra_Management_System
{
    partial class FormSettings
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.remind = new System.Windows.Forms.Label();
            this.LogOut = new Guna.UI2.WinForms.Guna2Button();
            this.BtnResetPW = new Guna.UI2.WinForms.Guna2Button();
            this.BtnAdmin = new Guna.UI2.WinForms.Guna2Button();
            this.BtnEditProfile = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // remind
            // 
            this.remind.AutoSize = true;
            this.remind.BackColor = System.Drawing.Color.Transparent;
            this.remind.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remind.ForeColor = System.Drawing.SystemColors.Control;
            this.remind.Location = new System.Drawing.Point(491, 514);
            this.remind.Name = "remind";
            this.remind.Size = new System.Drawing.Size(0, 17);
            this.remind.TabIndex = 47;
            this.remind.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LogOut
            // 
            this.LogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.LogOut.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(101)))));
            this.LogOut.BorderThickness = 2;
            this.LogOut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.LogOut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.LogOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.LogOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.LogOut.FillColor = System.Drawing.Color.White;
            this.LogOut.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(101)))));
            this.LogOut.HoverState.FillColor = System.Drawing.Color.Navy;
            this.LogOut.Image = global::Securentra_Management_System.Properties.Resources.icons8_logout_48;
            this.LogOut.Location = new System.Drawing.Point(358, 418);
            this.LogOut.Name = "LogOut";
            this.LogOut.PressedColor = System.Drawing.Color.Red;
            this.LogOut.Size = new System.Drawing.Size(267, 45);
            this.LogOut.TabIndex = 48;
            this.LogOut.Text = "Log Out";
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            this.LogOut.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LogOut_MouseClick);
            this.LogOut.MouseEnter += new System.EventHandler(this.LogOut_MouseEnter);
            this.LogOut.MouseHover += new System.EventHandler(this.LogOut_MouseHover);
            // 
            // BtnResetPW
            // 
            this.BtnResetPW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.BtnResetPW.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnResetPW.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnResetPW.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnResetPW.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnResetPW.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(101)))));
            this.BtnResetPW.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.BtnResetPW.ForeColor = System.Drawing.Color.White;
            this.BtnResetPW.HoverState.FillColor = System.Drawing.Color.Navy;
            this.BtnResetPW.Image = global::Securentra_Management_System.Properties.Resources.icons8_lock_orientation_301;
            this.BtnResetPW.Location = new System.Drawing.Point(358, 322);
            this.BtnResetPW.Name = "BtnResetPW";
            this.BtnResetPW.PressedColor = System.Drawing.Color.DarkSlateBlue;
            this.BtnResetPW.Size = new System.Drawing.Size(267, 45);
            this.BtnResetPW.TabIndex = 46;
            this.BtnResetPW.Text = "Change Password";
            this.BtnResetPW.Click += new System.EventHandler(this.BtnResetPW_Click);
            // 
            // BtnAdmin
            // 
            this.BtnAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.BtnAdmin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnAdmin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnAdmin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnAdmin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnAdmin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(101)))));
            this.BtnAdmin.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.BtnAdmin.ForeColor = System.Drawing.Color.White;
            this.BtnAdmin.HoverState.FillColor = System.Drawing.Color.Navy;
            this.BtnAdmin.Image = global::Securentra_Management_System.Properties.Resources.icons8_admin_settings_male_24;
            this.BtnAdmin.Location = new System.Drawing.Point(358, 226);
            this.BtnAdmin.Name = "BtnAdmin";
            this.BtnAdmin.PressedColor = System.Drawing.Color.DarkSlateBlue;
            this.BtnAdmin.Size = new System.Drawing.Size(267, 45);
            this.BtnAdmin.TabIndex = 45;
            this.BtnAdmin.Text = "Admin Details";
            this.BtnAdmin.Click += new System.EventHandler(this.BtnAdmin_Click);
            // 
            // BtnEditProfile
            // 
            this.BtnEditProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.BtnEditProfile.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnEditProfile.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnEditProfile.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnEditProfile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnEditProfile.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(101)))));
            this.BtnEditProfile.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.BtnEditProfile.ForeColor = System.Drawing.Color.White;
            this.BtnEditProfile.HoverState.FillColor = System.Drawing.Color.Navy;
            this.BtnEditProfile.Image = global::Securentra_Management_System.Properties.Resources.icons8_writer_male_24;
            this.BtnEditProfile.Location = new System.Drawing.Point(358, 130);
            this.BtnEditProfile.Name = "BtnEditProfile";
            this.BtnEditProfile.PressedColor = System.Drawing.Color.DarkSlateBlue;
            this.BtnEditProfile.Size = new System.Drawing.Size(267, 45);
            this.BtnEditProfile.TabIndex = 44;
            this.BtnEditProfile.Text = "Edit Profile";
            this.BtnEditProfile.Click += new System.EventHandler(this.BtnEditProfile_Click);
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Securentra_Management_System.Properties.Resources._6e32878542a4a6b86e640204d951fbff__blue_wallpapers_blue_backgrounds;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.LogOut);
            this.Controls.Add(this.remind);
            this.Controls.Add(this.BtnResetPW);
            this.Controls.Add(this.BtnAdmin);
            this.Controls.Add(this.BtnEditProfile);
            this.Name = "FormSettings";
            this.Size = new System.Drawing.Size(982, 623);
            this.Load += new System.EventHandler(this.FormSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button BtnEditProfile;
        private Guna.UI2.WinForms.Guna2Button BtnAdmin;
        private Guna.UI2.WinForms.Guna2Button BtnResetPW;
        private System.Windows.Forms.Label remind;
        private Guna.UI2.WinForms.Guna2Button LogOut;
    }
}
