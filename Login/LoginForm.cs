using APU_Programming_Cafe.Lecturer;
using System;
using System.Windows.Forms;
using APU_Programming_Cafe.Trainer;
using APU_Programming_Cafe.Student;
using APU_Programming_Cafe.Admin;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace APU_Programming_Cafe
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string connString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\User'\\OneDrive - Asia Pacific University (1)\\IOOP APPLICATION\\APU Programming Cafe\\APU database.mdf\";Integrated Security=True";
            //int ErrorCount = 1;
            bool userPresent=false;
            string Error = "";
            string userRole = "";

            LoginUsers userDetailsAndRole = new LoginUsers(txtLoginUsername.Text, txtLoginPassword.Text);

            if (txtLoginUsername.Text != "" && txtLoginPassword.Text != "")
            {
                if ((!txtLoginUsername.Text.Contains("AP") || !txtLoginUsername.Text.Contains("TP") || !txtLoginUsername.Text.Contains("AD") || !txtLoginUsername.Text.Contains("TD")) && txtLoginUsername.Text.Length != 8)
                {
                    Error += "Error: Invalid Username. Please try again.\n";
                }
                else
                {
                    List<string> connectionStrings = new List<string>
                    {
                        ConfigurationManager.ConnectionStrings["Student"].ToString(),
                        ConfigurationManager.ConnectionStrings["Lecturer"].ToString(),
                        //ConfigurationManager.ConnectionStrings["Admin"].ToString(),
                        connString,
                        ConfigurationManager.ConnectionStrings["Trainer"].ToString()
                    };

                    userPresent = userDetailsAndRole.checkUserInformation(connectionStrings, out connString, out userRole);
                }

                if (userPresent == false)
                {
                    Error += "Error logging in. Incorrect Username or Password. Please try again.\n";
                    MessageBox.Show(Error);
                }
                else
                {
                    if (userRole.Contains("Student"))
                    {
                        StudentForm studentForm = new StudentForm(connString, userDetailsAndRole.Username, userDetailsAndRole.Password);
                        studentForm.Show();
                        this.Hide();
                    }
                    else if (userRole.Contains("Lecturer"))
                    {
                        LecturerForm lecturerForm = new LecturerForm(connString, userDetailsAndRole.Username, userDetailsAndRole.Password);
                        lecturerForm.Show();
                        this.Hide();
                    }
                    // userRole == "Trainer"
                    else if (userRole.Contains("Trainer"))
                    {
                        TrainerForm trainerForm = new TrainerForm(connString, userDetailsAndRole.Username, userDetailsAndRole.Password);
                        trainerForm.Show();
                        this.Hide();
                    }
                    else if (userRole.Contains("Admin"))
                    {
                        AdminForm adminForm = new AdminForm(connString, userDetailsAndRole.Username, userDetailsAndRole.Password);
                        adminForm.Show();
                        this.Hide();
                    }
                }
            }

            else if (txtLoginUsername.Text == "Trainer" || txtLoginUsername.Text == "t" || txtLoginUsername.Text == "trainer")
            {
                //temporary loading trainer form.
                TrainerForm trainerForm = new TrainerForm(connString, userDetailsAndRole.Username, userDetailsAndRole.Password);
                trainerForm.Show();
                this.Hide();
            }
            
            else if (txtLoginUsername.Text == "Student" || txtLoginUsername.Text == "student" || txtLoginUsername.Text == "s")
            {
                //temporary loading student form.
                StudentForm studentForm = new StudentForm(connString, userDetailsAndRole.Username, userDetailsAndRole.Password);
                studentForm.Show();
                Hide();
            }
            
            else if (txtLoginUsername.Text == "Admin" || txtLoginUsername.Text == "admin" || txtLoginUsername.Text == "a")
            {
                //temporary loading admin form.
                AdminForm adminForm = new AdminForm(connString, userDetailsAndRole.Username, userDetailsAndRole.Password);
                adminForm.Show();
                Hide();
            }

            else
            {
                MessageBox.Show("No username or password inputted");
            }
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}