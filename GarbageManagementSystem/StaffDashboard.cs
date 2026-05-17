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
        }

        private void SetupGrid()
        {
            dgvReports.Columns.Clear();

            dgvReports.AutoGenerateColumns = false;
            dgvReports.AllowUserToAddRows = false;
            dgvReports.ReadOnly = true;
            dgvReports.Dock = DockStyle.Fill;

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
    }
}