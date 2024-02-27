using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static APU_Programming_Cafe.Login.Register_and_Ennrol;

namespace APU_Programming_Cafe.Lecturer
{
    public partial class Update_Enrolment : UserControl
    {
        string connectionString;
        public Update_Enrolment(string connString)
        {
            InitializeComponent();
            connectionString = connString;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ClearAll();
        }

        int ErrorCount = 0;
        string Error = "";
        List<string> tempStudentID = new List<string>();

        private void ClearAll()
        {
            listSelectedStudents.SelectedIndex = -1;
            cboUpdatedLevel.SelectedIndex = -1;
            cboUpdatedModule.SelectedIndex = -1;
            cboUpdatedMonth.SelectedIndex = -1;
            cboUpdatedYear.SelectedIndex = -1;
            txtSearch.Text = string.Empty;
        }


        private void Update_Enrolment_Load(object sender, EventArgs e)
        {
            btnRefresh.PerformClick();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string ErrorCheck = ErrorChecking();
            

            if (ErrorCheck != "False")
            {
                MessageBox.Show(ErrorCheck);
            }
            else
            {
                string ModuleCode = string.Empty;
                decimal PaymentAmount = 0M;
                string StudentID_and_CurrentModule = listSelectedStudents.SelectedItem.ToString();
                string[] splittingStudentID_and_CurrentModule = StudentID_and_CurrentModule.Split(' ');
                List<string> paymentMonth = new List<string>();
                switch (cboUpdatedLevel.SelectedIndex)
                {
                    case 0:
                        ModuleCode = $"{cboUpdatedModule.SelectedItem}01";
                        PaymentAmount = 200M;
                        break;
                    case 1:
                        ModuleCode = $"{cboUpdatedModule.SelectedItem}02";
                        PaymentAmount = 400M;
                        break;
                    case 2:
                        ModuleCode = $"{cboUpdatedModule.SelectedItem}03";
                        PaymentAmount = 600M;
                        break;
                }
                string intake = "";

                paymentMonth.Clear();

                if (cboUpdatedMonth.SelectedItem.ToString() == "January")
                {
                    intake = $"01{cboUpdatedYear.SelectedItem}";
                    paymentMonth.Add("January");
                    paymentMonth.Add("Febuary");
                    paymentMonth.Add("March");
                }
                else if (cboUpdatedMonth.SelectedItem.ToString() == "April")
                {
                    intake = $"04{cboUpdatedYear.SelectedItem}";
                    paymentMonth.Add("April");
                    paymentMonth.Add("May");
                    paymentMonth.Add("June");
                }
                else if (cboUpdatedMonth.SelectedItem.ToString() == "July")
                {
                    intake = $"07{cboUpdatedYear.SelectedItem}";
                    paymentMonth.Add("July");
                    paymentMonth.Add("August");
                    paymentMonth.Add("September");
                }
                else if (cboUpdatedMonth.SelectedItem.ToString() == "October")
                {
                    intake = $"10{cboUpdatedYear.SelectedItem}";
                    paymentMonth.Add("October");
                    paymentMonth.Add("November");
                    paymentMonth.Add("December");
                }

                Students updateEnrolment = new Students(splittingStudentID_and_CurrentModule[0], splittingStudentID_and_CurrentModule[1], PaymentAmount, intake, ModuleCode);
                bool updateSuccessful = updateEnrolment.UpdateEnrolment(connectionString);
                
                if (updateSuccessful == true)
                {
                    bool paymentSuccessful = false;
                    paymentSuccessful = updateEnrolment.UpdatePayment(connectionString, paymentMonth);
                    if (paymentSuccessful == true)
                    {
                        MessageBox.Show("Update Successful.");
                        btnRefresh.PerformClick();
                        ClearAll();
                    }
                    else
                    {
                        MessageBox.Show("Update Unsuccessful. Please try again.");
                    }
                }
                else
                {
                    MessageBox.Show("Update Unsuccessful. Please try again.");
                }
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            bool IDnotPresent = true;
            listSelectedStudents.Items.Clear();
            if (tempStudentID.Count > 0)
            {
                if (txtSearch.Text != string.Empty && txtSearch.Text.Contains("TP") && txtSearch.Text.Length <= 8)
                {
                    foreach (string ID in tempStudentID)
                    {
                        if (ID.Contains(txtSearch.Text))
                        {
                            listSelectedStudents.Items.Add(ID);
                            IDnotPresent = false;
                        }
                    }
                    if (IDnotPresent == true)
                    {
                        MessageBox.Show("Student ID entered is not found. Try again?");
                    }
                }
                else
                {
                    MessageBox.Show("Error: Invalid student ID entered. Please try again.");
                    btnRefresh.PerformClick();
                }
            }
            else
            {
                MessageBox.Show("There are no student to update at the moment.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
            btnRefresh.PerformClick();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            tempStudentID.Clear();
            listSelectedStudents.Items.Clear();

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT Enrolment.StudentID, Student.Name, Enrolment.ModuleCode, Enrolment.Intake FROM Enrolment INNER JOIN Student ON Enrolment.StudentID = Student.StudentID WHERE Completion = 'No'", connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            datagridEnrolledStudents.DataSource = dataTable;
            datagridEnrolledStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            string listboxQuery = "SELECT StudentID, ModuleCode FROM Enrolment ORDER BY StudentID ASC";
            List<string> StudentID_and_ModuleCode = new List<string>();
            SqlCommand command = new SqlCommand(listboxQuery, connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string StudentID = reader.GetString(0);
                string ModuleCode = reader.GetString(1);
                if (!StudentID_and_ModuleCode.Contains(StudentID))
                {
                    StudentID_and_ModuleCode.Add(StudentID + " " + ModuleCode);
                    tempStudentID.Add(StudentID + " " + ModuleCode);
                }
            }
            reader.Close();

            foreach (string item in StudentID_and_ModuleCode)
            {
                if (!listSelectedStudents.Items.Contains(item))
                {
                    listSelectedStudents.Items.Add(item);
                }
            }

            listSelectedStudents.DisplayMember = "ID";
            listSelectedStudents.SelectedIndex = -1;
            connection.Close();
            txtSearch.Text = string.Empty;
        }

        private string ErrorChecking()
        {
            Error = string.Empty;
            ErrorCount = 0;


            if (listSelectedStudents.SelectedIndex == -1)
            {
                ErrorCount += 1;
                Error += "Error: No student selected. Please follow the instructions and try again.\n";
            }
            if (cboUpdatedLevel.SelectedIndex == -1)
            {
                ErrorCount += 1;
                Error += "Error: No updated level selected. Please try again.\n";
            }
            if (cboUpdatedModule.SelectedIndex == -1)
            {
                ErrorCount += 1;
                Error += "Error: No updated module level selected. Please try again.\n";
            }

            if (cboUpdatedYear.SelectedIndex == -1)
            {
                ErrorCount += 1;
                Error += "Error: No updated year selected. Please try again.\n";
            }
            if (cboUpdatedMonth.SelectedIndex == -1)
            {
                ErrorCount += 1;
                Error += "Error: No updated month selected. Please try again.\n";
            }
            if (ErrorCount == 0)
            {
                string ModuleCode = string.Empty;
                switch (cboUpdatedLevel.SelectedIndex)
                {
                    case 0:
                        ModuleCode = $"{cboUpdatedModule.SelectedItem}01";
                        break;
                    case 1:
                        ModuleCode = $"{cboUpdatedModule.SelectedItem}02";
                        break;
                    case 2:
                        ModuleCode = $"{cboUpdatedModule.SelectedItem}03";
                        break;
                }

                string StudentID_and_UpdatedModule = listSelectedStudents.SelectedItem.ToString();
                string[] splittingStudentID_and_UpdatedModule = StudentID_and_UpdatedModule.Split(' ');
                string StudentIDForErrorChecking = splittingStudentID_and_UpdatedModule[0];
                string currentModuleCode = splittingStudentID_and_UpdatedModule[1];

                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                string listboxQuery = "SELECT ModuleCode FROM Enrolment WHERE StudentID = @student_ID";
                List<string> currentModulesList = new List<string>();
                SqlCommand command = new SqlCommand(listboxQuery, connection);
                command.Parameters.AddWithValue("@student_ID", StudentIDForErrorChecking);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string currentModule = reader.GetString(0);
                    if (!currentModulesList.Contains(currentModuleCode))
                    {
                        currentModulesList.Add(currentModule);
                    }
                }
                reader.Close();
                connection.Close();

                foreach (string module in currentModulesList)
                {
                    if (module == ModuleCode)
                    {
                        ErrorCount += 1;
                        Error += "Error: Student is already enrolled in the selected updated module and level.\n";
                        break;
                    }
                }
            }

            if (ErrorCount > 0)
            {
                return Error;
            }
            else
            {
                return "False";
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == string.Empty)
            {
                btnRefresh.PerformClick();
            }
        }

        private void Update_Enrolment_VisibleChanged(object sender, EventArgs e)
        {
            btnRefresh.PerformClick();
        }
    }
}
