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
            dgvReports = new DataGridView();
            panelTop = new Panel();
            panelActions = new Panel();
            btnViewHistory = new Button();
            btnMarkCleared = new Button();
            btnViewReports = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvReports).BeginInit();
            panelActions.SuspendLayout();
            SuspendLayout();
            // 
            // dgvReports
            // 
            dgvReports.AllowUserToAddRows = false;
            dgvReports.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReports.Dock = DockStyle.Fill;
            dgvReports.Location = new Point(0, 100);
            dgvReports.Name = "dgvReports";
            dgvReports.ReadOnly = true;
            dgvReports.Size = new Size(1156, 448);
            dgvReports.TabIndex = 0;
            // 
            // panelTop
            // 
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1156, 100);
            panelTop.TabIndex = 1;
            // 
            // panelActions
            // 
            panelActions.Controls.Add(btnViewReports);
            panelActions.Controls.Add(btnViewHistory);
            panelActions.Controls.Add(btnMarkCleared);
            panelActions.Dock = DockStyle.Bottom;
            panelActions.Location = new Point(0, 548);
            panelActions.Name = "panelActions";
            panelActions.Size = new Size(1156, 100);
            panelActions.TabIndex = 0;
            // 
            // btnViewHistory
            // 
            btnViewHistory.Location = new Point(193, 26);
            btnViewHistory.Name = "btnViewHistory";
            btnViewHistory.Size = new Size(104, 23);
            btnViewHistory.TabIndex = 1;
            btnViewHistory.Text = "View History";
            btnViewHistory.UseVisualStyleBackColor = true;
            btnViewHistory.Click += btnViewHistory_Click;
            // 
            // btnMarkCleared
            // 
            btnMarkCleared.Location = new Point(63, 26);
            btnMarkCleared.Name = "btnMarkCleared";
            btnMarkCleared.Size = new Size(124, 23);
            btnMarkCleared.TabIndex = 0;
            btnMarkCleared.Text = "Mark as Cleared";
            btnMarkCleared.UseVisualStyleBackColor = true;
            btnMarkCleared.Click += btnMarkCleared_Click;
            // 
            // btnViewReports
            // 
            btnViewReports.Location = new Point(312, 26);
            btnViewReports.Name = "btnViewReports";
            btnViewReports.Size = new Size(130, 23);
            btnViewReports.TabIndex = 2;
            btnViewReports.Text = "View active reports";
            btnViewReports.UseVisualStyleBackColor = true;
            btnViewReports.Click += btnViewReports_Click;
            // 
            // StaffDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1156, 648);
            Controls.Add(dgvReports);
            Controls.Add(panelTop);
            Controls.Add(panelActions);
            Name = "StaffDashboard";
            Text = "StaffDashboard";
            ((System.ComponentModel.ISupportInitialize)dgvReports).EndInit();
            panelActions.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvReports;
        private Panel panelTop;
        private Panel panelActions;
        private Button btnMarkCleared;
        private Button btnViewHistory;
        private Button btnViewReports;
    }
}