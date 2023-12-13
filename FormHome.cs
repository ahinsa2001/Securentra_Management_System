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

using Patagames.Ocr;
using System.Threading;

namespace Securentra_Management_System
{

    public partial class FormHome : UserControl
    {

        public FormHome()
        {
            InitializeComponent();

        }

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "ClOVtlKcXyNZP4W4Bvai2DgxtQLPcNWY417W0nk4",
            BasePath = "https://ntadb-95601-default-rtdb.asia-southeast1.firebasedatabase.app/"
        };

        IFirebaseClient client;

        private void FormHome_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(config);
            }
            catch
            {
                MessageBox.Show("No Internet or Connection Problem");
            }

            timer1.Start();
        }

        string picPath;
        private void Btn_Input_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.Filter = "Image files(*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png|All files(*.*)|*.*";

            if (od.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(od.FileName);

                picPath = od.FileName.ToString();
                pictureBox1.ImageLocation = picPath;
            }
        }

        private void ExtractTextBtn_Click(object sender, EventArgs e)
        {
            using (var objOcr = OcrApi.Create())
            {
                objOcr.Init(Patagames.Ocr.Enums.Languages.English);
                string plainText = objOcr.GetTextFromImage(pictureBox1.ImageLocation);
                extractText.Text = plainText;               
            } 
        }
       
        private async void AcessBtn_Click(object sender, EventArgs e)
        {
            FirebaseResponse responseRetrive = await client.GetAsync("Vehicle/" + extractText.Text);
            Vehicle Realvehicle = responseRetrive.ResultAs<Vehicle>(); //Database Result

            Vehicle CurVehicle = new Vehicle() //Detected Plate Number
            {
                NumberPlate = extractText.Text,
            };

            if (Vehicle.IsEqual(Realvehicle, CurVehicle))
            {

                FirebaseResponse response = await client.GetAsync("StaffList/" + Realvehicle.OwnerID);
                Staff obj = response.ResultAs<Staff>(); //Database Result

                if (obj.SAccess == "Yes") //Check Staff Member can access or not
                {
                    /*
                    var entranceRec = new EntranceRec
                    {
                        NumberPlate = extractText.Text,
                        OwnerID = Realvehicle.OwnerID,
                        Date = Date.Text,
                        Time = Time.Text
                    };

                    FirebaseResponse respon = await client.SetAsync("EntranceRec/" + extractText.Text, entranceRec);
                    MessageBox.Show("Entrance Record Saved!");
                    */
                    //
                    #region entranceRec
                    EntranceRec entrance = new EntranceRec
                    {
                        NumberPlate = extractText.Text,
                        OwnerID = Realvehicle.OwnerID,
                        Date = Date.Text,
                        Time = Time.Text
                    };
                    var set = client.Set(@"EntranceRec/" + extractText.Text, entrance);
                    #endregion
                    FirebaseResponse response2 = client.Get(@"Counter/");
                    int Counter = int.Parse(response2.ResultAs<string>());

                    RecList list = new RecList()
                    {
                        NumberPlate = extractText.Text
                    };

                    var set2 = client.Set(@"Counter", ++Counter);
                    var set3 = client.Set("RecList/" + Counter, list);

                    //
                    AccessCheckingForm check = new AccessCheckingForm(extractText.Text, Date.Text, Time.Text, Realvehicle.OwnerID, "ACCESS SUCCESSFULLY");
                    check.Show();
                }
                else
                {
                    MessageBox.Show("Can not Access!","Warning");
                    AccessCheckingForm check = new AccessCheckingForm(extractText.Text, Date.Text, Time.Text, Realvehicle.OwnerID, "ACCESS DENIED");
                    check.Show();
                }
            }
            else
            {
                AccessCheckingForm check = new AccessCheckingForm(extractText.Text, Date.Text, Time.Text, "Not Found", "ACCESS DENIED");
                check.Show();
            }
            extractText.Clear();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Time.Text = DateTime.Now.ToShortTimeString();
            Date.Text = DateTime.Now.ToShortDateString();
        }

        private void AcessBtn_MouseEnter(object sender, EventArgs e)
        {
            AcessBtn.ForeColor = Color.Red;
        }

        private void AcessBtn_MouseHover(object sender, EventArgs e)
        {
            AcessBtn.ForeColor = Color.Gray;
        }
    }
}
