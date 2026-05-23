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
            label1 = new Label();
            panel1 = new Panel();
            linkReg = new LinkLabel();
            label6 = new Label();
            btnLogin = new Button();
            chkShowPassword = new CheckBox();
            label5 = new Label();
            label4 = new Label();
            txtUsername = new RichTextBox();
            label3 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            txtPassword = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(255, 112);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(linkReg);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(chkShowPassword);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(320, 180);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(8);
            panel1.Size = new Size(478, 600);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // linkReg
            // 
            linkReg.BackColor = Color.ForestGreen;
            linkReg.LinkColor = Color.Khaki;
            linkReg.Location = new Point(318, 486);
            linkReg.Name = "linkReg";
            linkReg.Size = new Size(133, 18);
            linkReg.TabIndex = 11;
            linkReg.TabStop = true;
            linkReg.Text = "Sign up";
            linkReg.LinkClicked += linkLabel2_LinkClicked_1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Transparent;
            label6.Location = new Point(119, 484);
            label6.Name = "label6";
            label6.Size = new Size(183, 18);
            label6.TabIndex = 13;
            label6.Text = "Don't have an account?";
            label6.Click += label6_Click_1;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Ivory;
            btnLogin.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.Green;
            btnLogin.Location = new Point(76, 422);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(326, 53);
            btnLogin.TabIndex = 12;
            btnLogin.Text = "Log In";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.BackColor = Color.Transparent;
            chkShowPassword.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkShowPassword.ForeColor = Color.Ivory;
            chkShowPassword.Location = new Point(76, 376);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(137, 22);
            chkShowPassword.TabIndex = 10;
            chkShowPassword.Text = "Show Password";
            chkShowPassword.UseVisualStyleBackColor = false;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Transparent;
            label5.Location = new Point(76, 301);
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
            label4.Location = new Point(76, 236);
            label4.Name = "label4";
            label4.Size = new Size(75, 23);
            label4.TabIndex = 6;
            label4.Text = "Sign In:";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.Ivory;
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(76, 267);
            txtUsername.Margin = new Padding(5);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(326, 26);
            txtUsername.TabIndex = 4;
            txtUsername.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Century Gothic", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Ivory;
            label3.Location = new Point(77, 98);
            label3.Name = "label3";
            label3.Size = new Size(325, 112);
            label3.TabIndex = 0;
            label3.Text = "Log In";
            label3.Click += label3_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top;
            panel2.BackColor = Color.Ivory;
            panel2.Location = new Point(320, 121);
            panel2.Name = "panel2";
            panel2.Size = new Size(478, 130);
            panel2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(77, 327);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(326, 23);
            txtPassword.TabIndex = 14;
            // 
            // LogInPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1118, 791);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LogInPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EcoTrack";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label2;
        private Label label3;
        private Panel panel2;
        private RichTextBox txtUsername;
        private Label label4;
        private Label label5;
        private LinkLabel linkLabel1;
        private CheckBox chkShowPassword;
        private Button btnLogin;
        private Label label6;
        private LinkLabel linkReg;
        private TextBox txtPassword;
    }
}
