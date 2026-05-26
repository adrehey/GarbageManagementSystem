using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace GarbageManagementSystem
{
    public partial class registrationPage : Form
    {
        private readonly string connectionString = "Data Source=garbage.db;Version=3;";

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
                MessageBox.Show("Please fill in all fields.");
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
                    MessageBox.Show("Username already exists.");
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

            MessageBox.Show("Registration Successful!");
        }

        private void btnbackToLog_Click(object sender, EventArgs e)
        {
            LogInPage login = new LogInPage();
            login.Show();
            this.Hide();
        }
    }
}