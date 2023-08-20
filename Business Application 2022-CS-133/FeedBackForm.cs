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
    public partial class FeedBackForm : Form
    {
        public FeedBackForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
          
        

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string feedback = textBox2.Text;

            FeedBack feed = new FeedBack(name, feedback);
            FeedbackDL.feeds.Add(feed);
            FeedbackDL.StoreFeedback(Program.path3);
            MessageBox.Show("FeedBack Added Successfully.", "FeedBack ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            PassengerForm passenger=new PassengerForm();
            passenger.Show();

        }


        private void FeedBackForm_Load(object sender, EventArgs e)
        {
           
            
        }
    }
}
