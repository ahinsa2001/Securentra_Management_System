using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Linq.Expressions;
using System.Threading;

using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using FireSharp;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;

namespace Securentra_Management_System
{
    public partial class FormVehicle : UserControl
    {
        public FormVehicle()
        {
            InitializeComponent();
        }

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "ClOVtlKcXyNZP4W4Bvai2DgxtQLPcNWY417W0nk4",
            BasePath = "https://ntadb-95601-default-rtdb.asia-southeast1.firebasedatabase.app/"
        };

        IFirebaseClient client;

        private void FormVehicle_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
           
            FirebaseResponse res = client.Get(@"Vehicle");
            Dictionary<string, Vehicle> data = JsonConvert.DeserializeObject<Dictionary<string, Vehicle>>(res.Body.ToString());
            PopulateDataGridView(data);
          
        }

        void PopulateDataGridView(Dictionary<string, Vehicle> rec)
        {
            VehicleDGV.Rows.Clear();
            VehicleDGV.Columns.Clear();

            VehicleDGV.Columns.Add("Number Plate" , "Number Plate");
            VehicleDGV.Columns.Add("Vehicle Type" , "Vehicle Type");
            VehicleDGV.Columns.Add("Vehicle Model" , "Vehicle Model");
            VehicleDGV.Columns.Add("Owner ID" , "Owner ID");

            foreach (var item in rec)
            {
                VehicleDGV.Rows.Add(item.Value.NumberPlate, item.Value.VehicleType, item.Value.VehicleModel, item.Value.OwnerID);
            }
  
        }

        private async void BtnVehicle_Add_Click(object sender, EventArgs e)
        {
            FirebaseResponse responseRetrive = await client.GetAsync("StaffList/" + OwnerID.Text);
            Staff Real = responseRetrive.ResultAs<Staff>(); //Database Result

            Staff Current = new Staff() //Check Staff Member If exist or not
            {
                OwnerID = OwnerID.Text,
            };

            if (Staff.IsEqual(Real, Current))
            {
                var vehicle = new Vehicle
                {
                    NumberPlate = NumberPlate.Text,
                    VehicleModel = VehicleModel.Text,
                    VehicleType = VehicleType.Text,
                    OwnerID = OwnerID.Text
                };

                FirebaseResponse response = await client.SetAsync("Vehicle/" + NumberPlate.Text, vehicle);
                MessageBox.Show("New Vehicle Added");

                FirebaseResponse res = client.Get(@"Vehicle");
                Dictionary<string, Vehicle> data = JsonConvert.DeserializeObject<Dictionary<string, Vehicle>>(res.Body.ToString());
                PopulateDataGridView(data);

                NumberPlate.Clear();
                VehicleType.Clear();
                VehicleModel.Clear();
                OwnerID.Clear();

            }
            else
            {
                MessageBox.Show("Member Not Found! Check the ID Number Again!");
            }
        }

        private void VehicleDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private async void BtnVehicle_Delete_Click(object sender, EventArgs e)
        {
            FirebaseResponse responseDelete = await client.DeleteAsync("Vehicle/" + NumberPlate.Text);
            MessageBox.Show("Vehicle has been Deleted Successfully!");

            FirebaseResponse res = client.Get(@"Vehicle");
            Dictionary<string, Vehicle> data = JsonConvert.DeserializeObject<Dictionary<string, Vehicle>>(res.Body.ToString());
            PopulateDataGridView(data);

            NumberPlate.Clear();
            VehicleType.Clear();
            VehicleModel.Clear();
            OwnerID.Clear();
        }

        private async void BtnVehicle_Update_Click(object sender, EventArgs e)
        {
            var vehicle = new Vehicle
            {
                NumberPlate = NumberPlate.Text,
                VehicleModel = VehicleModel.Text,
                VehicleType = VehicleType.Text,
                OwnerID = OwnerID.Text
            };

            FirebaseResponse responseUpdate = await client.UpdateAsync("Vehicle/" + NumberPlate.Text, vehicle);
            Vehicle updateVehicle = responseUpdate.ResultAs<Vehicle>();
            MessageBox.Show("Vehicle Updated Successfully!");

            FirebaseResponse res = client.Get(@"Vehicle");
            Dictionary<string, Vehicle> data = JsonConvert.DeserializeObject<Dictionary<string, Vehicle>>(res.Body.ToString());
            PopulateDataGridView(data);

            NumberPlate.Clear();
            VehicleType.Clear();
            VehicleModel.Clear();
            OwnerID.Clear();
        }

        private async void BtnVehicle_Search_Click(object sender, EventArgs e)
        {
            try
            {
                FirebaseResponse responseRetrive = await client.GetAsync("Vehicle/" + NumberPlate.Text);
                Vehicle obj = responseRetrive.ResultAs<Vehicle>();

                VehicleModel.Text = obj.VehicleModel;
                VehicleType.Text = obj.VehicleType;
                OwnerID.Text = obj.OwnerID;
                MessageBox.Show("Vehicle Retrived Successfully!");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Vehicle Not Found!");
            }
        }

        private void export_MouseEnter(object sender, EventArgs e)
        {
            export.ForeColor = Color.Red;
        }

        private void export_MouseHover(object sender, EventArgs e)
        {
            export.ForeColor = Color.Gray;
        }

        private void export_Click(object sender, EventArgs e)
        {
            if (VehicleDGV.Rows.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF (*.pdf|*.pdf)";
                save.FileName = "Result";
                bool ErrorMessage = false;
                if (save.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(save.FileName))
                    {
                        try
                        {
                            File.Delete(save.FileName);
                        }
                        catch (Exception ex)
                        {
                            ErrorMessage = true;
                            MessageBox.Show("Unable Export Data" + ex.Message);
                        }

                        if (!ErrorMessage)
                        {
                            try
                            {
                                PdfPTable ptable = new PdfPTable(VehicleDGV.Columns.Count);
                                ptable.DefaultCell.Padding = 2;
                                ptable.WidthPercentage = 100;
                                ptable.HorizontalAlignment = Element.ALIGN_LEFT;

                                foreach (DataGridViewColumn col in VehicleDGV.Columns)
                                {
                                    PdfPCell pcell = new PdfPCell(new Phrase(col.HeaderText));
                                    ptable.AddCell(pcell);
                                }
                                foreach (DataGridViewRow prow in VehicleDGV.Rows)
                                {
                                    foreach (DataGridViewCell cell in prow.Cells)
                                    {
                                        ptable.AddCell(cell.Value.ToString());
                                    }
                                }

                                using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))
                                {
                                    Document document = new Document(PageSize.A4, 8f, 16f, 16f, 8f);
                                    document.Open();
                                    document.Add(ptable);
                                    document.Close();
                                    fileStream.Close();
                                }

                                MessageBox.Show("Data Export Successfully!", "Info");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error While Exporting Data!");
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record Found!");
            }
        }
    }
    
}
