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
    public partial class PassengerTicketSection : Form
    {
        public PassengerTicketSection()
        {
            InitializeComponent();
        }

        private void PassengerTicketSection_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = AdminDL.Flightdata;
            dataGridView1.Columns["UserName"].Visible = false;
            dataGridView1.Columns["UserPassword"].Visible = false;
            dataGridView1.Columns["Role"].Visible = false;
            dataGridView1.Refresh();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            TicketForm form = new TicketForm();
            form.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            CancelReservationForm form=new CancelReservationForm();
            form.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            PassengerForm form=new PassengerForm();
            form.Show();
        }
    }
}
