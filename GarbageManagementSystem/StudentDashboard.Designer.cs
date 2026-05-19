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
            mainPanel = new Panel();
            label1 = new Label();
            label2 = new Label();
            mainPanel.SuspendLayout();
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
            btnBack.Location = new Point(578, 306);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(88, 23);
            btnBack.TabIndex = 2;
            btnBack.Text = "Back to login";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // mainPanel
            // 
            mainPanel.BackColor = SystemColors.ActiveBorder;
            mainPanel.Controls.Add(label2);
            mainPanel.Controls.Add(label1);
            mainPanel.Controls.Add(btnBack);
            mainPanel.Controls.Add(btnReport);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1141, 709);
            mainPanel.TabIndex = 0;
            mainPanel.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(234, 51);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 0;
            label1.Text = "welcome";
           
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(284, 168);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 3;
            label2.Text = "label2";
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
        private Button btnReport;
        private Button btnBack;
        private Panel mainPanel;
        private Label label2;
        private Label label1;
    }
}