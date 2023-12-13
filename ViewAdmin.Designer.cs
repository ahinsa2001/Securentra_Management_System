namespace Securentra_Management_System
{
    partial class ViewAdmin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnMaxed = new Guna.UI2.WinForms.Guna2Button();
            this.BtnMin = new Guna.UI2.WinForms.Guna2Button();
            this.BtnMax = new Guna.UI2.WinForms.Guna2Button();
            this.Topic = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnClose = new Guna.UI2.WinForms.Guna2Button();
            this.AdminDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel3.SuspendLayout();
            this.Topic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdminDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(101)))));
            this.panel3.Controls.Add(this.BtnMaxed);
            this.panel3.Controls.Add(this.BtnMin);
            this.panel3.Controls.Add(this.BtnMax);
            this.panel3.Controls.Add(this.Topic);
            this.panel3.Controls.Add(this.BtnClose);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(964, 50);
            this.panel3.TabIndex = 65;
            // 
            // BtnMaxed
            // 
            this.BtnMaxed.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnMaxed.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnMaxed.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnMaxed.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnMaxed.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnMaxed.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(101)))));
            this.BtnMaxed.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnMaxed.ForeColor = System.Drawing.Color.White;
            this.BtnMaxed.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(101)))));
            this.BtnMaxed.Image = global::Securentra_Management_System.Properties.Resources.maximize2;
            this.BtnMaxed.ImageSize = new System.Drawing.Size(27, 27);
            this.BtnMaxed.Location = new System.Drawing.Point(764, 0);
            this.BtnMaxed.Name = "BtnMaxed";
            this.BtnMaxed.Size = new System.Drawing.Size(50, 50);
            this.BtnMaxed.TabIndex = 3;
            this.BtnMaxed.Visible = false;
            this.BtnMaxed.Click += new System.EventHandler(this.BtnMaxed_Click);
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
            this.BtnMin.Location = new System.Drawing.Point(814, 0);
            this.BtnMin.Name = "BtnMin";
            this.BtnMin.Size = new System.Drawing.Size(50, 50);
            this.BtnMin.TabIndex = 1;
            this.BtnMin.Click += new System.EventHandler(this.BtnMin_Click);
            // 
            // BtnMax
            // 
            this.BtnMax.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnMax.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnMax.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnMax.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnMax.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnMax.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(101)))));
            this.BtnMax.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnMax.ForeColor = System.Drawing.Color.White;
            this.BtnMax.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(101)))));
            this.BtnMax.Image = global::Securentra_Management_System.Properties.Resources.square_outline_xxl1;
            this.BtnMax.ImageSize = new System.Drawing.Size(15, 15);
            this.BtnMax.Location = new System.Drawing.Point(864, 0);
            this.BtnMax.Name = "BtnMax";
            this.BtnMax.Size = new System.Drawing.Size(50, 50);
            this.BtnMax.TabIndex = 3;
            this.BtnMax.Click += new System.EventHandler(this.BtnMax_Click);
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
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(101, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "View All Administators";
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
            // AdminDGV
            // 
            this.AdminDGV.AllowUserToAddRows = false;
            this.AdminDGV.AllowUserToDeleteRows = false;
            this.AdminDGV.AllowUserToResizeColumns = false;
            this.AdminDGV.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.AdminDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.AdminDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AdminDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.AdminDGV.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AdminDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.AdminDGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.AdminDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.AdminDGV.Location = new System.Drawing.Point(48, 73);
            this.AdminDGV.Name = "AdminDGV";
            this.AdminDGV.ReadOnly = true;
            this.AdminDGV.RowHeadersVisible = false;
            this.AdminDGV.RowHeadersWidth = 51;
            this.AdminDGV.RowTemplate.Height = 28;
            this.AdminDGV.Size = new System.Drawing.Size(869, 528);
            this.AdminDGV.TabIndex = 66;
            this.AdminDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.AdminDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.AdminDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.AdminDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.AdminDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.AdminDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.AdminDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.AdminDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.AdminDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.AdminDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.AdminDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.AdminDGV.ThemeStyle.HeaderStyle.Height = 30;
            this.AdminDGV.ThemeStyle.ReadOnly = true;
            this.AdminDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.AdminDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.AdminDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.AdminDGV.ThemeStyle.RowsStyle.Height = 28;
            this.AdminDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.AdminDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // ViewAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::Securentra_Management_System.Properties.Resources._6e32878542a4a6b86e640204d951fbff__blue_wallpapers_blue_backgrounds;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(964, 626);
            this.Controls.Add(this.AdminDGV);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewAdmin";
            this.Text = "ViewAdmin";
            this.Load += new System.EventHandler(this.ViewAdmin_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.Topic.ResumeLayout(false);
            this.Topic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdminDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2Button BtnMaxed;
        private Guna.UI2.WinForms.Guna2Button BtnMin;
        private Guna.UI2.WinForms.Guna2Button BtnMax;
        private System.Windows.Forms.Panel Topic;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button BtnClose;
        private Guna.UI2.WinForms.Guna2DataGridView AdminDGV;
    }
}