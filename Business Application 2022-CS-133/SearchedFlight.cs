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
    public partial class SearchedFlight : Form
    {
        public SearchedFlight()
        {
            InitializeComponent();
        }

        private void SearchedFlight_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int FlightNumber = int.Parse(textBox2.Text);
            Admin admin = AdminDL.getFlight(FlightNumber);
            
            List<Admin> admins = new List<Admin>();
            admins.Add(admin);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = admins;
            dataGridView1.Refresh();
            MessageBox.Show("Flight Found");
            this.Hide();

            AdminFlightFrm form=new    AdminFlightFrm();
            form.Show();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
