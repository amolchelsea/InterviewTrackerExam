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
    public partial class SetInterview : Form
    {
        public SetInterview()
        {
            InitializeComponent();
        }

        private void interviewbtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-9TPIVKR\SQLEXPRESS;integrated security = sspi;initial catalog=InterviewTracker;");
            con.Open();
            try
            {

                SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[setInterview]
        (Select Interviewr]
       ,[Select User For Interviewer]
         ,[Time]
       ,[Interview Staus]
        ,[Interview Name]
         ,[User Skills]
         ,[Date]
         ,[Technical Interview Status]
         
       )
      values" +
                           "(@Select Interviewr,@Select User For Interviewer,@Time,@Interview Staus,@Interview Name,@User Skills,@Date,@Technical Interview Status)", con);

                cmd.Parameters.AddWithValue("@Select Interviewr", interviewercomboBox1.Text);
                cmd.Parameters.AddWithValue("@Select User For Interviewer", usercomboBox2.Text);
                cmd.Parameters.AddWithValue("@Time", timetext.Text);
                cmd.Parameters.AddWithValue("@Interview Staus", statuscomboBox3.Text);
                cmd.Parameters.AddWithValue("@Interview Name", Nametext.Text);
                cmd.Parameters.AddWithValue("@User Skills", skillcomboBox1.Text);
                cmd.Parameters.AddWithValue("@Date", this.dateTimePicker1.Text);
                cmd.Parameters.AddWithValue("@Technical Interview Status", technicalcomboBox4.Text);




                cmd.ExecuteNonQuery();
                MessageBox.Show(" Registered!");

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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
