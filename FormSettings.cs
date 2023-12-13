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
    public partial class FormSettings : UserControl
    {
        public FormSettings(string user)
        {
            InitializeComponent();
            remind.Text = user;
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {

        }

        private void BtnAdmin_Click(object sender, EventArgs e)
        {
            FormAdmin admin = new FormAdmin();
            admin.Show();
        }

        private void BtnResetPW_Click(object sender, EventArgs e)
        {
            ResetPassword resetPassword = new ResetPassword(remind.Text);
            resetPassword.Show();
        }

        private void BtnEditProfile_Click(object sender, EventArgs e)
        {
            EditProfileForm editProfile = new EditProfileForm(remind.Text);
            editProfile.Show();
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            LoginForm obj = new LoginForm();
            this.Hide();
            obj.Show();
        }

        private void LogOut_MouseHover(object sender, EventArgs e)
        {
            LogOut.ForeColor = Color.Gray;
        }

        private void LogOut_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void LogOut_MouseEnter(object sender, EventArgs e)
        {
            LogOut.ForeColor = Color.Red;
        }
    }
}
