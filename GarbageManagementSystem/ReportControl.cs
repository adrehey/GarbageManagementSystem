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

        private void btnITCenter_Click(object sender, EventArgs e)
        {
            SaveReport("IT Center", "BIN - 01");
        }

        private void btnLibrary_Click(object sender, EventArgs e)
        {
            SaveReport("Library", "BIN - 02");
        }

        private void btnGym_Click(object sender, EventArgs e)
        {
            SaveReport("Gym", "BIN - 03");
        }

        private void btnCafeteria_Click(object sender, EventArgs e)
        {
            SaveReport("Cafeteria", "BIN - 04");
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            SaveReport("Registrar", "BIN - 05");
        }

        private void btnCas2_Click(object sender, EventArgs e)
        {
            SaveReport("Cas Cr 2", "BIN - 06");
        }

        private void btnTower_Click(object sender, EventArgs e)
        {
            SaveReport("Tower", "BIN - 07");
        }

        private void btnNb4_Click(object sender, EventArgs e)
        {
            SaveReport("NB4", "BIN - 08");
        }

        private void btnNb2_Click(object sender, EventArgs e)
        {
            SaveReport("NB2", "BIN - 09");
        }

        private void btnNb3_Click(object sender, EventArgs e)
        {
            SaveReport("Nb3", "BIN - 10");
        }

        private void btnGrotto_Click(object sender, EventArgs e)
        {
            SaveReport("Grotto", "BIN - 11");
        }

        private void btnCottage_Click(object sender, EventArgs e)
        {
            SaveReport("Cottage", "BIN - 12");
        }

        private void btnCas1_Click(object sender, EventArgs e)
        {
            SaveReport("Cas Cr 1", "BIN - 13");
        }

        private void btnRound_Click(object sender, EventArgs e)
        {
            SaveReport("Round Table", "BIN - 14");
        }

        private void btnNB1_Click(object sender, EventArgs e)
        {
            SaveReport("Nb1", "BIN - 15");
        }

        private void btnBo_Click(object sender, EventArgs e)
        {
            SaveReport("BO", "BIN - 16");
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