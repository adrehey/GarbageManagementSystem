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
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(265, 122);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(125, 27);
            txtUsername.TabIndex = 0;
            txtUsername.TextChanged += txtUsername_TextChanged;
            txtUsername.Enter += txtUsername_Enter_1;
            txtUsername.Leave += txtUsername_Leave;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(265, 176);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(125, 27);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(364, 239);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(109, 29);
            btnRegister.TabIndex = 3;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnback
            // 
            btnback.Location = new Point(205, 235);
            btnback.Name = "btnback";
            btnback.Size = new Size(133, 37);
            btnback.TabIndex = 0;
            btnback.Text = "Back to login";
            btnback.Click += btnback_Click;
            // 
            // cmbRole
            // 
            cmbRole.FormattingEnabled = true;
            cmbRole.Items.AddRange(new object[] { "Staff ", "Student " });
            cmbRole.Location = new Point(411, 121);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(83, 28);
            cmbRole.TabIndex = 4;
            // 
            // registrationPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbRole);
            Controls.Add(btnback);
            Controls.Add(btnRegister);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
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
    }
}