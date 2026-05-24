using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace GarbageManagementSystem
{
    public partial class StaffDashboard : Form
    {
        private string Username;

        private bool showingReports = false;
        private bool showingHistory = false;

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

            EnsureHistoryFile();
        }

        private void EnsureHistoryFile()
        {
            string historyPath = Path.Combine(Application.StartupPath, "history.txt");

            if (!File.Exists(historyPath))
            {
                File.Create(historyPath).Close();
            }
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

        // ================= ACTIVE REPORTS =================
        private void LoadReports()
        {
            string path = Path.Combine(Application.StartupPath, "reports.txt");

            dgvReports.Rows.Clear();

            if (!File.Exists(path))
            {
                MessageBox.Show("reports.txt not found");
                return;
            }

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
                }
            }
        }

        // ================= HISTORY =================
        private void LoadHistory()
        {
            string historyPath = Path.Combine(Application.StartupPath, "history.txt");

            dgvReports.Rows.Clear();

            if (!File.Exists(historyPath))
            {
                MessageBox.Show("No history found.");
                return;
            }

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
                }
            }
        }

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
        private void btnMarkCleared_Click(object sender, EventArgs e)
        {
            if (dgvReports.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a report first.");
                return;
            }

            DataGridViewRow row = dgvReports.SelectedRows[0];

            row.Cells[4].Value = "Completed";
            row.DefaultCellStyle.BackColor = System.Drawing.Color.LightGreen;

            SaveReports();
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
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}