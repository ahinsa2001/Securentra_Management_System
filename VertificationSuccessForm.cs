using circle_progressbar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Securentra_Management_System
{
    public partial class VertificationSuccessForm : Form
    {
        public VertificationSuccessForm(string user)
        {
            InitializeComponent();
            remind.Text = user;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            cpb.Increment(2);
            if (cpb.Value == 100)
            {
                timer1.Stop();
                Dashboard db = new Dashboard(remind.Text);
                this.Hide();
                db.Show();
            }
        }

    }
    
}
