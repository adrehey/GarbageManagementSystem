using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GarbageManagementSystem
{
    public partial class registrationPage : Form
    {
        public registrationPage()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_Enter_1(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Enter Username")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = Color.Black;
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {

                txtUsername.Text = "Enter Username";
                txtUsername.ForeColor = Color.Black;
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (username == "" || password == "")
            {

                MessageBox.Show("Pleas fill in all the feilds.");
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


                if (data[0] == username)
                {

                    MessageBox.Show("Username already Exist.");
                    return;

                }

            }

            string role = cmbRole.Text;


            if (role == "") {

                MessageBox.Show("Please fill up your role");
                return;
            }


            string userData = username + "," + password + "," + role;


            File.AppendAllText(filePath, userData + Environment.NewLine);


            MessageBox.Show("Registration Successful");

            txtUsername.Clear();
            txtPassword.Clear();




        }

        private void btnback_Click(object sender, EventArgs e)
        {
            LogInPage login = new LogInPage();
            login.Show();
            this.Hide();

        }
    }
}