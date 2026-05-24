using System;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;

namespace GarbageManagementSystem
{
    public partial class StaffDashboard : Form
    {
        private readonly string connectionString =
            "Data Source=garbage.db;Version=3;BusyTimeout=3000;";

        private bool isUpdating = false;

        public StaffDashboard()
        {
            InitializeComponent();
            this.Load += StaffDashboard_Load;
        }

        // FORM LOAD
        private void StaffDashboard_Load(object sender, EventArgs e)
        {
            EnsureDatabaseTableExists();

            SetupGrid();
            LoadReports();
            UpdateStats();

            LoadNotifications();
            MarkReportsAsRead();

            timerNotify.Interval = 5000;
            timerNotify.Tick += timerNotify_Tick;
            timerNotify.Start();
        }

        // CREATE TABLE IF NOT EXISTS
        private void EnsureDatabaseTableExists()
        {
            using (SQLiteConnection con = new SQLiteConnection(connectionString))
            {
                con.Open();

                string query = @"
                CREATE TABLE IF NOT EXISTS Reports (
                    ID INTEGER PRIMARY KEY AUTOINCREMENT,
                    StudentName TEXT,
                    StudentID TEXT,
                    Location TEXT,
                    BinCode TEXT,
                    Status TEXT,
                    DateTime TEXT,
                    IsRead INTEGER DEFAULT 0
                );";

                using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // GRID SETUP
        private void SetupGrid()
        {
            dgvReports.Columns.Clear();

            dgvReports.AutoGenerateColumns = false;
            dgvReports.AllowUserToAddRows = false;
            dgvReports.ReadOnly = true;
            dgvReports.Dock = DockStyle.Fill;
            dgvReports.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReports.MultiSelect = true;

            dgvReports.Columns.Add("ID", "ID");
            dgvReports.Columns.Add("StudentName", "Student");
            dgvReports.Columns.Add("StudentID", "ID");
            dgvReports.Columns.Add("Location", "Location");
            dgvReports.Columns.Add("BinCode", "Bin Code");
            dgvReports.Columns.Add("Status", "Status");
            dgvReports.Columns.Add("DateTime", "Time");
        }

        // LOAD ACTIVE REPORTS
        private void LoadReports()
        {
            dgvReports.Rows.Clear();

            using (SQLiteConnection con = new SQLiteConnection(connectionString))
            {
                con.Open();

                string query = "SELECT * FROM Reports WHERE Status != 'Completed'";

                using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string status = reader["Status"]?.ToString() ?? "";

                        int rowIndex = dgvReports.Rows.Add(
                            reader["ID"].ToString(),
                            reader["StudentName"]?.ToString() ?? "",
                            reader["StudentID"]?.ToString() ?? "",
                            reader["Location"]?.ToString() ?? "",
                            reader["BinCode"]?.ToString() ?? "",
                            status,
                            reader["DateTime"]?.ToString() ?? ""
                        );

                        ApplyRowColor(rowIndex, status);
                    }
                }
            }
        }

        // LOAD HISTORY
        private void LoadHistory()
        {
            dgvReports.Rows.Clear();

            using (SQLiteConnection con = new SQLiteConnection(connectionString))
            {
                con.Open();

                string query = "SELECT * FROM Reports WHERE Status = 'Completed'";

                using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string status = reader["Status"]?.ToString() ?? "";

                        int rowIndex = dgvReports.Rows.Add(
                            reader["ID"].ToString(),
                            reader["StudentName"]?.ToString() ?? "",
                            reader["StudentID"]?.ToString() ?? "",
                            reader["Location"]?.ToString() ?? "",
                            reader["BinCode"]?.ToString() ?? "",
                            status,
                            reader["DateTime"]?.ToString() ?? ""
                        );

                        ApplyRowColor(rowIndex, status);
                    }
                }
            }
        }

        // ROW COLORS
        private void ApplyRowColor(int rowIndex, string status)
        {
            if (status.Equals("pending", StringComparison.OrdinalIgnoreCase))
                dgvReports.Rows[rowIndex].DefaultCellStyle.BackColor = Color.LightCoral;

            else if (status.Equals("in progress", StringComparison.OrdinalIgnoreCase))
                dgvReports.Rows[rowIndex].DefaultCellStyle.BackColor = Color.Khaki;

            else if (status.Equals("completed", StringComparison.OrdinalIgnoreCase))
                dgvReports.Rows[rowIndex].DefaultCellStyle.BackColor = Color.LightGreen;
        }

        // MARK AS COMPLETED
        private void btnMarkCleared_Click(object sender, EventArgs e)
        {
            if (dgvReports.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select at least one report.");
                return;
            }

            using (SQLiteConnection con = new SQLiteConnection(connectionString))
            {
                con.Open();

                foreach (DataGridViewRow row in dgvReports.SelectedRows)
                {
                    string id = row.Cells["ID"].Value.ToString();

                    string query = @"UPDATE Reports SET Status='Completed' WHERE ID=@id";

                    using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }
                }
            }

            LoadReports();
            UpdateStats();
        }

        // VIEW HISTORY
        private void btnViewHistory_Click(object sender, EventArgs e)
        {
            LoadHistory();
            UpdateStats();
        }

        // VIEW ACTIVE REPORTS
        private void btnViewReports_Click(object sender, EventArgs e)
        {
            LoadReports();
            UpdateStats();
        }

        // UPDATE STATS
        private void UpdateStats()
        {
            using (SQLiteConnection con = new SQLiteConnection(connectionString))
            {
                con.Open();

                int pending = Convert.ToInt32(
                    new SQLiteCommand("SELECT COUNT(*) FROM Reports WHERE Status='Pending'", con)
                    .ExecuteScalar());

                int completed = Convert.ToInt32(
                    new SQLiteCommand("SELECT COUNT(*) FROM Reports WHERE Status='Completed'", con)
                    .ExecuteScalar());

                lblPending.Text = "Pending: " + pending;
                lblCompleted.Text = "Completed: " + completed;
                lblTotal.Text = "Total: " + (pending + completed);
            }
        }

        // 🔔 NOTIFICATIONS
        private void LoadNotifications()
        {
            using (SQLiteConnection con = new SQLiteConnection(connectionString))
            {
                con.Open();

                string query = "SELECT COUNT(*) FROM Reports WHERE IsRead = 0";
                SQLiteCommand cmd = new SQLiteCommand(query, con);

                int count = Convert.ToInt32(cmd.ExecuteScalar());

                lblNewReports.Text = "New Reports: " + count;
                lblNewReports.ForeColor = count > 0 ? Color.Red : Color.Green;
            }
        }

        // MARK AS READ
        private void MarkReportsAsRead()
        {
            using (SQLiteConnection con = new SQLiteConnection(connectionString))
            {
                con.Open();

                string query = "UPDATE Reports SET IsRead = 1 WHERE IsRead = 0";

                using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // TIMER (SAFE VERSION)
        private void timerNotify_Tick(object sender, EventArgs e)
        {
            if (isUpdating) return;

            try
            {
                isUpdating = true;

                LoadNotifications();
                UpdateStats();
            }
            finally
            {
                isUpdating = false;
            }
        }

        // EXIT
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // LOGOUT
        private void btnLog_Click(object sender, EventArgs e)
        {
            LogInPage login = new LogInPage();
            login.Show();
            this.Hide();
        }
    }
}