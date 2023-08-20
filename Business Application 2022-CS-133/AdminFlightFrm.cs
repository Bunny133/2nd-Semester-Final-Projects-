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
    public partial class AdminFlightFrm : Form
    {
        public AdminFlightFrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddFlightfrm flightfrm = new AddFlightfrm();
            flightfrm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchedFlight search=new SearchedFlight();
            search.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            RemoveFlightFrm remove = new RemoveFlightFrm();
            
            remove.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchUpdateFrm updateFrm=new SearchUpdateFrm();
            updateFrm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void AdminFlightFrm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = AdminDL.Flightdata;
            dataGridView1.Columns["UserName"].Visible = false;
            dataGridView1.Columns["UserPassword"].Visible = false;
            dataGridView1.Columns["Role"].Visible = false;
            dataGridView1.Refresh();
        }

        private void GridFlight_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewfeedbackFrm feedback = new ViewfeedbackFrm();
            feedback.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FormAdmin admin = new FormAdmin();
            admin.Show();
        }
    }
}
