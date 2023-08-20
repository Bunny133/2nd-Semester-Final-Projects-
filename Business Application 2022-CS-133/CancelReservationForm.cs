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
    public partial class CancelReservationForm : Form
    {
        public CancelReservationForm()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int Passportno = int.Parse(textBox2.Text);
                Passenger flight = PassengerDL.GetPassport(Passportno);
                bool flag = true;

                if (flight != null)
                {
                    int index = PassengerDL.Ticketdata.IndexOf(flight);

                  
                    if (index != -1)
                    {
                        PassengerDL.Ticketdata.RemoveAt(index);

                        

                        PassengerDL.StorePassenger(Program.path2);

                    MessageBox.Show("Cancelled Successfully");
                }
                    else
                    {
                        flag = false;
                        MessageBox.Show("Passenger not found in the list.");
                    }
                }
                else
                {
                    flag = false;
                    MessageBox.Show("Passenger with PassportNO " + Passportno + " not found.");
                }

             
                this.Hide();
            PassengerTicketSection form =new PassengerTicketSection();
            form.Show();
        }

        private void CancelReservationForm_Load(object sender, EventArgs e)
        {

        }
    }
}
