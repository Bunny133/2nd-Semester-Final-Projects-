using System;
using System.IO;
using System.Collections.Generic;

namespace _2nd_semester_Final_Project
{
    class PassengerUI
    {

    


        public static bool CancelReservation(string path, int Passportno)
        {
            
            Passenger flight = PassengerDL.GetPassport(Passportno);
            bool flag = true;
            if (flight != null)
            {
                int index = PassengerDL.Ticketdata.IndexOf(flight);
                PassengerDL.Ticketdata.RemoveAt(index);
                PassengerDL.StorePassenger(path);  
               // MessageBox.Show(flight.CompanyName);

            }
            else
            {
                flag = false;
                //MessageBox.Show("Flight Not Removed");
            }
            return flag;

        }











    }
}
