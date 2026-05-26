namespace GarbageManagementSystem
{
    partial class UserReports
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panel1 = new Panel();
            lblTotalReports = new Label();
            label1 = new Label();
            panel2 = new Panel();
            lblSuccessCount = new Label();
            label3 = new Label();
            panel3 = new Panel();
            lblEcoRank = new Label();
            label4 = new Label();
            dgvReports = new DataGridView();
            colDate = new DataGridViewTextBoxColumn();
            colIssue = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            btnDash = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReports).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FloralWhite;
            panel1.Controls.Add(btnDash);
            panel1.Controls.Add(lblTotalReports);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(630, 164);
            panel1.TabIndex = 0;
            // 
            // lblTotalReports
            // 
            lblTotalReports.AutoSize = true;
            lblTotalReports.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalReports.ForeColor = Color.FromArgb(0, 64, 0);
            lblTotalReports.Location = new Point(310, 91);
            lblTotalReports.Name = "lblTotalReports";
            lblTotalReports.Size = new Size(34, 40);
            lblTotalReports.TabIndex = 1;
            lblTotalReports.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 64, 0);
            label1.Location = new Point(238, 33);
            label1.Name = "label1";
            label1.Size = new Size(179, 32);
            label1.TabIndex = 0;
            label1.Text = "Total Reports";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FloralWhite;
            panel2.Controls.Add(lblSuccessCount);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(652, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(630, 164);
            panel2.TabIndex = 2;
            // 
            // lblSuccessCount
            // 
            lblSuccessCount.AutoSize = true;
            lblSuccessCount.BackColor = Color.Transparent;
            lblSuccessCount.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSuccessCount.ForeColor = Color.FromArgb(0, 64, 0);
            lblSuccessCount.Location = new Point(287, 93);
            lblSuccessCount.Name = "lblSuccessCount";
            lblSuccessCount.Size = new Size(34, 40);
            lblSuccessCount.TabIndex = 1;
            lblSuccessCount.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(0, 64, 0);
            label3.Location = new Point(176, 33);
            label3.Name = "label3";
            label3.Size = new Size(281, 32);
            label3.TabIndex = 0;
            label3.Text = "Successful Cleanups";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FloralWhite;
            panel3.Controls.Add(lblEcoRank);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(1292, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(600, 164);
            panel3.TabIndex = 3;
            // 
            // lblEcoRank
            // 
            lblEcoRank.AutoSize = true;
            lblEcoRank.BackColor = Color.Transparent;
            lblEcoRank.Font = new Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEcoRank.ForeColor = Color.FromArgb(0, 64, 0);
            lblEcoRank.Location = new Point(245, 95);
            lblEcoRank.Name = "lblEcoRank";
            lblEcoRank.Size = new Size(116, 36);
            lblEcoRank.TabIndex = 1;
            lblEcoRank.Text = "Novice";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(0, 64, 0);
            label4.Location = new Point(236, 34);
            label4.Name = "label4";
            label4.Size = new Size(139, 32);
            label4.TabIndex = 0;
            label4.Text = "Eco-Rank";
            // 
            // dgvReports
            // 
            dgvReports.AllowUserToAddRows = false;
            dgvReports.AllowUserToDeleteRows = false;
            dgvReports.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReports.Columns.AddRange(new DataGridViewColumn[] { colDate, colIssue, colStatus });
            dgvReports.Location = new Point(12, 182);
            dgvReports.Name = "dgvReports";
            dgvReports.ReadOnly = true;
            dgvReports.Size = new Size(1880, 847);
            dgvReports.TabIndex = 4;
            // 
            // colDate
            // 
            colDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colDate.HeaderText = "Date";
            colDate.Name = "colDate";
            colDate.ReadOnly = true;
            // 
            // colIssue
            // 
            colIssue.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colIssue.HeaderText = "Location";
            colIssue.Name = "colIssue";
            colIssue.ReadOnly = true;
            // 
            // colStatus
            // 
            colStatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colStatus.HeaderText = "Status";
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            // 
            // btnDash
            // 
            btnDash.Location = new Point(3, 3);
            btnDash.Name = "btnDash";
            btnDash.Size = new Size(75, 23);
            btnDash.TabIndex = 5;
            btnDash.Text = "Back";
            btnDash.UseVisualStyleBackColor = true;
            btnDash.Click += btnDash_Click;
            // 
            // UserReports
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1041);
            Controls.Add(dgvReports);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "UserReports";
            Text = "My Reports";
            WindowState = FormWindowState.Maximized;
            Load += UserReports_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReports).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblTotalReports;
        private Label label1;
        private Panel panel2;
        private Label lblSuccessCount;
        private Label label3;
        private Panel panel3;
        private Label lblEcoRank;
        private Label label4;
        private DataGridView dgvReports;
        private DataGridViewTextBoxColumn colDate;
        private DataGridViewTextBoxColumn colIssue;
        private DataGridViewTextBoxColumn colStatus;
        private Button btnDash;
    }
}