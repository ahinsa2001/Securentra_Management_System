namespace Securentra_Management_System
{
    partial class FormAdmin
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
            this.AccessPermission = new System.Windows.Forms.Label();
            this.Female = new System.Windows.Forms.RadioButton();
            this.AddAdminEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.AddAdminContactNum = new Guna.UI2.WinForms.Guna2TextBox();
            this.AddAdminID = new Guna.UI2.WinForms.Guna2TextBox();
            this.AddAdminFullname = new Guna.UI2.WinForms.Guna2TextBox();
            this.Male = new System.Windows.Forms.RadioButton();
            this.AddAdminPW = new Guna.UI2.WinForms.Guna2TextBox();
            this.AddAdminRetypePW = new Guna.UI2.WinForms.Guna2TextBox();
            this.UpdateAdminEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.UpdateAdminNum = new Guna.UI2.WinForms.Guna2TextBox();
            this.UpdateAdminID = new Guna.UI2.WinForms.Guna2TextBox();
            this.DeleteAdminID = new Guna.UI2.WinForms.Guna2TextBox();
            this.DeleteAdminRetypePW = new Guna.UI2.WinForms.Guna2TextBox();
            this.DeleteAdminPW = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnMaxed = new Guna.UI2.WinForms.Guna2Button();
            this.BtnMin = new Guna.UI2.WinForms.Guna2Button();
            this.BtnMax = new Guna.UI2.WinForms.Guna2Button();
            this.Topic = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnClose = new Guna.UI2.WinForms.Guna2Button();
            this.BtnAdmin_View = new Guna.UI2.WinForms.Guna2Button();
            this.BtnAdmin_Delete = new Guna.UI2.WinForms.Guna2Button();
            this.BtnAdmin_Update = new Guna.UI2.WinForms.Guna2Button();
            this.BtnAdmin_Add = new Guna.UI2.WinForms.Guna2Button();
            this.panel3.SuspendLayout();
            this.Topic.SuspendLayout();
            this.SuspendLayout();
            // 
            // AccessPermission
            // 
            this.AccessPermission.AutoSize = true;
            this.AccessPermission.BackColor = System.Drawing.Color.Transparent;
            this.AccessPermission.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccessPermission.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(101)))));
            this.AccessPermission.Location = new System.Drawing.Point(86, 281);
            this.AccessPermission.Name = "AccessPermission";
            this.AccessPermission.Size = new System.Drawing.Size(71, 19);
            this.AccessPermission.TabIndex = 49;
            this.AccessPermission.Text = "Gender";
            // 
            // Female
            // 
            this.Female.AutoSize = true;
            this.Female.BackColor = System.Drawing.Color.Transparent;
            this.Female.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Female.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            this.Female.Location = new System.Drawing.Point(228, 316);
            this.Female.Name = "Female";
            this.Female.Size = new System.Drawing.Size(76, 21);
            this.Female.TabIndex = 48;
            this.Female.TabStop = true;
            this.Female.Text = "Female";
            this.Female.UseVisualStyleBackColor = false;
            this.Female.CheckedChanged += new System.EventHandler(this.Female_CheckedChanged);
            // 
            // AddAdminEmail
            // 
            this.AddAdminEmail.BackColor = System.Drawing.Color.White;
            this.AddAdminEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.AddAdminEmail.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.AddAdminEmail.BorderThickness = 2;
            this.AddAdminEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AddAdminEmail.DefaultText = "";
            this.AddAdminEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.AddAdminEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.AddAdminEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AddAdminEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AddAdminEmail.FillColor = System.Drawing.Color.WhiteSmoke;
            this.AddAdminEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AddAdminEmail.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddAdminEmail.ForeColor = System.Drawing.Color.Black;
            this.AddAdminEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.AddAdminEmail.Location = new System.Drawing.Point(90, 217);
            this.AddAdminEmail.Name = "AddAdminEmail";
            this.AddAdminEmail.PasswordChar = '\0';
            this.AddAdminEmail.PlaceholderText = "Email Address";
            this.AddAdminEmail.SelectedText = "";
            this.AddAdminEmail.Size = new System.Drawing.Size(308, 33);
            this.AddAdminEmail.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.AddAdminEmail.TabIndex = 46;
            // 
            // AddAdminContactNum
            // 
            this.AddAdminContactNum.BackColor = System.Drawing.Color.White;
            this.AddAdminContactNum.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.AddAdminContactNum.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.AddAdminContactNum.BorderThickness = 2;
            this.AddAdminContactNum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AddAdminContactNum.DefaultText = "";
            this.AddAdminContactNum.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.AddAdminContactNum.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.AddAdminContactNum.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AddAdminContactNum.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AddAdminContactNum.FillColor = System.Drawing.Color.WhiteSmoke;
            this.AddAdminContactNum.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AddAdminContactNum.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddAdminContactNum.ForeColor = System.Drawing.Color.Black;
            this.AddAdminContactNum.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.AddAdminContactNum.Location = new System.Drawing.Point(90, 178);
            this.AddAdminContactNum.Name = "AddAdminContactNum";
            this.AddAdminContactNum.PasswordChar = '\0';
            this.AddAdminContactNum.PlaceholderText = "Contact Number";
            this.AddAdminContactNum.SelectedText = "";
            this.AddAdminContactNum.Size = new System.Drawing.Size(308, 33);
            this.AddAdminContactNum.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.AddAdminContactNum.TabIndex = 45;
            // 
            // AddAdminID
            // 
            this.AddAdminID.BackColor = System.Drawing.Color.White;
            this.AddAdminID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.AddAdminID.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.AddAdminID.BorderThickness = 2;
            this.AddAdminID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AddAdminID.DefaultText = "";
            this.AddAdminID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.AddAdminID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.AddAdminID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AddAdminID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AddAdminID.FillColor = System.Drawing.Color.WhiteSmoke;
            this.AddAdminID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AddAdminID.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddAdminID.ForeColor = System.Drawing.Color.Black;
            this.AddAdminID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.AddAdminID.Location = new System.Drawing.Point(90, 139);
            this.AddAdminID.Name = "AddAdminID";
            this.AddAdminID.PasswordChar = '\0';
            this.AddAdminID.PlaceholderText = "Admin ID";
            this.AddAdminID.SelectedText = "";
            this.AddAdminID.Size = new System.Drawing.Size(308, 33);
            this.AddAdminID.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.AddAdminID.TabIndex = 44;
            // 
            // AddAdminFullname
            // 
            this.AddAdminFullname.BackColor = System.Drawing.Color.White;
            this.AddAdminFullname.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.AddAdminFullname.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.AddAdminFullname.BorderThickness = 2;
            this.AddAdminFullname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AddAdminFullname.DefaultText = "";
            this.AddAdminFullname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.AddAdminFullname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.AddAdminFullname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AddAdminFullname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AddAdminFullname.FillColor = System.Drawing.Color.WhiteSmoke;
            this.AddAdminFullname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AddAdminFullname.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddAdminFullname.ForeColor = System.Drawing.Color.Black;
            this.AddAdminFullname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.AddAdminFullname.Location = new System.Drawing.Point(90, 100);
            this.AddAdminFullname.Name = "AddAdminFullname";
            this.AddAdminFullname.PasswordChar = '\0';
            this.AddAdminFullname.PlaceholderText = "Full Name";
            this.AddAdminFullname.SelectedText = "";
            this.AddAdminFullname.Size = new System.Drawing.Size(308, 33);
            this.AddAdminFullname.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.AddAdminFullname.TabIndex = 43;
            // 
            // Male
            // 
            this.Male.AutoSize = true;
            this.Male.BackColor = System.Drawing.Color.Transparent;
            this.Male.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Male.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            this.Male.Location = new System.Drawing.Point(90, 316);
            this.Male.Name = "Male";
            this.Male.Size = new System.Drawing.Size(60, 21);
            this.Male.TabIndex = 53;
            this.Male.TabStop = true;
            this.Male.Text = "Male";
            this.Male.UseVisualStyleBackColor = false;
            this.Male.CheckedChanged += new System.EventHandler(this.Male_CheckedChanged);
            // 
            // AddAdminPW
            // 
            this.AddAdminPW.BackColor = System.Drawing.Color.White;
            this.AddAdminPW.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.AddAdminPW.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.AddAdminPW.BorderThickness = 2;
            this.AddAdminPW.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AddAdminPW.DefaultText = "";
            this.AddAdminPW.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.AddAdminPW.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.AddAdminPW.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AddAdminPW.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AddAdminPW.FillColor = System.Drawing.Color.WhiteSmoke;
            this.AddAdminPW.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AddAdminPW.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddAdminPW.ForeColor = System.Drawing.Color.Black;
            this.AddAdminPW.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.AddAdminPW.Location = new System.Drawing.Point(90, 388);
            this.AddAdminPW.Name = "AddAdminPW";
            this.AddAdminPW.PasswordChar = '●';
            this.AddAdminPW.PlaceholderText = "Password";
            this.AddAdminPW.SelectedText = "";
            this.AddAdminPW.Size = new System.Drawing.Size(308, 33);
            this.AddAdminPW.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.AddAdminPW.TabIndex = 54;
            this.AddAdminPW.UseSystemPasswordChar = true;
            // 
            // AddAdminRetypePW
            // 
            this.AddAdminRetypePW.BackColor = System.Drawing.Color.White;
            this.AddAdminRetypePW.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.AddAdminRetypePW.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.AddAdminRetypePW.BorderThickness = 2;
            this.AddAdminRetypePW.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AddAdminRetypePW.DefaultText = "";
            this.AddAdminRetypePW.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.AddAdminRetypePW.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.AddAdminRetypePW.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AddAdminRetypePW.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AddAdminRetypePW.FillColor = System.Drawing.Color.WhiteSmoke;
            this.AddAdminRetypePW.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AddAdminRetypePW.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddAdminRetypePW.ForeColor = System.Drawing.Color.Black;
            this.AddAdminRetypePW.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.AddAdminRetypePW.Location = new System.Drawing.Point(90, 427);
            this.AddAdminRetypePW.Name = "AddAdminRetypePW";
            this.AddAdminRetypePW.PasswordChar = '●';
            this.AddAdminRetypePW.PlaceholderText = "Conform Your Password";
            this.AddAdminRetypePW.SelectedText = "";
            this.AddAdminRetypePW.Size = new System.Drawing.Size(308, 33);
            this.AddAdminRetypePW.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.AddAdminRetypePW.TabIndex = 55;
            this.AddAdminRetypePW.UseSystemPasswordChar = true;
            // 
            // UpdateAdminEmail
            // 
            this.UpdateAdminEmail.BackColor = System.Drawing.Color.White;
            this.UpdateAdminEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.UpdateAdminEmail.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.UpdateAdminEmail.BorderThickness = 2;
            this.UpdateAdminEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UpdateAdminEmail.DefaultText = "";
            this.UpdateAdminEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.UpdateAdminEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UpdateAdminEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UpdateAdminEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UpdateAdminEmail.FillColor = System.Drawing.Color.WhiteSmoke;
            this.UpdateAdminEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UpdateAdminEmail.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateAdminEmail.ForeColor = System.Drawing.Color.Black;
            this.UpdateAdminEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.UpdateAdminEmail.Location = new System.Drawing.Point(576, 178);
            this.UpdateAdminEmail.Name = "UpdateAdminEmail";
            this.UpdateAdminEmail.PasswordChar = '\0';
            this.UpdateAdminEmail.PlaceholderText = "Email Address";
            this.UpdateAdminEmail.SelectedText = "";
            this.UpdateAdminEmail.Size = new System.Drawing.Size(308, 33);
            this.UpdateAdminEmail.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.UpdateAdminEmail.TabIndex = 59;
            // 
            // UpdateAdminNum
            // 
            this.UpdateAdminNum.BackColor = System.Drawing.Color.White;
            this.UpdateAdminNum.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.UpdateAdminNum.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.UpdateAdminNum.BorderThickness = 2;
            this.UpdateAdminNum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UpdateAdminNum.DefaultText = "";
            this.UpdateAdminNum.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.UpdateAdminNum.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UpdateAdminNum.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UpdateAdminNum.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UpdateAdminNum.FillColor = System.Drawing.Color.WhiteSmoke;
            this.UpdateAdminNum.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UpdateAdminNum.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateAdminNum.ForeColor = System.Drawing.Color.Black;
            this.UpdateAdminNum.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.UpdateAdminNum.Location = new System.Drawing.Point(576, 139);
            this.UpdateAdminNum.Name = "UpdateAdminNum";
            this.UpdateAdminNum.PasswordChar = '\0';
            this.UpdateAdminNum.PlaceholderText = "Contact Number";
            this.UpdateAdminNum.SelectedText = "";
            this.UpdateAdminNum.Size = new System.Drawing.Size(308, 33);
            this.UpdateAdminNum.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.UpdateAdminNum.TabIndex = 58;
            // 
            // UpdateAdminID
            // 
            this.UpdateAdminID.BackColor = System.Drawing.Color.White;
            this.UpdateAdminID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.UpdateAdminID.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.UpdateAdminID.BorderThickness = 2;
            this.UpdateAdminID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UpdateAdminID.DefaultText = "";
            this.UpdateAdminID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.UpdateAdminID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UpdateAdminID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UpdateAdminID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UpdateAdminID.FillColor = System.Drawing.Color.WhiteSmoke;
            this.UpdateAdminID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UpdateAdminID.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateAdminID.ForeColor = System.Drawing.Color.Black;
            this.UpdateAdminID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.UpdateAdminID.Location = new System.Drawing.Point(576, 100);
            this.UpdateAdminID.Name = "UpdateAdminID";
            this.UpdateAdminID.PasswordChar = '\0';
            this.UpdateAdminID.PlaceholderText = "Admin ID";
            this.UpdateAdminID.SelectedText = "";
            this.UpdateAdminID.Size = new System.Drawing.Size(308, 33);
            this.UpdateAdminID.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.UpdateAdminID.TabIndex = 57;
            // 
            // DeleteAdminID
            // 
            this.DeleteAdminID.BackColor = System.Drawing.Color.White;
            this.DeleteAdminID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.DeleteAdminID.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.DeleteAdminID.BorderThickness = 2;
            this.DeleteAdminID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DeleteAdminID.DefaultText = "";
            this.DeleteAdminID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.DeleteAdminID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.DeleteAdminID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DeleteAdminID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DeleteAdminID.FillColor = System.Drawing.Color.WhiteSmoke;
            this.DeleteAdminID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DeleteAdminID.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteAdminID.ForeColor = System.Drawing.Color.Black;
            this.DeleteAdminID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.DeleteAdminID.Location = new System.Drawing.Point(576, 348);
            this.DeleteAdminID.Name = "DeleteAdminID";
            this.DeleteAdminID.PasswordChar = '\0';
            this.DeleteAdminID.PlaceholderText = "Admin ID";
            this.DeleteAdminID.SelectedText = "";
            this.DeleteAdminID.Size = new System.Drawing.Size(308, 33);
            this.DeleteAdminID.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.DeleteAdminID.TabIndex = 60;
            // 
            // DeleteAdminRetypePW
            // 
            this.DeleteAdminRetypePW.BackColor = System.Drawing.Color.White;
            this.DeleteAdminRetypePW.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.DeleteAdminRetypePW.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.DeleteAdminRetypePW.BorderThickness = 2;
            this.DeleteAdminRetypePW.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DeleteAdminRetypePW.DefaultText = "";
            this.DeleteAdminRetypePW.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.DeleteAdminRetypePW.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.DeleteAdminRetypePW.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DeleteAdminRetypePW.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DeleteAdminRetypePW.FillColor = System.Drawing.Color.WhiteSmoke;
            this.DeleteAdminRetypePW.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DeleteAdminRetypePW.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteAdminRetypePW.ForeColor = System.Drawing.Color.Black;
            this.DeleteAdminRetypePW.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.DeleteAdminRetypePW.Location = new System.Drawing.Point(576, 428);
            this.DeleteAdminRetypePW.Name = "DeleteAdminRetypePW";
            this.DeleteAdminRetypePW.PasswordChar = '\0';
            this.DeleteAdminRetypePW.PlaceholderText = "Conform Password";
            this.DeleteAdminRetypePW.SelectedText = "";
            this.DeleteAdminRetypePW.Size = new System.Drawing.Size(308, 33);
            this.DeleteAdminRetypePW.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.DeleteAdminRetypePW.TabIndex = 62;
            // 
            // DeleteAdminPW
            // 
            this.DeleteAdminPW.BackColor = System.Drawing.Color.White;
            this.DeleteAdminPW.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.DeleteAdminPW.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.DeleteAdminPW.BorderThickness = 2;
            this.DeleteAdminPW.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DeleteAdminPW.DefaultText = "";
            this.DeleteAdminPW.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.DeleteAdminPW.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.DeleteAdminPW.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DeleteAdminPW.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DeleteAdminPW.FillColor = System.Drawing.Color.WhiteSmoke;
            this.DeleteAdminPW.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DeleteAdminPW.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteAdminPW.ForeColor = System.Drawing.Color.Black;
            this.DeleteAdminPW.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.DeleteAdminPW.Location = new System.Drawing.Point(576, 388);
            this.DeleteAdminPW.Name = "DeleteAdminPW";
            this.DeleteAdminPW.PasswordChar = '\0';
            this.DeleteAdminPW.PlaceholderText = "Password";
            this.DeleteAdminPW.SelectedText = "";
            this.DeleteAdminPW.Size = new System.Drawing.Size(308, 33);
            this.DeleteAdminPW.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.DeleteAdminPW.TabIndex = 61;
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
            this.panel3.Size = new System.Drawing.Size(982, 50);
            this.panel3.TabIndex = 64;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
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
            this.BtnMaxed.Location = new System.Drawing.Point(782, 0);
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
            this.BtnMin.Location = new System.Drawing.Point(832, 0);
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
            this.BtnMax.Location = new System.Drawing.Point(882, 0);
            this.BtnMax.Name = "BtnMax";
            this.BtnMax.Size = new System.Drawing.Size(50, 50);
            this.BtnMax.TabIndex = 3;
            this.BtnMax.Click += new System.EventHandler(this.BtnMax_Click);
            // 
            // Topic
            // 
            this.Topic.Controls.Add(this.label1);
            this.Topic.Location = new System.Drawing.Point(277, 3);
            this.Topic.Name = "Topic";
            this.Topic.Size = new System.Drawing.Size(402, 44);
            this.Topic.TabIndex = 1;
            this.Topic.Paint += new System.Windows.Forms.PaintEventHandler(this.Topic_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(136, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin Details";
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
            this.BtnClose.Location = new System.Drawing.Point(932, 0);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(50, 50);
            this.BtnClose.TabIndex = 0;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnAdmin_View
            // 
            this.BtnAdmin_View.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.BtnAdmin_View.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(101)))));
            this.BtnAdmin_View.BorderThickness = 2;
            this.BtnAdmin_View.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnAdmin_View.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnAdmin_View.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnAdmin_View.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnAdmin_View.FillColor = System.Drawing.Color.White;
            this.BtnAdmin_View.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdmin_View.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(101)))));
            this.BtnAdmin_View.HoverState.FillColor = System.Drawing.Color.Navy;
            this.BtnAdmin_View.Image = global::Securentra_Management_System.Properties.Resources.icons8_ophthalmology_24;
            this.BtnAdmin_View.Location = new System.Drawing.Point(383, 586);
            this.BtnAdmin_View.Name = "BtnAdmin_View";
            this.BtnAdmin_View.PressedColor = System.Drawing.Color.DarkSlateBlue;
            this.BtnAdmin_View.Size = new System.Drawing.Size(217, 46);
            this.BtnAdmin_View.TabIndex = 63;
            this.BtnAdmin_View.Text = "View Database";
            this.BtnAdmin_View.Click += new System.EventHandler(this.BtnAdmin_View_Click);
            // 
            // BtnAdmin_Delete
            // 
            this.BtnAdmin_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.BtnAdmin_Delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnAdmin_Delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnAdmin_Delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnAdmin_Delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnAdmin_Delete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(101)))));
            this.BtnAdmin_Delete.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdmin_Delete.ForeColor = System.Drawing.Color.White;
            this.BtnAdmin_Delete.HoverState.FillColor = System.Drawing.Color.Navy;
            this.BtnAdmin_Delete.Image = global::Securentra_Management_System.Properties.Resources.icons8_remove_302;
            this.BtnAdmin_Delete.ImageSize = new System.Drawing.Size(15, 15);
            this.BtnAdmin_Delete.Location = new System.Drawing.Point(675, 508);
            this.BtnAdmin_Delete.Name = "BtnAdmin_Delete";
            this.BtnAdmin_Delete.PressedColor = System.Drawing.Color.DarkSlateBlue;
            this.BtnAdmin_Delete.Size = new System.Drawing.Size(120, 50);
            this.BtnAdmin_Delete.TabIndex = 52;
            this.BtnAdmin_Delete.Text = "Delete";
            // 
            // BtnAdmin_Update
            // 
            this.BtnAdmin_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.BtnAdmin_Update.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnAdmin_Update.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnAdmin_Update.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnAdmin_Update.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnAdmin_Update.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(101)))));
            this.BtnAdmin_Update.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdmin_Update.ForeColor = System.Drawing.Color.White;
            this.BtnAdmin_Update.HoverState.FillColor = System.Drawing.Color.Navy;
            this.BtnAdmin_Update.Image = global::Securentra_Management_System.Properties.Resources.kindpng_4474248;
            this.BtnAdmin_Update.ImageSize = new System.Drawing.Size(25, 25);
            this.BtnAdmin_Update.Location = new System.Drawing.Point(675, 255);
            this.BtnAdmin_Update.Name = "BtnAdmin_Update";
            this.BtnAdmin_Update.PressedColor = System.Drawing.Color.DarkSlateBlue;
            this.BtnAdmin_Update.Size = new System.Drawing.Size(120, 50);
            this.BtnAdmin_Update.TabIndex = 50;
            this.BtnAdmin_Update.Text = "Update";
            // 
            // BtnAdmin_Add
            // 
            this.BtnAdmin_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.BtnAdmin_Add.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnAdmin_Add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnAdmin_Add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnAdmin_Add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnAdmin_Add.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(101)))));
            this.BtnAdmin_Add.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdmin_Add.ForeColor = System.Drawing.Color.White;
            this.BtnAdmin_Add.HoverState.FillColor = System.Drawing.Color.Navy;
            this.BtnAdmin_Add.Image = global::Securentra_Management_System.Properties.Resources.kindpng_4414019;
            this.BtnAdmin_Add.ImageSize = new System.Drawing.Size(15, 15);
            this.BtnAdmin_Add.Location = new System.Drawing.Point(184, 508);
            this.BtnAdmin_Add.Name = "BtnAdmin_Add";
            this.BtnAdmin_Add.PressedColor = System.Drawing.Color.DarkSlateBlue;
            this.BtnAdmin_Add.Size = new System.Drawing.Size(120, 50);
            this.BtnAdmin_Add.TabIndex = 47;
            this.BtnAdmin_Add.Text = "Add";
            this.BtnAdmin_Add.Click += new System.EventHandler(this.BtnAdmin_Add_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Securentra_Management_System.Properties.Resources._6e32878542a4a6b86e640204d951fbff__blue_wallpapers_blue_backgrounds;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(982, 673);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.BtnAdmin_View);
            this.Controls.Add(this.DeleteAdminRetypePW);
            this.Controls.Add(this.DeleteAdminPW);
            this.Controls.Add(this.DeleteAdminID);
            this.Controls.Add(this.UpdateAdminEmail);
            this.Controls.Add(this.UpdateAdminNum);
            this.Controls.Add(this.UpdateAdminID);
            this.Controls.Add(this.AddAdminRetypePW);
            this.Controls.Add(this.AddAdminPW);
            this.Controls.Add(this.Male);
            this.Controls.Add(this.BtnAdmin_Delete);
            this.Controls.Add(this.BtnAdmin_Update);
            this.Controls.Add(this.AccessPermission);
            this.Controls.Add(this.Female);
            this.Controls.Add(this.BtnAdmin_Add);
            this.Controls.Add(this.AddAdminEmail);
            this.Controls.Add(this.AddAdminContactNum);
            this.Controls.Add(this.AddAdminID);
            this.Controls.Add(this.AddAdminFullname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAdmin";
            this.Text = "FormAdmin";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            this.panel3.ResumeLayout(false);
            this.Topic.ResumeLayout(false);
            this.Topic.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button BtnAdmin_Delete;
        private Guna.UI2.WinForms.Guna2Button BtnAdmin_Update;
        private System.Windows.Forms.Label AccessPermission;
        private System.Windows.Forms.RadioButton Female;
        private Guna.UI2.WinForms.Guna2Button BtnAdmin_Add;
        private Guna.UI2.WinForms.Guna2TextBox AddAdminEmail;
        private Guna.UI2.WinForms.Guna2TextBox AddAdminContactNum;
        private Guna.UI2.WinForms.Guna2TextBox AddAdminID;
        private Guna.UI2.WinForms.Guna2TextBox AddAdminFullname;
        private System.Windows.Forms.RadioButton Male;
        private Guna.UI2.WinForms.Guna2TextBox AddAdminPW;
        private Guna.UI2.WinForms.Guna2TextBox AddAdminRetypePW;
        private Guna.UI2.WinForms.Guna2TextBox UpdateAdminEmail;
        private Guna.UI2.WinForms.Guna2TextBox UpdateAdminNum;
        private Guna.UI2.WinForms.Guna2TextBox UpdateAdminID;
        private Guna.UI2.WinForms.Guna2TextBox DeleteAdminID;
        private Guna.UI2.WinForms.Guna2TextBox DeleteAdminRetypePW;
        private Guna.UI2.WinForms.Guna2TextBox DeleteAdminPW;
        private Guna.UI2.WinForms.Guna2Button BtnAdmin_View;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2Button BtnMaxed;
        private Guna.UI2.WinForms.Guna2Button BtnMin;
        private Guna.UI2.WinForms.Guna2Button BtnMax;
        private System.Windows.Forms.Panel Topic;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button BtnClose;
    }
}