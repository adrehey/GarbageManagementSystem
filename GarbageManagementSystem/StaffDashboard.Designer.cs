namespace GarbageManagementSystem
{
    partial class StaffDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffDashboard));
            btnMarkCleared = new Button();
            btnViewHistory = new Button();
            btnViewReports = new Button();
            pictureBox1 = new PictureBox();
            btnBack = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnMarkCleared
            // 
            btnMarkCleared.BackgroundImage = (Image)resources.GetObject("btnMarkCleared.BackgroundImage");
            btnMarkCleared.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMarkCleared.ForeColor = Color.White;
            btnMarkCleared.Location = new Point(14, 334);
            btnMarkCleared.Name = "btnMarkCleared";
            btnMarkCleared.Size = new Size(310, 63);
            btnMarkCleared.TabIndex = 0;
            btnMarkCleared.Text = "Mark as Cleared";
            btnMarkCleared.UseVisualStyleBackColor = true;
            btnMarkCleared.Click += btnMarkCleared_Click;
            // 
            // btnViewHistory
            // 
            btnViewHistory.BackgroundImage = (Image)resources.GetObject("btnViewHistory.BackgroundImage");
            btnViewHistory.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewHistory.ForeColor = Color.White;
            btnViewHistory.Location = new Point(14, 472);
            btnViewHistory.Name = "btnViewHistory";
            btnViewHistory.Size = new Size(310, 63);
            btnViewHistory.TabIndex = 1;
            btnViewHistory.Text = "View History";
            btnViewHistory.UseVisualStyleBackColor = true;
            btnViewHistory.Click += btnViewHistory_Click;
            // 
            // btnViewReports
            // 
            btnViewReports.BackgroundImage = (Image)resources.GetObject("btnViewReports.BackgroundImage");
            btnViewReports.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewReports.ForeColor = Color.White;
            btnViewReports.Location = new Point(14, 403);
            btnViewReports.Name = "btnViewReports";
            btnViewReports.Size = new Size(310, 63);
            btnViewReports.TabIndex = 2;
            btnViewReports.Text = "View active reports";
            btnViewReports.UseVisualStyleBackColor = true;
            btnViewReports.Click += btnViewReports_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(339, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1553, 1017);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(0, 64, 0);
            btnBack.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(891, 502);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(122, 36);
            btnBack.TabIndex = 3;
            btnBack.Text = "Back to login";
            btnBack.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(14, 966);
            button1.Name = "button1";
            button1.Size = new Size(310, 63);
            button1.TabIndex = 4;
            button1.Text = "Log Out";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(12, 12);
            button2.Name = "button2";
            button2.Size = new Size(122, 36);
            button2.TabIndex = 5;
            button2.Text = "Back to login";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(14, 541);
            button3.Name = "button3";
            button3.Size = new Size(310, 63);
            button3.TabIndex = 6;
            button3.Text = "Show Live Data";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(16, 610);
            button4.Name = "button4";
            button4.Size = new Size(310, 63);
            button4.TabIndex = 7;
            button4.Text = "Show Map";
            button4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(57, 289);
            label1.Name = "label1";
            label1.Size = new Size(224, 23);
            label1.TabIndex = 8;
            label1.Text = "Welcome, {USERNAME}!";
            // 
            // StaffDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1904, 1041);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnBack);
            Controls.Add(btnViewReports);
            Controls.Add(pictureBox1);
            Controls.Add(btnViewHistory);
            Controls.Add(btnMarkCleared);
            Name = "StaffDashboard";
            Text = "StaffDashboard";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMarkCleared;
        private Button btnViewHistory;
        private Button btnViewReports;
        private PictureBox pictureBox1;
        private Button btnBack;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label1;
    }
}