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
    public partial class PassengerDataFrm : Form
    {
        public PassengerDataFrm()
        {
            InitializeComponent();

        }

        private void GridFlight_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void PassengerDataFrm_Load(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = null;
            
            dataGridView1.DataSource = PassengerDL.Ticketdata;
            dataGridView1.Columns["UserName"].Visible = false;
            dataGridView1.Columns["UserPassword"].Visible = false;
            dataGridView1.Columns["Role"].Visible = false;
            RefreshGrid();
            dataGridView1.Refresh();
        }
        public void RefreshGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = PassengerDL.Ticketdata.Select(c => new
            {
                Name = c.Name,
                Passport = c.Passport,
                Cell = c.CellNumber,
                CNIC = c.CNIC,
                Departure = c.Departure1,
                Destination = c.Destination1,
                ReserveSeats = c.ReserveSeats,
                TravelType = c.TravelType
            }).ToList();
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAdmin form =new FormAdmin();
             form.Show();
        }
    }
}
