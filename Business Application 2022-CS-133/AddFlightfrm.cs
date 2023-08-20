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
    public partial class AddFlightfrm : Form
    {
        public AddFlightfrm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int Number = int.Parse(textBox1.Text);
            string Company = textBox2.Text;
            string Departure = textBox5.Text;
            string Destination = textBox6.Text;
            string Time = textBox7.Text;
            string Date = textBox8.Text;
            Admin flight = new Admin(Number,Company,Departure,Destination,Time,Date);
            AdminDL.Flightdata.Add(flight);
            AdminDL.StoreFlight(Program.Path);
            MessageBox.Show($"Flight number {Number} has been successfully Added.", "Flight Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            FormAdmin form=new FormAdmin();
            form.Show();
        }

        private void AddFlightfrm_Load(object sender, EventArgs e)
        {

        }
    }
}
