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
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminFlightFrm flightFrm = new AdminFlightFrm();
            flightFrm.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            PassengerDataFrm passenger = new PassengerDataFrm();
            passenger.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewfeedbackFrm viewFeed= new ViewfeedbackFrm();
            viewFeed.Show();
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            SigninForm signin = new SigninForm();
            signin.Show();
        }
    }
}
