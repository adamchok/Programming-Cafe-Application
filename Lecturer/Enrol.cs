using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APU_Programming_Cafe.Lecturer
{
    public partial class Enrol : UserControl
    {
        string connectionString;
        public Enrol(string connString)
        {
            connectionString = connString;
            InitializeComponent();
        }

        int ErrorCount = 0;
        string Error = "";
        List<string> tempStudentID = new List<string>();

        public void ClearAll()
        {
            cboLevel.SelectedIndex = -1;
            cboModule.SelectedIndex = -1;
            cboMonth.SelectedIndex = -1;
            cboYear.SelectedIndex = -1;
            txtSearch.Text = string.Empty;
            listSelectedStudents.SelectedIndex = -1;
        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Error = string.Empty;
            ErrorCount = 0;

            if (listSelectedStudents.SelectedIndex == -1)
            {
                ErrorCount += 1;
                Error += "Error: No student selected. Please try again.\n";
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

                string enrolmentSuccessful = string.Empty;
                Students addEnrolment = new Students(listSelectedStudents.SelectedItem.ToString(), ModuleCode, intake, "No", PaymentAmount);
                enrolmentSuccessful = addEnrolment.EnrolStudent(connectionString);

                if (enrolmentSuccessful == "true")
                {
                    foreach (string month in paymentMonth)
                    {
                        addEnrolment.addPayment(connectionString, month);
                    }
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            tempStudentID.Clear();
            listSelectedStudents.Items.Clear();

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT Student.StudentID, Student.Name, Enrolment.ModuleCode FROM Student INNER JOIN Enrolment ON Student.StudentID = Enrolment.StudentID", connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            datagridEnrolledStudents.DataSource = dataTable;
            datagridEnrolledStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            string listboxQuery = "SELECT DISTINCT Student.StudentID FROM Student INNER JOIN Enrolment ON Student.StudentID = Enrolment.StudentID WHERE Enrolment.Completion = 'No'";
            List<string> studentID = new List<string>();
            SqlCommand command = new SqlCommand(listboxQuery, connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string StudentID = reader.GetString(0);
                if (!studentID.Contains(StudentID))
                {
                    studentID.Add(StudentID);
                    tempStudentID.Add(StudentID);
                }
            }
            reader.Close();

            foreach (string item in studentID)
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

        private void Enrol_Load(object sender, EventArgs e)
        {
            btnRefresh.PerformClick();
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ClearAll();
            btnRefresh.PerformClick();
            this.Visible = false;
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

        private void Enrol_VisibleChanged(object sender, EventArgs e)
        {
            btnRefresh.PerformClick();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                btnRefresh.PerformClick();
            }
        }
    }
}
