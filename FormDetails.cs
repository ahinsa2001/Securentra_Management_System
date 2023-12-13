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
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace Securentra_Management_System
{
    public partial class FormDetails : UserControl
    {
        public FormDetails()
        {
            InitializeComponent();
        }

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "ClOVtlKcXyNZP4W4Bvai2DgxtQLPcNWY417W0nk4",
            BasePath = "https://ntadb-95601-default-rtdb.asia-southeast1.firebasedatabase.app/"
        };

        IFirebaseClient client;

        private void FormDetails_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(config);
            }
            catch
            {
                MessageBox.Show("No Internet or Connection Problem");
            }
            /*
            FirebaseResponse res1 = client.Get(@"EntranceRec");
            Dictionary<string, EntranceRec> data1 = JsonConvert.DeserializeObject<Dictionary<string, EntranceRec>>(res1.Body.ToString());
            PopulateDataGridView(data1);
            */
            //

            FirebaseResponse response = client.Get(@"Counter/");
            int Counter = int.Parse(response.ResultAs<string>());

            DetailsDGV.Rows.Clear();
            DetailsDGV.Columns.Clear();

            DetailsDGV.Columns.Add("NumberPlate", "NumberPlate");
            DetailsDGV.Columns.Add("OwnerID", "OwnerID");
            DetailsDGV.Columns.Add("Date", "Date");
            DetailsDGV.Columns.Add("Time", "Time");

            for (int i=1;  i<= Counter; i++)
            {
                FirebaseResponse response1 = client.Get(@"RecList/" + i + "/NumberPlate");
                string NumberPlate = response1.ResultAs<string>();

                FirebaseResponse response01 = client.Get(@"EntranceRec/" + NumberPlate);
                EntranceRec entry = response01.ResultAs<EntranceRec>();

                DetailsDGV.Rows.Add(entry.NumberPlate, entry.OwnerID, entry.Date, entry.Time);   
            }


        }

        void PopulateDataGridView(Dictionary<string, EntranceRec> rec)
        {
            DetailsDGV.Rows.Clear();
            DetailsDGV.Columns.Clear();

            DetailsDGV.Columns.Add("NumberPlate", "NumberPlate");
            DetailsDGV.Columns.Add("OwnerID", "OwnerID");
            DetailsDGV.Columns.Add("Date", "Date");
            DetailsDGV.Columns.Add("Time", "Time");

            foreach (var item in rec)
            {
                DetailsDGV.Rows.Add(item.Value.NumberPlate, item.Value.OwnerID, item.Value.Date, item.Value.Time);
            }
        }

        void FilterNmuberPlateDataGridView(Dictionary<string, EntranceRec> rec)
        {
            DetailsDGV.Rows.Clear();
            DetailsDGV.Columns.Clear();

            DetailsDGV.Columns.Add("NumberPlate", "NumberPlate");
            DetailsDGV.Columns.Add("OwnerID", "OwnerID");
            DetailsDGV.Columns.Add("Date", "Date");
            DetailsDGV.Columns.Add("Time", "Time");

            foreach (var item in rec)
            {
                DetailsDGV.Rows.Add(item.Value.NumberPlate, item.Value.OwnerID, item.Value.Date, item.Value.Time);
            }
        }

        private void FilterPlateNum_Click(object sender, EventArgs e)
        {
            DetailsDGV.Rows.Clear();
            DetailsDGV.Columns.Clear();

            DetailsDGV.Columns.Add("NumberPlate", "NumberPlate");
            DetailsDGV.Columns.Add("OwnerID", "OwnerID");
            DetailsDGV.Columns.Add("Date", "Date");
            DetailsDGV.Columns.Add("Time", "Time"); 

            FirebaseResponse response2 = client.Get(@"Counter/");
            int Counter = int.Parse(response2.ResultAs<string>());

            for (int i = 1; i <= Counter; i++)
            {
                FirebaseResponse response3 = client.Get(@"RecList/" + i + "/NumberPlate");
                string NumberPlate = response3.ResultAs<string>();

                if (plateno.Text == NumberPlate)
                {

                    FirebaseResponse response4 = client.Get(@"EntranceRec/" + NumberPlate);
                    EntranceRec entry1 = response4.ResultAs<EntranceRec>();
                                                  
                    DetailsDGV.Rows.Add(entry1.NumberPlate, entry1.OwnerID, entry1.Date, entry1.Time);
                                   
                }
            }

        }

        private void FilterOwner_Click(object sender, EventArgs e)
        {
            DetailsDGV.Rows.Clear();
            DetailsDGV.Columns.Clear();

            DetailsDGV.Columns.Add("OwnerID", "OwnerID");
            DetailsDGV.Columns.Add("NumberPlate", "NumberPlate");
            DetailsDGV.Columns.Add("Date", "Date");
            DetailsDGV.Columns.Add("Time", "Time");

            FirebaseResponse response5 = client.Get(@"Counter/");
            int Counter = int.Parse(response5.ResultAs<string>());

            for (int i = 1; i <= Counter; i++)
            {
                FirebaseResponse response6 = client.Get(@"RecList/" + i + "/NumberPlate");
                string NumberPlate = response6.ResultAs<string>();

                FirebaseResponse response7 = client.Get(@"EntranceRec/" + NumberPlate);
                EntranceRec entry2 = response7.ResultAs<EntranceRec>();

                if (owner.Text == entry2.OwnerID)
                {
                    DetailsDGV.Rows.Add(entry2.OwnerID, entry2.NumberPlate, entry2.Date, entry2.Time);
                }
            }
        }

        private void export_Click(object sender, EventArgs e)
        {
            if(DetailsDGV.Rows.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF (*.pdf|*.pdf)";
                save.FileName = "Result";
                bool ErrorMessage = false;
                if(save.ShowDialog()==DialogResult.OK)
                {
                    if (File.Exists(save.FileName))
                    {
                        try
                        {
                            File.Delete(save.FileName);
                        }
                        catch(Exception ex)
                        {
                            ErrorMessage = true;
                            MessageBox.Show("Unable Export Data" + ex.Message);
                        }

                        if (!ErrorMessage)
                        {
                            try
                            {
                                PdfPTable ptable = new PdfPTable(DetailsDGV.Columns.Count);
                                ptable.DefaultCell.Padding = 2;
                                ptable.WidthPercentage = 100;
                                ptable.HorizontalAlignment = Element.ALIGN_LEFT;

                                foreach (DataGridViewColumn col in DetailsDGV.Columns)
                                {
                                    PdfPCell pcell = new PdfPCell(new Phrase(col.HeaderText));
                                    ptable.AddCell(pcell);
                                }
                                foreach (DataGridViewRow prow in DetailsDGV.Rows)
                                {
                                    foreach (DataGridViewCell cell in prow.Cells)
                                    {
                                        ptable.AddCell(cell.Value.ToString());
                                    }
                                }

                                using (FileStream fileStream = new FileStream(save.FileName,FileMode.Create)) 
                                {
                                    Document document = new Document(PageSize.A4, 8f, 16f, 16f, 8f);
                                    document.Open();
                                    document.Add(ptable);
                                    document.Close();
                                    fileStream.Close();
                                }

                                MessageBox.Show("Data Export Successfully!","Info");
                            }
                            catch(Exception ex)
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

        private void FilterDate_Click(object sender, EventArgs e)
        {
            DetailsDGV.Rows.Clear();
            DetailsDGV.Columns.Clear();

            DetailsDGV.Columns.Add("Date", "Date");
            DetailsDGV.Columns.Add("NumberPlate", "NumberPlate");
            DetailsDGV.Columns.Add("OwnerID", "OwnerID");
            DetailsDGV.Columns.Add("Time", "Time");

            FirebaseResponse response8 = client.Get(@"Counter/");
            int Counter = int.Parse(response8.ResultAs<string>());

            for (int i = 1; i <= Counter; i++)
            {
                FirebaseResponse response9 = client.Get(@"RecList/" + i + "/NumberPlate");
                string NumberPlate = response9.ResultAs<string>();

                FirebaseResponse response10 = client.Get(@"EntranceRec/" + NumberPlate);
                EntranceRec entry3 = response10.ResultAs<EntranceRec>();

                if (date.Text == entry3.Date)
                {
                    DetailsDGV.Rows.Add(entry3.Date, entry3.NumberPlate, entry3.OwnerID, entry3.Time);
                }
            }
        }
    }
}
