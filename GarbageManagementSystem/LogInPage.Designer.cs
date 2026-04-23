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
            linkLabel2 = new LinkLabel();
            label6 = new Label();
            btnLogin = new Button();
            linkLabel1 = new LinkLabel();
            checkBox1 = new CheckBox();
            label5 = new Label();
            label4 = new Label();
            txtPassword = new RichTextBox();
            txtUsername = new RichTextBox();
            label3 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(291, 149);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(linkLabel2);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(366, 240);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(9, 11, 9, 11);
            panel1.Size = new Size(546, 800);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.BackColor = Color.ForestGreen;
            linkLabel2.LinkColor = Color.Yellow;
            linkLabel2.Location = new Point(363, 648);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(59, 20);
            linkLabel2.TabIndex = 14;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Sign up";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked_1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Transparent;
            label6.Location = new Point(136, 645);
            label6.Name = "label6";
            label6.Size = new Size(230, 23);
            label6.TabIndex = 13;
            label6.Text = "Don't have an account?";
            label6.Click += label6_Click_1;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Ivory;
            btnLogin.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.Green;
            btnLogin.Location = new Point(87, 563);
            btnLogin.Margin = new Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(373, 71);
            btnLogin.TabIndex = 12;
            btnLogin.Text = "Log In";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel1.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabel1.LinkColor = Color.Khaki;
            linkLabel1.Location = new Point(307, 503);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(170, 23);
            linkLabel1.TabIndex = 11;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Forgot Password?";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.Transparent;
            checkBox1.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox1.ForeColor = Color.Ivory;
            checkBox1.Location = new Point(87, 501);
            checkBox1.Margin = new Padding(3, 4, 3, 4);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(169, 27);
            checkBox1.TabIndex = 10;
            checkBox1.Text = "Remember me";
            checkBox1.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Transparent;
            label5.Location = new Point(87, 401);
            label5.Name = "label5";
            label5.Size = new Size(128, 28);
            label5.TabIndex = 7;
            label5.Text = "Password:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(87, 315);
            label4.Name = "label4";
            label4.Size = new Size(95, 28);
            label4.TabIndex = 6;
            label4.Text = "Sign In:";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.Ivory;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(87, 443);
            txtPassword.Margin = new Padding(6, 7, 6, 7);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(373, 35);
            txtPassword.TabIndex = 5;
            txtPassword.Text = "";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.Ivory;
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(87, 356);
            txtUsername.Margin = new Padding(6, 7, 6, 7);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(373, 35);
            txtUsername.TabIndex = 4;
            txtUsername.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Century Gothic", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Ivory;
            label3.Location = new Point(88, 131);
            label3.Name = "label3";
            label3.Size = new Size(409, 141);
            label3.TabIndex = 0;
            label3.Text = "Log In";
            label3.Click += label3_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.Ivory;
            panel2.Location = new Point(366, 161);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(546, 173);
            panel2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 1;
            // 
            // LogInPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1278, 1055);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
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
        private RichTextBox txtPassword;
        private Label label4;
        private Label label5;
        private LinkLabel linkLabel1;
        private CheckBox checkBox1;
        private Button btnLogin;
        private Label label6;
        private LinkLabel linkLabel2;
    }
}
