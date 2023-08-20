using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2nd_semester_Final_Project
{
    public partial class SIgnupForm : Form
    {
        public SIgnupForm()
        {
            InitializeComponent();
        }

        private void SIgnupForm_Load(object sender, EventArgs e)
        {
            
        }
        public void ClearDataFromForm()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
             
             string name = textBox1.Text;
            string password = textBox2.Text;
            //string id = txt_Id.Text;
            string role = textBox3.Text;
            //int id1 = int.Parse(id);
            Credentials newUser = new Credentials(name, password, role);
            bool flag = MUserDL.addUser(newUser, Program.path);
            if (flag)
            {
                this.Hide();
                SigninForm signin = new SigninForm();
                signin.Show();
            }
            else
            {
                MessageBox.Show("User Already Exists");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SigninForm login = new SigninForm();
            login.FormClosed += (s, args) => this.Close(); // Close the signup form when login form is closed
            login.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            char passCharacter = textBox2.PasswordChar;
            if (passCharacter == '*')
            {;
                textBox2.PasswordChar = '\0';
                pictureBox3.Image = Properties.Resources.eye;
            }
            else
            {
                textBox2.PasswordChar = '*';
                pictureBox3.Image = Properties.Resources.hidden;
            }
        }
    }
}
