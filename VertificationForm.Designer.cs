namespace Securentra_Management_System
{
    partial class VertificationForm
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
            this.Vertify_Exit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.StartedDescription = new System.Windows.Forms.Label();
            this.Button_Vertify = new Guna.UI2.WinForms.Guna2GradientButton();
            this.TextBox_VertifyOTP = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Label_ResendOTP = new System.Windows.Forms.Label();
            this.remind = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Vertify_Exit
            // 
            this.Vertify_Exit.AutoSize = true;
            this.Vertify_Exit.BackColor = System.Drawing.Color.Transparent;
            this.Vertify_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vertify_Exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.Vertify_Exit.Location = new System.Drawing.Point(790, 9);
            this.Vertify_Exit.Name = "Vertify_Exit";
            this.Vertify_Exit.Size = new System.Drawing.Size(19, 18);
            this.Vertify_Exit.TabIndex = 9;
            this.Vertify_Exit.Text = "X";
            this.Vertify_Exit.Click += new System.EventHandler(this.Vertify_Exit_Click);
            this.Vertify_Exit.MouseEnter += new System.EventHandler(this.Vertify_Exit_MouseEnter);
            this.Vertify_Exit.MouseLeave += new System.EventHandler(this.Vertify_Exit_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(101)))));
            this.label1.Location = new System.Drawing.Point(261, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 34);
            this.label1.TabIndex = 10;
            this.label1.Text = "Vertify Your Account";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StartedDescription
            // 
            this.StartedDescription.AutoSize = true;
            this.StartedDescription.BackColor = System.Drawing.Color.Transparent;
            this.StartedDescription.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartedDescription.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.StartedDescription.Location = new System.Drawing.Point(185, 81);
            this.StartedDescription.Name = "StartedDescription";
            this.StartedDescription.Size = new System.Drawing.Size(450, 20);
            this.StartedDescription.TabIndex = 14;
            this.StartedDescription.Text = " Please enter the One-Time Password to vertify Your Account";
            this.StartedDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Button_Vertify
            // 
            this.Button_Vertify.BackColor = System.Drawing.Color.Transparent;
            this.Button_Vertify.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_Vertify.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_Vertify.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_Vertify.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_Vertify.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_Vertify.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(101)))));
            this.Button_Vertify.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(101)))));
            this.Button_Vertify.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Vertify.ForeColor = System.Drawing.Color.White;
            this.Button_Vertify.Image = global::Securentra_Management_System.Properties.Resources.icons8_check_50;
            this.Button_Vertify.Location = new System.Drawing.Point(308, 310);
            this.Button_Vertify.Name = "Button_Vertify";
            this.Button_Vertify.Size = new System.Drawing.Size(203, 35);
            this.Button_Vertify.TabIndex = 15;
            this.Button_Vertify.Text = "Validate";
            this.Button_Vertify.Click += new System.EventHandler(this.Button_Vertify_Click);
            // 
            // TextBox_VertifyOTP
            // 
            this.TextBox_VertifyOTP.BackColor = System.Drawing.Color.Transparent;
            this.TextBox_VertifyOTP.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.TextBox_VertifyOTP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_VertifyOTP.DefaultText = "";
            this.TextBox_VertifyOTP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_VertifyOTP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_VertifyOTP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_VertifyOTP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_VertifyOTP.FillColor = System.Drawing.Color.WhiteSmoke;
            this.TextBox_VertifyOTP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_VertifyOTP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_VertifyOTP.ForeColor = System.Drawing.Color.Black;
            this.TextBox_VertifyOTP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_VertifyOTP.Location = new System.Drawing.Point(308, 260);
            this.TextBox_VertifyOTP.Name = "TextBox_VertifyOTP";
            this.TextBox_VertifyOTP.PasswordChar = '●';
            this.TextBox_VertifyOTP.PlaceholderForeColor = System.Drawing.Color.Black;
            this.TextBox_VertifyOTP.PlaceholderText = "   *   *   *   *   *   *   ";
            this.TextBox_VertifyOTP.SelectedText = "";
            this.TextBox_VertifyOTP.Size = new System.Drawing.Size(203, 35);
            this.TextBox_VertifyOTP.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.TextBox_VertifyOTP.TabIndex = 16;
            this.TextBox_VertifyOTP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBox_VertifyOTP.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label2.Location = new System.Drawing.Point(246, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(328, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "A One-Time Password has been sent to your email";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_ResendOTP
            // 
            this.Label_ResendOTP.AutoSize = true;
            this.Label_ResendOTP.BackColor = System.Drawing.Color.Transparent;
            this.Label_ResendOTP.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_ResendOTP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(64)))), ((int)(((byte)(123)))));
            this.Label_ResendOTP.Location = new System.Drawing.Point(486, 373);
            this.Label_ResendOTP.Name = "Label_ResendOTP";
            this.Label_ResendOTP.Size = new System.Drawing.Size(96, 17);
            this.Label_ResendOTP.TabIndex = 19;
            this.Label_ResendOTP.Text = "Resend again";
            this.Label_ResendOTP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label_ResendOTP.Click += new System.EventHandler(this.Label_ResendOTP_Click);
            this.Label_ResendOTP.MouseLeave += new System.EventHandler(this.Label_ResendOTP_MouseLeave);
            this.Label_ResendOTP.MouseHover += new System.EventHandler(this.Label_ResendOTP_MouseHover);
            // 
            // remind
            // 
            this.remind.AutoSize = true;
            this.remind.BackColor = System.Drawing.Color.Transparent;
            this.remind.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remind.ForeColor = System.Drawing.Color.Gray;
            this.remind.Location = new System.Drawing.Point(617, 166);
            this.remind.Name = "remind";
            this.remind.Size = new System.Drawing.Size(0, 17);
            this.remind.TabIndex = 20;
            this.remind.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.remind.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(492, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Your Username : -";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(492, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "Your Email : -";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Visible = false;
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.BackColor = System.Drawing.Color.Transparent;
            this.email.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.ForeColor = System.Drawing.Color.Gray;
            this.email.Location = new System.Drawing.Point(589, 202);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(0, 17);
            this.email.TabIndex = 24;
            this.email.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.email.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(239, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Didn\'t receive the Vertification OTP?";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::Securentra_Management_System.Properties.Resources.icons8_otp_100;
            this.pictureBox1.Location = new System.Drawing.Point(344, 132);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // VertificationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Securentra_Management_System.Properties.Resources._6e32878542a4a6b86e640204d951fbff__blue_wallpapers_blue_backgrounds;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(821, 427);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.remind);
            this.Controls.Add(this.Label_ResendOTP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextBox_VertifyOTP);
            this.Controls.Add(this.Button_Vertify);
            this.Controls.Add(this.StartedDescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Vertify_Exit);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VertificationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VertificationForm";
            this.Load += new System.EventHandler(this.VertificationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Vertify_Exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label StartedDescription;
        private Guna.UI2.WinForms.Guna2GradientButton Button_Vertify;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_VertifyOTP;
        private System.Windows.Forms.Label Label_ResendOTP;
        private System.Windows.Forms.Label remind;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}