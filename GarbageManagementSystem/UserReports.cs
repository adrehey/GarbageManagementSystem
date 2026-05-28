using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GarbageManagementSystem
{
    public partial class UserReports : Form
    {
        public UserReports()
        {
            InitializeComponent();
        }

        private void UserReports_Load(object sender, EventArgs e)
        {
            dgvReports.Rows.Clear();

            // UPGRADED CONNECTION STRING: Added BusyTimeout and WAL mode to completely prevent "database is locked" errors
            string connString = $"Data Source={Path.Combine(Application.StartupPath, "garbage.db")};Version=3;BusyTimeout=5000;Journal Mode=WAL;";

            int totalReports = 0;
            int successfulCleanups = 0;

            try
            {
                using (System.Data.SQLite.SQLiteConnection conn = new System.Data.SQLite.SQLiteConnection(connString))
                {
                    conn.Open();

                    // 2. Query reports that belong ONLY to this logged-in student's ID
                    string query = "SELECT Location, BinCode, Status, ReportTime FROM Reports WHERE StudentID = @studentId";

                    using (System.Data.SQLite.SQLiteCommand cmd = new System.Data.SQLite.SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@studentId", LoggedInUser.ID);

                        using (System.Data.SQLite.SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string location = reader["Location"].ToString();
                                string binCode = reader["BinCode"].ToString();
                                string status = reader["Status"].ToString();
                                string time = reader["ReportTime"].ToString();

                                // 3. Add to DataGridView (Adjust column order matching your grid design)
                                // Based on your old code dgvReports.Rows.Add(data[1], data[2], data[3]);
                                // Ensure these match what columns you have set up in your designer!
                                dgvReports.Rows.Add(location, binCode, status);

                                totalReports++;

                                // 4. Count successful cleanups if the status is marked 'Completed'
                                if (status.Equals("Completed", StringComparison.OrdinalIgnoreCase))
                                {
                                    successfulCleanups++;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading your reports: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // 5. Update UI counters
            lblTotalReports.Text = totalReports.ToString();
            lblSuccessCount.Text = successfulCleanups.ToString();

            // 6. Gamification / Eco Rank System
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

        private void btnDash_Click(object sender, EventArgs e)
        {
            StudentDashboard dashboard = new StudentDashboard(LoggedInUser.Name);
            dashboard.Show();
            this.Close();
        }
    }
}