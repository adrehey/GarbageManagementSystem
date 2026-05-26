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
            SaveReport("NB CR 1", "BIN - 03");

        }

        private void btnCafeteria_Click(object sender, EventArgs e)
        {
            SaveReport("Cafeteria", "BIN - 04");
        }

        private void btnNb2_Click(object sender, EventArgs e)
        {
            SaveReport("NB CR 2", "BIN - 05");
        }

        private void btnNb3_Click(object sender, EventArgs e)
        {
            SaveReport("NB CR 3", "BIN - 06");
        }

        private void btnNb4_Click(object sender, EventArgs e)
        {
            SaveReport("NB CR 4", "BIN - 07");
        }

        private void btnCaf2_Click(object sender, EventArgs e)
        {
            SaveReport("Cafeteria 2", "BIN - 08");
        }

        private void btnCottage_Click(object sender, EventArgs e)
        {
            SaveReport("Cottage", "BIN - 09");
        }

        private void btnTable_Click(object sender, EventArgs e)
        {
            SaveReport("Table Area", "BIN - 10");
        }

        private void btnTower_Click(object sender, EventArgs e)
        {
            SaveReport("Tower", "BIN - 11");
        }

        private void btnCas1_Click(object sender, EventArgs e)
        {
            SaveReport("CAS 1", "BIN - 12");
        }

        private void btnCas2_Click(object sender, EventArgs e)
        {
            SaveReport("CAS 2", "BIN - 13");
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            SaveReport("Registrar", "BIN - 14");
        }

        private void btnBo_Click(object sender, EventArgs e)
        {
            SaveReport("BO", "BIN - 15");
        }

        private void btnGrotto_Click(object sender, EventArgs e)
        {
            SaveReport("Grotto", "BIN - 16");
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

        private void btnback_Click_1(object? sender, EventArgs e)
        {
            StudentDashboard dash = new StudentDashboard(LoggedInUser.Name);
            dash.Show();

            var parentForm = this.FindForm();
            if (parentForm != null)
            {
                parentForm.Close();
            }
        }

    
    }
}
