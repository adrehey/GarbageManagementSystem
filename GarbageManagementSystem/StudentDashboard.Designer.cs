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
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1141, 709);
            mainPanel.TabIndex = 0;
            mainPanel.Paint += panel1_Paint;
            // 
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
            // 
            // StudentDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1141, 709);
            Controls.Add(mainPanel);
            Name = "StudentDashboard";
            Text = "StudentDashboard";
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMyReports).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnReport;
        private Button btnBack;
        private Label lblWelcome;
        private Button btnOut;
        private Panel mainPanel;
        private Button btnViewReports;
        private DataGridView dgvMyReports;
    }
}