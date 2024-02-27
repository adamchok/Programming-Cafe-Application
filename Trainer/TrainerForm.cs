using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using APU_Programming_Cafe.Lecturer;
using APU_Programming_Cafe.Login;

namespace APU_Programming_Cafe.Trainer
{
    public partial class TrainerForm : Form
    {
        string connectionString;
        string TrainerID;
        string Password;
        AddCoachingClass addCoachingClass;
        Feedback feedback;
        RemoveCoachingClass removeCoachingClass;
        StudentsListandFees studentsListandFees;
        TrainerProfile profile;
        Update_Coaching_Class updateCoachingClass;

        public TrainerForm(string connString, string trainerID, string password)
        {
            connectionString = connString;
            TrainerID = trainerID;
            Password = password;
            InitializeComponent();
            addCoachingClass = new AddCoachingClass(connectionString, TrainerID);
            feedback = new Feedback(connectionString, TrainerID);
            removeCoachingClass = new RemoveCoachingClass(connectionString, TrainerID);
            studentsListandFees = new StudentsListandFees(connectionString, TrainerID);
            profile = new TrainerProfile(connectionString, TrainerID, Password);
            updateCoachingClass = new Update_Coaching_Class(connectionString, TrainerID);
        }
        private void TrainerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void TrainerForm_Load(object sender, EventArgs e)
        {
            this.Controls.Add(profile);
            profile.Location = new Point(186, 272);
            profile.Visible = false;

            //profile.ClearAll_and_Reset(TrainerID);

            this.Controls.Add(addCoachingClass);
            addCoachingClass.Location = new Point(186, 0);
            addCoachingClass.Visible = false;

            this.Controls.Add(feedback);
            feedback.Location = new Point(186, 0);
            feedback.Visible = false;

            this.Controls.Add(removeCoachingClass);
            removeCoachingClass.Location = new Point(186, 0);
            removeCoachingClass.Visible = false;

            this.Controls.Add(studentsListandFees);
            studentsListandFees.Location = new Point(186, 0);
            studentsListandFees.Visible = false;

            this.Controls.Add(updateCoachingClass);
            updateCoachingClass.Location = new Point(186, 0);
            updateCoachingClass.Visible = false;

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string insertLecturerIDandName = "SELECT TrainerID, Name FROM Trainer WHERE TrainerID = @value1";
            SqlCommand insertLecturerIDandNameCommand = new SqlCommand(insertLecturerIDandName, connection);
            insertLecturerIDandNameCommand.Parameters.AddWithValue("@value1", TrainerID);
            SqlDataReader reader = insertLecturerIDandNameCommand.ExecuteReader();
            while (reader.Read())
            {
                lblTrainerID.Text = reader.GetString(0);
                lblTrainerName.Text = reader.GetString(1);
            }
            reader.Close();
            connection.Close();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            profile.Visible = true;
            profile.BringToFront();
            addCoachingClass.Visible = false;
            feedback.Visible = false;
            removeCoachingClass.Visible = false;
            studentsListandFees.Visible = false;
            updateCoachingClass.Visible=false;
        }

        private void btnHomeScreen_Click(object sender, EventArgs e)
        {
            profile.Visible = false;
            addCoachingClass.Visible = false;
            feedback.Visible = false;
            removeCoachingClass.Visible = false;
            studentsListandFees.Visible = false;
            updateCoachingClass.Visible = false;
        }

        private void btnCoachingClass_Click(object sender, EventArgs e)
        {
            addCoachingClass.Visible = true;
            addCoachingClass.BringToFront();
            profile.Visible= false;
            feedback.Visible= false;
            removeCoachingClass.Visible = false;
            studentsListandFees.Visible = false;
            updateCoachingClass.Visible = false;
        }

        private void btnUpdateClassInfo_Click(object sender, EventArgs e)
        {
            updateCoachingClass.Visible = true;
            updateCoachingClass.BringToFront();
            profile.Visible = false;
            addCoachingClass.Visible = false;
            feedback.Visible = false;
            removeCoachingClass.Visible = false;
            studentsListandFees.Visible = false;
        }

        private void btnDeleteClassInfo_Click(object sender, EventArgs e)
        {
            removeCoachingClass.Visible = true;
            removeCoachingClass.BringToFront();
            studentsListandFees.Visible = false;
            updateCoachingClass.Visible = false;
            profile.Visible = false;
            addCoachingClass.Visible = false;
            feedback.Visible = false;
        }

        private void btnStudentView_Click(object sender, EventArgs e)
        {
            studentsListandFees.Visible= true;
            studentsListandFees.BringToFront();
            profile.Visible = false;
            addCoachingClass.Visible = false;
            feedback.Visible = false;
            removeCoachingClass.Visible = false;
            updateCoachingClass.Visible= false;
        }

        private void btnFeedback_Click(object sender, EventArgs e)
        {
            feedback.Visible = true;
            feedback.BringToFront();
            removeCoachingClass.Visible = false;
            studentsListandFees.Visible = false;
            updateCoachingClass.Visible = false;
            profile.Visible = false;
            addCoachingClass.Visible = false;
        }
    }
}
