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
    public partial class SigninForm : Form
    {
        public SigninForm()
        {
            InitializeComponent();
            AdminDL.LoadFlight(Program.Path);
            PassengerDL.LoadPassenger(Program.path2);
            FeedbackDL.LoadFeedback(Program.path3);
            MUserDL.loadUser(Program.path);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        public void ClearDataFromForm()
        {
            textBox1.Text = "";
            textBox2.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string password = textBox2.Text;
            Credentials credentials = MUserDL.search(name, password);
            if (credentials.Role == "Admin")
            {
                this.Hide();
                FormAdmin manager = new FormAdmin();
                manager.FormClosed += (s, args) => this.Close();
                manager.Show();
            }
            else if (credentials.Role == "Customer")
            {
                this.Hide();
                PassengerForm cashier = new PassengerForm();
                cashier.FormClosed += (s, args) => this.Close();
                cashier.Show();
            }
            else
            {
                MessageBox.Show("User Not Exists");

            }
        }

        private void SigninForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            char passCharacter = textBox2.PasswordChar;
            if (passCharacter == '*')
            {
                
                textBox2.PasswordChar = '\0';
                pictureBox1.Image = Properties.Resources.eye;
            }
            else
            {
                textBox2.PasswordChar = '*';
                pictureBox1.Image = Properties.Resources.hidden;
            }
        }
    }
}
