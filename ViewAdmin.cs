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
using Newtonsoft.Json;

namespace Securentra_Management_System
{
    public partial class ViewAdmin : Form
    {
        public ViewAdmin()
        {
            InitializeComponent();
        }

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "ClOVtlKcXyNZP4W4Bvai2DgxtQLPcNWY417W0nk4",
            BasePath = "https://ntadb-95601-default-rtdb.asia-southeast1.firebasedatabase.app/"
        };

        IFirebaseClient client;

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

        private void ViewAdmin_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);

            FirebaseResponse res = client.Get(@"Admin");
            Dictionary<string, Admin> data = JsonConvert.DeserializeObject<Dictionary<string, Admin>>(res.Body.ToString());
            PopulateDataGridView(data);
        }

        void PopulateDataGridView(Dictionary<string, Admin> rec)
        {
            AdminDGV.Rows.Clear();
            AdminDGV.Columns.Clear();

            AdminDGV.Columns.Add("AName", "AName");
            AdminDGV.Columns.Add("AID", "AID");
            AdminDGV.Columns.Add("Gender", "Gender");
            AdminDGV.Columns.Add("AContact", "AContact");
            AdminDGV.Columns.Add("AEmail", "AEmail");

            foreach (var item in rec)
            {
                AdminDGV.Rows.Add(item.Value.AName, item.Value.AID, item.Value.Gender, item.Value.AContact, item.Value.AEmail);
            }
        }
    }
}
