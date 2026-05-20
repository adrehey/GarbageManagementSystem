using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace GarbageManagementSystem
{
    public partial class LogInPage : Form
    {
        public LogInPage()
        {
            InitializeComponent();
        }

        // LOGIN BUTTON
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            string connectionString = "Data Source=garbage.db;Version=3;";

            using (SQLiteConnection con = new SQLiteConnection(connectionString))
            {
                con.Open();
                string query = "SELECT * FROM Users WHERE Username=@username AND Password=@password";

                using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Removed the duplicate outer variable declarations to fix CS0136
                            string role = reader["Role"]?.ToString() ?? "";
                            string studentID = reader["StudentID"]?.ToString() ?? "";

                            // Saves the username globally so the dashboards can say "Welcome, Username!"
                            LoggedInUser.Name = username;
                            LoggedInUser.ID = studentID;

                            if (string.Equals(role, "student", StringComparison.OrdinalIgnoreCase))
                            {
                                StudentDashboard sd = new StudentDashboard();
                                sd.Show();
                                this.Hide();
                            }
                            else if (string.Equals(role, "staff", StringComparison.OrdinalIgnoreCase))
                            {
                                StaffDashboard sd = new StaffDashboard();
                                sd.Show();
                                this.Hide();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password.");
                        }
                    } // Reader closes here safely
                } // Command closes here safely
            } // Connection closes here safely and unlocks the database!
        }

        // OPEN REGISTRATION
        private void linkLabel2_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            registrationPage reg = new registrationPage();
            reg.Show();
            this.Hide();
        }

        // EMPTY EVENTS (SAFE TO IGNORE)
        private void label3_Click(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
        private void label6_Click_1(object sender, EventArgs e) { }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) { }
    }
}