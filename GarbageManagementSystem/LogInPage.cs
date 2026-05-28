using System;
using System.Data.SQLite;
using System.IO; // Added for Path support
using System.Windows.Forms;

namespace GarbageManagementSystem
{
    public partial class LogInPage : Form
    {
        // UPGRADED CONNECTION STRING: Added BusyTimeout and WAL mode to completely prevent "database is locked" errors
        private readonly string connectionString = $"Data Source={Path.Combine(Application.StartupPath, "garbage.db")};Version=3;BusyTimeout=5000;Journal Mode=WAL;";

        public LogInPage()
        {
            InitializeComponent();
            // Hook up the load event to automatically build your table if it's missing
            this.Load += LogInPage_Load;
        }

        private void LogInPage_Load(object? sender, EventArgs e)
        {
            EnsureDatabaseTableExists();
        }

        // ================= AUTO-CREATE TABLE LOGIC =================
        private void EnsureDatabaseTableExists()
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();

                    // This SQL query automatically builds your Reports table blueprint if it isn't there yet
                    string createTableQuery = @"
                        CREATE TABLE IF NOT EXISTS Reports (
                            ReportID INTEGER PRIMARY KEY AUTOINCREMENT,
                            StudentName TEXT NOT NULL,
                            StudentID TEXT NOT NULL,
                            Location TEXT NOT NULL,
                            BinCode TEXT NOT NULL,
                            Status TEXT NOT NULL,
                            ReportTime TEXT NOT NULL
                        );";

                    using (SQLiteCommand cmd = new SQLiteCommand(createTableQuery, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error initializing backend tables: " + ex.Message, "Initialization Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string studentIdInput = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string query = @"SELECT Username, StudentID, Role 
                                 FROM Users 
                                 WHERE StudentID=@id AND Password=@p";

                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", studentIdInput);
                cmd.Parameters.AddWithValue("@p", password);

                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string user = reader["Username"]?.ToString() ?? "";
                        string id = reader["StudentID"]?.ToString() ?? "";
                        string role = reader["Role"]?.ToString()?.Trim() ?? "";

                        LoggedInUser.Name = user;
                        LoggedInUser.ID = id;

                        MessageBox.Show("Login Successful!");

                        if (role.Equals("staff", StringComparison.OrdinalIgnoreCase))
                        {
                            StaffDashboard staff = new StaffDashboard(user);
                            staff.Show();
                        }
                        else
                        {
                            StudentDashboard student = new StudentDashboard(user);
                            student.Show();
                        }

                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Student ID or Password.");
                    }
                }
            }
        }

        private void linkSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            registrationPage reg = new registrationPage();
            reg.Show();
            this.Hide();
        }

        private void chkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPass.Checked;
        }
    }
}