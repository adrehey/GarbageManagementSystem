using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GarbageManagementSystem
{
    public partial class StudentDashboard : Form
    {
        private string loggedInUser;

        public StudentDashboard(string username)
        {
            InitializeComponent();

            loggedInUser = username;

            lblWelcome.Text = $"Welcome, {loggedInUser}!";

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void LoadControl(UserControl control)
        {

            mainPanel.Controls.Clear();
            control.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(control);

        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            LoadControl(new ReportControl());
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserReports reportsPage = new UserReports();
            reportsPage.Show();
            this.Hide();
        }
    }
}
