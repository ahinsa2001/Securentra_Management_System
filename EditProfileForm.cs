using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace Securentra_Management_System
{
    public partial class EditProfileForm : Form
    {
        public EditProfileForm(string user)
        {
            InitializeComponent();
            username.Text = user;
        }

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "ClOVtlKcXyNZP4W4Bvai2DgxtQLPcNWY417W0nk4",
            BasePath = "https://ntadb-95601-default-rtdb.asia-southeast1.firebasedatabase.app/"
        };

        IFirebaseClient client;

        private void EditProfileForm_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(config);
            }
            catch
            {
                MessageBox.Show("No Internet or Connection Problem");
            }

            FirebaseResponse res = client.Get(@"Admin/" + username.Text);
            Admin admin = res.ResultAs<Admin>();

            name.Text = admin.AName;
            Contactno.Text = admin.AContact;
            email.Text = admin.AEmail;

            //Retreive Image from firebase
            byte[] b = Convert.FromBase64String(admin.APhoto);
            MemoryStream m = new MemoryStream();
            m.Write(b, 0, Convert.ToInt32(b.Length));
            Bitmap bmp = new Bitmap(m, false);
            m.Dispose();
            userDp.Image = bmp;
        }

        private void UploadBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.Title = "Select Image";
            od.Filter = "Image files(*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png|All files(*.*)|*.*";

            if(od.ShowDialog() == DialogResult.OK)
            {
                userDp.Image = new Bitmap(od.FileName);
            }
        }

        private async void Save_Click(object sender, EventArgs e)
        {
            FirebaseResponse res = client.Get(@"Admin/" + username.Text);
            Admin admin = res.ResultAs<Admin>();

            MemoryStream ms = new MemoryStream();
            userDp.Image.Save(ms, ImageFormat.Jpeg);
            byte[] a = ms.GetBuffer();
            string outputImg = Convert.ToBase64String(a);

            var myadmin = new Admin
            {
                AName = admin.AName,
                AID = admin.AID,
                Gender = admin.Gender,
                AContact = Contactno.Text,
                AEmail = email.Text,
                APassword = admin.APassword,
                APhoto = outputImg
            };

            FirebaseResponse save = await client.UpdateAsync("Admin/" + username.Text, myadmin);
            Admin edit = save.ResultAs<Admin>();
            MessageBox.Show("Saved");

            this.Close();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
