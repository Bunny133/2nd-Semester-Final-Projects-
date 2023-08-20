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
    public partial class RemoveFlightFrm : Form
    {
        public RemoveFlightFrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox2.Text, out int flightNumber))
            {
                bool removed = AdminUI.RemoveFlight(Program.Path, flightNumber);

                if (removed)
                {
                    MessageBox.Show($"Flight number {flightNumber} has been removed successfully.", "Flight Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Flight number {flightNumber} was not found.", "Flight Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Invalid Flight Number. Please enter a valid integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Hide();
            AdminFlightFrm form=new AdminFlightFrm();
                form.Show();
        }

        private void RemoveFlightFrm_Load(object sender, EventArgs e)
        {

        }
    }
}
