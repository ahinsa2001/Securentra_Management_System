using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Securentra_Management_System
{
    internal class EntranceRec
    {
        public string NumberPlate { get; set; }

        public string OwnerID { get; set; }

        public string Date { get; set; }

        public string Time { get; set; }

        private static string error = "There was some error!";

        public static void ShowError()
        {
            MessageBox.Show(error);
        }

        public static bool IsEqual(EntranceRec user1, EntranceRec user2)
        {
            if (user1 == null || user2 == null) { return false; }

            if (user1.NumberPlate != user2.NumberPlate)
            {
                error = "Number Plate does not Exist!";
                return false;
            }
            else if (user1.NumberPlate == user2.NumberPlate)
            {
                return true;
            }

            return true;
        }
    }
}
