using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APU_Programming_Cafe.Trainer
{
    public partial class TrainerProfile : UserControl
    {
        string connectionString;
        string TrainerID;
        string Password;
        public TrainerProfile(string connString, string trainerID, string password)
        {
            connectionString = connString;
            TrainerID = trainerID;
            Password = password;
            InitializeComponent();
        }

        private void ClearAll_and_Reset(string trainerID)
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

            Trainers trainerDetails = new Trainers(trainerID);
            txtPassword.Text = Password;
            trainerDetails.displayTrainerProfile(txtTrainerID, txtAddress, txtEmail, txtContactNumber, txtPassword, connectionString);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int ErrorCount = 0;
            string Error = "";
            if (txtPassword.Text == string.Empty || txtPassword.Text.Length > 30)
            {
                ErrorCount++;
                Error += "Error: Password is empty or exceeded the 30 character limit. Please try again.\n";
            }
            int phoneNumber;
            if (txtContactNumber.Text.Length != 12 || !int.TryParse(txtContactNumber.Text.Substring(0, 3), out phoneNumber) || !txtContactNumber.Text.Substring(3,1).Equals("-") || !int.TryParse(txtContactNumber.Text.Substring(4,3), out phoneNumber) || !txtContactNumber.Text.Substring(7,1).Equals("-") || !int.TryParse(txtContactNumber.Text.Substring(8,4), out phoneNumber))
            {
                ErrorCount++;
                Error += "Error invalid contact number. Please enter a valid contact number in the format xxx-xxx-xxxx (x is an integer number).\n";
            }
            if (txtAddress.Text == string.Empty)
            {
                ErrorCount++;
                Error += "Error: Address is emtpy. Please try again.\n";
            }
            if (txtEmail.Text == string.Empty || !txtEmail.Text.Contains("@") || !txtEmail.Text.Contains(".com"))
            {
                ErrorCount++;
                Error += "Error: Invalid email. Email is either empty or is an invalid format. Please enter a valid email address with an '@' and '.com'.\n";
            }

            if (ErrorCount > 0)
            {
                MessageBox.Show(Error);
            }
            else
            {
                Trainers updatedTrainerDetails = new Trainers(TrainerID, txtContactNumber.Text, txtAddress.Text, txtEmail.Text);
                string updateDetails = updatedTrainerDetails.updateTrainerProfile(connectionString);

                LoginUsers updatedTrainerPassword = new LoginUsers(TrainerID, txtPassword.Text);
                string updatePassword = updatedTrainerPassword.updatePassword(connectionString);

                if (updateDetails.Contains("Successful") && updatePassword.Contains("Successful"))
                {
                    MessageBox.Show(updateDetails);
                }
                else
                {
                    MessageBox.Show(updateDetails);
                }
                ClearAll_and_Reset(TrainerID);
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClearAll_and_Reset(TrainerID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void TrainerProfile_Load(object sender, EventArgs e)
        {
            btnRefresh.PerformClick();
        }

        private void TrainerProfile_VisibleChanged(object sender, EventArgs e)
        {
            btnRefresh.PerformClick();
        }
    }
}
