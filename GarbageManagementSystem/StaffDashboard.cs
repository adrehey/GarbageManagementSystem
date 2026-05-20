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
            LoadReports();

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

        private void LoadReports()
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


                    string status = data[4].ToLower();

                    if (status == "pending")
                    {
                        dgvReports.Rows[rowIndex].DefaultCellStyle.BackColor = System.Drawing.Color.LightCoral;
                    }
                    else if (status == "in progress")
                    {
                        dgvReports.Rows[rowIndex].DefaultCellStyle.BackColor = System.Drawing.Color.Khaki;
                    }
                    else if (status == "completed")
                    {
                        dgvReports.Rows[rowIndex].DefaultCellStyle.BackColor = System.Drawing.Color.LightGreen;
                    }
                }
            }
        }

        private void SaveReports()
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

        private void btnViewHistory_Click(object sender, EventArgs e)
        {
            string historyPath = Path.Combine(Application.StartupPath, "history.txt");

            if (!File.Exists(historyPath))
            {
                MessageBox.Show("No history found.");
                return;
            }

            dgvReports.Rows.Clear();

            string[] lines = File.ReadAllLines(historyPath);

            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line))
                    continue;

                string[] data = line.Split(',')
                                    .Select(x => x.Trim())
                                    .ToArray();

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

                    dgvReports.Rows[rowIndex].DefaultCellStyle.BackColor =
                        System.Drawing.Color.LightGreen;
                }
            }
        }

        private void btnViewReports_Click(object sender, EventArgs e)
        {
            LoadReports();
        }
    }
}