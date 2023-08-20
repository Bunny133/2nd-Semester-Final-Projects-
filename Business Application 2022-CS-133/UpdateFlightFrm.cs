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
    public partial class UpdateFlightFrm : Form
    {
        public UpdateFlightFrm()
        {
            InitializeComponent();
        }

        private void UpdateFlightFrm_Load(object sender, EventArgs e)
        {
           
        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {           
                string updatedTime = textBox7.Text;
                string updatedDeparture = textBox5.Text;
                string updatedDestination = textBox6.Text;
            AdminDL.admin.Departure = updatedDeparture;
            AdminDL.admin.FlightArival = updatedDestination;
            AdminDL.admin.DepartureTime = updatedTime;
            
                AdminDL.StoreFlight(Program.Path);

            MessageBox.Show("Flight schedule updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            AdminFlightFrm form=new AdminFlightFrm();
                form.Show();
           
        }


    }
    }

