using System;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace GarbageManagementSystem
{
    public partial class registrationPage : Form
    {
        private readonly string connectionString = $"Data Source={Path.Combine(Application.StartupPath, "garbage.db")};Version=3;BusyTimeout=5000;Journal Mode=WAL;";

        public registrationPage()
        {
            InitializeComponent();
            CreateTable();
        }

        private void CreateTable()
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string query = @"CREATE TABLE IF NOT EXISTS Users (
                                    Username TEXT PRIMARY KEY,
                                    Password TEXT NOT NULL,
                                    StudentID TEXT NOT NULL,
                                    Role TEXT NOT NULL
                                )";

                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string studentID = txtStudentID.Text.Trim();
            string role = "student"; // default role

           
            if (username == "" || password == "" || studentID == "")
            {
                MessageBox.Show("Please fill in all fields.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

          
            if (password.Length <= 2)
            {
                MessageBox.Show("Password must be more than 2 characters long.", "Weak Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           
            if (!studentID.All(c => char.IsDigit(c) || c == '-'))
            {
                MessageBox.Show("Please enter a valid Student ID (numbers and dashes only).", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string check = "SELECT COUNT(*) FROM Users WHERE Username=@u";
                SQLiteCommand checkCmd = new SQLiteCommand(check, conn);
                checkCmd.Parameters.AddWithValue("@u", username);

                long exists = (long)checkCmd.ExecuteScalar();

                if (exists > 0)
                {
                    MessageBox.Show("Username already exists.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string insert = @"INSERT INTO Users 
                                (Username, Password, StudentID, Role)
                                VALUES (@u, @p, @s, @r)";

                SQLiteCommand cmd = new SQLiteCommand(insert, conn);
                cmd.Parameters.AddWithValue("@u", username);
                cmd.Parameters.AddWithValue("@p", password);
                cmd.Parameters.AddWithValue("@s", studentID);
                cmd.Parameters.AddWithValue("@r", role);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Registration Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnbackToLog_Click(object sender, EventArgs e)
        {
            LogInPage login = new LogInPage();
            login.Show();
            this.Hide();
        }

        private void txtStudentID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }
    }
}