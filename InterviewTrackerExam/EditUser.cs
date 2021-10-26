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
{/// <summary>
                                             //Edit User
/// </summary>
    public partial class EditUser : Form
    {
        public EditUser()
        {
            InitializeComponent();
        }

        //Edit Button for edit data
        private void Deletebutton1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-9TPIVKR\SQLEXPRESS;integrated security = sspi;initial catalog=InterviewTracker;");
            try
            {
                SqlCommand cmd = new SqlCommand("update InterviewDetails set  FirstName=@FirstName,LastName=@LastName,Status=@Status,UserType=@UserType,Reporting To=@Reporting To", con);
                con.Open();
                cmd.Parameters.AddWithValue("@FirstName", fnametext.Text);
                cmd.Parameters.AddWithValue("@LastName", lnametext.Text);
                cmd.Parameters.AddWithValue("@Status", stauscomboBox1.Text);
                cmd.Parameters.AddWithValue("UserType", usercomboBox2.Text);
                cmd.Parameters.AddWithValue("@Reporting To", reporttext.Text);

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data Deleted Successfully!");
            }
            catch (SqlException e1)
            {
                MessageBox.Show(e1.Message);

            }
            finally
            {
                con.Close();

            }

        }

        //back To list
        private void button2_Click(object sender, EventArgs e)
        {
            AdminPage ad = new AdminPage();
            ad.Show();
        }
    }
}
