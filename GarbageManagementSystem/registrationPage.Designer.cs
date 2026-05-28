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
        /// 

      
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registrationPage));
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnRegister = new Button();
            btnbackToLog = new Button();
            txtStudentID = new TextBox();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            chkShowPass = new CheckBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(86, 244);
            txtUsername.Margin = new Padding(3, 2, 3, 2);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Username";
            txtUsername.Size = new Size(325, 23);
            txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(86, 369);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(325, 23);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = Color.Green;
            btnRegister.Location = new Point(85, 422);
            btnRegister.Margin = new Padding(3, 2, 3, 2);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(327, 53);
            btnRegister.TabIndex = 3;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnbackToLog
            // 
            btnbackToLog.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnbackToLog.ForeColor = Color.Green;
            btnbackToLog.Location = new Point(308, 484);
            btnbackToLog.Margin = new Padding(3, 2, 3, 2);
            btnbackToLog.Name = "btnbackToLog";
            btnbackToLog.Size = new Size(103, 28);
            btnbackToLog.TabIndex = 0;
            btnbackToLog.Text = "Back to login";
            btnbackToLog.Click += btnbackToLog_Click;
            // 
            // txtStudentID
            // 
            txtStudentID.Location = new Point(85, 309);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.PlaceholderText = "School ID";
            txtStudentID.Size = new Size(326, 23);
            txtStudentID.TabIndex = 5;
            txtStudentID.KeyPress += txtStudentID_KeyPress;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.BackColor = Color.Ivory;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnRegister);
            panel1.Controls.Add(txtStudentID);
            panel1.Controls.Add(btnbackToLog);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(713, 243);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(8);
            panel1.Size = new Size(478, 600);
            panel1.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Green;
            label2.Location = new Point(84, 487);
            label2.Name = "label2";
            label2.Size = new Size(218, 19);
            label2.TabIndex = 17;
            label2.Text = "Already have an account?";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(85, 344);
            label1.Name = "label1";
            label1.Size = new Size(153, 23);
            label1.TabIndex = 16;
            label1.Text = "Enter password:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Green;
            label5.Location = new Point(85, 283);
            label5.Name = "label5";
            label5.Size = new Size(150, 23);
            label5.TabIndex = 7;
            label5.Text = "Enter School ID:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Green;
            label4.Location = new Point(86, 219);
            label4.Name = "label4";
            label4.Size = new Size(158, 23);
            label4.TabIndex = 6;
            label4.Text = "Enter Username:";
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Century Gothic", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Green;
            label3.Location = new Point(86, 155);
            label3.Name = "label3";
            label3.Size = new Size(309, 54);
            label3.TabIndex = 0;
            label3.Text = "Registration Page";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top;
            panel2.AutoSize = true;
            panel2.BackColor = Color.Ivory;
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(713, 197);
            panel2.Name = "panel2";
            panel2.Size = new Size(478, 187);
            panel2.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(151, 51);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(181, 133);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // chkShowPass
            // 
            chkShowPass.Location = new Point(0, 0);
            chkShowPass.Name = "chkShowPass";
            chkShowPass.Size = new Size(104, 24);
            chkShowPass.TabIndex = 0;
            // 
            // registrationPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1904, 1041);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "registrationPage";
            Text = "EcoTrack";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnRegister;
        private Button btnbackToLog;
        private TextBox txtStudentID;
        private Panel panel1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private System.Windows.Forms.CheckBox chkShowPass;
    }
}