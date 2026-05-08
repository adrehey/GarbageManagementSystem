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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string location = txtLocation.Text.Trim();
            string description = txtDescription.Text.Trim();

            if (location == "" || description == "") { 
            
                MessageBox.Show("Please fill in all the fields.");
                return;
            }

            string report = location + "," + description + "," + DateTime.Now;


            File.AppendAllText("reports.txt", report + Environment.NewLine);


            MessageBox.Show("Report submitted successfully.");

            txtLocation.Clear();
            txtDescription.Clear();

        }
    }
}
