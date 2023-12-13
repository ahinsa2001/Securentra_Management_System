using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace Securentra_Management_System
{
    public partial class Dashboard : Form
    {

        public Dashboard(string user)
        {
            InitializeComponent();
            remind.Text = user;
        }

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "ClOVtlKcXyNZP4W4Bvai2DgxtQLPcNWY417W0nk4",
            BasePath = "https://ntadb-95601-default-rtdb.asia-southeast1.firebasedatabase.app/"
        };

        IFirebaseClient client;

        private void Dashboard_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(config);
            }
            catch
            {
                MessageBox.Show("No Internet or Connection Problem");
            }
            FormHome Home = new FormHome();
            MainControlClass.showControl(Home, panelContainer);

            try
            {
                FirebaseResponse res = client.Get(@"Admin/" + remind.Text);
                Admin admin = res.ResultAs<Admin>();
                name.Text = admin.AName;
                byte[] b = Convert.FromBase64String(admin.APhoto);
                MemoryStream m = new MemoryStream();
                m.Write(b, 0, Convert.ToInt32(b.Length));
                Bitmap bmp = new Bitmap(m, false);
                m.Dispose();
                UserPic.Image = bmp;
            }
            catch
            {
                MessageBox.Show("Profile Picture Not Found!");
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button_Home_Click(object sender, EventArgs e)
        {
            FormHome Home = new FormHome();
            MainControlClass.showControl(Home, panelContainer);
        }

        private void Button_Vehicle_Click(object sender, EventArgs e)
        {
            FormVehicle Vehicle = new FormVehicle();
            MainControlClass.showControl(Vehicle, panelContainer);
        }

        private void Button_Staff_Click(object sender, EventArgs e)
        {
            FormStaff Staff = new FormStaff();
            MainControlClass.showControl(Staff, panelContainer);
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

        private void Button_Settings_Click(object sender, EventArgs e)
        {
            FormSettings settings = new FormSettings(remind.Text);
            MainControlClass.showControl(settings, panelContainer);
        }

        private void Button_Details_Click(object sender, EventArgs e)
        {
            FormDetails formDetails = new FormDetails();
            MainControlClass.showControl(formDetails, panelContainer);
        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
