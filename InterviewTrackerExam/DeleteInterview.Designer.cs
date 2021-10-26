
namespace InterviewTrackerExam
{
    partial class DeleteInterview
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.skillcomboBox1 = new System.Windows.Forms.ComboBox();
            this.interviewbtn = new System.Windows.Forms.Button();
            this.technicalcomboBox4 = new System.Windows.Forms.ComboBox();
            this.statuslabel = new System.Windows.Forms.Label();
            this.statuscomboBox3 = new System.Windows.Forms.ComboBox();
            this.usercomboBox2 = new System.Windows.Forms.ComboBox();
            this.interviewercomboBox1 = new System.Windows.Forms.ComboBox();
            this.Nametext = new System.Windows.Forms.TextBox();
            this.timetext = new System.Windows.Forms.TextBox();
            this.datelabel = new System.Windows.Forms.Label();
            this.skilllbl = new System.Windows.Forms.Label();
            this.namelbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Timelbl = new System.Windows.Forms.Label();
            this.selectUserlbl = new System.Windows.Forms.Label();
            this.selectinterviewlbl1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Location = new System.Drawing.Point(612, 257);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(123, 20);
            this.dateTimePicker1.TabIndex = 40;
            // 
            // skillcomboBox1
            // 
            this.skillcomboBox1.FormattingEnabled = true;
            this.skillcomboBox1.Items.AddRange(new object[] {
            ".net=1",
            "java=2",
            "Angular=3",
            "oop=4"});
            this.skillcomboBox1.Location = new System.Drawing.Point(612, 209);
            this.skillcomboBox1.Name = "skillcomboBox1";
            this.skillcomboBox1.Size = new System.Drawing.Size(121, 21);
            this.skillcomboBox1.TabIndex = 39;
            // 
            // interviewbtn
            // 
            this.interviewbtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interviewbtn.ForeColor = System.Drawing.Color.Red;
            this.interviewbtn.Location = new System.Drawing.Point(340, 363);
            this.interviewbtn.Name = "interviewbtn";
            this.interviewbtn.Size = new System.Drawing.Size(94, 36);
            this.interviewbtn.TabIndex = 38;
            this.interviewbtn.Text = "Delete";
            this.interviewbtn.UseVisualStyleBackColor = true;
            // 
            // technicalcomboBox4
            // 
            this.technicalcomboBox4.FormattingEnabled = true;
            this.technicalcomboBox4.Items.AddRange(new object[] {
            "Inprocess=1",
            "Cancel=2",
            "Fail=3",
            "pass=4",
            "Done=5"});
            this.technicalcomboBox4.Location = new System.Drawing.Point(612, 294);
            this.technicalcomboBox4.Name = "technicalcomboBox4";
            this.technicalcomboBox4.Size = new System.Drawing.Size(121, 21);
            this.technicalcomboBox4.TabIndex = 37;
            // 
            // statuslabel
            // 
            this.statuslabel.AutoSize = true;
            this.statuslabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statuslabel.Location = new System.Drawing.Point(425, 294);
            this.statuslabel.Name = "statuslabel";
            this.statuslabel.Size = new System.Drawing.Size(181, 17);
            this.statuslabel.TabIndex = 36;
            this.statuslabel.Text = "Technical Interview Status";
            // 
            // statuscomboBox3
            // 
            this.statuscomboBox3.FormattingEnabled = true;
            this.statuscomboBox3.Items.AddRange(new object[] {
            "Inprocess=1",
            "Cancel=2",
            "Fail=3",
            "pass=4",
            "Done=5"});
            this.statuscomboBox3.Location = new System.Drawing.Point(249, 304);
            this.statuscomboBox3.Name = "statuscomboBox3";
            this.statuscomboBox3.Size = new System.Drawing.Size(121, 21);
            this.statuscomboBox3.TabIndex = 35;
            // 
            // usercomboBox2
            // 
            this.usercomboBox2.FormattingEnabled = true;
            this.usercomboBox2.Items.AddRange(new object[] {
            "gouri",
            "pooja",
            "pranav",
            "pritam"});
            this.usercomboBox2.Location = new System.Drawing.Point(249, 205);
            this.usercomboBox2.Name = "usercomboBox2";
            this.usercomboBox2.Size = new System.Drawing.Size(121, 21);
            this.usercomboBox2.TabIndex = 34;
            // 
            // interviewercomboBox1
            // 
            this.interviewercomboBox1.FormattingEnabled = true;
            this.interviewercomboBox1.Items.AddRange(new object[] {
            "varun",
            "ganesh",
            "gouri",
            "amit",
            "prajakta"});
            this.interviewercomboBox1.Location = new System.Drawing.Point(251, 156);
            this.interviewercomboBox1.Name = "interviewercomboBox1";
            this.interviewercomboBox1.Size = new System.Drawing.Size(121, 21);
            this.interviewercomboBox1.TabIndex = 33;
            // 
            // Nametext
            // 
            this.Nametext.Location = new System.Drawing.Point(612, 168);
            this.Nametext.Name = "Nametext";
            this.Nametext.Size = new System.Drawing.Size(123, 20);
            this.Nametext.TabIndex = 32;
            // 
            // timetext
            // 
            this.timetext.Location = new System.Drawing.Point(249, 254);
            this.timetext.Name = "timetext";
            this.timetext.Size = new System.Drawing.Size(123, 20);
            this.timetext.TabIndex = 31;
            // 
            // datelabel
            // 
            this.datelabel.AutoSize = true;
            this.datelabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datelabel.Location = new System.Drawing.Point(425, 257);
            this.datelabel.Name = "datelabel";
            this.datelabel.Size = new System.Drawing.Size(39, 17);
            this.datelabel.TabIndex = 30;
            this.datelabel.Text = "Date";
            // 
            // skilllbl
            // 
            this.skilllbl.AutoSize = true;
            this.skilllbl.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skilllbl.Location = new System.Drawing.Point(425, 209);
            this.skilllbl.Name = "skilllbl";
            this.skilllbl.Size = new System.Drawing.Size(80, 17);
            this.skilllbl.TabIndex = 29;
            this.skilllbl.Text = "User Skills";
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelbl.Location = new System.Drawing.Point(425, 168);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(113, 17);
            this.namelbl.TabIndex = 28;
            this.namelbl.Text = "Interview Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(65, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "Interview Status";
            // 
            // Timelbl
            // 
            this.Timelbl.AutoSize = true;
            this.Timelbl.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Timelbl.Location = new System.Drawing.Point(65, 254);
            this.Timelbl.Name = "Timelbl";
            this.Timelbl.Size = new System.Drawing.Size(42, 17);
            this.Timelbl.TabIndex = 26;
            this.Timelbl.Text = "Time";
            // 
            // selectUserlbl
            // 
            this.selectUserlbl.AutoSize = true;
            this.selectUserlbl.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectUserlbl.Location = new System.Drawing.Point(65, 205);
            this.selectUserlbl.Name = "selectUserlbl";
            this.selectUserlbl.Size = new System.Drawing.Size(178, 17);
            this.selectUserlbl.TabIndex = 25;
            this.selectUserlbl.Text = "Select User For Interview";
            // 
            // selectinterviewlbl1
            // 
            this.selectinterviewlbl1.AutoSize = true;
            this.selectinterviewlbl1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectinterviewlbl1.Location = new System.Drawing.Point(65, 156);
            this.selectinterviewlbl1.Name = "selectinterviewlbl1";
            this.selectinterviewlbl1.Size = new System.Drawing.Size(121, 17);
            this.selectinterviewlbl1.TabIndex = 24;
            this.selectinterviewlbl1.Text = "Select Interviwer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(308, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 36);
            this.label1.TabIndex = 23;
            this.label1.Text = "Delete Interview";
            // 
            // DeleteInterview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.skillcomboBox1);
            this.Controls.Add(this.interviewbtn);
            this.Controls.Add(this.technicalcomboBox4);
            this.Controls.Add(this.statuslabel);
            this.Controls.Add(this.statuscomboBox3);
            this.Controls.Add(this.usercomboBox2);
            this.Controls.Add(this.interviewercomboBox1);
            this.Controls.Add(this.Nametext);
            this.Controls.Add(this.timetext);
            this.Controls.Add(this.datelabel);
            this.Controls.Add(this.skilllbl);
            this.Controls.Add(this.namelbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Timelbl);
            this.Controls.Add(this.selectUserlbl);
            this.Controls.Add(this.selectinterviewlbl1);
            this.Controls.Add(this.label1);
            this.Name = "DeleteInterview";
            this.Text = "DeleteInterview";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox skillcomboBox1;
        private System.Windows.Forms.Button interviewbtn;
        private System.Windows.Forms.ComboBox technicalcomboBox4;
        private System.Windows.Forms.Label statuslabel;
        private System.Windows.Forms.ComboBox statuscomboBox3;
        private System.Windows.Forms.ComboBox usercomboBox2;
        private System.Windows.Forms.ComboBox interviewercomboBox1;
        private System.Windows.Forms.TextBox Nametext;
        private System.Windows.Forms.TextBox timetext;
        private System.Windows.Forms.Label datelabel;
        private System.Windows.Forms.Label skilllbl;
        private System.Windows.Forms.Label namelbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Timelbl;
        private System.Windows.Forms.Label selectUserlbl;
        private System.Windows.Forms.Label selectinterviewlbl1;
        private System.Windows.Forms.Label label1;
    }
}