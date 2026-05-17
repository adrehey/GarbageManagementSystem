using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace GarbageManagementSystem
{
    public partial class ReportControl : UserControl
    {
        public ReportControl()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {



        }

        private void btnITCenter_Click(object sender, EventArgs e)
        {

            SaveReport("IT Center", "BIN - 01");


        }

        private void btnLibrary_Click(object sender, EventArgs e)
        {

            SaveReport("Library", "BIN - 02");


        }

        private void btnGym_Click(object sender, EventArgs e)
        {

            SaveReport("Gym", "BIN - 03");


        }

        private void btnCafeteria_Click(object sender, EventArgs e)
        {

            SaveReport("Cafeteria", "BIN - 04");


        }

        private void SaveReport(string location, string binCode)
        {
            string studentName = string.IsNullOrWhiteSpace(LoggedInUser.Name) ? "Unknown" : LoggedInUser.Name;
            string studentID = string.IsNullOrWhiteSpace(LoggedInUser.ID) ? "N/A" : LoggedInUser.ID;
            string status = "Pending";
            string dateTime = DateTime.Now.ToString("MM/dd/yyyy HH:mm");

            string report = $"{studentName},{studentID},{location},{binCode},{status},{dateTime}";

            string path = Path.Combine(Application.StartupPath, "reports.txt");
            File.AppendAllText(path, report + Environment.NewLine);

            MessageBox.Show("Report submitted successfully!");
        }

        private void btnback_Click_1(object sender, EventArgs e)
        {
            StudentDashboard dash = new StudentDashboard();
            dash.Show();

            this.FindForm().Close();
        }
    }
}
