using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Securentra_Management_System
{
    public partial class ForgotPasswordForm : System.Windows.Forms.Form
    {
        public ForgotPasswordForm()
        {
            InitializeComponent();
        }

        private void ForgetPassword_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ForgetPassword_Exit_MouseEnter(object sender, EventArgs e)
        {
            ForgetPassword_Exit.ForeColor = Color.Black;
        }

        private void ForgetPassword_Exit_MouseLeave(object sender, EventArgs e)
        {
            ForgetPassword_Exit.ForeColor = Color.DarkSlateBlue;
        }

        private void Button_ForgotPassword_Click(object sender, EventArgs e)
        {
            LoginForm loginform1 = new LoginForm();
            this.Hide();
            loginform1.Show();
        }
    }
}
