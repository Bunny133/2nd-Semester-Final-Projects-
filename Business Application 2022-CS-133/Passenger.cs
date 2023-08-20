using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2nd_semester_Final_Project
{
    class Passenger : Credentials
    {
        private int passport;
        private int cellNumber;
        private int cNIC;
        private int reserveSeats;
        private string travelType;
        private string Departure;
        private string Destination;
        private string name;
        private string departrue;

        public int Passport { get => passport; set => passport = value; }
        public int CellNumber { get => cellNumber; set => cellNumber = value; }
        public int CNIC { get => cNIC; set => cNIC = value; }
        public int ReserveSeats { get => reserveSeats; set => reserveSeats = value; }
        public string TravelType { get => travelType; set => travelType = value; }
       
        public string Departure1 { get => Departure; set => Departure = value; }
        public string Destination1 { get => Destination; set => Destination = value; }
        public string Name { get => name; set => name = value; }

        public Passenger(string Name,string password,string role,int Passport, int CNIC, int CellNumber, int ReserveSeats, string TravelType, string Departure, string FlightArival) : base(password,role)

        {
            this.Name=Name;
            this.Passport = Passport;
            this.CNIC = CNIC;
            this.CellNumber = CellNumber;
            this.ReserveSeats = ReserveSeats;
            this.TravelType = TravelType;
            this.Departure1 = Departure;
            this.Destination1 = FlightArival;
        }

        
        public Passenger(string name, int passport, int cellNumber, int cNIC, string departrue, string destination, int reserveSeats, string travelType)
        {
            this.Name = name;
            this.passport = passport;
            this.cellNumber = cellNumber;
            this.cNIC = cNIC;
            this.Departure = departrue;
            Destination = destination;
            this.reserveSeats = reserveSeats;
            this.travelType = travelType;
        }
    }

}

