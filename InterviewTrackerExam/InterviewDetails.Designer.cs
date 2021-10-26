
namespace InterviewTrackerExam
{
    partial class InterviewDetails
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
            this.label1 = new System.Windows.Forms.Label();
            this.intnamelbl = new System.Windows.Forms.Label();
            this.usertypelbl = new System.Windows.Forms.Label();
            this.datelbl = new System.Windows.Forms.Label();
            this.timelbl = new System.Windows.Forms.Label();
            this.intervnametxt = new System.Windows.Forms.TextBox();
            this.usertypeBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.timetext = new System.Windows.Forms.TextBox();
            this.lastNamelbl2 = new System.Windows.Forms.Label();
            this.reportlbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.reportbox = new System.Windows.Forms.ComboBox();
            this.statusbox = new System.Windows.Forms.ComboBox();
            this.lastnametext = new System.Windows.Forms.TextBox();
            this.Register = new System.Windows.Forms.Button();
            this.useridlbl = new System.Windows.Forms.Label();
            this.useridtext = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(299, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Apply For Interview";
            // 
            // intnamelbl
            // 
            this.intnamelbl.AutoSize = true;
            this.intnamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intnamelbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.intnamelbl.Location = new System.Drawing.Point(28, 145);
            this.intnamelbl.Name = "intnamelbl";
            this.intnamelbl.Size = new System.Drawing.Size(77, 15);
            this.intnamelbl.TabIndex = 1;
            this.intnamelbl.Text = "First Name";
            // 
            // usertypelbl
            // 
            this.usertypelbl.AutoSize = true;
            this.usertypelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usertypelbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.usertypelbl.Location = new System.Drawing.Point(28, 195);
            this.usertypelbl.Name = "usertypelbl";
            this.usertypelbl.Size = new System.Drawing.Size(67, 15);
            this.usertypelbl.TabIndex = 2;
            this.usertypelbl.Text = "UserType";
            // 
            // datelbl
            // 
            this.datelbl.AutoSize = true;
            this.datelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datelbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.datelbl.Location = new System.Drawing.Point(16, 248);
            this.datelbl.Name = "datelbl";
            this.datelbl.Size = new System.Drawing.Size(98, 15);
            this.datelbl.TabIndex = 3;
            this.datelbl.Text = "Interview Date";
            // 
            // timelbl
            // 
            this.timelbl.AutoSize = true;
            this.timelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timelbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.timelbl.Location = new System.Drawing.Point(372, 253);
            this.timelbl.Name = "timelbl";
            this.timelbl.Size = new System.Drawing.Size(100, 15);
            this.timelbl.TabIndex = 4;
            this.timelbl.Text = "Interview Time";
            // 
            // intervnametxt
            // 
            this.intervnametxt.Location = new System.Drawing.Point(152, 140);
            this.intervnametxt.Name = "intervnametxt";
            this.intervnametxt.Size = new System.Drawing.Size(141, 20);
            this.intervnametxt.TabIndex = 5;
            // 
            // usertypeBox1
            // 
            this.usertypeBox1.FormattingEnabled = true;
            this.usertypeBox1.Items.AddRange(new object[] {
            "Trainee",
            "TranineeIntern",
            "Manager",
            "Developer",
            "FresherAssociate",
            "TeamLead",
            "TeamSupervisor",
            "DeliveryLead",
            "ProductLead",
            "NotAssigned"});
            this.usertypeBox1.Location = new System.Drawing.Point(152, 189);
            this.usertypeBox1.Name = "usertypeBox1";
            this.usertypeBox1.Size = new System.Drawing.Size(141, 21);
            this.usertypeBox1.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(152, 243);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(141, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // timetext
            // 
            this.timetext.Location = new System.Drawing.Point(520, 248);
            this.timetext.Name = "timetext";
            this.timetext.Size = new System.Drawing.Size(141, 20);
            this.timetext.TabIndex = 8;
            this.timetext.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lastNamelbl2
            // 
            this.lastNamelbl2.AutoSize = true;
            this.lastNamelbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNamelbl2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lastNamelbl2.Location = new System.Drawing.Point(388, 119);
            this.lastNamelbl2.Name = "lastNamelbl2";
            this.lastNamelbl2.Size = new System.Drawing.Size(76, 15);
            this.lastNamelbl2.TabIndex = 9;
            this.lastNamelbl2.Text = "Last Name";
            // 
            // reportlbl
            // 
            this.reportlbl.AutoSize = true;
            this.reportlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportlbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.reportlbl.Location = new System.Drawing.Point(388, 167);
            this.reportlbl.Name = "reportlbl";
            this.reportlbl.Size = new System.Drawing.Size(90, 15);
            this.reportlbl.TabIndex = 10;
            this.reportlbl.Text = "Reporting To";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(388, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Status";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // reportbox
            // 
            this.reportbox.FormattingEnabled = true;
            this.reportbox.Items.AddRange(new object[] {
            "varun",
            "ganesh",
            "gouri",
            "amit",
            "prajakta"});
            this.reportbox.Location = new System.Drawing.Point(520, 161);
            this.reportbox.Name = "reportbox";
            this.reportbox.Size = new System.Drawing.Size(141, 21);
            this.reportbox.TabIndex = 12;
            // 
            // statusbox
            // 
            this.statusbox.FormattingEnabled = true;
            this.statusbox.Items.AddRange(new object[] {
            "Inprocess=1",
            "Cancel=2",
            "Fail=3",
            "pass=4",
            "Done=5"});
            this.statusbox.Location = new System.Drawing.Point(520, 205);
            this.statusbox.Name = "statusbox";
            this.statusbox.Size = new System.Drawing.Size(141, 21);
            this.statusbox.TabIndex = 13;
            // 
            // lastnametext
            // 
            this.lastnametext.Location = new System.Drawing.Point(520, 113);
            this.lastnametext.Name = "lastnametext";
            this.lastnametext.Size = new System.Drawing.Size(141, 20);
            this.lastnametext.TabIndex = 14;
            // 
            // Register
            // 
            this.Register.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register.Location = new System.Drawing.Point(315, 317);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(75, 23);
            this.Register.TabIndex = 15;
            this.Register.Text = "Register";
            this.Register.UseVisualStyleBackColor = true;
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // useridlbl
            // 
            this.useridlbl.AutoSize = true;
            this.useridlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.useridlbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.useridlbl.Location = new System.Drawing.Point(28, 114);
            this.useridlbl.Name = "useridlbl";
            this.useridlbl.Size = new System.Drawing.Size(55, 15);
            this.useridlbl.TabIndex = 16;
            this.useridlbl.Text = "User ID";
            // 
            // useridtext
            // 
            this.useridtext.Location = new System.Drawing.Point(152, 109);
            this.useridtext.Name = "useridtext";
            this.useridtext.Size = new System.Drawing.Size(141, 20);
            this.useridtext.TabIndex = 17;
            // 
            // InterviewDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.useridtext);
            this.Controls.Add(this.useridlbl);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.lastnametext);
            this.Controls.Add(this.statusbox);
            this.Controls.Add(this.reportbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.reportlbl);
            this.Controls.Add(this.lastNamelbl2);
            this.Controls.Add(this.timetext);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.usertypeBox1);
            this.Controls.Add(this.intervnametxt);
            this.Controls.Add(this.timelbl);
            this.Controls.Add(this.datelbl);
            this.Controls.Add(this.usertypelbl);
            this.Controls.Add(this.intnamelbl);
            this.Controls.Add(this.label1);
            this.Name = "InterviewDetails";
            this.Text = "InterviewDetails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label intnamelbl;
        private System.Windows.Forms.Label usertypelbl;
        private System.Windows.Forms.Label datelbl;
        private System.Windows.Forms.Label timelbl;
        private System.Windows.Forms.TextBox intervnametxt;
        private System.Windows.Forms.ComboBox usertypeBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox timetext;
        private System.Windows.Forms.Label lastNamelbl2;
        private System.Windows.Forms.Label reportlbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox reportbox;
        private System.Windows.Forms.ComboBox statusbox;
        private System.Windows.Forms.TextBox lastnametext;
        private System.Windows.Forms.Button Register;
        private System.Windows.Forms.Label useridlbl;
        private System.Windows.Forms.TextBox useridtext;
    }
}