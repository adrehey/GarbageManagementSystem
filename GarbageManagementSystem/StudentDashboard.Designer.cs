namespace GarbageManagementSystem
{
    partial class StudentDashboard
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
<<<<<<< Updated upstream
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentDashboard));
            mainPanel = new Panel();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            btnBack = new Button();
            button2 = new Button();
            btnReport = new Button();
            label1 = new Label();
            mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.BackColor = SystemColors.ActiveBorder;
            mainPanel.BackgroundImage = (Image)resources.GetObject("mainPanel.BackgroundImage");
            mainPanel.Controls.Add(pictureBox1);
            mainPanel.Controls.Add(panel1);
=======
            btnReport = new Button();
            btnBack = new Button();
            lblWelcome = new Label();
            btnOut = new Button();
            mainPanel = new Panel();
            dgvMyReports = new DataGridView();
            btnViewReports = new Button();
            mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMyReports).BeginInit();
            SuspendLayout();
            // 
            // btnReport
            // 
            btnReport.Location = new Point(179, 298);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(119, 23);
            btnReport.TabIndex = 1;
            btnReport.Text = "Report Trash";
            btnReport.UseVisualStyleBackColor = true;
            btnReport.Click += btnReport_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(456, 284);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(88, 23);
            btnBack.TabIndex = 2;
            btnBack.Text = "Back to login";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.BackColor = SystemColors.ButtonHighlight;
            lblWelcome.Location = new Point(234, 51);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(55, 15);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "welcome";
            // 
            // btnOut
            // 
            btnOut.Location = new Point(456, 109);
            btnOut.Name = "btnOut";
            btnOut.Size = new Size(75, 23);
            btnOut.TabIndex = 3;
            btnOut.Text = "Log out";
            btnOut.UseVisualStyleBackColor = true;
            btnOut.Click += btnOut_Click;
            // 
            // mainPanel
            // 
            mainPanel.BackColor = SystemColors.ActiveBorder;
            mainPanel.Controls.Add(dgvMyReports);
            mainPanel.Controls.Add(btnViewReports);
            mainPanel.Controls.Add(btnOut);
            mainPanel.Controls.Add(lblWelcome);
            mainPanel.Controls.Add(btnBack);
            mainPanel.Controls.Add(btnReport);
>>>>>>> Stashed changes
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1904, 1041);
            mainPanel.TabIndex = 0;
            mainPanel.Paint += panel1_Paint;
            // 
<<<<<<< Updated upstream
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(339, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1553, 1017);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1904, 1041);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(btnBack);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(btnReport);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(337, 1041);
            panel2.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(79, 106);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(180, 180);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Transparent;
            btnBack.BackgroundImage = (Image)resources.GetObject("btnBack.BackgroundImage");
            btnBack.Font = new Font("Century Gothic", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(14, 951);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(310, 78);
            btnBack.TabIndex = 2;
            btnBack.Text = "Log Out";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.Font = new Font("Century Gothic", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.ImageAlign = ContentAlignment.MiddleRight;
            button2.Location = new Point(14, 418);
            button2.Name = "button2";
            button2.Size = new Size(310, 78);
            button2.TabIndex = 3;
            button2.Text = "My Reports  ";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = true;
            // 
            // btnReport
            // 
            btnReport.BackgroundImage = (Image)resources.GetObject("btnReport.BackgroundImage");
            btnReport.Font = new Font("Century Gothic", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReport.ForeColor = Color.White;
            btnReport.Location = new Point(14, 334);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(310, 78);
            btnReport.TabIndex = 1;
            btnReport.Text = "Report Trash";
            btnReport.TextAlign = ContentAlignment.MiddleRight;
            btnReport.UseVisualStyleBackColor = true;
            btnReport.Click += btnReport_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(93, 289);
            label1.Name = "label1";
            label1.Size = new Size(113, 23);
            label1.TabIndex = 0;
            label1.Text = "Welcome, !";
            label1.Click += label1_Click;
=======
            // dgvMyReports
            // 
            dgvMyReports.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMyReports.Location = new Point(673, 51);
            dgvMyReports.Name = "dgvMyReports";
            dgvMyReports.Size = new Size(435, 256);
            dgvMyReports.TabIndex = 5;
            // 
            // btnViewReports
            // 
            btnViewReports.Location = new Point(284, 197);
            btnViewReports.Name = "btnViewReports";
            btnViewReports.Size = new Size(118, 23);
            btnViewReports.TabIndex = 4;
            btnViewReports.Text = "view my reports";
            btnViewReports.UseVisualStyleBackColor = true;
            btnViewReports.Click += btnViewReports_Click;
>>>>>>> Stashed changes
            // 
            // StudentDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1041);
            Controls.Add(mainPanel);
            Name = "StudentDashboard";
            Text = "StudentDashboard";
            WindowState = FormWindowState.Maximized;
            mainPanel.ResumeLayout(false);
<<<<<<< Updated upstream
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
=======
            mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMyReports).EndInit();
>>>>>>> Stashed changes
            ResumeLayout(false);
        }

        #endregion

<<<<<<< Updated upstream
        private Panel mainPanel;
        private Label label1;
        private Button btnReport;
        private Button btnBack;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel2;
        private Button button2;
        private PictureBox pictureBox2;
=======
        private Button btnReport;
        private Button btnBack;
        private Label lblWelcome;
        private Button btnOut;
        private Panel mainPanel;
        private Button btnViewReports;
        private DataGridView dgvMyReports;
>>>>>>> Stashed changes
    }
}