using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APU_Programming_Cafe
{
    public class Admins
    {
        private string _AdminID;
        private string _Name;
        private string _ContactNumber;
        private string _Address;
        private string _Email;

        public string AdminID
        {
            get { return _AdminID; }
            set { _AdminID = value; }
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

        //Constructor to display profile
        public Admins(string adminID)
        {
            AdminID = adminID;
        }

        //Constructor to update profile details
        public Admins(string adminID, string contactNumber, string address, string email)
        {
            AdminID = adminID;
            ContactNumber = contactNumber;
            Address = address;
            Email = email;
        }

        //Method for displaying admin profile detais in admin profile user control form
        public void displayAdminProfile(TextBox txtAdminID, TextBox txtAddress, TextBox txtEmail, TextBox txtContactNumber, TextBox txtPassword, string connectionString)
        {
            string password = "";
            try
            {
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();

                string adminDetails = "SELECT * FROM Admin WHERE AdminID = @adminID";
                SqlCommand adminDetailscmd = new SqlCommand(adminDetails, con);
                adminDetailscmd.Parameters.AddWithValue("@adminID", _AdminID);
                SqlDataReader rd = adminDetailscmd.ExecuteReader();
                while (rd.Read())
                {
                    ContactNumber = rd.GetString(2);
                    Email = rd.GetString(3);
                    Address = rd.GetString(4);
                }
                rd.Close();

                txtAdminID.Text = _AdminID;
                txtAddress.Text = _Address;
                txtEmail.Text = _Email;
                txtContactNumber.Text = _ContactNumber;

                string lecturerPassword = "SELECT Password FROM Login WHERE Username = @username";
                SqlCommand checkUserPasswordCommand = new SqlCommand(lecturerPassword, con);
                checkUserPasswordCommand.Parameters.AddWithValue("@username", _AdminID);
                SqlDataReader passwordReader = checkUserPasswordCommand.ExecuteReader();
                while (passwordReader.Read())
                {
                    password = passwordReader.GetString(0);
                }
                passwordReader.Close();

                txtPassword.Text = password;
                con.Close();
            }
            catch
            {
                txtAdminID.Text = "ID not found";
            }
        }

        //Method for updating admin profile details
        public string updateAdminProfile(string connectionString)
        {
            try
            {
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();

                string updateAdminProfile = "UPDATE Admin SET ContactNumber = @contactNumber, Email = @email, Address = @address WHERE AdminID = @adminID";
                SqlCommand updateAdminProfilecmd = new SqlCommand(updateAdminProfile, con);
                updateAdminProfilecmd.Parameters.AddWithValue("@contactNumber", _ContactNumber);
                updateAdminProfilecmd.Parameters.AddWithValue("@email", _Email);
                updateAdminProfilecmd.Parameters.AddWithValue("@address", _Address);
                updateAdminProfilecmd.Parameters.AddWithValue("@adminID", _AdminID);
                updateAdminProfilecmd.ExecuteNonQuery();

                con.Close();

                return "Update Successful.";
            }
            catch
            {
                return "Update Unsuccessful.";
            }
        }
    }
}
