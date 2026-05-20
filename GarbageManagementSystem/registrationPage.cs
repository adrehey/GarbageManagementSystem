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
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string studentID = txtStudentID.Text.Trim();
            string role = cmbRole.Text.Trim();

            
            if (username == "" || password == "" || studentID == "" || role == "")
            {
<<<<<<< HEAD

                MessageBox.Show("Pleas fill in all the fields.");
=======
                MessageBox.Show("Please fill in all fields.");
>>>>>>> 84b9f26da8c0a21dc0a4c942eb856d4b840908dc
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

           
            string userData = username + "," + password + "," + role + "," + studentID;

            File.AppendAllText(filePath, userData + Environment.NewLine);

            MessageBox.Show("Registration Successful!");

            txtUsername.Clear();
            txtPassword.Clear();
            txtStudentID.Clear();
            cmbRole.SelectedIndex = -1;
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            LogInPage login = new LogInPage();
            login.Show();
            this.Hide();
        }

        
        private void txtStudentID_TextChanged(object sender, EventArgs e) { }
    }
}