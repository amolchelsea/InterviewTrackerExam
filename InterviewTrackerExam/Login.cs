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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        //Admin Login

        private void loginbutton1_Click(object sender, EventArgs e)
        {
            //SqlConnection scn = new SqlConnection();
            SqlConnection scn = new SqlConnection(@"Data Source=DESKTOP-9TPIVKR\SQLEXPRESS;integrated security = sspi;initial catalog=InterviewTracker;");
            try
            {
                SqlCommand scmd = new SqlCommand("select count (*) as cnt from Register where Email=@userName and Password=@pwd", scn);
                scmd.Parameters.Clear();
                scmd.Parameters.AddWithValue("@userName", usertext.Text);
                scmd.Parameters.AddWithValue("@pwd", logpasswordtext.Text);
                scn.Open();

                if (scmd.ExecuteScalar().ToString() == "1")
                {
                    AdminPage ad = new AdminPage();
                    ad.Show();

                }

                else
                {
                    MessageBox.Show("ACCESS Denied");

                }
            }
            catch (SqlException e2)
            {
                MessageBox.Show(e2.Message);

            }
            finally
            {

                scn.Close();
            }
        }

        private void logpasswordtext_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
