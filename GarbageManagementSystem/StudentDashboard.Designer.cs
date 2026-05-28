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
            panel1 = new Panel();
            panel2 = new Panel();
            lblWelcome = new Label();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnBack = new Button();
            button2 = new Button();
            btnReport = new Button();
            mainPanel.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.BackColor = SystemColors.ActiveBorder;
            mainPanel.BackgroundImage = (Image)resources.GetObject("mainPanel.BackgroundImage");
            mainPanel.Controls.Add(panel1);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1904, 1041);
            mainPanel.TabIndex = 0;
            mainPanel.Paint += panel1_Paint;
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
            panel2.Controls.Add(lblWelcome);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(btnBack);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(btnReport);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(664, 1070);
            panel2.TabIndex = 2;
            // 
            // lblWelcome
            // 
            lblWelcome.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.White;
            lblWelcome.Location = new Point(267, 313);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(113, 23);
            lblWelcome.TabIndex = 7;
            lblWelcome.Text = "Welcome";
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(188, 448);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(60, 60);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(194, 364);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 60);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(233, 106);
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
            btnBack.Location = new Point(96, 844);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(455, 78);
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
            button2.Location = new Point(96, 440);
            button2.Name = "button2";
            button2.Size = new Size(455, 78);
            button2.TabIndex = 3;
            button2.Text = "        My Reports  ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnReport
            // 
            btnReport.BackgroundImage = (Image)resources.GetObject("btnReport.BackgroundImage");
            btnReport.Font = new Font("Century Gothic", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReport.ForeColor = Color.White;
            btnReport.Location = new Point(96, 356);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(455, 78);
            btnReport.TabIndex = 1;
            btnReport.Text = "        Report Trash";
            btnReport.UseVisualStyleBackColor = true;
            btnReport.Click += btnReport_Click;
            // 
            // StudentDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1041);
            Controls.Add(mainPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "StudentDashboard";
            Text = "StudentDashboard";
            WindowState = FormWindowState.Maximized;
            mainPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel mainPanel;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Button btnBack;
        private Button button2;
        private Button btnReport;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private Label lblWelcome;
    }
}