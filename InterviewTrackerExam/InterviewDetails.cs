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
    public partial class InterviewDetails : Form
    {
        public InterviewDetails()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Register_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-9TPIVKR\SQLEXPRESS;integrated security = sspi;initial catalog=InterviewTracker;");
            con.Open();
            try
            {

                SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[IterviewDetails]
        ([userid]
       ,[FirstName]
       ,[LastName]
         ,[UserType]
       ,[Interview Date]
       ,[Interview Time] 
        ,[Reporting To] 
         ,[Status] 
       )
      values" +
                           "(@userid,@FirstName,@LastName,@UserType,@Interview Date,@Interview Time,@Reporting To,@Status)", con);

                cmd.Parameters.AddWithValue("@userid", useridtext.Text);
                cmd.Parameters.AddWithValue("@FirstName", intervnametxt.Text);
                cmd.Parameters.AddWithValue("@LastName", lastnametext.Text);
                cmd.Parameters.AddWithValue("@UserType", this.usertypeBox1.Text);

                cmd.Parameters.AddWithValue("@Interview Date", this.dateTimePicker1.Text);

               cmd.Parameters.AddWithValue("@Interview Time", timetext.Text);
                cmd.Parameters.AddWithValue("@Reporting To", this.reportbox.Text);
                cmd.Parameters.AddWithValue("@Status", this.statusbox.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show(" Registered!");

            }
            catch (SqlException e3)
            {
                MessageBox.Show(e3.Message);

            }
            finally
            {
                con.Close();

            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
