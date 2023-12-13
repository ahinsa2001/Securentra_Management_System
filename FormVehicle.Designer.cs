namespace Securentra_Management_System
{
    partial class FormVehicle
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
            this.NumberPlate = new Guna.UI2.WinForms.Guna2TextBox();
            this.VehicleType = new Guna.UI2.WinForms.Guna2TextBox();
            this.VehicleModel = new Guna.UI2.WinForms.Guna2TextBox();
            this.OwnerID = new Guna.UI2.WinForms.Guna2TextBox();
            this.VehicleDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.BtnVehicle_Update = new Guna.UI2.WinForms.Guna2Button();
            this.BtnVehicle_Delete = new Guna.UI2.WinForms.Guna2Button();
            this.BtnVehicle_Search = new Guna.UI2.WinForms.Guna2Button();
            this.BtnVehicle_Add = new Guna.UI2.WinForms.Guna2Button();
            this.export = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.VehicleDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // NumberPlate
            // 
            this.NumberPlate.BackColor = System.Drawing.SystemColors.Control;
            this.NumberPlate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(85)))), ((int)(((byte)(133)))));
            this.NumberPlate.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.NumberPlate.BorderThickness = 2;
            this.NumberPlate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NumberPlate.DefaultText = "";
            this.NumberPlate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NumberPlate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NumberPlate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NumberPlate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NumberPlate.FillColor = System.Drawing.Color.WhiteSmoke;
            this.NumberPlate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NumberPlate.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberPlate.ForeColor = System.Drawing.Color.Black;
            this.NumberPlate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.NumberPlate.Location = new System.Drawing.Point(45, 104);
            this.NumberPlate.Name = "NumberPlate";
            this.NumberPlate.PasswordChar = '\0';
            this.NumberPlate.PlaceholderText = "Number Plate";
            this.NumberPlate.SelectedText = "";
            this.NumberPlate.Size = new System.Drawing.Size(308, 33);
            this.NumberPlate.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.NumberPlate.TabIndex = 4;
            // 
            // VehicleType
            // 
            this.VehicleType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(181)))), ((int)(((byte)(209)))));
            this.VehicleType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(85)))), ((int)(((byte)(133)))));
            this.VehicleType.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.VehicleType.BorderThickness = 2;
            this.VehicleType.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.VehicleType.DefaultText = "";
            this.VehicleType.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.VehicleType.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.VehicleType.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.VehicleType.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.VehicleType.FillColor = System.Drawing.Color.WhiteSmoke;
            this.VehicleType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.VehicleType.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VehicleType.ForeColor = System.Drawing.Color.Black;
            this.VehicleType.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.VehicleType.Location = new System.Drawing.Point(45, 278);
            this.VehicleType.Name = "VehicleType";
            this.VehicleType.PasswordChar = '\0';
            this.VehicleType.PlaceholderText = "Vehicle Type";
            this.VehicleType.SelectedText = "";
            this.VehicleType.Size = new System.Drawing.Size(308, 33);
            this.VehicleType.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.VehicleType.TabIndex = 5;
            // 
            // VehicleModel
            // 
            this.VehicleModel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(181)))), ((int)(((byte)(209)))));
            this.VehicleModel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(85)))), ((int)(((byte)(133)))));
            this.VehicleModel.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.VehicleModel.BorderThickness = 2;
            this.VehicleModel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.VehicleModel.DefaultText = "";
            this.VehicleModel.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.VehicleModel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.VehicleModel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.VehicleModel.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.VehicleModel.FillColor = System.Drawing.Color.WhiteSmoke;
            this.VehicleModel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.VehicleModel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VehicleModel.ForeColor = System.Drawing.Color.Black;
            this.VehicleModel.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.VehicleModel.Location = new System.Drawing.Point(45, 317);
            this.VehicleModel.Name = "VehicleModel";
            this.VehicleModel.PasswordChar = '\0';
            this.VehicleModel.PlaceholderText = "Vehicle Model";
            this.VehicleModel.SelectedText = "";
            this.VehicleModel.Size = new System.Drawing.Size(308, 33);
            this.VehicleModel.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.VehicleModel.TabIndex = 6;
            // 
            // OwnerID
            // 
            this.OwnerID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(181)))), ((int)(((byte)(209)))));
            this.OwnerID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(85)))), ((int)(((byte)(133)))));
            this.OwnerID.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.OwnerID.BorderThickness = 2;
            this.OwnerID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.OwnerID.DefaultText = "";
            this.OwnerID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.OwnerID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.OwnerID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.OwnerID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.OwnerID.FillColor = System.Drawing.Color.WhiteSmoke;
            this.OwnerID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.OwnerID.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OwnerID.ForeColor = System.Drawing.Color.Black;
            this.OwnerID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.OwnerID.Location = new System.Drawing.Point(45, 356);
            this.OwnerID.Name = "OwnerID";
            this.OwnerID.PasswordChar = '\0';
            this.OwnerID.PlaceholderText = "Owner ID";
            this.OwnerID.SelectedText = "";
            this.OwnerID.Size = new System.Drawing.Size(308, 33);
            this.OwnerID.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.OwnerID.TabIndex = 7;
            // 
            // VehicleDGV
            // 
            this.VehicleDGV.AllowUserToAddRows = false;
            this.VehicleDGV.AllowUserToDeleteRows = false;
            this.VehicleDGV.AllowUserToResizeColumns = false;
            this.VehicleDGV.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.VehicleDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.VehicleDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VehicleDGV.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.VehicleDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.VehicleDGV.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.VehicleDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.VehicleDGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.VehicleDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.VehicleDGV.Location = new System.Drawing.Point(403, 38);
            this.VehicleDGV.Name = "VehicleDGV";
            this.VehicleDGV.ReadOnly = true;
            this.VehicleDGV.RowHeadersVisible = false;
            this.VehicleDGV.RowHeadersWidth = 51;
            this.VehicleDGV.RowTemplate.Height = 28;
            this.VehicleDGV.Size = new System.Drawing.Size(540, 543);
            this.VehicleDGV.TabIndex = 9;
            this.VehicleDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.VehicleDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.VehicleDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.VehicleDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.VehicleDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.VehicleDGV.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.VehicleDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.VehicleDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.VehicleDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.VehicleDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VehicleDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.VehicleDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.VehicleDGV.ThemeStyle.HeaderStyle.Height = 30;
            this.VehicleDGV.ThemeStyle.ReadOnly = true;
            this.VehicleDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.VehicleDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.VehicleDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VehicleDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.VehicleDGV.ThemeStyle.RowsStyle.Height = 28;
            this.VehicleDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.VehicleDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.VehicleDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VehicleDGV_CellContentClick);
            // 
            // BtnVehicle_Update
            // 
            this.BtnVehicle_Update.BackColor = System.Drawing.Color.Navy;
            this.BtnVehicle_Update.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnVehicle_Update.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnVehicle_Update.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnVehicle_Update.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnVehicle_Update.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(101)))));
            this.BtnVehicle_Update.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVehicle_Update.ForeColor = System.Drawing.Color.White;
            this.BtnVehicle_Update.HoverState.FillColor = System.Drawing.Color.Navy;
            this.BtnVehicle_Update.Image = global::Securentra_Management_System.Properties.Resources.kindpng_4474248;
            this.BtnVehicle_Update.ImageSize = new System.Drawing.Size(25, 25);
            this.BtnVehicle_Update.Location = new System.Drawing.Point(233, 431);
            this.BtnVehicle_Update.Name = "BtnVehicle_Update";
            this.BtnVehicle_Update.PressedColor = System.Drawing.Color.DarkSlateBlue;
            this.BtnVehicle_Update.Size = new System.Drawing.Size(120, 50);
            this.BtnVehicle_Update.TabIndex = 45;
            this.BtnVehicle_Update.Text = "Update";
            this.BtnVehicle_Update.Click += new System.EventHandler(this.BtnVehicle_Update_Click);
            // 
            // BtnVehicle_Delete
            // 
            this.BtnVehicle_Delete.BackColor = System.Drawing.Color.Navy;
            this.BtnVehicle_Delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnVehicle_Delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnVehicle_Delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnVehicle_Delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnVehicle_Delete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(101)))));
            this.BtnVehicle_Delete.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVehicle_Delete.ForeColor = System.Drawing.Color.White;
            this.BtnVehicle_Delete.HoverState.FillColor = System.Drawing.Color.Navy;
            this.BtnVehicle_Delete.Image = global::Securentra_Management_System.Properties.Resources.icons8_remove_301;
            this.BtnVehicle_Delete.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnVehicle_Delete.ImageSize = new System.Drawing.Size(15, 15);
            this.BtnVehicle_Delete.Location = new System.Drawing.Point(233, 177);
            this.BtnVehicle_Delete.Name = "BtnVehicle_Delete";
            this.BtnVehicle_Delete.PressedColor = System.Drawing.Color.DarkSlateBlue;
            this.BtnVehicle_Delete.Size = new System.Drawing.Size(120, 50);
            this.BtnVehicle_Delete.TabIndex = 44;
            this.BtnVehicle_Delete.Text = "Delete";
            this.BtnVehicle_Delete.Click += new System.EventHandler(this.BtnVehicle_Delete_Click);
            // 
            // BtnVehicle_Search
            // 
            this.BtnVehicle_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.BtnVehicle_Search.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnVehicle_Search.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnVehicle_Search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnVehicle_Search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnVehicle_Search.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(101)))));
            this.BtnVehicle_Search.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVehicle_Search.ForeColor = System.Drawing.Color.White;
            this.BtnVehicle_Search.HoverState.FillColor = System.Drawing.Color.Navy;
            this.BtnVehicle_Search.Image = global::Securentra_Management_System.Properties.Resources.kindpng_790382;
            this.BtnVehicle_Search.ImageSize = new System.Drawing.Size(15, 15);
            this.BtnVehicle_Search.Location = new System.Drawing.Point(45, 177);
            this.BtnVehicle_Search.Name = "BtnVehicle_Search";
            this.BtnVehicle_Search.PressedColor = System.Drawing.Color.DarkSlateBlue;
            this.BtnVehicle_Search.Size = new System.Drawing.Size(120, 50);
            this.BtnVehicle_Search.TabIndex = 43;
            this.BtnVehicle_Search.Text = "Search";
            this.BtnVehicle_Search.Click += new System.EventHandler(this.BtnVehicle_Search_Click);
            // 
            // BtnVehicle_Add
            // 
            this.BtnVehicle_Add.BackColor = System.Drawing.Color.Navy;
            this.BtnVehicle_Add.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnVehicle_Add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnVehicle_Add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnVehicle_Add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnVehicle_Add.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(101)))));
            this.BtnVehicle_Add.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVehicle_Add.ForeColor = System.Drawing.Color.White;
            this.BtnVehicle_Add.HoverState.FillColor = System.Drawing.Color.Navy;
            this.BtnVehicle_Add.Image = global::Securentra_Management_System.Properties.Resources.add;
            this.BtnVehicle_Add.ImageSize = new System.Drawing.Size(15, 15);
            this.BtnVehicle_Add.Location = new System.Drawing.Point(45, 431);
            this.BtnVehicle_Add.Name = "BtnVehicle_Add";
            this.BtnVehicle_Add.PressedColor = System.Drawing.Color.DarkSlateBlue;
            this.BtnVehicle_Add.Size = new System.Drawing.Size(120, 50);
            this.BtnVehicle_Add.TabIndex = 8;
            this.BtnVehicle_Add.Text = "Add";
            this.BtnVehicle_Add.Click += new System.EventHandler(this.BtnVehicle_Add_Click);
            // 
            // export
            // 
            this.export.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.export.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(101)))));
            this.export.BorderThickness = 2;
            this.export.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.export.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.export.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.export.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.export.FillColor = System.Drawing.Color.White;
            this.export.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.export.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(101)))));
            this.export.HoverState.FillColor = System.Drawing.Color.Navy;
            this.export.Image = global::Securentra_Management_System.Properties.Resources.data_export_icon_0;
            this.export.ImageSize = new System.Drawing.Size(15, 15);
            this.export.Location = new System.Drawing.Point(86, 544);
            this.export.Name = "export";
            this.export.PressedColor = System.Drawing.Color.Red;
            this.export.Size = new System.Drawing.Size(223, 37);
            this.export.TabIndex = 51;
            this.export.Text = "Export Data";
            this.export.Click += new System.EventHandler(this.export_Click);
            this.export.MouseEnter += new System.EventHandler(this.export_MouseEnter);
            this.export.MouseHover += new System.EventHandler(this.export_MouseHover);
            // 
            // FormVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Securentra_Management_System.Properties.Resources._6e32878542a4a6b86e640204d951fbff__blue_wallpapers_blue_backgrounds;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.export);
            this.Controls.Add(this.BtnVehicle_Update);
            this.Controls.Add(this.BtnVehicle_Delete);
            this.Controls.Add(this.BtnVehicle_Search);
            this.Controls.Add(this.VehicleDGV);
            this.Controls.Add(this.BtnVehicle_Add);
            this.Controls.Add(this.OwnerID);
            this.Controls.Add(this.VehicleModel);
            this.Controls.Add(this.VehicleType);
            this.Controls.Add(this.NumberPlate);
            this.Name = "FormVehicle";
            this.Size = new System.Drawing.Size(982, 623);
            this.Load += new System.EventHandler(this.FormVehicle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VehicleDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox NumberPlate;
        private Guna.UI2.WinForms.Guna2TextBox VehicleType;
        private Guna.UI2.WinForms.Guna2TextBox VehicleModel;
        private Guna.UI2.WinForms.Guna2TextBox OwnerID;
        private Guna.UI2.WinForms.Guna2Button BtnVehicle_Add;
        private Guna.UI2.WinForms.Guna2DataGridView VehicleDGV;
        private Guna.UI2.WinForms.Guna2Button BtnVehicle_Delete;
        private Guna.UI2.WinForms.Guna2Button BtnVehicle_Search;
        private Guna.UI2.WinForms.Guna2Button BtnVehicle_Update;
        private Guna.UI2.WinForms.Guna2Button export;
    }
}
