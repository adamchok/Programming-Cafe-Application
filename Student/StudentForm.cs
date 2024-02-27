using APU_Programming_Cafe.Lecturer;
using APU_Programming_Cafe.Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APU_Programming_Cafe.Student
{
    public partial class StudentForm : Form
    {
        string connectionString;
        string StudentID;
        string Password;
        frmPayment payment;
        frmRequest request;
        frmDeleteRequest deleteRequest;
        Timetable timetable;
        Student_Profile profile;

        public StudentForm(string connString, string studentID, string password)
        {
            connectionString = connString;
            StudentID = studentID;
            Password = password;
            InitializeComponent();
            payment = new frmPayment(connectionString, StudentID); 
            request = new frmRequest(connectionString, StudentID);
            deleteRequest = new frmDeleteRequest(connectionString, StudentID);
            timetable = new Timetable(connectionString, StudentID);
            profile = new Student_Profile(connectionString, StudentID, Password);
        }

        private void StudentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            this.Controls.Add(profile);
            profile.Location = new Point(186, 272);
            profile.Visible = false;

            profile.ClearAll_and_Reset(StudentID);

            this.Controls.Add(payment);
            payment.Location = new Point(186, 0);
            payment.Visible = false;

            this.Controls.Add(request);
            request.Location = new Point(186, 0);
            request.Visible = false;

            this.Controls.Add(deleteRequest);
            deleteRequest.Location = new Point(186, 0);
            deleteRequest.Visible = false;

            this.Controls.Add(timetable);
            timetable.Location = new Point(186, 0);
            timetable.Visible = false;

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string insertLecturerIDandName = "SELECT StudentID, Name FROM Student WHERE StudentID = @studentID";
            SqlCommand insertLecturerIDandNameCommand = new SqlCommand(insertLecturerIDandName, connection);
            insertLecturerIDandNameCommand.Parameters.AddWithValue("@studentID", StudentID);
            SqlDataReader reader = insertLecturerIDandNameCommand.ExecuteReader();
            while (reader.Read())
            {
                lblStudentID.Text = reader.GetString(0);
                lblStudentName.Text = reader.GetString(1);
            }
            reader.Close();
            connection.Close();
        }

        private void btnHomeScreen_Click(object sender, EventArgs e)
        {
            payment.Visible = false;
            request.Visible = false;
            deleteRequest.Visible = false;
            timetable.Visible = false;
            profile.Visible = false;
        }

        private void btnTimetable_Click(object sender, EventArgs e)
        {
            timetable.Visible = true;
            timetable.BringToFront();
            profile.Visible = false;
            payment.Visible = false;
            request.Visible = false;
            deleteRequest.Visible = false;
        }

        private void btnRequestClass_Click(object sender, EventArgs e)
        {
            request.Visible = true;
            request.BringToFront();
            deleteRequest.Visible = false;
            profile.Visible = false;
            payment.Visible = false;
            timetable.Visible = false;
        }

        private void btnPending_Click(object sender, EventArgs e)
        {
            deleteRequest.Visible = true;
            deleteRequest.BringToFront();
            profile.Visible = false;
            payment.Visible = false;
            request.Visible = false;
            timetable.Visible = false;
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            payment.Visible = true;
            payment.BringToFront();
            request.Visible = false;
            deleteRequest.Visible = false;
            timetable.Visible = false;
            profile.Visible = false;
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            profile.Visible = true;
            profile.BringToFront();
            payment.Visible = false;
            request.Visible = false;
            deleteRequest.Visible = false;
            timetable.Visible = false;
        }
    }
}
