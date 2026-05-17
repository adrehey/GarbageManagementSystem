using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace GarbageManagementSystem
{
    public partial class StaffDashboard : Form
    {
        public StaffDashboard()
        {
            InitializeComponent();
            this.Load += StaffDashboard_Load;
        }

        private void StaffDashboard_Load(object sender, EventArgs e)
        {
            SetupGrid();
            EnsureHistoryFile();
            LoadReports();
            UpdateStats();
        }


        private void EnsureHistoryFile() //tig chech sa history file
        {
            string historyPath = Path.Combine(Application.StartupPath, "history.txt");

            if (!File.Exists(historyPath))
            {
                File.Create(historyPath).Close();
            }
        }


        private void SetupGrid() //sa set up grid ni
        {
            dgvReports.Columns.Clear();

            dgvReports.AutoGenerateColumns = false;
            dgvReports.AllowUserToAddRows = false;
            dgvReports.ReadOnly = true;
            dgvReports.Dock = DockStyle.Fill;

            dgvReports.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReports.MultiSelect = false;

            dgvReports.Columns.Add("Student", "Student");
            dgvReports.Columns.Add("ID", "ID");
            dgvReports.Columns.Add("Location", "Location");
            dgvReports.Columns.Add("Bin", "Bin Code");
            dgvReports.Columns.Add("Status", "Status");
            dgvReports.Columns.Add("Time", "Time");
        }



        private void LoadReports() // mopa kita sa mga active reports
        {
            string path = Path.Combine(Application.StartupPath, "reports.txt");

            dgvReports.Rows.Clear();

            if (!File.Exists(path))
            {
                MessageBox.Show("reports.txt not found");
                return;
            }

            string[] lines = File.ReadAllLines(path);

            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line))
                    continue;

                string[] data = line.Split(',').Select(x => x.Trim()).ToArray();

                if (data.Length == 6)
                {
                    int rowIndex = dgvReports.Rows.Add(
                        data[0],
                        data[1],
                        data[2],
                        data[3],
                        data[4],
                        data[5]
                    );

                    ApplyRowColor(rowIndex, data[4]);
                }
            }
        }



        private void LoadHistory() // kani mao ni mo load sa history
        {
            string historyPath = Path.Combine(Application.StartupPath, "history.txt");

            dgvReports.Rows.Clear();

            if (!File.Exists(historyPath))
            {
                MessageBox.Show("No history found.");
                return;
            }

            string[] lines = File.ReadAllLines(historyPath);

            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line))
                    continue;

                string[] data = line.Split(',').Select(x => x.Trim()).ToArray();

                if (data.Length == 6)
                {
                    dgvReports.Rows.Add(
                        data[0],
                        data[1],
                        data[2],
                        data[3],
                        data[4],
                        data[5]
                    );
                }
            }
        }




        private void ApplyRowColor(int rowIndex, string status) // Mao ni nag hatag og color sa row
        {
            status = status.ToLower();

            if (status == "pending")
                dgvReports.Rows[rowIndex].DefaultCellStyle.BackColor = System.Drawing.Color.LightCoral;
            else if (status == "in progress")
                dgvReports.Rows[rowIndex].DefaultCellStyle.BackColor = System.Drawing.Color.Khaki;
            else if (status == "completed")
                dgvReports.Rows[rowIndex].DefaultCellStyle.BackColor = System.Drawing.Color.LightGreen;
        }



        private void SaveReports() // mao ni ga save sa mga reports e butang ni sa report.txt file
        {
            string path = Path.Combine(Application.StartupPath, "reports.txt");

            var lines = dgvReports.Rows
                .Cast<DataGridViewRow>()
                .Where(r => !r.IsNewRow)
                .Select(r =>
                    string.Join(",",
                        r.Cells[0].Value,
                        r.Cells[1].Value,
                        r.Cells[2].Value,
                        r.Cells[3].Value,
                        r.Cells[4].Value,
                        r.Cells[5].Value
                    ));

            File.WriteAllLines(path, lines);
        }



        private void btnMarkCleared_Click(object sender, EventArgs e) // button ni sya to clear or mark a clean sa mga active reports
        {
            if (dgvReports.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a report first.");
                return;
            }

            DataGridViewRow row = dgvReports.SelectedRows[0];

            row.Cells[4].Value = "Completed";
            row.DefaultCellStyle.BackColor = System.Drawing.Color.LightGreen;


            string historyPath = Path.Combine(Application.StartupPath, "history.txt");

            string completedReport = string.Join(",",
                row.Cells[0].Value,
                row.Cells[1].Value,
                row.Cells[2].Value,
                row.Cells[3].Value,
                row.Cells[4].Value,
                row.Cells[5].Value
            );


            File.AppendAllText(historyPath, completedReport + Environment.NewLine);


            dgvReports.Rows.Remove(row);

            SaveReports();
            UpdateStats();
        }



        private void btnViewHistory_Click(object sender, EventArgs e) // button rani to show the history 
        {
            LoadHistory();
            UpdateStats();
        }



        private void btnViewReports_Click(object sender, EventArgs e) // button rani to show ang mga active reports
        {
            LoadReports();
            UpdateStats();
        }



        private void UpdateStats() // kani  mo update sa stats sa pending, completed, ug total reports
        {
            int pending = 0;
            int completed = 0;

            foreach (DataGridViewRow row in dgvReports.Rows)
            {
                if (row.IsNewRow) continue;

                string status = row.Cells[4].Value?.ToString().ToLower();

                if (status == "pending")
                    pending++;
                else if (status == "completed")
                    completed++;
            }

            int total = pending + completed;

            lblPending.Text = "Pending: " + pending;
            lblCompleted.Text = "Completed: " + completed;
            lblTotal.Text = "Total: " + total;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}