
namespace InterviewTrackerExam
{
    partial class DeleteUser
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
            this.userlbl = new System.Windows.Forms.Label();
            this.fnamelbl = new System.Windows.Forms.Label();
            this.lnamelbl = new System.Windows.Forms.Label();
            this.selectlabel5 = new System.Windows.Forms.Label();
            this.reportlbl = new System.Windows.Forms.Label();
            this.Deletebutton1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.fnametext = new System.Windows.Forms.TextBox();
            this.lnametext = new System.Windows.Forms.TextBox();
            this.reporttext = new System.Windows.Forms.TextBox();
            this.usercomboBox2 = new System.Windows.Forms.ComboBox();
            this.Userlabel1 = new System.Windows.Forms.Label();
            this.stauscomboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userlbl
            // 
            this.userlbl.AutoSize = true;
            this.userlbl.BackColor = System.Drawing.Color.Red;
            this.userlbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.userlbl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.userlbl.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userlbl.Location = new System.Drawing.Point(313, 41);
            this.userlbl.Name = "userlbl";
            this.userlbl.Size = new System.Drawing.Size(117, 28);
            this.userlbl.TabIndex = 0;
            this.userlbl.Text = "Delete User";
            // 
            // fnamelbl
            // 
            this.fnamelbl.AutoSize = true;
            this.fnamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnamelbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.fnamelbl.Location = new System.Drawing.Point(83, 130);
            this.fnamelbl.Name = "fnamelbl";
            this.fnamelbl.Size = new System.Drawing.Size(77, 15);
            this.fnamelbl.TabIndex = 2;
            this.fnamelbl.Text = "First Name";
            // 
            // lnamelbl
            // 
            this.lnamelbl.AutoSize = true;
            this.lnamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnamelbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lnamelbl.Location = new System.Drawing.Point(394, 130);
            this.lnamelbl.Name = "lnamelbl";
            this.lnamelbl.Size = new System.Drawing.Size(76, 15);
            this.lnamelbl.TabIndex = 13;
            this.lnamelbl.Text = "Last Name";
            // 
            // selectlabel5
            // 
            this.selectlabel5.AutoSize = true;
            this.selectlabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectlabel5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.selectlabel5.Location = new System.Drawing.Point(394, 177);
            this.selectlabel5.Name = "selectlabel5";
            this.selectlabel5.Size = new System.Drawing.Size(115, 15);
            this.selectlabel5.TabIndex = 15;
            this.selectlabel5.Text = "Select User Type";
            // 
            // reportlbl
            // 
            this.reportlbl.AutoSize = true;
            this.reportlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportlbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.reportlbl.Location = new System.Drawing.Point(83, 227);
            this.reportlbl.Name = "reportlbl";
            this.reportlbl.Size = new System.Drawing.Size(90, 15);
            this.reportlbl.TabIndex = 16;
            this.reportlbl.Text = "Reporting To";
            this.reportlbl.Click += new System.EventHandler(this.reportlbl_Click);
            // 
            // Deletebutton1
            // 
            this.Deletebutton1.BackColor = System.Drawing.Color.DodgerBlue;
            this.Deletebutton1.Location = new System.Drawing.Point(418, 236);
            this.Deletebutton1.Name = "Deletebutton1";
            this.Deletebutton1.Size = new System.Drawing.Size(75, 23);
            this.Deletebutton1.TabIndex = 17;
            this.Deletebutton1.Text = "Delete";
            this.Deletebutton1.UseVisualStyleBackColor = false;
            this.Deletebutton1.Click += new System.EventHandler(this.Deletebutton1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(550, 236);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Back To List";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // fnametext
            // 
            this.fnametext.Location = new System.Drawing.Point(183, 130);
            this.fnametext.Name = "fnametext";
            this.fnametext.Size = new System.Drawing.Size(148, 20);
            this.fnametext.TabIndex = 19;
            // 
            // lnametext
            // 
            this.lnametext.Location = new System.Drawing.Point(521, 130);
            this.lnametext.Name = "lnametext";
            this.lnametext.Size = new System.Drawing.Size(148, 20);
            this.lnametext.TabIndex = 20;
            this.lnametext.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // reporttext
            // 
            this.reporttext.Location = new System.Drawing.Point(183, 227);
            this.reporttext.Name = "reporttext";
            this.reporttext.Size = new System.Drawing.Size(148, 20);
            this.reporttext.TabIndex = 23;
            // 
            // usercomboBox2
            // 
            this.usercomboBox2.FormattingEnabled = true;
            this.usercomboBox2.Items.AddRange(new object[] {
            "Inprocess=1",
            "Cancel=2",
            "Fail=3",
            "pass=4",
            "Done=5"});
            this.usercomboBox2.Location = new System.Drawing.Point(521, 176);
            this.usercomboBox2.Name = "usercomboBox2";
            this.usercomboBox2.Size = new System.Drawing.Size(148, 21);
            this.usercomboBox2.TabIndex = 25;
            // 
            // Userlabel1
            // 
            this.Userlabel1.AutoSize = true;
            this.Userlabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Userlabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Userlabel1.Location = new System.Drawing.Point(83, 177);
            this.Userlabel1.Name = "Userlabel1";
            this.Userlabel1.Size = new System.Drawing.Size(81, 15);
            this.Userlabel1.TabIndex = 11;
            this.Userlabel1.Text = "User Status";
            // 
            // stauscomboBox1
            // 
            this.stauscomboBox1.FormattingEnabled = true;
            this.stauscomboBox1.Location = new System.Drawing.Point(183, 177);
            this.stauscomboBox1.Name = "stauscomboBox1";
            this.stauscomboBox1.Size = new System.Drawing.Size(148, 21);
            this.stauscomboBox1.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(83, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "First Name";
            // 
            // DeleteUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.stauscomboBox1);
            this.Controls.Add(this.usercomboBox2);
            this.Controls.Add(this.reporttext);
            this.Controls.Add(this.lnametext);
            this.Controls.Add(this.fnametext);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Deletebutton1);
            this.Controls.Add(this.reportlbl);
            this.Controls.Add(this.selectlabel5);
            this.Controls.Add(this.lnamelbl);
            this.Controls.Add(this.Userlabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fnamelbl);
            this.Controls.Add(this.userlbl);
            this.Name = "DeleteUser";
            this.Text = "DeleteUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userlbl;
        private System.Windows.Forms.Label fnamelbl;
        private System.Windows.Forms.Label lnamelbl;
        private System.Windows.Forms.Label selectlabel5;
        private System.Windows.Forms.Label reportlbl;
        private System.Windows.Forms.Button Deletebutton1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox fnametext;
        private System.Windows.Forms.TextBox lnametext;
        private System.Windows.Forms.TextBox reporttext;
        private System.Windows.Forms.ComboBox usercomboBox2;
        private System.Windows.Forms.Label Userlabel1;
        private System.Windows.Forms.ComboBox stauscomboBox1;
        private System.Windows.Forms.Label label1;
    }
}