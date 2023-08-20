using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Game
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
           
            

          
        }

        private void StartForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Transparent;
            this.Hide();
            Game_Form form=new Game_Form();
            form.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.Transparent;
            Application.Exit();
        }
    }
}
