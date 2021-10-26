
namespace InterviewTrackerExam
{
    partial class AdminPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NewUser = new System.Windows.Forms.Button();
            this.addinterviewbutton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.deletebtn = new System.Windows.Forms.Button();
            this.editbutton1 = new System.Windows.Forms.Button();
            this.interviewdelbutton1 = new System.Windows.Forms.Button();
            this.editinterviewbutton2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // NewUser
            // 
            this.NewUser.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewUser.Location = new System.Drawing.Point(210, 1);
            this.NewUser.Name = "NewUser";
            this.NewUser.Size = new System.Drawing.Size(152, 43);
            this.NewUser.TabIndex = 0;
            this.NewUser.Text = "Add New User";
            this.NewUser.UseVisualStyleBackColor = true;
            this.NewUser.Click += new System.EventHandler(this.button1_Click);
            // 
            // addinterviewbutton
            // 
            this.addinterviewbutton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addinterviewbutton.Location = new System.Drawing.Point(368, 1);
            this.addinterviewbutton.Name = "addinterviewbutton";
            this.addinterviewbutton.Size = new System.Drawing.Size(152, 43);
            this.addinterviewbutton.TabIndex = 1;
            this.addinterviewbutton.Text = "Add New Interview";
            this.addinterviewbutton.UseVisualStyleBackColor = true;
            this.addinterviewbutton.Click += new System.EventHandler(this.addinterviewbutton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(155, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(484, 150);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // deletebtn
            // 
            this.deletebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.deletebtn.Location = new System.Drawing.Point(221, 50);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(75, 23);
            this.deletebtn.TabIndex = 3;
            this.deletebtn.Text = "Delete";
            this.deletebtn.UseVisualStyleBackColor = false;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // editbutton1
            // 
            this.editbutton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.editbutton1.Location = new System.Drawing.Point(302, 50);
            this.editbutton1.Name = "editbutton1";
            this.editbutton1.Size = new System.Drawing.Size(75, 23);
            this.editbutton1.TabIndex = 4;
            this.editbutton1.Text = "Edit";
            this.editbutton1.UseVisualStyleBackColor = false;
            this.editbutton1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // interviewdelbutton1
            // 
            this.interviewdelbutton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.interviewdelbutton1.Location = new System.Drawing.Point(383, 50);
            this.interviewdelbutton1.Name = "interviewdelbutton1";
            this.interviewdelbutton1.Size = new System.Drawing.Size(75, 23);
            this.interviewdelbutton1.TabIndex = 5;
            this.interviewdelbutton1.Text = "Delete";
            this.interviewdelbutton1.UseVisualStyleBackColor = false;
            this.interviewdelbutton1.Click += new System.EventHandler(this.interviewdelbutton1_Click);
            // 
            // editinterviewbutton2
            // 
            this.editinterviewbutton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.editinterviewbutton2.Location = new System.Drawing.Point(464, 50);
            this.editinterviewbutton2.Name = "editinterviewbutton2";
            this.editinterviewbutton2.Size = new System.Drawing.Size(75, 23);
            this.editinterviewbutton2.TabIndex = 6;
            this.editinterviewbutton2.Text = "Edit";
            this.editinterviewbutton2.UseVisualStyleBackColor = false;
            this.editinterviewbutton2.Click += new System.EventHandler(this.editinterviewbutton2_Click);
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.editinterviewbutton2);
            this.Controls.Add(this.interviewdelbutton1);
            this.Controls.Add(this.editbutton1);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.addinterviewbutton);
            this.Controls.Add(this.NewUser);
            this.Name = "AdminPage";
            this.Text = "AdminPage";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NewUser;
        private System.Windows.Forms.Button addinterviewbutton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button editbutton1;
        private System.Windows.Forms.Button interviewdelbutton1;
        private System.Windows.Forms.Button editinterviewbutton2;
    }
}