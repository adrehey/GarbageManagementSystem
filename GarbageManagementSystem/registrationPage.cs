using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace GarbageManagementSystem
{
    public partial class registrationPage : Form
    {
        public registrationPage()
        {
            // Debug 1: Removed GetTxtUsername1()
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string studentID = txtStudentID.Text.Trim();
            // Debug 2: Removed cmbRole reference

            // Debug 3: Removed role from empty check
            if (username == "" || password == "" || studentID == "")
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            string filePath = "users.txt";

            if (!File.Exists(filePath))
            {
                File.Create(filePath).Close();
            }

            string[] users = File.ReadAllLines(filePath);

            foreach (string user in users)
            {
                string[] data = user.Split(',');

                if (data.Length >= 1)
                {
                    if (data[0] == username)
                    {
                        MessageBox.Show("Username already exists.");
                        return;
                    }
                }
            }

            // Debug 4: Removed role from the save string
            string userData = username + "," + password + "," + studentID;

            File.AppendAllText(filePath, userData + Environment.NewLine);

            MessageBox.Show("Registration Successful!");

            txtUsername.Clear();
            txtPassword.Clear();
            txtStudentID.Clear();
            // Debug 5: Removed cmbRole reset
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            LogInPage login = new LogInPage();
            login.Show();
            this.Hide();
        }

        private void txtStudentID_TextChanged(object sender, EventArgs e) { }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}