using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace APU_Programming_Cafe.Lecturer
{
    public partial class LecturerForm : Form
    {
        public string lecturerID { get; set; }
        public string tableName;
        public string password;
        List<string> LecturerIDList = new List<string>();
        List<string> LecturerNameList = new List<string>();

        public LecturerForm()
        {
            InitializeComponent();
        }
        
        private void btnRegister_Click(object sender, EventArgs e)
        {
            register_and_Ennrol.Visible = true;
            register_and_Ennrol.BringToFront();
            update_Enrolment.Visible = false;
            enrolment_Request.Visible = false;
            removeStudent.Visible = false;
            lecturer_Profile1.Visible = false;
        }

        private void btnHomeScreen_Click(object sender, EventArgs e)
        {
            register_and_Ennrol.Visible=false;
            update_Enrolment.Visible = false;
            enrolment_Request.Visible = false;
            removeStudent.Visible = false;
            lecturer_Profile1.Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            update_Enrolment.Visible = true;
            update_Enrolment.BringToFront();
            register_and_Ennrol.Visible = false;
            enrolment_Request.Visible = false;
            removeStudent.Visible = false;
            lecturer_Profile1.Visible = false;
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            enrolment_Request.Visible = true;
            enrolment_Request.BringToFront();
            update_Enrolment.Visible = false;
            register_and_Ennrol.Visible = false;
            removeStudent.Visible = false;
            lecturer_Profile1.Visible = false;
        }

        private void LecturerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            removeStudent.Visible = true;
            removeStudent.BringToFront();
            enrolment_Request.Visible = false;
            update_Enrolment.Visible = false;
            register_and_Ennrol.Visible = false;
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            lecturer_Profile1.Visible = true;
            lecturer_Profile1.BringToFront();
            if (lecturer_Profile1.Visible == true)
            {
                lecturer_Profile1.ClearAll_and_Reset(lecturerID);
            }
        }

        private void LecturerForm_Load(object sender, EventArgs e)
        {
            // database access code to fetch LecturerID and Lecturer Name from Code.
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\user\OneDrive - Asia Pacific University\IOOP APPLICATION\APU Programming Cafe\APU database.mdf"";Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string showLecturerID_and_Name = $"SELECT LecturerID, Name FROM {tableName} WHERE LecturerID = @value2";
            SqlCommand checkUserDetailsCommand = new SqlCommand(showLecturerID_and_Name, connection);
            try
            {
                checkUserDetailsCommand.Parameters.AddWithValue("@value2", lecturerID);
                SqlDataReader reader = checkUserDetailsCommand.ExecuteReader();
                while (reader.Read())
                {
                    string LecturerID = reader.GetString(0);
                    string LecturerName = reader.GetString(1);
                    LecturerIDList.Add(LecturerID);
                    LecturerNameList.Add(LecturerName);
                }
                reader.Close();
                lblLecturerID.Text = LecturerIDList[0].ToString();
                lblLecturerName.Text = LecturerNameList[0].ToString();
                lecturer_Profile1.lecturerID = LecturerIDList[0].ToString();
                lecturer_Profile1.password = password;
                lecturer_Profile1.insertProfileDetails = true;
                connection.Close();
            }
            catch /*(Exception ex)*/
            {
                //MessageBox.Show(ex.ToString());
                lblLecturerID.Text = "ID not found.";
                lblLecturerName.Text = "Name not found.";
            }
        }

        
    }
}
