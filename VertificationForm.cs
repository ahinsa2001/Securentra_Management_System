using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FireSharp.Response;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp;
using FluentEmail.Core;

namespace Securentra_Management_System
{
    public partial class VertificationForm : Form
    {

        string randomcode;

        public VertificationForm(string user)
        {
            InitializeComponent();
            remind.Text = user;
        }

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "ClOVtlKcXyNZP4W4Bvai2DgxtQLPcNWY417W0nk4",
            BasePath = "https://ntadb-95601-default-rtdb.asia-southeast1.firebasedatabase.app/"
        };

        IFirebaseClient Clients;

        private void Vertify_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Vertify_Exit_MouseEnter(object sender, EventArgs e)
        {
            Vertify_Exit.ForeColor = Color.Black;
        }

        private void Vertify_Exit_MouseLeave(object sender, EventArgs e)
        {
            Vertify_Exit.ForeColor = Color.DarkSlateBlue;
        }

        private void Label_ResendOTP_MouseHover(object sender, EventArgs e)
        {
            Label_ResendOTP.ForeColor = Color.Red;
        }

        private void Label_ResendOTP_MouseLeave(object sender, EventArgs e)
        {
            Label_ResendOTP.ForeColor = Color.DarkSlateBlue;
        }

        private void Button_Vertify_Click(object sender, EventArgs e)
        {
            if(randomcode == (TextBox_VertifyOTP.Text).ToString())
            {
                VertificationSuccessForm verSuccess = new VertificationSuccessForm(remind.Text);
                this.Hide();
                verSuccess.Show();
            }
            else
            {
                MessageBox.Show("Invalid OTP!");
                TextBox_VertifyOTP.Clear();
            }

        }


        int term = 0;
        private async void Label_ResendOTP_Click(object sender, EventArgs e)
        {
            TextBox_VertifyOTP.Clear();
            Random rand = new Random();
            randomcode = (rand.Next(999999)).ToString();

            SmtpClient Client = new SmtpClient()
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential()
                {
                    UserName = "securentrasystem@gmail.com",
                    Password = "fhlbacvrcfdktrmm"
                }

            };

            FirebaseResponse responseRetrive = await Clients.GetAsync("Admin/" + remind.Text);
            Admin obj = responseRetrive.ResultAs<Admin>();
            email.Text = obj.AEmail;
            MailAddress FromMail = new MailAddress("securentrasystem@gmail.com", "Securentra");
            MailAddress ToMail = new MailAddress(email.Text, obj.AName);
            MailMessage mailMessage = new MailMessage()
            {
                From = FromMail,
                Subject = "Securentra Account Vertification Code",
                Body = $"Your Account Vertification Code is {randomcode}",
            };
            mailMessage.To.Add(ToMail);

            try
            {
                if (term < 3)
                {
                    Client.Send(mailMessage);
                    MessageBox.Show("OTP Send Successfully! Check Your Email");
                    term++;
                }
                else
                {
                    MessageBox.Show("Resend OTP over 3 times So you can't Access Now!", "Error");
                    LoginForm login = new LoginForm();
                    this.Hide();
                    login.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void VertificationForm_Load(object sender, EventArgs e)
        {
            try
            {
                Clients = new FireSharp.FirebaseClient(config);
            }
            catch
            {
                MessageBox.Show("No Internet or Connection Problem");
            }

            Random rand = new Random();
            randomcode = (rand.Next(999999)).ToString();

            SmtpClient Client = new SmtpClient()
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential()
                {
                    UserName = "securentrasystem@gmail.com",
                    Password = "fhlbacvrcfdktrmm"
                }

            };

            FirebaseResponse responseRetrive = await Clients.GetAsync("Admin/" + remind.Text);
            Admin obj = responseRetrive.ResultAs<Admin>();
            email.Text = obj.AEmail;
            MailAddress FromMail = new MailAddress("securentrasystem@gmail.com", "Securentra");
            MailAddress ToMail = new MailAddress(email.Text, obj.AName);
            MailMessage mailMessage = new MailMessage()
            {
                From = FromMail,
                Subject = "Securentra Account Vertification Code",
                Body = $"Your Account Vertification Code is {randomcode}",
            };
            mailMessage.To.Add(ToMail);
            try
            {
                Client.Send(mailMessage);
                MessageBox.Show("OTP Send Successfully! Check Your Email");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

    }
}
