using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using System.Data.SQLite; // Ensure you have installed the System.Data.SQLite NuGet package

namespace GarbageManagementSystem
{
    public partial class StaffDashboard : Form
    {
        private string Username;
        private bool showingReports = false;
        private bool showingHistory = false;

        // Connection string pointing directly to your garbage.db
        private string connString = $"Data Source={Path.Combine(Application.StartupPath, "garbage.db")};Version=3;";

        public StaffDashboard(string user)
        {
            InitializeComponent();
            this.Load += StaffDashboard_Load;

            Username = user;
        }

        private void StaffDashboard_Load(object? sender, EventArgs e)
        {
            SetupGrid();

            dgvReports.Visible = false;
            picMap.Visible = false;

            lblUser.Text = $"Welcome, {Username} 👋";
        }

        private void SetupGrid()
        {
            dgvReports.Columns.Clear();

            dgvReports.AutoGenerateColumns = false;
            dgvReports.AllowUserToAddRows = false;
            dgvReports.ReadOnly = true;

            dgvReports.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReports.MultiSelect = false;

            dgvReports.Columns.Add("Student", "Student");
            dgvReports.Columns.Add("ID", "ID");
            dgvReports.Columns.Add("Location", "Location");
            dgvReports.Columns.Add("Bin", "Bin Code");
            dgvReports.Columns.Add("Status", "Status");
            dgvReports.Columns.Add("Time", "Time");
        }

        // ================= ACTIVE REPORTS FROM DATABASE =================
        private void LoadReports()
        {
            dgvReports.Rows.Clear();

            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connString))
                {
                    conn.Open();

                    // Pulls only reports that are NOT completed
                    string query = "SELECT StudentName, StudentID, Location, BinCode, Status, ReportTime FROM Reports WHERE Status != 'Completed'";

                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int rowIndex = dgvReports.Rows.Add(
                                reader["StudentName"].ToString(),
                                reader["StudentID"].ToString(),
                                reader["Location"].ToString(),
                                reader["BinCode"].ToString(),
                                reader["Status"].ToString(),
                                reader["ReportTime"].ToString()
                            );

                            string status = reader["Status"].ToString().ToLower();

                            if (status == "pending")
                                dgvReports.Rows[rowIndex].DefaultCellStyle.BackColor = System.Drawing.Color.LightCoral;
                            else if (status == "in progress")
                                dgvReports.Rows[rowIndex].DefaultCellStyle.BackColor = System.Drawing.Color.Khaki;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading active reports: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ================= HISTORY FROM DATABASE =================
        private void LoadHistory()
        {
            dgvReports.Rows.Clear();

            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connString))
                {
                    conn.Open();

                    // Pulls ONLY completed items for the history log
                    string query = "SELECT StudentName, StudentID, Location, BinCode, Status, ReportTime FROM Reports WHERE Status = 'Completed'";

                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int rowIndex = dgvReports.Rows.Add(
                                reader["StudentName"].ToString(),
                                reader["StudentID"].ToString(),
                                reader["Location"].ToString(),
                                reader["BinCode"].ToString(),
                                reader["Status"].ToString(),
                                reader["ReportTime"].ToString()
                            );

                            // History records are styled green
                            dgvReports.Rows[rowIndex].DefaultCellStyle.BackColor = System.Drawing.Color.LightGreen;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading history: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ================= TOGGLE REPORTS =================
        private void btnViewReports_Click(object sender, EventArgs e)
        {
            showingReports = !showingReports;

            if (showingReports)
            {
                showingHistory = false;
                picMap.Visible = false;

                dgvReports.Visible = true;
                LoadReports();
            }
            else
            {
                dgvReports.Visible = false;
            }
        }

        // ================= TOGGLE HISTORY =================
        private void btnViewHistory_Click(object sender, EventArgs e)
        {
            showingHistory = !showingHistory;

            if (showingHistory)
            {
                showingReports = false;
                picMap.Visible = false;

                dgvReports.Visible = true;
                LoadHistory();
            }
            else
            {
                dgvReports.Visible = false;
            }
        }

        // ================= MARK COMPLETED IN DATABASE =================
        private void btnMarkCleared_Click(object sender, EventArgs e)
        {
            if (dgvReports.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a report first.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow row = dgvReports.SelectedRows[0];

            string studentId = row.Cells[1].Value?.ToString() ?? "";
            string binCode = row.Cells[3].Value?.ToString() ?? "";
            string timeStamp = row.Cells[5].Value?.ToString() ?? "";

            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connString))
                {
                    conn.Open();

                    // Changes the status inside the data row to 'Completed'
                    string query = "UPDATE Reports SET Status = 'Completed' WHERE StudentID = @id AND BinCode = @bin AND ReportTime = @time";

                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", studentId);
                        cmd.Parameters.AddWithValue("@bin", binCode);
                        cmd.Parameters.AddWithValue("@time", timeStamp);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Report successfully marked as cleared!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Live refresh the data grid view so it immediately drops out of sight
                LoadReports();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error clearing report: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ================= MAP TOGGLE =================
        private void btnShowMap_Click(object sender, EventArgs e)
        {
            picMap.Visible = !picMap.Visible;

            if (picMap.Visible)
            {
                dgvReports.Visible = false;
                showingReports = false;
                showingHistory = false;
            }
        }

        // ================= EXIT =================
        private void btnOut_Click(object sender, EventArgs e)
        {
            LogInPage login = new LogInPage();
            login.Show();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e) { }
        private void lblUser_Click(object sender, EventArgs e) { }
    }
}