using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace GarbageManagementSystem
{
    public partial class StudentDashboard : Form
    {
        public StudentDashboard()
        {
            InitializeComponent();
            this.Load += StudentDashboard_Load;
        }

        // FORM LOAD
        private void StudentDashboard_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Hello, " + LoggedInUser.Name + "!";

            SetupMyReportsGrid();
        }

        // SETUP GRID
        private void SetupMyReportsGrid()
        {
            dgvMyReports.Columns.Clear();

            dgvMyReports.AllowUserToAddRows = false;
            dgvMyReports.ReadOnly = true;
            dgvMyReports.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMyReports.MultiSelect = false;

            dgvMyReports.Columns.Add("Location", "Location");
            dgvMyReports.Columns.Add("BinCode", "Bin Code");
            dgvMyReports.Columns.Add("Status", "Status");
            dgvMyReports.Columns.Add("DateTime", "Date & Time");
        }

        // LOAD USER CONTROL INTO PANEL
        private void LoadControl(UserControl control)
        {
            mainPanel.Controls.Clear();
            control.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(control);
        }

        // OPEN REPORT PAGE
        private void btnReport_Click(object sender, EventArgs e)
        {
            LoadControl(new ReportControl());
        }

        // VIEW MY REPORTS
        private void btnViewReports_Click(object sender, EventArgs e)
        {
            LoadMyReports();
        }

        // LOAD ONLY CURRENT STUDENT REPORTS
        private void LoadMyReports()
        {
            dgvMyReports.Rows.Clear();

            using (SQLiteConnection con =
                new SQLiteConnection("Data Source=garbage.db;Version=3;"))
            {
                con.Open();

                string query = @"
                SELECT * FROM Reports
                WHERE StudentID=@id";

                SQLiteCommand cmd = new SQLiteCommand(query, con);
                cmd.Parameters.AddWithValue("@id", LoggedInUser.ID);

                SQLiteDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    dgvMyReports.Rows.Add(
                        reader["Location"].ToString(),
                        reader["BinCode"].ToString(),
                        reader["Status"].ToString(),
                        reader["DateTime"].ToString()
                    );
                }

                con.Close();
            }
        }

        // BACK TO LOGIN
        private void btnBack_Click(object sender, EventArgs e)
        {
<<<<<<< Updated upstream
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

=======
            LogInPage login = new LogInPage();
            login.Show();
            this.Close();
>>>>>>> Stashed changes
        }

        // EXIT APP
        private void btnOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // UNUSED EVENTS
        private void lblWelcome_Click(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
    }
}
