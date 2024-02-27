using APU_Programming_Cafe.Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using static APU_Programming_Cafe.LoginForm;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace APU_Programming_Cafe.Lecturer
{
    public partial class LecturerForm : Form
    {
        string connectionString;
        string LecturerID;
        string Password;
        Lecturer_Profile lecturer_Profile;
        Register_and_Ennrol register_And_Ennrol;
        RemoveStudent removeStudent;
        Update_Enrolment update_Enrolment;
        Enrolment_Request enrolment_Request;
        Enrol enrol_Student;


        public LecturerForm(string connString, string lecturerID, string password)
        {
            InitializeComponent();
            connectionString = connString;
            LecturerID = lecturerID;
            Password = password;
            lecturer_Profile = new Lecturer_Profile(connectionString, LecturerID, Password);
            register_And_Ennrol = new Register_and_Ennrol(connectionString);
            removeStudent = new RemoveStudent(connectionString);
            update_Enrolment = new Update_Enrolment(connectionString);
            enrolment_Request = new Enrolment_Request(connectionString);
            enrol_Student = new Enrol(connectionString);
        }

        private void LecturerForm_Load(object sender, EventArgs e)
        {
            this.Controls.Add(lecturer_Profile);
            lecturer_Profile.Location = new Point(186, 272);
            lecturer_Profile.Visible = false;

            lecturer_Profile.ClearAll_and_Reset(LecturerID);
            
            this.Controls.Add(register_And_Ennrol);
            register_And_Ennrol.Location = new Point(186, 0);
            register_And_Ennrol.Visible = false;

            this.Controls.Add(removeStudent);
            removeStudent.Location = new Point(186, 0);
            removeStudent.Visible = false;

            this.Controls.Add(update_Enrolment);
            update_Enrolment.Location = new Point(186, 0);
            update_Enrolment.Visible = false;

            this.Controls.Add(enrolment_Request);
            enrolment_Request.Location = new Point(186, 0);
            enrolment_Request.Visible = false;

            this.Controls.Add(enrol_Student);
            enrol_Student.Location = new Point(186, 0);
            enrol_Student.Visible = false;

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string insertLecturerIDandName = "SELECT LecturerID, Name FROM Lecturer WHERE LecturerID = @value1";
            SqlCommand insertLecturerIDandNameCommand = new SqlCommand(insertLecturerIDandName, connection);
            insertLecturerIDandNameCommand.Parameters.AddWithValue("@value1", LecturerID);
            SqlDataReader reader = insertLecturerIDandNameCommand.ExecuteReader();
            while (reader.Read())
            {
                lblLecturerID.Text = reader.GetString(0);
                lblLecturerName.Text = reader.GetString(1);
            }
            reader.Close();
            connection.Close();
        }

        private void LecturerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void btnHomeScreen_Click(object sender, EventArgs e)
        {
            lecturer_Profile.Visible = false;
            register_And_Ennrol.Visible = false;
            removeStudent.Visible = false;
            update_Enrolment.Visible = false;
            enrolment_Request.Visible = false;
            enrol_Student.Visible = false;
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            lecturer_Profile.Visible = true;
            lecturer_Profile.BringToFront();
            register_And_Ennrol.Visible = false;
            removeStudent.Visible = false;
            update_Enrolment.Visible = false;
            enrolment_Request.Visible = false;
            enrol_Student.Visible = false;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            register_And_Ennrol.Visible = true;
            register_And_Ennrol.BringToFront();
            removeStudent.Visible = false;
            update_Enrolment.Visible = false;
            enrolment_Request.Visible = false;
            lecturer_Profile.Visible = false;
            enrol_Student.Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            update_Enrolment.Visible = true;
            update_Enrolment.BringToFront();
            lecturer_Profile.Visible = false;
            register_And_Ennrol.Visible = false;
            removeStudent.Visible = false;
            enrolment_Request.Visible = false;
            enrol_Student.Visible = false;
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            enrolment_Request.Visible = true;
            enrolment_Request.BringToFront();
            lecturer_Profile.Visible = false;
            register_And_Ennrol.Visible = false;
            removeStudent.Visible = false;
            update_Enrolment.Visible = false;
            enrol_Student.Visible = false;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            removeStudent.Visible = true;
            removeStudent.BringToFront();
            update_Enrolment.Visible = false;
            enrolment_Request.Visible = false;
            lecturer_Profile.Visible = false;
            register_And_Ennrol.Visible = false;
            enrol_Student.Visible = false;
        }

        private void btnEnrol_Click(object sender, EventArgs e)
        {
            enrol_Student.Visible = true;
            enrol_Student.BringToFront();
            update_Enrolment.Visible = false;
            enrolment_Request.Visible = false;
            lecturer_Profile.Visible = false;
            register_And_Ennrol.Visible = false;
            removeStudent.Visible = false;
        }
    }
}
