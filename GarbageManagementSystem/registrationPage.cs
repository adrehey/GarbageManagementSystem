using System;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

namespace GarbageManagementSystem
{
    public partial class registrationPage : Form
    {
        public registrationPage()
        {
            InitializeComponent();
            CreateDatabase();
        }

        // CREATE DATABASE + TABLE
        private void CreateDatabase()
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
                CREATE TABLE IF NOT EXISTS Users (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Username TEXT,
                    Password TEXT,
                    Role TEXT,
                    StudentID TEXT
                )";

                SQLiteCommand cmd = new SQLiteCommand(query, con);
                cmd.ExecuteNonQuery();

                con.Close();
            }
        }

        // REGISTER BUTTON
        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string studentID = txtStudentID.Text.Trim();
            string role = cmbRole.Text.Trim().ToLower();

<<<<<<< Updated upstream

            if (username == "" || password == "" || studentID == "" || role == "")
=======
            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(studentID) ||
                string.IsNullOrWhiteSpace(role))
>>>>>>> Stashed changes
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

<<<<<<< Updated upstream
            string filePath = "users.txt";


            if (!File.Exists(filePath))
=======
            using (SQLiteConnection con =
                new SQLiteConnection("Data Source=garbage.db;Version=3;"))
>>>>>>> Stashed changes
            {
                con.Open();

                // CHECK IF USER EXISTS
                string checkQuery =
                    "SELECT COUNT(*) FROM Users WHERE Username=@username";

<<<<<<< Updated upstream

            foreach (string user in users)
            {
                string[] data = user.Split(',');
=======
                SQLiteCommand checkCmd =
                    new SQLiteCommand(checkQuery, con);
>>>>>>> Stashed changes

                checkCmd.Parameters.AddWithValue("@username", username);

                long count = (long)checkCmd.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("Username already exists.");
                    return;
                }

                // INSERT USER
                string insertQuery = @"
                INSERT INTO Users
                (Username, Password, Role, StudentID)
                VALUES
                (@username, @password, @role, @studentID)";

                SQLiteCommand cmd =
                    new SQLiteCommand(insertQuery, con);

                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@role", role);
                cmd.Parameters.AddWithValue("@studentID", studentID);

                cmd.ExecuteNonQuery();

                con.Close();
            }

<<<<<<< Updated upstream

            string userData = username + "," + password + "," + role + "," + studentID;

            File.AppendAllText(filePath, userData + Environment.NewLine);

=======
>>>>>>> Stashed changes
            MessageBox.Show("Registration Successful!");

        }

        // BACK BUTTON
        private void btnback_Click(object sender, EventArgs e)
        {
            LogInPage login = new LogInPage();
            login.Show();
            this.Hide();
        }

<<<<<<< Updated upstream

        private void txtStudentID_TextChanged(object sender, EventArgs e) { }

        private void label3_Click(object sender, EventArgs e)
=======
        private void txtStudentID_TextChanged(object sender, EventArgs e)
>>>>>>> Stashed changes
        {

        }
    }
}