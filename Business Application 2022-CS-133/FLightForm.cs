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
    public partial class FLightForm : Form
    {
        public FLightForm()
        {
            InitializeComponent();
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {



        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void refreshGrid()
        {
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //GridFlight.DataSource = null;
            //GridFlight.DataSource = AdminDL.Flightdata;
            //GridFlight.Refresh();
        }

        private void FLightForm_Load(object sender, EventArgs e)
        {
            GridFlight.DataSource = null;
            GridFlight.DataSource = AdminDL.Flightdata;
            GridFlight.Columns["UserName"].Visible = false;
            GridFlight.Columns["UserPassword"].Visible = false;
            GridFlight.Columns["Role"].Visible = false;
            GridFlight.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            PassengerForm pasenger = new PassengerForm();
            pasenger.Show();
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
