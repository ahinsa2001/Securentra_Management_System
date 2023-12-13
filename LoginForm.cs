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
    public partial class LoginForm : System.Windows.Forms.Form
    {

        public LoginForm()
        {
            InitializeComponent();
        }

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "ClOVtlKcXyNZP4W4Bvai2DgxtQLPcNWY417W0nk4",
            BasePath = "https://ntadb-95601-default-rtdb.asia-southeast1.firebasedatabase.app/"
        };

        IFirebaseClient client;

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ForgetPassword_MouseHover(object sender, EventArgs e)
        {
            ForgetPassword.ForeColor = Color.Red;
        }

        private void ForgetPassword_MouseLeave(object sender, EventArgs e)
        {
            ForgetPassword.ForeColor = Color.Gray;
        }

        private void Login_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Exit_MouseEnter(object sender, EventArgs e)
        {
            Login_Exit.ForeColor = Color.Red;
        }

        private void Login_Exit_MouseLeave(object sender, EventArgs e)
        {
            Login_Exit.ForeColor = Color.DarkSlateBlue;
        }

        
        private void Button_Login_Click(object sender, EventArgs e)
        {
            #region Condition
            if (string.IsNullOrWhiteSpace(TextBox_Username.Text) &&
                string.IsNullOrWhiteSpace(TextBox_Password.Text))
            {
                MessageBox.Show("Please Fill All the Fields");
                return;
            }
            #endregion

            FirebaseResponse res = client.Get(@"Admin/" + TextBox_Username.Text);
            Admin RealUser = res.ResultAs<Admin>(); //Database result

            Admin CurUser = new Admin() //User given info
            {
                AID = TextBox_Username.Text,
                APassword = TextBox_Password.Text
            };

            if (Admin.IsEqual(RealUser, CurUser))
            {
                VertificationForm vertificationform = new VertificationForm(TextBox_Username.Text);
                MessageBox.Show("Login Successfully!");
                this.Hide();
                vertificationform.Show();
            }
            else
            {
                Admin.ShowError();
            }
            
        }

        private void ForgetPassword_Click(object sender, EventArgs e)
        {
            ForgotPasswordForm forgotPasswordForm = new ForgotPasswordForm();
            this.Hide();
            forgotPasswordForm.Show();
        }

        private void Username_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(config);
            }
            catch
            {
                MessageBox.Show("No Internet or Connection Problem");
            }
        }

        private void TextBox_Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox_Username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
