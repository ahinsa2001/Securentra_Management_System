using System;
using System.Collections.Generic;
using Newtonsoft.Json;
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
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;

namespace Securentra_Management_System
{
    public partial class FormStaff : UserControl
    {
        public FormStaff()
        {
            InitializeComponent();
        }

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "ClOVtlKcXyNZP4W4Bvai2DgxtQLPcNWY417W0nk4",
            BasePath = "https://ntadb-95601-default-rtdb.asia-southeast1.firebasedatabase.app/"
        };

        IFirebaseClient client;

        private void FormStaff_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);

            FirebaseResponse res = client.Get(@"StaffList");
            Dictionary<string, Staff> data = JsonConvert.DeserializeObject<Dictionary<string, Staff>>(res.Body.ToString());
            PopulateDataGridView(data);
        }

        void PopulateDataGridView(Dictionary<string, Staff> record)
        {
            StaffDGV.Rows.Clear();
            StaffDGV.Columns.Clear();

            StaffDGV.Columns.Add("Owner ID", "Owner ID");
            StaffDGV.Columns.Add("SName", "Name");
            StaffDGV.Columns.Add("SPosition", "Position");
            StaffDGV.Columns.Add("SDepartment", "Department");
            StaffDGV.Columns.Add("SAccess", "Access");

            foreach (var item in record)
            {
                StaffDGV.Rows.Add(item.Value.OwnerID, item.Value.SName, item.Value.SPosition, item.Value.SDepartment, item.Value.SAccess);
            }
        }


        string Access;

        private async void BtnStaff_Add_Click(object sender, EventArgs e)
        {
            var staff = new Staff
            {
                OwnerID = Staff_CompID.Text,
                SName = Staff_Name.Text,
                SPosition = Staff_Position.Text,
                SDepartment = Staff_Department.Text,
                SAccess = Access
            };

            FirebaseResponse response = await client.SetAsync("StaffList/" + Staff_CompID.Text, staff);
            MessageBox.Show("New Staff Member Added");

            FirebaseResponse res = client.Get(@"StaffList");
            Dictionary<string, Staff> data = JsonConvert.DeserializeObject<Dictionary<string, Staff>>(res.Body.ToString());
            PopulateDataGridView(data);

            Staff_CompID.Clear();
            Staff_Name.Clear();
            Staff_Position.Clear();
            Staff_Department.Clear();
            Yes.Checked = false;
            No.Checked = false;
        }

        private void Yes_CheckedChanged(object sender, EventArgs e)
        {
            Access = "Yes";
        }

        private void No_CheckedChanged(object sender, EventArgs e)
        {
            Access = "No";
        }

        private async void BtnStaff_Delete_Click(object sender, EventArgs e)
        {
            FirebaseResponse responseDelete = await client.DeleteAsync("StaffList/" + Staff_CompID.Text);
            MessageBox.Show("Staff Member has been Deleted Successfully!");

            FirebaseResponse res = client.Get(@"StaffList");
            Dictionary<string, Staff> data = JsonConvert.DeserializeObject<Dictionary<string, Staff>>(res.Body.ToString());
            PopulateDataGridView(data);

            Staff_CompID.Clear();
            Staff_Name.Clear();
            Staff_Position.Clear();
            Staff_Department.Clear();
            Yes.Checked = false;
            No.Checked = false;
        }

        private void StaffDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private async void BtnStaff_Update_Click(object sender, EventArgs e)
        {
            var staff = new Staff
            {
                OwnerID = Staff_CompID.Text,
                SName = Staff_Name.Text,
                SPosition = Staff_Position.Text,
                SDepartment = Staff_Department.Text,
                SAccess = Access
            };

            FirebaseResponse responseUpdate = await client.UpdateAsync("StaffList/" + Staff_CompID.Text, staff);
            Staff updateStaff = responseUpdate.ResultAs<Staff>();
            MessageBox.Show("Staff Member Updated Successfully!");

            FirebaseResponse res = client.Get(@"StaffList");
            Dictionary<string, Staff> data = JsonConvert.DeserializeObject<Dictionary<string, Staff>>(res.Body.ToString());
            PopulateDataGridView(data);

            Staff_CompID.Clear();
            Staff_Name.Clear();
            Staff_Position.Clear();
            Staff_Department.Clear();
            Yes.Checked = false;
            No.Checked = false;

        }

        private async void BtnStaff_Search_Click(object sender, EventArgs e)
        {
            FirebaseResponse responseRetrive = await client.GetAsync("StaffList/" + Staff_CompID.Text);
            Staff obj = responseRetrive.ResultAs<Staff>();

            Staff_Name.Text = obj.SName;
            Staff_Position.Text = obj.SPosition;
            Staff_Department.Text = obj.SDepartment;
            Access = obj.SAccess;
            MessageBox.Show("Staff Member Retrived Successfully!");
        }

        private void export_MouseEnter(object sender, EventArgs e)
        {
            Export.ForeColor = Color.Red;
        }

        private void export_MouseHover(object sender, EventArgs e)
        {
            Export.ForeColor = Color.Gray;
        }

        private void export_Click(object sender, EventArgs e)
        {
            if (StaffDGV.Rows.Count > 0)
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
                                PdfPTable ptable = new PdfPTable(StaffDGV.Columns.Count);
                                ptable.DefaultCell.Padding = 2;
                                ptable.WidthPercentage = 100;
                                ptable.HorizontalAlignment = Element.ALIGN_LEFT;

                                foreach (DataGridViewColumn col in StaffDGV.Columns)
                                {
                                    PdfPCell pcell = new PdfPCell(new Phrase(col.HeaderText));
                                    ptable.AddCell(pcell);
                                } 
                                foreach (DataGridViewRow prow in StaffDGV.Rows)
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
