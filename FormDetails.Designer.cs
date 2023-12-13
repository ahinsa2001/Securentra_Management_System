namespace Securentra_Management_System
{
    partial class FormDetails
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DetailsDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.date = new Guna.UI2.WinForms.Guna2TextBox();
            this.plateno = new Guna.UI2.WinForms.Guna2TextBox();
            this.owner = new Guna.UI2.WinForms.Guna2TextBox();
            this.refresh = new Guna.UI2.WinForms.Guna2Button();
            this.FilterOwner = new Guna.UI2.WinForms.Guna2Button();
            this.FilterPlateNum = new Guna.UI2.WinForms.Guna2Button();
            this.FilterDate = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.DetailsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // DetailsDGV
            // 
            this.DetailsDGV.AllowUserToAddRows = false;
            this.DetailsDGV.AllowUserToDeleteRows = false;
            this.DetailsDGV.AllowUserToResizeColumns = false;
            this.DetailsDGV.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DetailsDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DetailsDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DetailsDGV.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DetailsDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DetailsDGV.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DetailsDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.DetailsDGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DetailsDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DetailsDGV.Location = new System.Drawing.Point(394, 39);
            this.DetailsDGV.Name = "DetailsDGV";
            this.DetailsDGV.ReadOnly = true;
            this.DetailsDGV.RowHeadersVisible = false;
            this.DetailsDGV.RowHeadersWidth = 51;
            this.DetailsDGV.RowTemplate.Height = 28;
            this.DetailsDGV.Size = new System.Drawing.Size(540, 543);
            this.DetailsDGV.TabIndex = 10;
            this.DetailsDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DetailsDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DetailsDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DetailsDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DetailsDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DetailsDGV.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DetailsDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DetailsDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DetailsDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DetailsDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetailsDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DetailsDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DetailsDGV.ThemeStyle.HeaderStyle.Height = 30;
            this.DetailsDGV.ThemeStyle.ReadOnly = true;
            this.DetailsDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DetailsDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DetailsDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetailsDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DetailsDGV.ThemeStyle.RowsStyle.Height = 28;
            this.DetailsDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DetailsDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // date
            // 
            this.date.BackColor = System.Drawing.SystemColors.Control;
            this.date.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.date.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(85)))), ((int)(((byte)(133)))));
            this.date.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.date.BorderThickness = 2;
            this.date.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.date.DefaultText = "";
            this.date.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.date.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.date.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.date.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.date.FillColor = System.Drawing.Color.WhiteSmoke;
            this.date.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.date.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.ForeColor = System.Drawing.Color.Black;
            this.date.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.date.Location = new System.Drawing.Point(46, 75);
            this.date.Name = "date";
            this.date.PasswordChar = '\0';
            this.date.PlaceholderText = "Enter Date (DD/MM/YYYY)";
            this.date.SelectedText = "";
            this.date.Size = new System.Drawing.Size(308, 33);
            this.date.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.date.TabIndex = 45;
            this.date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // plateno
            // 
            this.plateno.BackColor = System.Drawing.SystemColors.Control;
            this.plateno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.plateno.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(85)))), ((int)(((byte)(133)))));
            this.plateno.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.plateno.BorderThickness = 2;
            this.plateno.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.plateno.DefaultText = "";
            this.plateno.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.plateno.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.plateno.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.plateno.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.plateno.FillColor = System.Drawing.Color.WhiteSmoke;
            this.plateno.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.plateno.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plateno.ForeColor = System.Drawing.Color.Black;
            this.plateno.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.plateno.Location = new System.Drawing.Point(46, 235);
            this.plateno.Name = "plateno";
            this.plateno.PasswordChar = '\0';
            this.plateno.PlaceholderText = "Enter Vehicle Plate Number";
            this.plateno.SelectedText = "";
            this.plateno.Size = new System.Drawing.Size(308, 33);
            this.plateno.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.plateno.TabIndex = 47;
            this.plateno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // owner
            // 
            this.owner.BackColor = System.Drawing.Color.Transparent;
            this.owner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.owner.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(85)))), ((int)(((byte)(133)))));
            this.owner.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.owner.BorderThickness = 2;
            this.owner.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.owner.DefaultText = "";
            this.owner.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.owner.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.owner.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.owner.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.owner.FillColor = System.Drawing.Color.WhiteSmoke;
            this.owner.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.owner.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.owner.ForeColor = System.Drawing.Color.Black;
            this.owner.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.owner.Location = new System.Drawing.Point(46, 395);
            this.owner.Name = "owner";
            this.owner.PasswordChar = '\0';
            this.owner.PlaceholderText = "Enter Vehicle Owner ID";
            this.owner.SelectedText = "";
            this.owner.Size = new System.Drawing.Size(308, 33);
            this.owner.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.owner.TabIndex = 49;
            this.owner.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // refresh
            // 
            this.refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.refresh.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(101)))));
            this.refresh.BorderThickness = 2;
            this.refresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.refresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.refresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.refresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.refresh.FillColor = System.Drawing.Color.White;
            this.refresh.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(101)))));
            this.refresh.HoverState.FillColor = System.Drawing.Color.Navy;
            this.refresh.Image = global::Securentra_Management_System.Properties.Resources.icons8_update_left_rotation_30;
            this.refresh.Location = new System.Drawing.Point(224, 545);
            this.refresh.Name = "refresh";
            this.refresh.PressedColor = System.Drawing.Color.Red;
            this.refresh.Size = new System.Drawing.Size(130, 37);
            this.refresh.TabIndex = 50;
            this.refresh.Text = "Refresh";
            this.refresh.Click += new System.EventHandler(this.export_Click);
            // 
            // FilterOwner
            // 
            this.FilterOwner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.FilterOwner.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.FilterOwner.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.FilterOwner.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.FilterOwner.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.FilterOwner.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(101)))));
            this.FilterOwner.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterOwner.ForeColor = System.Drawing.Color.White;
            this.FilterOwner.HoverState.FillColor = System.Drawing.Color.Navy;
            this.FilterOwner.Image = global::Securentra_Management_System.Properties.Resources.kindpng_790382;
            this.FilterOwner.ImageSize = new System.Drawing.Size(15, 15);
            this.FilterOwner.Location = new System.Drawing.Point(83, 456);
            this.FilterOwner.Name = "FilterOwner";
            this.FilterOwner.PressedColor = System.Drawing.Color.DarkSlateBlue;
            this.FilterOwner.Size = new System.Drawing.Size(235, 41);
            this.FilterOwner.TabIndex = 48;
            this.FilterOwner.Text = "Filter by OwnerID";
            this.FilterOwner.Click += new System.EventHandler(this.FilterOwner_Click);
            // 
            // FilterPlateNum
            // 
            this.FilterPlateNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.FilterPlateNum.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.FilterPlateNum.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.FilterPlateNum.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.FilterPlateNum.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.FilterPlateNum.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(101)))));
            this.FilterPlateNum.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterPlateNum.ForeColor = System.Drawing.Color.White;
            this.FilterPlateNum.HoverState.FillColor = System.Drawing.Color.Navy;
            this.FilterPlateNum.Image = global::Securentra_Management_System.Properties.Resources.kindpng_790382;
            this.FilterPlateNum.ImageSize = new System.Drawing.Size(15, 15);
            this.FilterPlateNum.Location = new System.Drawing.Point(83, 296);
            this.FilterPlateNum.Name = "FilterPlateNum";
            this.FilterPlateNum.PressedColor = System.Drawing.Color.DarkSlateBlue;
            this.FilterPlateNum.Size = new System.Drawing.Size(235, 41);
            this.FilterPlateNum.TabIndex = 46;
            this.FilterPlateNum.Text = "Filter by NumberPlate";
            this.FilterPlateNum.Click += new System.EventHandler(this.FilterPlateNum_Click);
            // 
            // FilterDate
            // 
            this.FilterDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.FilterDate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.FilterDate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.FilterDate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.FilterDate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.FilterDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(101)))));
            this.FilterDate.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterDate.ForeColor = System.Drawing.Color.White;
            this.FilterDate.HoverState.FillColor = System.Drawing.Color.Navy;
            this.FilterDate.Image = global::Securentra_Management_System.Properties.Resources.kindpng_790382;
            this.FilterDate.ImageSize = new System.Drawing.Size(15, 15);
            this.FilterDate.Location = new System.Drawing.Point(83, 136);
            this.FilterDate.Name = "FilterDate";
            this.FilterDate.PressedColor = System.Drawing.Color.DarkSlateBlue;
            this.FilterDate.Size = new System.Drawing.Size(235, 41);
            this.FilterDate.TabIndex = 44;
            this.FilterDate.Text = "Filter by Date";
            this.FilterDate.Click += new System.EventHandler(this.FilterDate_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.guna2Button1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(101)))));
            this.guna2Button1.BorderThickness = 2;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.White;
            this.guna2Button1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(101)))));
            this.guna2Button1.HoverState.FillColor = System.Drawing.Color.Navy;
            this.guna2Button1.Image = global::Securentra_Management_System.Properties.Resources.data_export_icon_0;
            this.guna2Button1.ImageSize = new System.Drawing.Size(15, 15);
            this.guna2Button1.Location = new System.Drawing.Point(46, 545);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.PressedColor = System.Drawing.Color.Red;
            this.guna2Button1.Size = new System.Drawing.Size(130, 37);
            this.guna2Button1.TabIndex = 51;
            this.guna2Button1.Text = "Export Data";
            // 
            // FormDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Securentra_Management_System.Properties.Resources._6e32878542a4a6b86e640204d951fbff__blue_wallpapers_blue_backgrounds;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.owner);
            this.Controls.Add(this.FilterOwner);
            this.Controls.Add(this.plateno);
            this.Controls.Add(this.FilterPlateNum);
            this.Controls.Add(this.date);
            this.Controls.Add(this.FilterDate);
            this.Controls.Add(this.DetailsDGV);
            this.Name = "FormDetails";
            this.Size = new System.Drawing.Size(982, 623);
            this.Load += new System.EventHandler(this.FormDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DetailsDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView DetailsDGV;
        private Guna.UI2.WinForms.Guna2Button FilterDate;
        private Guna.UI2.WinForms.Guna2TextBox date;
        private Guna.UI2.WinForms.Guna2TextBox plateno;
        private Guna.UI2.WinForms.Guna2Button FilterPlateNum;
        private Guna.UI2.WinForms.Guna2TextBox owner;
        private Guna.UI2.WinForms.Guna2Button FilterOwner;
        private Guna.UI2.WinForms.Guna2Button refresh;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}
