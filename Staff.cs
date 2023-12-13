using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Securentra_Management_System
{
    public class Staff
    {
        public string OwnerID { get; set; }
        public string SName { get; set; }
        public string SPosition { get; set; }
        public string SDepartment { get; set; }
        public string SAccess { get; set; }

        private static string error = "There was some error!";


        public static void ShowError()
        {
            MessageBox.Show(error);
        }

        public static bool IsEqual(Staff user1, Staff user2)
        {
            if (user1 == null || user2 == null) { return false; }

            if (user1.OwnerID != user2.OwnerID)
            {
                error = "Member Not Found!";
                return false;
            }
            else if (user1.OwnerID == user2.OwnerID)
            {
                return true;
            }

            return true;
        }
    }
}
