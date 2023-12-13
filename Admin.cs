using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Securentra_Management_System
{
    class Admin
    {
        public string AName { get; set; }

        public string AID { get; set; }

        public string Gender { get; set; }

        public string AContact { get; set; }

        public string AEmail { get; set; }

        public string APassword { get; set; }

        public string APhoto { get; set; }


        private static string error = "There was some error!";

        public static void ShowError()
        {
            MessageBox.Show(error);
        }

        public static bool IsEqual(Admin user1, Admin user2)
        {
            if(user1 == null || user2 == null){return false;}

            if(user1.AID != user2.AID)
            {
                error = "Username does not exist!";
                return false;
            }
            else if(user1.APassword != user2.APassword)
            {
                error = "Username & Password does not match!";
                return false;
            }

            return true;
        }

        public static bool IsEqualPassword(Admin user1, Admin user2)
        {
            if (user1 == null || user2 == null) { return false; }

            if (user1.APassword != user2.APassword)
            {
                error = "Doesn't Match with Your Current Password!";
                return false;
            }

            return true;
        }
    }
}
