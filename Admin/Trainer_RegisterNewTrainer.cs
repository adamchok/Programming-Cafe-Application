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
    public partial class Trainer_RegisterNewTrainer : UserControl
    {
        string connectionString;
        string Error = "";
        int ErrorCount = 0;

        public Trainer_RegisterNewTrainer(string connString)
        {
            InitializeComponent();
            connectionString = connString;
        }

        private void ClearAll()
        {
            txtTrainerID.Text = string.Empty;
            txtTrainerName.Text = string.Empty;
            txtContact.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtAddress.Text = string.Empty;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            int phoneNumberChecker;
            Error = string.Empty;
            ErrorCount = 0;

            if (txtTrainerName.Text == string.Empty || !txtTrainerName.Text.Contains(" "))
            {
                ErrorCount += 1;
                Error += "Error: Invalid trainer name. Please include spaces in the name.\n";
            }
            if (txtTrainerID.Text == string.Empty || !txtTrainerID.Text.Contains("TD") || txtTrainerID.Text.Length != 8)
            {
                ErrorCount += 1;
                Error += "Error: Invalid trainer ID. Please enter a valid TrainerID in the format TDXXXXXX.\n";
            }

            if (txtContact.Text.Length != 12 || !int.TryParse(txtContact.Text.Substring(0, 3), out phoneNumberChecker) || !txtContact.Text.Substring(3, 1).Equals("-") || !int.TryParse(txtContact.Text.Substring(4, 3), out phoneNumberChecker) || !txtContact.Text.Substring(7, 1).Equals("-") || !int.TryParse(txtContact.Text.Substring(8, 4), out phoneNumberChecker))
            {
                ErrorCount += 1;
                Error += "Error: Invalid contact number. Please enter a valid contact number in the format xxx-xxx-xxxx (x is an integer number).\n";
            }
            if (txtEmail.Text == string.Empty || !txtEmail.Text.Contains("@") || !txtEmail.Text.Contains(".com"))
            {
                ErrorCount += 1;
                Error += "Error: Invalid trainer email. Please enter a valid email address in the format: xxx@mail.com.\n";
            }
            if (txtAddress.Text == string.Empty || txtAddress.Text.Length < 10 || txtAddress.Text.Length > 1000)
            {
                ErrorCount += 1;
                Error += "Error: Invalid trainer address. Please be longer than 10 characters and less than 1000 characters.\n";
            }

            if (ErrorCount > 0)
            {
                MessageBox.Show(Error);
            }
            else
            {
                Trainers RegisterNewTrainer = new Trainers(txtTrainerName.Text, txtTrainerID.Text, txtContact.Text, txtEmail.Text, txtAddress.Text);
                string RegisterSuccessful = RegisterNewTrainer.RegisterNewTrainer(connectionString);
                string Password = RegisterNewTrainer.TrainerID;

                LoginUsers addUsertoLogin = new LoginUsers(RegisterNewTrainer.TrainerID, Password, "Trainer");
                string addUserSuccessful = addUsertoLogin.addUser(connectionString);

                if (RegisterSuccessful == "true" && addUserSuccessful == "true")
                {
                    MessageBox.Show("Registration Successful.");
                    ClearAll();
                }
                else
                {
                    if (RegisterSuccessful.Contains("duplicate") || addUserSuccessful.Contains("duplicate"))
                    {
                        MessageBox.Show("Trainer already registered.");
                    }
                    else
                    {
                        MessageBox.Show("Register Unsuccessful. Please try again.");
                    }
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ClearAll();
            this.Visible = false;
        }

        private void Trainer_RegisterNewTrainer_VisibleChanged(object sender, EventArgs e)
        {
            ClearAll();
        }
    }
}
