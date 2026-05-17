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
            lblTotal = new Label();
            lblCompleted = new Label();
            lblPending = new Label();
            panelActions = new Panel();
            btnViewReports = new Button();
            btnViewHistory = new Button();
            btnMarkCleared = new Button();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvReports).BeginInit();
            panelTop.SuspendLayout();
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
            panelTop.Controls.Add(lblTotal);
            panelTop.Controls.Add(lblCompleted);
            panelTop.Controls.Add(lblPending);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1156, 100);
            panelTop.TabIndex = 1;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTotal.Location = new Point(256, 28);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(127, 21);
            lblTotal.TabIndex = 2;
            lblTotal.Text = "Total Reports: 0";
            // 
            // lblCompleted
            // 
            lblCompleted.AutoSize = true;
            lblCompleted.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCompleted.Location = new Point(124, 28);
            lblCompleted.Name = "lblCompleted";
            lblCompleted.Size = new Size(111, 21);
            lblCompleted.TabIndex = 1;
            lblCompleted.Text = "Completed: 0";
            // 
            // lblPending
            // 
            lblPending.AutoSize = true;
            lblPending.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblPending.Location = new Point(11, 28);
            lblPending.Name = "lblPending";
            lblPending.Size = new Size(91, 21);
            lblPending.TabIndex = 0;
            lblPending.Text = "Pending: 0";
            // 
            // panelActions
            // 
            panelActions.Controls.Add(btnExit);
            panelActions.Controls.Add(btnViewReports);
            panelActions.Controls.Add(btnViewHistory);
            panelActions.Controls.Add(btnMarkCleared);
            panelActions.Dock = DockStyle.Bottom;
            panelActions.Location = new Point(0, 548);
            panelActions.Name = "panelActions";
            panelActions.Size = new Size(1156, 100);
            panelActions.TabIndex = 0;
            // 
            // btnViewReports
            // 
            btnViewReports.Location = new Point(312, 26);
            btnViewReports.Name = "btnViewReports";
            btnViewReports.Size = new Size(120, 40);
            btnViewReports.TabIndex = 2;
            btnViewReports.Text = "View active reports";
            btnViewReports.UseVisualStyleBackColor = true;
            btnViewReports.Click += btnViewReports_Click;
            // 
            // btnViewHistory
            // 
            btnViewHistory.Location = new Point(186, 26);
            btnViewHistory.Name = "btnViewHistory";
            btnViewHistory.Size = new Size(120, 40);
            btnViewHistory.TabIndex = 1;
            btnViewHistory.Text = "View History";
            btnViewHistory.UseVisualStyleBackColor = true;
            btnViewHistory.Click += btnViewHistory_Click;
            // 
            // btnMarkCleared
            // 
            btnMarkCleared.Location = new Point(63, 26);
            btnMarkCleared.Name = "btnMarkCleared";
            btnMarkCleared.Size = new Size(120, 40);
            btnMarkCleared.TabIndex = 0;
            btnMarkCleared.Text = "Mark as Cleared";
            btnMarkCleared.UseVisualStyleBackColor = true;
            btnMarkCleared.Click += btnMarkCleared_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(447, 26);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(120, 40);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit system";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
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
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
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
        private Label lblTotal;
        private Label lblCompleted;
        private Label lblPending;
        private Button btnExit;
    }
}