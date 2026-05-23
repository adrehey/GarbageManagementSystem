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
            txtPassword.UseSystemPasswordChar = true; 
        }

        // LOGIN BUTTON
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string studentID = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(studentID) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter your ID number and password.");
                return;
            }

            string connectionString = "Data Source=garbage.db;Version=3;";

            try
            {
                using (SQLiteConnection con = new SQLiteConnection(connectionString))
                {
                    con.Open();

                    string query = @"
                        SELECT Username, StudentID, Role
                        FROM Users
                        WHERE StudentID = @studentID
                        AND Password = @password
                        LIMIT 1";

                    using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@studentID", studentID);
                        cmd.Parameters.AddWithValue("@password", password);

                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string dbUsername = reader["Username"]?.ToString();
                                string dbStudentID = reader["StudentID"]?.ToString();
                                string role = reader["Role"]?.ToString();

                                // Save logged in user globally
                                LoggedInUser.Name = dbUsername;   // display name
                                LoggedInUser.ID = dbStudentID;    // login ID

                                MessageBox.Show($"Welcome, {dbUsername}!");

                                if (role.Equals("student", StringComparison.OrdinalIgnoreCase))
                                {
                                    StudentDashboard sd = new StudentDashboard();
                                    sd.Show();
                                    this.Hide();
                                }
                                else if (role.Equals("staff", StringComparison.OrdinalIgnoreCase))
                                {
                                    StaffDashboard sd = new StaffDashboard();
                                    sd.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("Invalid user role detected.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Invalid ID number or password.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login error: " + ex.Message);
            }
        }

        // OPEN REGISTRATION
        private void linkLabel2_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            registrationPage reg = new registrationPage();
            reg.Show();
            this.Hide();
        }


        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }


        // UNUSED EVENTS
        private void label3_Click(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
        private void label6_Click_1(object sender, EventArgs e) { }
        private void linkLabel1_LinkClicked(object sender, EventArgs e) { }

        
    }
}