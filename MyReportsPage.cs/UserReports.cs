using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GarbageManagementSystem
{
    public partial class UserReports : Form
    {
        // 1. Standard constructor (no parameters needed!)
        public UserReports()
        {
            InitializeComponent();
        }

        private void UserReports_Load(object sender, EventArgs e)
        {
            dgvReports.Rows.Clear();

            string filePath = "reports.txt";

            if (File.Exists(filePath))
            {
                string[] allReports = File.ReadAllLines(filePath);

                foreach (string report in allReports)
                {
                    string[] data = report.Split(',');

                    if (data.Length >= 4)
                    {
                        // 2. THE MAGIC: Check if the report belongs to the globally logged-in user!
                        if (data[0] == LoggedInUser.Name)
                        {
                            dgvReports.Rows.Add(data[1], data[2], data[3]);
                        }
                    }
                }
            }

            // 3. Calculate Stats
            int totalReports = dgvReports.Rows.Count;
            int successfulCleanups = 0;

            foreach (DataGridViewRow row in dgvReports.Rows)
            {
                if (row.Cells[2].Value != null && row.Cells[2].Value.ToString() == "Resolved")
                {
                    successfulCleanups++;
                }
            }

            lblTotalReports.Text = totalReports.ToString();
            lblSuccessCount.Text = successfulCleanups.ToString();

            // 4. Gamification
            if (successfulCleanups >= 10)
            {
                lblEcoRank.Text = "Eco-Hero 🌍";
                lblEcoRank.ForeColor = Color.Gold;
            }
            else if (successfulCleanups >= 3)
            {
                lblEcoRank.Text = "Ranger 🌿";
                lblEcoRank.ForeColor = Color.LimeGreen;
            }
            else
            {
                lblEcoRank.Text = "Novice 🌱";
                lblEcoRank.ForeColor = Color.DarkGreen;
            }
        }
    }
}