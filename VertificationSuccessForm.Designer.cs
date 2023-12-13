namespace Securentra_Management_System
{
    partial class VertificationSuccessForm
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
            this.remind = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cpb = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(101)))));
            this.label1.Location = new System.Drawing.Point(215, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 34);
            this.label1.TabIndex = 11;
            this.label1.Text = "Authentication Successfull !";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // remind
            // 
            this.remind.AutoSize = true;
            this.remind.BackColor = System.Drawing.Color.Transparent;
            this.remind.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remind.ForeColor = System.Drawing.Color.Transparent;
            this.remind.Location = new System.Drawing.Point(359, 401);
            this.remind.Name = "remind";
            this.remind.Size = new System.Drawing.Size(0, 17);
            this.remind.TabIndex = 24;
            this.remind.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.remind.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 25;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cpb
            // 
            this.cpb.BackColor = System.Drawing.Color.Transparent;
            this.cpb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cpb.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.cpb.FillThickness = 12;
            this.cpb.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cpb.ForeColor = System.Drawing.Color.White;
            this.cpb.Location = new System.Drawing.Point(332, 161);
            this.cpb.Minimum = 0;
            this.cpb.Name = "cpb";
            this.cpb.ProgressColor = System.Drawing.Color.Navy;
            this.cpb.ProgressColor2 = System.Drawing.Color.MediumSlateBlue;
            this.cpb.ProgressThickness = 12;
            this.cpb.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.cpb.Size = new System.Drawing.Size(157, 157);
            this.cpb.TabIndex = 26;
            this.cpb.Text = "CircleProgressBar";
            this.cpb.Value = 15;
            // 
            // VertificationSuccessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Securentra_Management_System.Properties.Resources._6e32878542a4a6b86e640204d951fbff__blue_wallpapers_blue_backgrounds;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(821, 427);
            this.Controls.Add(this.cpb);
            this.Controls.Add(this.remind);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VertificationSuccessForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VertificationSuccessForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label remind;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2CircleProgressBar cpb;
    }
}