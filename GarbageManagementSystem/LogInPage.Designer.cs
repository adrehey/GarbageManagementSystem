namespace GarbageManagementSystem
{
    partial class LogInPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInPage));
            panel1 = new Panel();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            linkSignUp = new LinkLabel();
            label6 = new Label();
            btnLogin = new Button();
            chkShowPass = new CheckBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(linkSignUp);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(chkShowPass);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(743, 281);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(8);
            panel1.Size = new Size(418, 513);
            panel1.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(67, 293);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(285, 25);
            txtPassword.TabIndex = 15;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(67, 233);
            txtUsername.Margin = new Padding(3, 2, 3, 2);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(285, 25);
            txtUsername.TabIndex = 0;
            // 
            // linkSignUp
            // 
            linkSignUp.BackColor = Color.Transparent;
            linkSignUp.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkSignUp.LinkBehavior = LinkBehavior.NeverUnderline;
            linkSignUp.LinkColor = Color.Khaki;
            linkSignUp.Location = new Point(272, 416);
            linkSignUp.Name = "linkSignUp";
            linkSignUp.Size = new Size(63, 19);
            linkSignUp.TabIndex = 14;
            linkSignUp.TabStop = true;
            linkSignUp.Text = "Sign Up";
            linkSignUp.LinkClicked += linkSignUp_LinkClicked;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Transparent;
            label6.Location = new Point(94, 416);
            label6.Name = "label6";
            label6.Size = new Size(183, 18);
            label6.TabIndex = 13;
            label6.Text = "Don't have an account?";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Ivory;
            btnLogin.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.Green;
            btnLogin.Location = new Point(67, 368);
            btnLogin.Margin = new Padding(3, 2, 3, 2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(285, 40);
            btnLogin.TabIndex = 12;
            btnLogin.Text = "Log In";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // chkShowPass
            // 
            chkShowPass.AutoSize = true;
            chkShowPass.BackColor = Color.Transparent;
            chkShowPass.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkShowPass.ForeColor = Color.Ivory;
            chkShowPass.Location = new Point(67, 327);
            chkShowPass.Margin = new Padding(3, 2, 3, 2);
            chkShowPass.Name = "chkShowPass";
            chkShowPass.Size = new Size(137, 22);
            chkShowPass.TabIndex = 10;
            chkShowPass.Text = "Show Password";
            chkShowPass.UseVisualStyleBackColor = false;
            chkShowPass.CheckedChanged += chkShowPass_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Transparent;
            label5.Location = new Point(67, 268);
            label5.Name = "label5";
            label5.Size = new Size(101, 23);
            label5.TabIndex = 7;
            label5.Text = "Password:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(67, 208);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 6;
            label4.Text = "School ID:";
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Century Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Ivory;
            label3.Location = new Point(47, 136);
            label3.Name = "label3";
            label3.Size = new Size(328, 72);
            label3.TabIndex = 0;
            label3.Text = "Log In";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top;
            panel2.AutoSize = true;
            panel2.BackColor = Color.Ivory;
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(743, 247);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(418, 124);
            panel2.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(133, 12);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(158, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // LogInPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1904, 1041);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "LogInPage";
            StartPosition = FormStartPosition.CenterScreen;
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
        private Panel panel1;
        private Label label3;
        private Panel panel2;
        private Label label4;
        private Label label5;
        private CheckBox chkShowPass;
        private Button btnLogin;
        private LinkLabel linkSignUp;
        private Label label6;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private PictureBox pictureBox1;
    }
}
