using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace APU_Programming_Cafe.Lecturer
{
    public partial class Lecturer_Profile : UserControl
    {
        public string lecturerID;
        public string password;
        public bool insertProfileDetails = false;
        public class LecturerDetails
        {
            public string LecturerID;
            public string Password;
            public string ContactNumber;
            public string EmailAddress;
            public string Address;
        }

        public class updatedLecturerDetails
        {
            public string Password;
            public string ContactNumber;
            public string EmailAddress;
            public string Address;
        }
        public Lecturer_Profile()
        {
            InitializeComponent();
        }

        public void insertDetails(string lecturerID)
        {
            LecturerDetails lecturerDetails = new LecturerDetails();
            lecturerDetails.LecturerID = lecturerID;

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\user\OneDrive - Asia Pacific University\IOOP APPLICATION\APU Programming Cafe\APU database.mdf"";Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string fetchLecturerDetails = "SELECT * FROM Lecturer WHERE LecturerID = @value1";
            string fetchLecturerPassword = "SELECT Password FROM Login WHERE Username = @value2";
            SqlCommand checkUserDetailsCommand = new SqlCommand(fetchLecturerDetails, connection);
            SqlCommand checkUserPasswordCommand = new SqlCommand(fetchLecturerPassword, connection);
            try
            {
                checkUserDetailsCommand.Parameters.AddWithValue("@value1", lecturerID);
                checkUserPasswordCommand.Parameters.AddWithValue("@value2", lecturerID);
                SqlDataReader reader = checkUserDetailsCommand.ExecuteReader();
                while (reader.Read())
                {
                    lecturerDetails.ContactNumber = reader.GetString(2);
                    lecturerDetails.EmailAddress = reader.GetString(3);
                    lecturerDetails.Address = reader.GetString(4);
                }
                reader.Close();
                SqlDataReader passwordReader = checkUserPasswordCommand.ExecuteReader();
                while (passwordReader.Read())
                {
                    lecturerDetails.Password = passwordReader.GetString(0);
                }
                passwordReader.Close();
                txtAddress.Text = lecturerDetails.Address;
                txtContactNumber.Text = lecturerDetails.ContactNumber;
                txtEmail.Text = lecturerDetails.EmailAddress;
                txtLecturerID.Text = lecturerDetails.LecturerID;
                txtPassword.Text = lecturerDetails.Password;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                //lblLecturerID.Text = "ID not found.";
                //lblLecturerName.Text = "Name not found.";
            }
        }

        public void updateLectureProfile(string Password, string ContactNumber, string Email, string Address, string LecturerID)
        {
            try
            {
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\user\OneDrive - Asia Pacific University\IOOP APPLICATION\APU Programming Cafe\APU database.mdf"";Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                string updateLecturerProfile = "UPDATE Lecturer SET ContactNumber = @contact_Number, Email = @email_Address, Address = @address";
                SqlCommand updateLecturerProfileCommand = new SqlCommand(updateLecturerProfile, connection);
                updateLecturerProfileCommand.Parameters.AddWithValue("@contact_Number", ContactNumber);
                updateLecturerProfileCommand.Parameters.AddWithValue("@email_Address", Email);
                updateLecturerProfileCommand.Parameters.AddWithValue("@address", Address);
                updateLecturerProfileCommand.ExecuteNonQuery();

                string updateUserLoginDetails = "UPDATE Login SET Password = @password WHERE Username = @lecturerID";
                SqlCommand updateUserLoginDetailsCommand = new SqlCommand(updateUserLoginDetails, connection);
                updateUserLoginDetailsCommand.Parameters.AddWithValue("@password", Password);
                updateUserLoginDetailsCommand.Parameters.AddWithValue("@lecturerID", LecturerID);
                updateUserLoginDetailsCommand.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }


        public void ClearAll_and_Reset(string lecturerID)
        {
            btnSave.Visible = false;
            txtAddress.Enabled = false;
            txtPassword.Enabled = false;
            txtContactNumber.Enabled = false;
            txtEmail.Enabled = false;
            txtPassword.PasswordChar = '*';
            
            txtAddress.Text = "";
            txtPassword.Text = "";
            txtContactNumber.Text = "";
            txtEmail.Text = "";
            txtPassword.Text = "";

            insertDetails(lecturerID);
        }

        public void disableTextBox()
        {
            txtAddress.Enabled = false;
            txtPassword.Enabled = false;
            txtContactNumber.Enabled = false;
            txtEmail.Enabled = false;
            txtPassword.PasswordChar = '*';
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int ErrorCount = 0;
            string Error = "";
            if (txtPassword.Text == string.Empty || txtPassword.Text.Length > 30)
            {
                ErrorCount += 1;
                Error += "Error: Password is empty or exceeded the 30 character limit. Please try again.\n";
            }
            int phoneNumber;
            if (txtContactNumber.Text.Length != 12 || !int.TryParse(txtContactNumber.Text.Substring(0, 3), out phoneNumber) || !txtContactNumber.Text.Substring(3, 1).Equals("-") || !int.TryParse(txtContactNumber.Text.Substring(4, 3), out phoneNumber) || !txtContactNumber.Text.Substring(7, 1).Equals("-") || !int.TryParse(txtContactNumber.Text.Substring(8, 4), out phoneNumber))
            {
                ErrorCount += 1;
                Error += "Error: Invalid contact number. Please enter a valid contact number in the format xxx-xxx-xxxx (x is an integer number).\n";
            }
            if (txtAddress.Text == string.Empty)
            {
                ErrorCount += 1;
                Error += "Error: Address is empty. Please try again.\n";
            }
            if (txtEmail.Text == string.Empty || !txtEmail.Text.Contains("@") || !txtEmail.Text.Contains(".com"))
            {
                ErrorCount += 1;
                Error += "Error: Invalid email. Email is either empty or is in an invalid format. Please enter a valid email address with an '@' and '.com'\n";
            }

            if (ErrorCount > 0)
            {
                MessageBox.Show(Error);
                //ClearAll_and_Reset(lecturerID);
            }
            else
            {
                updatedLecturerDetails updatedLecturerDetails = new updatedLecturerDetails();
                updatedLecturerDetails.Password = txtPassword.Text;
                updatedLecturerDetails.ContactNumber = txtContactNumber.Text;
                updatedLecturerDetails.EmailAddress = txtEmail.Text;
                updatedLecturerDetails.Address = txtAddress.Text;

                updateLectureProfile(updatedLecturerDetails.Password, updatedLecturerDetails.ContactNumber, updatedLecturerDetails.EmailAddress, updatedLecturerDetails.Address, lecturerID);
                ClearAll_and_Reset(lecturerID);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnSave.Visible = true;
            txtAddress.Enabled = true;
            txtPassword.Enabled = true;
            txtContactNumber.Enabled = true;
            txtEmail.Enabled = true;
            txtPassword.PasswordChar = '\0';
        }

        private void Lecturer_Profile_Load(object sender, EventArgs e)
        {
            if (insertProfileDetails == true)
            {
                insertDetails(lecturerID);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClearAll_and_Reset(lecturerID);
        }
    }
}
