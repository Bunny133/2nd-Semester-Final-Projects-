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
    public partial class SearchUpdateFrm : Form
    {
        public SearchUpdateFrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminDL.admin  = AdminDL.getFlight(int.Parse(textBox2.Text));
            if (AdminDL.admin != null)
            {
                UpdateFlightFrm update = new UpdateFlightFrm();
                update.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Flight Number. Please enter a valid integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
