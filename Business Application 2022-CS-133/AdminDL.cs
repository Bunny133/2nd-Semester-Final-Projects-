using System;
using System.Collections.Generic;
using System.IO;
namespace _2nd_semester_Final_Project
{
    class AdminDL
    {
        public static List<Admin> Flightdata = new List<Admin>();
       
        public static Admin admin;
      

        public static Admin getFlight(int flightNo)
        {
            foreach (Admin item in Flightdata)
            {
                if (flightNo == item.FlightNumber)
                {
                    return item;
                }
            }
            return null;
        }

       

     
        public static void AddFlightIntoTheList(Admin s)
        {
            Flightdata.Add(s);
        }

        public static void StoreFlight(string path)
        {
            StreamWriter store = new StreamWriter(path);
            foreach (Admin user in Flightdata)
            {
                store.WriteLine(user.FlightNumber + "," + user.CompanyName + "," + user.Departure + 
                      "," + user.FlightArival + "," + user.DepartureDate + "," + user.DepartureTime);
            }
            store.Flush();
            store.Close();
        }

        public static void LoadFlight(string path)
        {
            if (File.Exists(path))
            {
                StreamReader storeFlight = new StreamReader(path);
                string line;

                while ((line = storeFlight.ReadLine()) != null)
                {
                   
                    string[] splittedRecord = line.Split(',');
                    int flightnumber = int.Parse(splittedRecord[0]);
                    string companyName = splittedRecord[1];
                    string departure = splittedRecord[2];
                    string destination = splittedRecord[3];
                    string date = splittedRecord[4];
                    string time = splittedRecord[5];
                    Admin newUser = new Admin(flightnumber, companyName, departure, destination, date, time);
           
                    AddFlightIntoTheList(newUser);
                }

                storeFlight.Close();
            }
        }






    }
}
