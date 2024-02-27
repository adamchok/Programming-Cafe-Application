using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static APU_Programming_Cafe.Lecturer.Enrolment_Request;

namespace APU_Programming_Cafe.Lecturer
{
    public partial class Enrolment_Request : UserControl
    {
        string connectionString;
        public Enrolment_Request(string connString)
        {
            InitializeComponent();
            connectionString = connString;
        }

        List<string> tempStudentID = new List<string>();

        public void ClearAll()
        {
            cboEnrolmentMonth.SelectedIndex = -1;
            cboEnrolmentYear.SelectedIndex = -1;
            listSelectedStudents.SelectedIndex = -1;
            txtSearch.Text = string.Empty;
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            listSelectedStudents.Items.Clear();
            ClearAll();
            this.Visible = false;
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            int ErrorCount = 0;
            string Error = string.Empty;
            if (listSelectedStudents.Items.Count == 0)
            {
                ErrorCount += 1;
                Error += "Error: There are no student request at the moment.\n";
            }
            else
            {
                if (listSelectedStudents.SelectedIndex == -1)
                {
                    ErrorCount += 1;
                    Error += "Error: No requested student selected. Please try again.\n";
                }
                if (cboEnrolmentMonth.SelectedIndex == -1)
                {
                    ErrorCount += 1;
                    Error += "Error: No enrolment month selected. Please try again.\n";
                }
                if (cboEnrolmentYear.SelectedIndex == -1)
                {
                    ErrorCount += 1;
                    Error += "Error: No enrolment year selected. Please try again.\n";
                }
            }

            if (ErrorCount > 0)
            {
                MessageBox.Show(Error);
            }
            else
            {
                string StudentID_and_RequestedModule = listSelectedStudents.SelectedItem.ToString();
                string[] splittingStudentID_and_RequestedModule = StudentID_and_RequestedModule.Split(' ');
                decimal PaymentAmount = 0;
                string ModuleCode = splittingStudentID_and_RequestedModule[1];
                string StudentID = splittingStudentID_and_RequestedModule[0];

                if (ModuleCode.Contains("01"))
                {
                    PaymentAmount = 200M;
                }
                else if (ModuleCode.Contains("02"))
                {
                    PaymentAmount = 400M;
                }
                else if (ModuleCode.Contains("03"))
                {
                    PaymentAmount = 600M;
                }

                string intake = string.Empty;
                List<string> paymentMonth = new List<string>();
                paymentMonth.Clear();

                if (cboEnrolmentMonth.SelectedItem.ToString() == "January")
                {
                    intake = $"01{cboEnrolmentYear.SelectedItem}";
                    paymentMonth.Add("January");
                    paymentMonth.Add("Febuary");
                    paymentMonth.Add("March");
                }
                else if (cboEnrolmentMonth.SelectedItem.ToString() == "April")
                {
                    intake = $"04{cboEnrolmentYear.SelectedItem}";
                    paymentMonth.Add("April");
                    paymentMonth.Add("May");
                    paymentMonth.Add("June");
                }
                else if (cboEnrolmentMonth.SelectedItem.ToString() == "July")
                {
                    intake = $"07{cboEnrolmentYear.SelectedItem}";
                    paymentMonth.Add("July");
                    paymentMonth.Add("August");
                    paymentMonth.Add("September");
                }
                else if (cboEnrolmentMonth.SelectedItem.ToString() == "October")
                {
                    intake = $"10{cboEnrolmentYear.SelectedItem}";
                    paymentMonth.Add("October");
                    paymentMonth.Add("November");
                    paymentMonth.Add("December");
                }

                string enrolmentSuccessful = string.Empty;
                Students addEnrolment = new Students(StudentID, ModuleCode, intake, "No", PaymentAmount);
                enrolmentSuccessful = addEnrolment.EnrolStudent(connectionString);

                if (enrolmentSuccessful == "true")
                {
                    foreach (string month in paymentMonth)
                    {
                        addEnrolment.addPayment(connectionString, month);
                    }
                    addEnrolment.DeleteRequest(connectionString);
                    MessageBox.Show("Enrolment Successful!");
                    ClearAll();
                    btnRefresh.PerformClick();
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
        }
        private void Enrolment_Request_Load(object sender, EventArgs e)
        {
            btnRefresh.PerformClick();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            listSelectedStudents.Items.Clear();
            tempStudentID.Clear();

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT Request.StudentID, Student.Name, Request.ModuleCode FROM Request INNER JOIN Student ON Request.StudentID = Student.StudentID", connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            datagridRequestedStudents.DataSource = dataTable;
            datagridRequestedStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            string listboxQuery = "SELECT StudentID, ModuleCode FROM Request ORDER BY StudentID ASC";
            List<string> Student_and_RequestedModule = new List<string>();
            SqlCommand command = new SqlCommand(listboxQuery, connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string StudentID = reader.GetString(0);
                string ModuleCode = reader.GetString(1);
                if (!Student_and_RequestedModule.Contains(StudentID))
                {
                    Student_and_RequestedModule.Add(StudentID + " " + ModuleCode);
                    tempStudentID.Add(StudentID + " " + ModuleCode);
                }
            }
            reader.Close();
            foreach (string item in Student_and_RequestedModule)
            {
                if (!listSelectedStudents.Items.Contains(item))
                {
                    listSelectedStudents.Items.Add(item);
                }
            }
            listSelectedStudents.DisplayMember = "ID";
            listSelectedStudents.SelectedIndex = -1;
            connection.Close();
            ClearAll();
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
                MessageBox.Show("There are no student requests at the moment.");
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == string.Empty)
            {
                btnRefresh.PerformClick();
            }
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            string[] splittingStudentID_and_RequestedModule = listSelectedStudents.SelectedItem.ToString().Split(' ');
            Students rejectedStudent = new Students();
            rejectedStudent.StudentID = splittingStudentID_and_RequestedModule[0];
            rejectedStudent.ModuleCode = splittingStudentID_and_RequestedModule[1];

            string DeleteSuccessful = rejectedStudent.DeleteRequest(connectionString);
            if (DeleteSuccessful != "true")
            {
                MessageBox.Show("Error: Unable to reject student's request.");
            }
            else
            {
                MessageBox.Show("Rejection Successful.");
                btnRefresh.PerformClick();
            }
        }

        private void Enrolment_Request_VisibleChanged(object sender, EventArgs e)
        {
            btnRefresh.PerformClick();
        }
    }
}