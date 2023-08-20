using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2nd_semester_Final_Project
{
     class Admin : Credentials
    {
        private int flightNumber;
        private string companyName;
        private string departure;
        private string flightArival;
        private string departureTime;
        private string departureDate;
       

        public int FlightNumber { get => flightNumber; set => flightNumber = value; }
        public string CompanyName { get => companyName; set => companyName = value; }
        public string Departure { get => departure; set => departure = value; }
        public string FlightArival { get => flightArival; set => flightArival = value; }
        public string DepartureTime { get => departureTime; set => departureTime = value; }
        public string DepartureDate { get => departureDate; set => departureDate = value; }

        public Admin(int FlightNumber, string CompanyName, string Departure, string FlightArival, string DepartureTime, string DepartureDate)
        {
            this.FlightNumber = FlightNumber;
            this.CompanyName = CompanyName;
            this.Departure = Departure;
            this.DepartureDate = DepartureDate;
            this.DepartureTime = DepartureTime;
            this.FlightArival = FlightArival;
        }

        

       
    }
}
