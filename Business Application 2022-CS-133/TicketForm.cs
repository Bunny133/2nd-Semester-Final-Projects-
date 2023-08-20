using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2nd_semester_Final_Project
{
    public partial class TicketForm : Form
    {
        public TicketForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void TicketForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Name = textBox1.Text;
            int Cell = int.Parse(textBox3.Text);
            int Cnic = int.Parse(textBox4.Text);

            string Departure = textBox5.Text;
            int Passport = int.Parse(textBox2.Text);

            string FlightArival = textBox6.Text;
            int ReserveSeats = int.Parse(textBox7.Text);
            string TravelType = textBox8.Text;
           // Credentials credentials = MUserDL.search(Name);
            Passenger data = new Passenger(Name, Passport, Cell, Cnic, Departure, FlightArival, ReserveSeats, TravelType);
            PassengerDL.Ticketdata.Add(data);
            PassengerDL.StorePassenger(Program.path2);
            MessageBox.Show($"Ticket is Successfully Booked.", "Flight Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            PassengerTicketSection form =new PassengerTicketSection();
            form.Show();

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
