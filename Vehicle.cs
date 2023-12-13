using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Securentra_Management_System
{
    public class Vehicle
    {
        public string NumberPlate { get; set; }

        public string VehicleModel { get; set; }

        public string VehicleType { get; set; }

        public string OwnerID { get; set; }

        private static string error = "There was some error!";

        public static void ShowError()
        {
            MessageBox.Show(error);
        }

        public static bool IsEqual(Vehicle user1, Vehicle user2)
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
