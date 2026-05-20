using System;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

namespace GarbageManagementSystem
{
    public partial class ReportControl : UserControl
    {
        public ReportControl()
        {
            InitializeComponent();
            CreateReportsTable();
        }

        // CREATE REPORTS TABLE
        private void CreateReportsTable()
        {
            if (!File.Exists("garbage.db"))
            {
                SQLiteConnection.CreateFile("garbage.db");
            }

            using (SQLiteConnection con =
                new SQLiteConnection("Data Source=garbage.db;Version=3;"))
            {
                con.Open();

                string query = @"
                CREATE TABLE IF NOT EXISTS Reports (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    StudentName TEXT,
                    StudentID TEXT,
                    Location TEXT,
                    BinCode TEXT,
                    Status TEXT,
                    DateTime TEXT
                )";

                SQLiteCommand cmd = new SQLiteCommand(query, con);
                cmd.ExecuteNonQuery();

                con.Close();
            }
        }

        // IT CENTER
        private void btnITCenter_Click(object sender, EventArgs e)
        {
            SaveReport("IT Center", "BIN - 01");
        }

        // LIBRARY
        private void btnLibrary_Click(object sender, EventArgs e)
        {
            SaveReport("Library", "BIN - 02");
        }

        // GYM
        private void btnGym_Click(object sender, EventArgs e)
        {
            SaveReport("Gym", "BIN - 03");
        }

        // CAFETERIA
        private void btnCafeteria_Click(object sender, EventArgs e)
        {
            SaveReport("Cafeteria", "BIN - 04");
        }

        // SAVE REPORT TO DATABASE
        private void SaveReport(string location, string binCode)
        {
            string studentName =
                string.IsNullOrWhiteSpace(LoggedInUser.Name)
                ? "Unknown"
                : LoggedInUser.Name;

            string studentID =
                string.IsNullOrWhiteSpace(LoggedInUser.ID)
                ? "N/A"
                : LoggedInUser.ID;

            string status = "Pending";

            string dateTime =
                DateTime.Now.ToString("MM/dd/yyyy HH:mm");

            using (SQLiteConnection con =
                new SQLiteConnection("Data Source=garbage.db;Version=3;"))
            {
                con.Open();

                string query = @"
                INSERT INTO Reports
                (StudentName, StudentID, Location, BinCode, Status, DateTime)
                VALUES
                (@studentName, @studentID, @location,
                 @binCode, @status, @dateTime)";

                SQLiteCommand cmd = new SQLiteCommand(query, con);

                cmd.Parameters.AddWithValue("@studentName", studentName);
                cmd.Parameters.AddWithValue("@studentID", studentID);
                cmd.Parameters.AddWithValue("@location", location);
                cmd.Parameters.AddWithValue("@binCode", binCode);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@dateTime", dateTime);

                cmd.ExecuteNonQuery();

                con.Close();
            }

            MessageBox.Show("Report submitted successfully!");
        }

        // BACK BUTTON
        private void btnback_Click_1(object sender, EventArgs e)
        {
            StudentDashboard dash = new StudentDashboard();
            dash.Show();

            this.FindForm().Close();
        }

        // EMPTY EVENT
        private void btnback_Click(object sender, EventArgs e)
        {

        }
    }
}