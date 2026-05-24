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

<<<<<<< Updated upstream
=======
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
>>>>>>> Stashed changes
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
<<<<<<< Updated upstream
            SaveReport("NB CR 1", "BIN - 03");

=======
            SaveReport("Gym", "BIN - 03");
>>>>>>> Stashed changes
        }

        // CAFETERIA
        private void btnCafeteria_Click(object sender, EventArgs e)
        {
            SaveReport("Cafeteria", "BIN - 04");
<<<<<<< Updated upstream
        }

        private void btnNb2_Click(object sender, EventArgs e)
        {
            SaveReport("NB CR 2", "BIN - 05");
        }

        private void btnNb3_Click(object sender, EventArgs e)
        {
            SaveReport("NB CR 3", "BIN - 06");
        }

        private void btnNb4_Click(object sender, EventArgs e)
        {
            SaveReport("NB CR 4", "BIN - 07");
        }

        private void btnCaf2_Click(object sender, EventArgs e)
        {
            SaveReport("Cafeteria 2", "BIN - 08");
        }

        private void btnCottage_Click(object sender, EventArgs e)
        {
            SaveReport("Cottage", "BIN - 09");
        }

        private void btnTable_Click(object sender, EventArgs e)
        {
            SaveReport("Table Area", "BIN - 10");
        }

        private void btnTower_Click(object sender, EventArgs e)
        {
            SaveReport("Tower", "BIN - 11");
        }

        private void btnCas1_Click(object sender, EventArgs e)
        {
            SaveReport("CAS 1", "BIN - 12");
        }

        private void btnCas2_Click(object sender, EventArgs e)
        {
            SaveReport("CAS 2", "BIN - 13");
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            SaveReport("Registrar", "BIN - 14");
        }

        private void btnBo_Click(object sender, EventArgs e)
        {
            SaveReport("BO", "BIN - 15");
        }

        private void btnGrotto_Click(object sender, EventArgs e)
        {
            SaveReport("Grotto", "BIN - 16");
=======
>>>>>>> Stashed changes
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

<<<<<<< Updated upstream
        private void btnback_Click_1(object? sender, EventArgs e)
=======
        // BACK BUTTON
        private void btnback_Click_1(object sender, EventArgs e)
>>>>>>> Stashed changes
        {
            StudentDashboard dash = new StudentDashboard();
            dash.Show();

            var parentForm = this.FindForm();
            if (parentForm != null)
            {
                parentForm.Close();
            }
        }

<<<<<<< Updated upstream
    
=======
        // EMPTY EVENT
        private void btnback_Click(object sender, EventArgs e)
        {

        }
>>>>>>> Stashed changes
    }
}