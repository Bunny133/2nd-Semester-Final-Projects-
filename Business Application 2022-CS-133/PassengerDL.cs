using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace _2nd_semester_Final_Project
{


    class PassengerDL
    {
        public static List<Passenger> Ticketdata = new List<Passenger>();
        public static List<Passenger> Feedback = new List<Passenger>();

        private static List<Admin> Flightdata = new List<Admin>();
               


        public static Passenger GetPassport(int PassportNO)
        {
            foreach (Passenger item in Ticketdata)
            {
                if (PassportNO==item.Passport)
                {
                    return item;
                }
                
            }
            return null;
        }


        public static void AddTicketsIntoList(Passenger obj)
        {
            Ticketdata.Add(obj);
        }


        public static void StorePassenger(string path)
        {
            
            StreamWriter storePassenger = new StreamWriter(path,false);
            foreach (Passenger passenger in PassengerDL.Ticketdata)
            {
                storePassenger.WriteLine(passenger.Name + "," + passenger.Passport + "," + passenger.CellNumber + "," + passenger.CNIC + "," + passenger.Departure1 + "," + passenger.Destination1 + "," + passenger.ReserveSeats + "," + passenger.TravelType);
            }
            
            storePassenger.Flush();
            storePassenger.Close();

         

        }

 
        public static void LoadPassenger(string path)
        {
            if (File.Exists(path))
            {
                StreamReader storeUser = new StreamReader(path);
                string line;
                while ((line = storeUser.ReadLine()) != null)
                {
                    string[] splittedRecord = line.Split(',');

                    if (splittedRecord.Length == 8)
                    {
                       
                        string name = splittedRecord[0];
                        int passport = int.Parse(splittedRecord[1]);
                        int CellNumber=int.Parse(splittedRecord[2]);
                        int CNIC= int.Parse(splittedRecord[3]);
                        string Departrue = splittedRecord[4];
                        string Destination = splittedRecord[5];
                        int ReserveSeats= int.Parse(splittedRecord[6]);
                        string TravelType = splittedRecord[7];
                        Passenger passenger = new Passenger(name, passport, CellNumber, CNIC, Departrue, Destination, ReserveSeats, TravelType);


                       
                       Ticketdata.Add(passenger);
                    }
                    else
                    {
                        //MessageBox.Show("Invalid data in the file: " + line);
                    }
                }
                storeUser.Close();
            }
        }
    }
}
