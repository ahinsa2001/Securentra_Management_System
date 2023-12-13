using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using FireSharp;

namespace Securentra_Management_System
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "ClOVtlKcXyNZP4W4Bvai2DgxtQLPcNWY417W0nk4",
            BasePath = "https://ntadb-95601-default-rtdb.asia-southeast1.firebasedatabase.app/"
        };

        IFirebaseClient client;
        private void FormAdmin_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);


        }

        private void Topic_Paint(object sender, PaintEventArgs e)
        {

        }

        string gender;
        private void Male_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Male";
        }

        private void Female_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            BtnMax.Visible = false;
            BtnMaxed.Location = BtnMax.Location;
            BtnMaxed.Visible = true;
        }

        private void BtnMaxed_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            BtnMaxed.Visible = false;
            BtnMax.Visible = true;
        }

        private void BtnAdmin_Add_Click(object sender, EventArgs e)
        {
            #region Condition
            if (string.IsNullOrWhiteSpace(AddAdminFullname.Text) &&
               string.IsNullOrWhiteSpace(AddAdminID.Text) &&
               string.IsNullOrWhiteSpace(AddAdminContactNum.Text) &&
               string.IsNullOrWhiteSpace(AddAdminEmail.Text) &&
               string.IsNullOrWhiteSpace(AddAdminPW.Text) &&
               string.IsNullOrWhiteSpace(AddAdminRetypePW.Text))
            {
                MessageBox.Show("Please Fill All the Fields");
                return;
            }
            #endregion

            Admin admin = new Admin()
            {
                AName = AddAdminFullname.Text,
                AID = AddAdminID.Text,
                Gender = gender,
                AContact = AddAdminContactNum.Text,
                AEmail = AddAdminEmail.Text,
                APassword = AddAdminPW.Text
            };

            if (AddAdminPW.Text == AddAdminRetypePW.Text)
            {
                SetResponse set = client.Set(@"Admin/" + AddAdminID.Text, admin);
                MessageBox.Show("New Admin Added Successfully!");

                AddAdminFullname.Clear();
                AddAdminID.Clear();
                AddAdminContactNum.Clear();
                AddAdminEmail.Clear();
                AddAdminPW.Clear();
                AddAdminRetypePW.Clear();
                gender = "";
            }
            else if(AddAdminPW.Text != AddAdminRetypePW.Text)
            {
                MessageBox.Show("Password do not match!");
                AddAdminPW.Clear();
                AddAdminRetypePW.Clear();
            }

        }

        private void BtnAdmin_View_Click(object sender, EventArgs e)
        {
            ViewAdmin viewAdmin = new ViewAdmin();
            this.Hide();
            viewAdmin.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
