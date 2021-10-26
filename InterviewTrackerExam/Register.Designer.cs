
namespace InterviewTrackerExam
{
    partial class Register
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
            this.NameLb1 = new System.Windows.Forms.Label();
            this.Addresslbl = new System.Windows.Forms.Label();
            this.mobilelbl = new System.Windows.Forms.Label();
            this.emaillbl = new System.Windows.Forms.Label();
            this.Lblpassword = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.textMobile = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(298, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Register";
            // 
            // NameLb1
            // 
            this.NameLb1.AutoSize = true;
            this.NameLb1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.NameLb1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLb1.Location = new System.Drawing.Point(103, 95);
            this.NameLb1.Name = "NameLb1";
            this.NameLb1.Size = new System.Drawing.Size(47, 20);
            this.NameLb1.TabIndex = 1;
            this.NameLb1.Text = "Name";
            // 
            // Addresslbl
            // 
            this.Addresslbl.AutoSize = true;
            this.Addresslbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Addresslbl.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addresslbl.Location = new System.Drawing.Point(103, 153);
            this.Addresslbl.Name = "Addresslbl";
            this.Addresslbl.Size = new System.Drawing.Size(60, 20);
            this.Addresslbl.TabIndex = 2;
            this.Addresslbl.Text = "Address";
            this.Addresslbl.Click += new System.EventHandler(this.Addresslbl_Click);
            // 
            // mobilelbl
            // 
            this.mobilelbl.AutoSize = true;
            this.mobilelbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mobilelbl.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobilelbl.Location = new System.Drawing.Point(103, 207);
            this.mobilelbl.Name = "mobilelbl";
            this.mobilelbl.Size = new System.Drawing.Size(55, 20);
            this.mobilelbl.TabIndex = 3;
            this.mobilelbl.Text = "Mobile";
            // 
            // emaillbl
            // 
            this.emaillbl.AutoSize = true;
            this.emaillbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.emaillbl.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emaillbl.Location = new System.Drawing.Point(103, 263);
            this.emaillbl.Name = "emaillbl";
            this.emaillbl.Size = new System.Drawing.Size(44, 20);
            this.emaillbl.TabIndex = 4;
            this.emaillbl.Text = "Email";
            // 
            // Lblpassword
            // 
            this.Lblpassword.AutoSize = true;
            this.Lblpassword.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lblpassword.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblpassword.Location = new System.Drawing.Point(94, 307);
            this.Lblpassword.Name = "Lblpassword";
            this.Lblpassword.Size = new System.Drawing.Size(69, 20);
            this.Lblpassword.TabIndex = 5;
            this.Lblpassword.Text = "Password";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(267, 95);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(317, 20);
            this.txtName.TabIndex = 7;
            this.txtName.TextChanged += new System.EventHandler(this.txtbox1_TextChanged);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(267, 153);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(317, 20);
            this.txtAddress.TabIndex = 8;
            // 
            // textMobile
            // 
            this.textMobile.Location = new System.Drawing.Point(267, 207);
            this.textMobile.Name = "textMobile";
            this.textMobile.Size = new System.Drawing.Size(317, 20);
            this.textMobile.TabIndex = 9;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(267, 263);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(317, 20);
            this.txtEmail.TabIndex = 10;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(267, 307);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(317, 20);
            this.txtPassword.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Font = new System.Drawing.Font("Calibri", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(267, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.textMobile);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.Lblpassword);
            this.Controls.Add(this.emaillbl);
            this.Controls.Add(this.mobilelbl);
            this.Controls.Add(this.Addresslbl);
            this.Controls.Add(this.NameLb1);
            this.Controls.Add(this.label1);
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label NameLb1;
        private System.Windows.Forms.Label Addresslbl;
        private System.Windows.Forms.Label mobilelbl;
        private System.Windows.Forms.Label emaillbl;
        private System.Windows.Forms.Label Lblpassword;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox textMobile;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button button1;
    }
}