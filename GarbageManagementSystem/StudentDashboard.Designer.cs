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
            mainPanel = new Panel();
            btnBack = new Button();
            btnReport = new Button();
            label1 = new Label();
            mainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.BackColor = SystemColors.ActiveBorder;
            mainPanel.Controls.Add(btnBack);
            mainPanel.Controls.Add(btnReport);
            mainPanel.Controls.Add(label1);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1141, 709);
            mainPanel.TabIndex = 0;
            mainPanel.Paint += panel1_Paint;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(519, 217);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(88, 23);
            btnBack.TabIndex = 2;
            btnBack.Text = "Back to login";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnReport
            // 
            btnReport.Location = new Point(236, 186);
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
            label1.Location = new Point(519, 121);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 0;
            label1.Text = "welcome";
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
            ResumeLayout(false);
        }

        #endregion

        private Panel mainPanel;
        private Label label1;
        private Button btnReport;
        private Button btnBack;
    }
}