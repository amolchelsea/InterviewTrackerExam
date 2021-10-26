using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace InterviewTrackerExam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        /*  private void registerToolStripMenuItem_Click(object sender, EventArgs e)
          {
              //object creation for registerform
              Register rs = new Register();
              rs.Show();
          }*/

        //Register Form
        private void registerToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Register rs = new Register();
            rs.Show();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login ls = new Login();
            ls.Show();
        }
    }
}
