using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace APU_Programming_Cafe.Login
{
    public partial class Register_and_Ennrol : UserControl
    {
        string connectionString;
        public Register_and_Ennrol(string connString)
        {
            InitializeComponent();
            connectionString = connString;
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


            if (txtStudentName.Text == string.Empty)
            {
                ErrorCount += 1;
                Error += "Error: Invalid student name. Please entry a student name";
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
                string intake = string.Empty;
                List<string> paymentMonth = new List<string>();

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
                paymentMonth.Clear();

                if (cboMonth.SelectedItem.ToString() == "January")
                {
                    intake = $"01{cboYear.SelectedItem}";
                    paymentMonth.Add("January");
                    paymentMonth.Add("Febuary");
                    paymentMonth.Add("March");
                }
                else if (cboMonth.SelectedItem.ToString() == "April")
                {
                    intake = $"04{cboYear.SelectedItem}";
                    paymentMonth.Add("April");
                    paymentMonth.Add("May");
                    paymentMonth.Add("June");
                }
                else if (cboMonth.SelectedItem.ToString() == "July")
                {
                    intake = $"07{cboYear.SelectedItem}";
                    paymentMonth.Add("July");
                    paymentMonth.Add("August");
                    paymentMonth.Add("September");
                }
                else if (cboMonth.SelectedItem.ToString() == "October")
                {
                    intake = $"10{cboYear.SelectedItem}";
                    paymentMonth.Add("October");
                    paymentMonth.Add("November");
                    paymentMonth.Add("December");
                }

                
                Students RegisterStudent = new Students(txtStudentID.Text, txtStudentName.Text, txtContactNumber.Text, txtStudentEmail.Text ,txtStudentAddress.Text);
                string RegisterSuccessful = RegisterStudent.RegisterStudent(connectionString);
                string Password = RegisterStudent.StudentID;

                LoginUsers addUserLogin = new LoginUsers(RegisterStudent.StudentID, Password, "Student");
                string addUserSuccessful = addUserLogin.addUser(connectionString);

                if (RegisterSuccessful == "true" && addUserSuccessful == "true")
                {
                    string enrolmentSuccessful = string.Empty;
                    Students addEnrolment = new Students(RegisterStudent.StudentID, ModuleCode, intake, "No", PaymentAmount);
                    enrolmentSuccessful = addEnrolment.EnrolStudent(connectionString);

                    if (enrolmentSuccessful == "true")
                    {
                        foreach (string month in paymentMonth)
                        {
                            addEnrolment.addPayment(connectionString, month);
                        }
                        MessageBox.Show("Enrolment Successful!");
                        ClearAll();
                    }
                    else
                    {
                        if (enrolmentSuccessful.Contains("duplicate"))
                        {
                            MessageBox.Show("Student already enrolled for this specific course.");
                        }
                        else
                        {
                            MessageBox.Show("Error: Unable to enrol student. Please try again.");
                        }
                    }
                }
                else
                {
                    if (RegisterSuccessful.Contains("duplicate") || addUserSuccessful.Contains("duplicate"))
                    {
                        MessageBox.Show("Student already registered.");
                    }
                    else
                    {
                        MessageBox.Show("Register Unsuccessful. Please try again.");
                    }
                }
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

    }
}
