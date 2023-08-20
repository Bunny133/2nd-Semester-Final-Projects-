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
    public partial class PassengerForm : Form
    {
        public PassengerForm()
        {
            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // this.lbl_pnlHeader.Text = "Cashiers";
            this.Hide();
            FLightForm passenger = new FLightForm();
           
            passenger.Show();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            PassengerTicketSection ticket = new PassengerTicketSection();
            ticket.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            FeedBackForm feedBack = new FeedBackForm();
            feedBack.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
         
        }

        private void PassengerForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            SigninForm sigin = new SigninForm();
            sigin.Show();
        }
    }
}
