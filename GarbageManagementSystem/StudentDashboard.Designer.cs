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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentDashboard));
            mainPanel = new Panel();
            pictureBox1 = new PictureBox();
            btnBack = new Button();
            btnReport = new Button();
            label1 = new Label();
            panel1 = new Panel();
            mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.BackColor = SystemColors.ActiveBorder;
            mainPanel.BackgroundImage = (Image)resources.GetObject("mainPanel.BackgroundImage");
            mainPanel.Controls.Add(pictureBox1);
            mainPanel.Controls.Add(btnBack);
            mainPanel.Controls.Add(btnReport);
            mainPanel.Controls.Add(label1);
            mainPanel.Controls.Add(panel1);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1904, 1041);
            mainPanel.TabIndex = 0;
            mainPanel.Paint += panel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(339, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1565, 1041);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(12, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(88, 23);
            btnBack.TabIndex = 2;
            btnBack.Text = "Back to login";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnReport
            // 
            btnReport.Location = new Point(33, 109);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(119, 23);
            btnReport.TabIndex = 1;
            btnReport.Text = "Report Trash";
            btnReport.UseVisualStyleBackColor = true;
            btnReport.Click += btnReport_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(51, 184);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 0;
            label1.Text = "welcome";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1904, 1041);
            panel1.TabIndex = 4;
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
            mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel mainPanel;
        private Label label1;
        private Button btnReport;
        private Button btnBack;
        private PictureBox pictureBox1;
        private Panel panel1;
    }
}