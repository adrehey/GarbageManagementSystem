using System.ComponentModel.DataAnnotations;
using System.IO;
namespace GarbageManagementSystem
{
    public partial class LogInPage : Form
    {
        public LogInPage()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel2_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            registrationPage reg = new registrationPage();
            reg.Show();

            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            string filePath = "users.txt";

            if (!File.Exists(filePath)) {

                MessageBox.Show("No registered users found");
                return;
            
         
            }
            string[] users = File.ReadAllLines(filePath);


            foreach (string user in users) {

                string[] data = user.Split(',');


                if (data.Length < 3) {

                    continue;

                }

                string storedUsername = data[0];
                string storedPassword = data[1];
                string Role = data[2].Trim();


                if (username == storedUsername && password == storedPassword) {

                    MessageBox.Show("Login successful");

                    if (Role.Equals("Student", StringComparison.OrdinalIgnoreCase))
                    {

                        StudentDashboard student = new StudentDashboard();
                        student.Show();
                        this.Hide();

                    }

                    else if (Role.Equals("Staff", StringComparison.OrdinalIgnoreCase)) {

                        StaffDashboard staff = new StaffDashboard();
                        staff.Show();
                        this.Hide();
                    }
                    return;
                } 
            }
            MessageBox.Show("Invalid username or password");
        }


        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
