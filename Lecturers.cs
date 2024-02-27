using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APU_Programming_Cafe
{
    public class Lecturers
    {
        private string _LecturerID;
        private string _Name;
        private string _ContactNumber;
        private string _Address;
        private string _Email;

        public string LecturerID
        {
            get { return _LecturerID; }
            set { _LecturerID = value;}
        }
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public string ContactNumber
        {
            get { return _ContactNumber; }
            set { _ContactNumber = value; }
        }
        public string Address
        {
            get { return _Address; }
            set { _Address = value; }
        }
        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }

        // Constructor for display profile
        public Lecturers(string lecturerID)
        {
            LecturerID = lecturerID;
        }

        // Constructor for update profile profile details
        public Lecturers(string lecturerID, string contactNumber, string address, string email)
        {
            LecturerID = lecturerID;
            ContactNumber = contactNumber;
            Address = address;
            Email = email;
        }

        //Method for updating lecturer profile details
        public string updateLecturerProfile(string connectionString)
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                string updateLecturerProfile = "UPDATE Lecturer SET ContactNumber = @contact_Number, Email = @email_Address, Address = @address WHERE LecturerID = @lecturer_ID";
                SqlCommand updateLecturerProfileCommand = new SqlCommand(updateLecturerProfile, connection);
                updateLecturerProfileCommand.Parameters.AddWithValue("@contact_Number", _ContactNumber);
                updateLecturerProfileCommand.Parameters.AddWithValue("@email_Address", _Email);
                updateLecturerProfileCommand.Parameters.AddWithValue("@address", _Address);
                updateLecturerProfileCommand.Parameters.AddWithValue("@lecturer_ID", _LecturerID);
                updateLecturerProfileCommand.ExecuteNonQuery();
                connection.Close();
             
                return "Update Successful.";
            }
            catch
            {
                return "Update Unsuccessful";
            }
        }

        //Method for displaying lecturer profile details in lecturer profile user control form
        public void displayLecturerProfile(TextBox txtLecturerID, TextBox txtAddress, TextBox txtEmail, TextBox txtContactNumber, string connectionString)
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                string lecturerDetails = "SELECT * FROM Lecturer WHERE LecturerID = @lecturerID";
                SqlCommand checkUserDetailsCommand = new SqlCommand(lecturerDetails, connection); 
                checkUserDetailsCommand.Parameters.AddWithValue("@lecturerID", _LecturerID);
                SqlDataReader reader = checkUserDetailsCommand.ExecuteReader();
                while (reader.Read())
                {
                    ContactNumber = reader.GetString(2);
                    Email = reader.GetString(3);
                    Address = reader.GetString(4);
                }
                reader.Close();

                txtAddress.Text = _Address;
                txtContactNumber.Text = _ContactNumber;
                txtEmail.Text = Email;
                txtLecturerID.Text = _LecturerID;
                connection.Close();
            }
            catch
            {
                txtLecturerID.Text = "ID not found.";
            }
        }
    }
}
