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
using static APU_Programming_Cafe.Lecturer.Lecturer_Profile;
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
        Database_Access database_access = new Database_Access();


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

            database_access.insertDetails(lecturerID, txtAddress, txtContactNumber, txtEmail, txtLecturerID, txtPassword);
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
                database_access.updateProfileInformation(updatedLecturerDetails.ContactNumber, updatedLecturerDetails.EmailAddress, updatedLecturerDetails.Address, updatedLecturerDetails.Password, lecturerID);
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
                database_access.insertDetails(lecturerID, txtAddress, txtContactNumber, txtEmail, txtLecturerID, txtPassword);
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
