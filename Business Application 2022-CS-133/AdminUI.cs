using System;
using System.Windows.Forms;

namespace _2nd_semester_Final_Project
{
    class AdminUI 
    {
      

        public static bool RemoveFlight(string path, int no)
        {
            Admin flight = AdminDL.getFlight(no);
            bool flag = true;
            if (flight != null)
            {
                int index = AdminDL.Flightdata.IndexOf(flight);
                AdminDL.Flightdata.RemoveAt(index);
                AdminDL.StoreFlight(path);
                MessageBox.Show(flight.CompanyName);

            }
            else
            {
                flag = false;
                MessageBox.Show("Flight Not Removed");
            }
            return flag;

        }



    }
}
