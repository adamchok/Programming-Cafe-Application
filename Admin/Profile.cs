using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APU_Programming_Cafe.Admin
{
    public partial class AdminProfile : UserControl
    {
        string connectionString;
        string adminID;
        string password;

        public AdminProfile(string connString, string ADMINID, string PASSWORD)
        {
            InitializeComponent();
            connectionString = connString;
            adminID = ADMINID;
            password = PASSWORD;
        }

        public void Clear_and_Reset(string adminID)
        {
            // Clear everything.
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

            //Reinsert everything.
            Admins adminDetails = new Admins(adminID);
            txtPassword.Text = password;
            adminDetails.displayAdminProfile(txtAdminID, txtAddress, txtEmail, txtContactNumber, txtPassword, connectionString);
        }

        private void AdminProfile_Load(object sender, EventArgs e)
        {
            Clear_and_Reset(adminID);
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
            }
            else
            {
                Admins updateAdminDetails = new Admins(adminID, txtContactNumber.Text, txtAddress.Text, txtEmail.Text);
                string output = updateAdminDetails.updateAdminProfile(connectionString);

                if (output != "Update Successful.")
                {
                    MessageBox.Show(output);
                }
                else
                {
                    LoginUsers updateAdminPassword = new LoginUsers(adminID, txtPassword.Text);
                    string passwordOutput = updateAdminPassword.updatePassword(connectionString);

                    if (passwordOutput != "Successful")
                    {
                        MessageBox.Show(passwordOutput);
                    }
                    else
                    {
                        MessageBox.Show(output);
                    }
                }
                Clear_and_Reset(adminID);
                
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Clear_and_Reset(adminID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
