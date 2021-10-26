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

//register 

namespace InterviewTrackerExam
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Addresslbl_Click(object sender, EventArgs e)
        {

        }
        //Admin Register
        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-9TPIVKR\SQLEXPRESS;integrated security = sspi;initial catalog=InterviewTracker;");
            con.Open();
            try
            {
                
                SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[Register]
        ([Name]
       ,[Address]
         ,[Mobile]
       ,[Email]
        ,[Password]
         
       )
      values" +
                           "(@Name,@Address,@Mobile,@Email,@Password)", con);

                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
             cmd.Parameters.AddWithValue("@mobile", textMobile.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
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

        private void txtbox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
