using APU_Programming_Cafe.Lecturer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using APU_Programming_Cafe.Trainer;
using APU_Programming_Cafe.Student;
using APU_Programming_Cafe.Admin;

namespace APU_Programming_Cafe
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        public class UserDetailsAndRole
        {
            public string Username { get; set; }
            public string Password { get; set; }
            public string UserRole { get; set; }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //temporary loading lecturer form.
            if (txtLoginUsername.Text != "" && txtLoginPassword.Text != "")
            {
                UserDetailsAndRole userDetailsAndRole = new UserDetailsAndRole();
                userDetailsAndRole.Username = txtLoginUsername.Text;
                userDetailsAndRole.Password = txtLoginPassword.Text;
                Database_Access loginCheck = new Database_Access();
                string outcome = loginCheck.CheckLoginInformation(userDetailsAndRole.Username, userDetailsAndRole.Password);
                if (outcome == "Error")
                {
                    MessageBox.Show("Error logging in. Please try again.");
                }
                else if (outcome == "False")
                {
                    MessageBox.Show("Error logging in. Incorrect username or password. Please try again.");
                }
                else
                {
                    userDetailsAndRole.UserRole = outcome;
                    LecturerForm lecturerForm = new LecturerForm();
                    lecturerForm.lecturerID = userDetailsAndRole.Username;
                    lecturerForm.password = userDetailsAndRole.Password;
                    lecturerForm.tableName = userDetailsAndRole.UserRole;
                    lecturerForm.Show();
                    this.Hide();
                }
            }
            
            
            else if (txtLoginUsername.Text == "Trainer" || txtLoginUsername.Text == "t" || txtLoginUsername.Text == "trainer")
            {
                //temporary loading trainer form.
                TrainerForm trainerForm = new TrainerForm();
                trainerForm.Show();
                this.Hide();
            }
            
            else if (txtLoginUsername.Text == "Student" || txtLoginUsername.Text == "student" || txtLoginUsername.Text == "s")
            {
                //temporary loading student form.
                StudentForm studentForm = new StudentForm();
                studentForm.Show();
                Hide();
            }
            
            else if (txtLoginUsername.Text == "Admin" || txtLoginUsername.Text == "admin" || txtLoginUsername.Text == "a")
            {
                //temporary loading admin form.
                AdminForm adminForm = new AdminForm();
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