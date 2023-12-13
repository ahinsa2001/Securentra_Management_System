using Emgu.CV.Bioinspired;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Securentra_Management_System
{
    public partial class AccessCheckingForm : Form
    {
        public AccessCheckingForm(string platenumber, string date, string time, string owner, string accessStatus)
        {
            InitializeComponent();
            Date.Text = date;
            Time.Text = time;
            num.Text = platenumber;
            ownerId.Text = owner;
            accessTag.Text = accessStatus;
        }

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "ClOVtlKcXyNZP4W4Bvai2DgxtQLPcNWY417W0nk4",
            BasePath = "https://ntadb-95601-default-rtdb.asia-southeast1.firebasedatabase.app/"
        };

        IFirebaseClient client;

        private void AccessCheckingForm_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(config);
            }
            catch
            {
                MessageBox.Show("No Internet or Connection Problem");
            }

            if(accessTag.Text == "ACCESS SUCCESSFULLY")
            {
                accessTag.ForeColor = Color.Green;
            }
            else if(accessTag.Text == "ACCESS DENIED")
            {
                accessTag.ForeColor = Color.Red;
            }
            
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
