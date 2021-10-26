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
    public partial class AdminPage : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-9TPIVKR\SQLEXPRESS;integrated security = sspi;initial catalog=InterviewTracker;");
        int Index = 0;
        SqlDataAdapter da;
        public AdminPage()
        {
            InitializeComponent();
        }

        //Go to Add user
        private void button1_Click(object sender, EventArgs e)
        {
            InterviewDetails ID = new InterviewDetails();
            ID.Show();
        }

        //Go To Add Interview
        private void addinterviewbutton_Click(object sender, EventArgs e)
        {
            SetInterview SI = new SetInterview();
            SI.Show();
        }
        //Display Data in datagridView

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            filldata();
        }


       
        public void filldata()
        {
            con.Open();
            try
            {
                da = new SqlDataAdapter("select * from setInterview", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.AutoGenerateColumns = false;
                foreach (DataRow row in dt.Rows)
                {
                    int i = dataGridView1.Rows.Add();
                    dataGridView1.Rows[i].Cells[0].Value = row["Select Interviewr"].ToString();
                    dataGridView1.Rows[i].Cells[1].Value = row["Select User For Interviewer]"].ToString();
                    dataGridView1.Rows[i].Cells[2].Value = row["Interview Staus"].ToString();
                    dataGridView1.Rows[i].Cells[3].Value = row["Interview Name"].ToString();
                    dataGridView1.Rows[i].Cells[3].Value = row["User Skills"].ToString();
                    dataGridView1.Rows[i].Cells[3].Value = row["Technical Interview Status"].ToString();
                }
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

        private void deletebtn_Click(object sender, EventArgs e)
        {
            DeleteUser db = new DeleteUser();
            db.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            EditUser ed = new EditUser();
            ed.Show();
        }

        private void interviewdelbutton1_Click(object sender, EventArgs e)
        {
            DeleteInterview di = new DeleteInterview();
            di.Show();
                
        }

        private void editinterviewbutton2_Click(object sender, EventArgs e)
        {
            EditInterviewcs ei = new EditInterviewcs();
            ei.Show();

        }
    }
}
