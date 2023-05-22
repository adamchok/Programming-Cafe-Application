using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace APU_Programming_Cafe.Login
{
    public partial class Register_and_Ennrol : UserControl
    {
        public Register_and_Ennrol()
        {
            InitializeComponent();
        }
        int ErrorCount = 0;
        string Error = "";
        

        private void ClearAll()
        {
            txtStudentName.Text = string.Empty;
            txtStudentID.Text = string.Empty;
            txtStudentEmail.Text = string.Empty;
            txtContactNumber.Text = string.Empty;
            txtStudentAddress.Text = string.Empty;
            cboLevel.SelectedIndex = -1;
            cboModule.SelectedIndex = -1;
            cboMonth.SelectedIndex = -1;
            cboYear.SelectedIndex = -1;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ClearAll();
            this.Visible = false;

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int phoneNumberChecker;
            Error = string.Empty;
            ErrorCount = 0;
            if (txtStudentName.Text == string.Empty || !txtStudentName.Text.Contains(" "))
            {
                ErrorCount += 1;
                Error += "Error: Invalid student name. Please include spaces in the name.\n";
            }
            if (txtStudentID.Text == string.Empty || !txtStudentID.Text.Contains("TP") || txtStudentID.Text.Length != 8)
            {
                ErrorCount += 1;
                Error += "Error: Invalid student ID. Please enter a valid StudentID in the format TPXXXXXX.\n";
            }
            
            if (txtContactNumber.Text.Length != 12 || !int.TryParse(txtContactNumber.Text.Substring(0, 3), out phoneNumberChecker) || !txtContactNumber.Text.Substring(3, 1).Equals("-") || !int.TryParse(txtContactNumber.Text.Substring(4, 3), out phoneNumberChecker) || !txtContactNumber.Text.Substring(7, 1).Equals("-") || !int.TryParse(txtContactNumber.Text.Substring(8, 4), out phoneNumberChecker))
            {
                ErrorCount += 1;
                Error += "Error: Invalid contact number. Please enter a valid contact number in the format xxx-xxx-xxxx (x is an integer number).\n";
            }
            if (txtStudentEmail.Text == string.Empty || !txtStudentEmail.Text.Contains("@") || !txtStudentEmail.Text.Contains(".com"))
            {
                ErrorCount += 1;
                Error += "Error: Invalid student email. Please enter a valid email address in the format: xxx@mail.com.\n";
            }
            if (txtStudentAddress.Text == string.Empty || txtStudentAddress.Text.Length < 10 || txtStudentAddress.Text.Length > 1000)
            {
                ErrorCount += 1;
                Error += "Error: Invalid student address. Please be longer than 10 characters and less than 1000 characters.\n";
            }

            if (cboLevel.SelectedIndex == -1)
            {
                ErrorCount += 1;
                Error += "Error: No level selected. Please try again.\n";
            }
            if (cboModule.SelectedIndex == -1)
            {
                ErrorCount += 1;
                Error += "Error: No module selected. Please try again.\n";
            }
            if (cboMonth.SelectedIndex == -1)
            {
                ErrorCount += 1;
                Error += "Error: No month of enrolment selected selected. Please try again.\n";
            }
            if (cboYear.SelectedIndex == -1)
            {
                ErrorCount += 1;
                Error += "Error: No year of enrolment selected. Please try again.\n";
            }

            if (ErrorCount > 0)
            {
                MessageBox.Show(Error);
            }
            else
            {
                string ModuleCode = string.Empty;
                decimal PaymentAmount = 0;
                switch (cboLevel.SelectedIndex)
                {
                    case 0:
                        ModuleCode = $"{cboModule.SelectedItem}01";
                        PaymentAmount = 200M;
                        break;
                    case 1:
                        ModuleCode = $"{cboModule.SelectedItem}02";
                        PaymentAmount = 400M;
                        break;
                    case 2:
                        ModuleCode = $"{cboModule.SelectedItem}03";
                        PaymentAmount = 600M;
                        break;
                }
                Students newStudentDetails = new Students();
                newStudentDetails.Name = txtStudentName.Text;
                newStudentDetails.StudentID = txtStudentID.Text;
                newStudentDetails.Email = txtStudentEmail.Text;
                newStudentDetails.ContactNumber = txtContactNumber.Text;
                newStudentDetails.Address = txtStudentAddress.Text;
                newStudentDetails.Level = cboLevel.SelectedItem.ToString();
                newStudentDetails.Module = ModuleCode;
                newStudentDetails.PaymentAmount = PaymentAmount;
                newStudentDetails.EnrolmentMonth = cboMonth.SelectedItem.ToString();
                newStudentDetails.EnrolmentYear = cboYear.SelectedItem.ToString();
                newStudentDetails.Completion = "No";

                Database_Access InsertStudentDataMethod = new Database_Access();
                try
                {
                    InsertStudentDataMethod.RegisterEnrolmentInsertStudentData(newStudentDetails.StudentID, newStudentDetails.Name, newStudentDetails.ContactNumber, newStudentDetails.Email, newStudentDetails.Address, newStudentDetails.Module, newStudentDetails.EnrolmentMonth, newStudentDetails.EnrolmentYear, newStudentDetails.PaymentAmount, newStudentDetails.Completion);
                    MessageBox.Show("Enrolment Successful.");
                    ClearAll();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    //MessageBox.Show("Enrolment Unsuccessful. Please try again.");
                }
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
    }
}
