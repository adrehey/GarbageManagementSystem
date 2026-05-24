using System;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;

namespace GarbageManagementSystem
{
    public partial class StaffDashboard : Form
    {
<<<<<<< Updated upstream
        private string Username;

        private bool showingReports = false;
        private bool showingHistory = false;

        public StaffDashboard(string user)
=======
        private readonly string connectionString =
            "Data Source=garbage.db;Version=3;BusyTimeout=3000;";

        private bool isUpdating = false;

        public StaffDashboard()
>>>>>>> Stashed changes
        {
            InitializeComponent();
            this.Load += StaffDashboard_Load;

            Username = user;
        }

<<<<<<< Updated upstream
        private void StaffDashboard_Load(object? sender, EventArgs e)
=======
        // FORM LOAD
        private void StaffDashboard_Load(object sender, EventArgs e)
>>>>>>> Stashed changes
        {
            EnsureDatabaseTableExists();

            SetupGrid();
<<<<<<< Updated upstream

            dgvReports.Visible = false;
            picMap.Visible = false;

            lblUser.Text = $"Welcome, {Username} 👋";

            EnsureHistoryFile();
        }

        private void EnsureHistoryFile()
=======
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
>>>>>>> Stashed changes
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

<<<<<<< Updated upstream
=======
        // GRID SETUP
>>>>>>> Stashed changes
        private void SetupGrid()
        {
            dgvReports.Columns.Clear();

            dgvReports.AutoGenerateColumns = false;
            dgvReports.AllowUserToAddRows = false;
            dgvReports.ReadOnly = true;
<<<<<<< Updated upstream

=======
            dgvReports.Dock = DockStyle.Fill;
>>>>>>> Stashed changes
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

<<<<<<< Updated upstream
        // ================= ACTIVE REPORTS =================
=======
        // LOAD ACTIVE REPORTS
>>>>>>> Stashed changes
        private void LoadReports()
        {
            dgvReports.Rows.Clear();

            using (SQLiteConnection con = new SQLiteConnection(connectionString))
            {
                con.Open();

<<<<<<< Updated upstream
            foreach (string line in File.ReadAllLines(path))
            {
                if (string.IsNullOrWhiteSpace(line)) continue;

                string[] data = line.Split(',')
                                    .Select(x => x.Trim())
                                    .ToArray();

                if (data.Length == 6)
                {
                    int rowIndex = dgvReports.Rows.Add(data);

                    string status = data[4].ToLower();

                    if (status == "pending")
                        dgvReports.Rows[rowIndex].DefaultCellStyle.BackColor = System.Drawing.Color.LightCoral;
                    else if (status == "in progress")
                        dgvReports.Rows[rowIndex].DefaultCellStyle.BackColor = System.Drawing.Color.Khaki;
                    else if (status == "completed")
                        dgvReports.Rows[rowIndex].DefaultCellStyle.BackColor = System.Drawing.Color.LightGreen;
=======
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
>>>>>>> Stashed changes
                }
            }
        }

<<<<<<< Updated upstream
        // ================= HISTORY =================
=======
        // LOAD HISTORY
>>>>>>> Stashed changes
        private void LoadHistory()
        {
            dgvReports.Rows.Clear();

            using (SQLiteConnection con = new SQLiteConnection(connectionString))
            {
                con.Open();

<<<<<<< Updated upstream
            foreach (string line in File.ReadAllLines(historyPath))
            {
                if (string.IsNullOrWhiteSpace(line)) continue;

                string[] data = line.Split(',')
                                    .Select(x => x.Trim())
                                    .ToArray();

                if (data.Length == 6)
                {
                    int rowIndex = dgvReports.Rows.Add(data);

                    dgvReports.Rows[rowIndex].DefaultCellStyle.BackColor =
                        System.Drawing.Color.LightGreen;
=======
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
>>>>>>> Stashed changes
                }
            }
        }

<<<<<<< Updated upstream
        private void SaveReports()
        {
            string path = Path.Combine(Application.StartupPath, "reports.txt");

            var lines = dgvReports.Rows
                .Cast<DataGridViewRow>()
                .Where(r => !r.IsNewRow)
                .Select(r => string.Join(",",
                    r.Cells[0].Value,
                    r.Cells[1].Value,
                    r.Cells[2].Value,
                    r.Cells[3].Value,
                    r.Cells[4].Value,
                    r.Cells[5].Value
                ));

            File.WriteAllLines(path, lines);
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

        // ================= MARK COMPLETED =================
=======
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
>>>>>>> Stashed changes
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

<<<<<<< Updated upstream
            SaveReports();
        }

        // ================= MAP TOGGLE =================
        private void btnShowMap_Click(object sender, EventArgs e)
=======
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
>>>>>>> Stashed changes
        {
            picMap.Visible = !picMap.Visible;

<<<<<<< Updated upstream
            if (picMap.Visible)
            {
                dgvReports.Visible = false;
                showingReports = false;
                showingHistory = false;
            }
        }

        // ================= EXIT =================
        private void btnOut_Click(object sender, EventArgs e)
=======
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
>>>>>>> Stashed changes
        {
            Application.Exit();
        }

<<<<<<< Updated upstream
        private void pictureBox2_Click(object sender, EventArgs e)
=======
        // LOGOUT
        private void btnLog_Click(object sender, EventArgs e)
>>>>>>> Stashed changes
        {

        }
    }
}