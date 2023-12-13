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
    public partial class MainForm : System.Windows.Forms.Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Main_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Main_Exit_MouseEnter(object sender, EventArgs e)
        {
            Main_Exit.ForeColor = Color.Black;
        }

        private void Main_Exit_MouseLeave(object sender, EventArgs e)
        {
            Main_Exit.ForeColor = Color.DarkSlateBlue;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            progressBar.Increment(2);
            if(progressBar.Value == 100)
            {
                timer1.Enabled = false;
                LoginForm loginForm = new LoginForm();
                this.Hide();
                loginForm.Show();
            }
        }

    
    }
}
