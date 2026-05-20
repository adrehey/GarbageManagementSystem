namespace GarbageManagementSystem
{
    partial class registrationPage
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
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnRegister = new Button();
            btnback = new Button();
            cmbRole = new ComboBox();
            txtStudentID = new TextBox();
            SuspendLayout();
            // 
            // txtUsername
            // 
<<<<<<< HEAD
            txtUsername.Location = new Point(232, 92);
            txtUsername.Margin = new Padding(3, 2, 3, 2);
            txtUsername.Name = "txtUsername";
=======
            txtUsername.Location = new Point(232, 61);
            txtUsername.Margin = new Padding(3, 2, 3, 2);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Username";
>>>>>>> 84b9f26da8c0a21dc0a4c942eb856d4b840908dc
            txtUsername.Size = new Size(110, 23);
            txtUsername.TabIndex = 0;
           
            // txtPassword
            // 
<<<<<<< HEAD
            txtPassword.Location = new Point(232, 132);
=======
            txtPassword.Location = new Point(232, 133);
>>>>>>> 84b9f26da8c0a21dc0a4c942eb856d4b840908dc
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(110, 23);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(318, 179);
            btnRegister.Margin = new Padding(3, 2, 3, 2);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(95, 22);
            btnRegister.TabIndex = 3;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnback
            // 
            btnback.Location = new Point(179, 176);
            btnback.Margin = new Padding(3, 2, 3, 2);
            btnback.Name = "btnback";
            btnback.Size = new Size(116, 28);
            btnback.TabIndex = 0;
            btnback.Text = "Back to login";
            btnback.Click += btnback_Click;
            // 
            // cmbRole
            // 
            cmbRole.FormattingEnabled = true;
            cmbRole.Items.AddRange(new object[] { "Staff ", "Student " });
            cmbRole.Location = new Point(360, 91);
            cmbRole.Margin = new Padding(3, 2, 3, 2);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(73, 23);
            cmbRole.TabIndex = 4;
            // 
            // txtStudentID
            // 
            txtStudentID.Location = new Point(232, 96);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.PlaceholderText = "School ID";
            txtStudentID.Size = new Size(110, 23);
            txtStudentID.TabIndex = 5;
            txtStudentID.TextChanged += txtStudentID_TextChanged;
            // 
            // registrationPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
<<<<<<< HEAD
=======
            Controls.Add(txtStudentID);
>>>>>>> 84b9f26da8c0a21dc0a4c942eb856d4b840908dc
            Controls.Add(cmbRole);
            Controls.Add(btnback);
            Controls.Add(btnRegister);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Margin = new Padding(3, 2, 3, 2);
            Name = "registrationPage";
            Text = "registrationPage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnRegister;
        private Button btnback;
        private ComboBox cmbRole;
        private TextBox txtStudentID;
    }
}