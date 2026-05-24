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
            picMap = new PictureBox();
            btnOut = new Button();
            btnShowMap = new Button();
            lblUser = new Label();
            dgvReports = new DataGridView();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picMap).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvReports).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            // picMap
            // 
            picMap.Image = (Image)resources.GetObject("picMap.Image");
            picMap.Location = new Point(339, 12);
            picMap.Name = "picMap";
            picMap.Size = new Size(1553, 1017);
            picMap.SizeMode = PictureBoxSizeMode.StretchImage;
            picMap.TabIndex = 2;
            picMap.TabStop = false;
            // 
            // btnOut
            // 
            btnOut.BackgroundImage = (Image)resources.GetObject("btnOut.BackgroundImage");
            btnOut.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOut.ForeColor = Color.White;
            btnOut.Location = new Point(14, 966);
            btnOut.Name = "btnOut";
            btnOut.Size = new Size(310, 63);
            btnOut.TabIndex = 4;
            btnOut.Text = "Log Out";
            btnOut.UseVisualStyleBackColor = true;
            btnOut.Click += btnOut_Click;
            // 
            // btnShowMap
            // 
            btnShowMap.BackgroundImage = (Image)resources.GetObject("btnShowMap.BackgroundImage");
            btnShowMap.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnShowMap.ForeColor = Color.White;
            btnShowMap.Location = new Point(12, 541);
            btnShowMap.Name = "btnShowMap";
            btnShowMap.Size = new Size(310, 63);
            btnShowMap.TabIndex = 7;
            btnShowMap.Text = "Show Map";
            btnShowMap.UseVisualStyleBackColor = true;
            btnShowMap.Click += btnShowMap_Click;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.BackColor = Color.Transparent;
            lblUser.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUser.ForeColor = Color.White;
            lblUser.Location = new Point(93, 289);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(113, 23);
            lblUser.TabIndex = 8;
            lblUser.Text = "Welcome, !";
            // 
            // dgvReports
            // 
            dgvReports.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReports.Location = new Point(339, 12);
            dgvReports.Name = "dgvReports";
            dgvReports.Size = new Size(1553, 1017);
            dgvReports.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(79, 92);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(180, 180);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(715, 120);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(800, 800);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // StaffDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1904, 1041);
            Controls.Add(pictureBox1);
            Controls.Add(dgvReports);
            Controls.Add(lblUser);
            Controls.Add(btnShowMap);
            Controls.Add(btnOut);
            Controls.Add(btnViewReports);
            Controls.Add(picMap);
            Controls.Add(btnViewHistory);
            Controls.Add(btnMarkCleared);
            Controls.Add(pictureBox2);
            Name = "StaffDashboard";
            Text = "StaffDashboard";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)picMap).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvReports).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMarkCleared;
        private Button btnViewHistory;
        private Button btnViewReports;
        private PictureBox picMap;
        private Button btnOut;
        private Button btnShowMap;
        private Label lblUser;
        private DataGridView dgvReports;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}