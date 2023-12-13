using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Windows.Forms;

namespace Securentra_Management_System
{
    public partial class ResetPassword : Form
    {

        public ResetPassword(string user)
        {
            InitializeComponent();
            ID.Text = user;
        }

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "ClOVtlKcXyNZP4W4Bvai2DgxtQLPcNWY417W0nk4",
            BasePath = "https://ntadb-95601-default-rtdb.asia-southeast1.firebasedatabase.app/"
        };

        IFirebaseClient client;

        private void ResetPassword_Load(object sender, EventArgs e)
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

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private async void Btn_ResetPW_Click(object sender, EventArgs e)
        {
            #region Condition
            if (string.IsNullOrWhiteSpace(RP_CurrentPassword.Text) &&
                string.IsNullOrWhiteSpace(RP_NewPassword.Text) &&
                string.IsNullOrWhiteSpace(RP_ReNewPassword.Text))
            {
                MessageBox.Show("Please Fill All the Fields");
                return;
            }
            #endregion

            FirebaseResponse res = client.Get(@"Admin/" + ID.Text);
            Admin RealUser = res.ResultAs<Admin>(); //Database result

            Admin CurUser = new Admin() //User given info
            {
                AName = RealUser.AName,
                AID = RealUser.AID,
                Gender = RealUser.Gender,
                AContact = RealUser.AContact,
                AEmail = RealUser.AEmail,
                APassword = RP_CurrentPassword.Text
            };

            if (Admin.IsEqualPassword(RealUser, CurUser))
            {
                if (RP_NewPassword.Text == RP_ReNewPassword.Text)
                {
                    var admin = new Admin
                    {
                        AName = RealUser.AName,
                        AID = RealUser.AID,
                        Gender = RealUser.Gender,
                        AContact = RealUser.AContact,
                        AEmail = RealUser.AEmail,
                        APassword = RP_NewPassword.Text
                    };

                    FirebaseResponse resetpw = await client.UpdateAsync("Admin/" + ID.Text, admin);
                    Admin reset = resetpw.ResultAs<Admin>();
                    MessageBox.Show("Password Successfully Changed!");

                    RP_CurrentPassword.Clear();
                    RP_NewPassword.Clear();
                    RP_ReNewPassword.Clear();

                }
                else if (RP_NewPassword.Text != RP_ReNewPassword.Text)
                {
                    MessageBox.Show("New Password & Confirm Password Should Same");
                }
            }
            else
            {
                Admin.ShowError();
            }
        }
    }
}
