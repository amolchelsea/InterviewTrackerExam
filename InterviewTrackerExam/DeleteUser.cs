using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace InterviewTrackerExam
{
    public partial class DeleteUser : Form
    {
        public DeleteUser()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        //Back to Admin Page
        private void button2_Click(object sender, EventArgs e)
        {
            AdminPage ad = new AdminPage();
            ad.Show();
        }
        //delete Button for delete data
        private void Deletebutton1_Click(object sender, EventArgs e)
        {
            c
            finally
            {
                con.Close();

            }

        }

        private void reportlbl_Click(object sender, EventArgs e)
        {

        }
    }
}
