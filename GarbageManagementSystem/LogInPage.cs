using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace GarbageManagementSystem
{
    public partial class LogInPage : Form
    {
        private readonly string connectionString = "Data Source=garbage.db;Version=3;";

        public LogInPage()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // CHANGED: Reading the ID instead of a username from the input box
            string studentIdInput = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                // CHANGED: Query now looks for StudentID=@id instead of Username=@u
                string query = @"SELECT Username, StudentID, Role 
                                 FROM Users 
                                 WHERE StudentID=@id AND Password=@p";

                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                // CHANGED: Passing the student ID parameter
                cmd.Parameters.AddWithValue("@id", studentIdInput);
                cmd.Parameters.AddWithValue("@p", password);

                SQLiteDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    // Use the null-coalescing operator (??) to provide a fallback empty string if the database value is null
                    string user = reader["Username"]?.ToString() ?? "";
                    string id = reader["StudentID"]?.ToString() ?? "";
                    string role = reader["Role"]?.ToString()?.Trim() ?? "";

                    LoggedInUser.Name = user;
                    LoggedInUser.ID = id;

                    MessageBox.Show("Login Successful!");

                    // FIXED ROLE CHECK (case-insensitive)
                    if (role.Equals("staff", StringComparison.OrdinalIgnoreCase))
                    {
                        StaffDashboard staff = new StaffDashboard(user);
                        staff.Show();
                    }
                    else
                    {
                        // Your dashboard still receives the 'user' (Name) string here,
                        // so your "Welcome (username)" feature will still work perfectly!
                        StudentDashboard student = new StudentDashboard(user);
                        student.Show();
                    }

                    this.Hide();
                }
                else
                {
                    // CHANGED: Updated the error message to reflect the ID login change
                    MessageBox.Show("Invalid Student ID or Password.");
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