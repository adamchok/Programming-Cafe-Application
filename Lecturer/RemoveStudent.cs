using System;
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

namespace APU_Programming_Cafe.Lecturer
{
    public partial class RemoveStudent : UserControl
    {
        public string connectionString;
        public RemoveStudent(string connString)
        {
            InitializeComponent();
            connectionString = connString;
        }

        private void ClearAll()
        {
            listSelectedStudents.Items.Clear();
            txtSearch.Text = string.Empty;
            cboLevelFilter.SelectedIndex = -1;
            cboModuleFilter.SelectedIndex = -1;
            cboYearFilter.SelectedIndex = -1;
            cboMonthFilter.SelectedIndex = -1;
        }

        List<string> tempStudentID = new List<string>();
        List<string> ToBeRemovedStudent = new List<string>();

        private void RemoveStudent_Load(object sender, EventArgs e)
        {
            btnRefresh.PerformClick();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
            btnRefresh.PerformClick();
        }

        private void datagridCompletedStudents_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = datagridCompletedStudents.Rows[e.RowIndex];
            
            string moduleCode = selectedRow.Cells["ModuleCode"].Value.ToString();
            string studentID = selectedRow.Cells["StudentID"].Value.ToString();

            if (!listSelectedStudents.Items.Contains(studentID + " " + moduleCode))
            {
                tempStudentID.Add(studentID + " " + moduleCode);
            }
            foreach (string selectedStudentInfo in tempStudentID)
            {
                listSelectedStudents.Items.Add(selectedStudentInfo);
            }
            tempStudentID.Clear();
        }

        private void listSelectedStudents_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            listSelectedStudents.Items.Remove(listSelectedStudents.SelectedItem);
        }

        private void btnFilterSearch_Click(object sender, EventArgs e)
        {
            bool intakeFilter = false;
            if (cboMonthFilter.SelectedIndex != -1 && cboYearFilter.SelectedIndex != -1)
            {
                intakeFilter = true;
            }

            string ModuleCode = "";
            string Level = "";
            string Month = "";
            string Year = "";
            string ModuleName = "";
            switch (cboLevelFilter.SelectedIndex)
            {
                case 0:
                    if (cboModuleFilter.SelectedIndex != -1)
                    {
                        ModuleCode = $"{cboModuleFilter.SelectedItem}01";
                    }
                    Level = "01";
                    break;
                case 1:
                    if (cboModuleFilter.SelectedIndex != -1)
                    {
                        ModuleCode = $"{cboModuleFilter.SelectedItem}02";
                    }
                    Level = "02";
                    break;
                case 2:
                    if (cboModuleFilter.SelectedIndex != -1)
                    {
                        ModuleCode = $"{cboModuleFilter.SelectedItem}03";
                    }
                    Level = "03";
                    break;
            }
           
            if (cboMonthFilter.SelectedIndex == 0)
            {
                Month = "01";
            }
            else if (cboMonthFilter.SelectedIndex == 1)
            {
                Month = "04";
            }
            else if (cboMonthFilter.SelectedIndex == 2)
            {
                Month = "07";
            }
            else if (cboMonthFilter.SelectedIndex == 3)
            {
                Month = "10";
            }

            if (cboYearFilter.SelectedIndex != -1)
            {
                Year = cboYearFilter.SelectedItem.ToString();
            }
            
            if (cboModuleFilter.SelectedIndex != -1)
            {
                ModuleName = cboModuleFilter.SelectedItem.ToString();
            }

            Students studentDetails = new Students();
            studentDetails.ModuleCode = ModuleCode;
            studentDetails.ModuleName = ModuleName;
            studentDetails.ModuleLevel = Level;
            studentDetails.Intake = $"{Month}{Year}";

            List<string> SearchConditions = new List<string>();
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            string openTableWithNoSearchConditions = "SELECT Enrolment.StudentID, Student.Name, Enrolment.ModuleCode, Enrolment.Intake FROM Enrolment INNER JOIN Student ON Enrolment.StudentID = Student.StudentID WHERE Completion = 'Yes'";

            if (!string.IsNullOrEmpty(ModuleCode))
            {
                SearchConditions.Add("ModuleCode = @value1");
                parameters["@value1"] = studentDetails.ModuleCode;
            }

            if (!string.IsNullOrEmpty(studentDetails.Intake) && intakeFilter == true)
            {
                SearchConditions.Add("Intake = @value2");
                parameters["@value2"] = studentDetails.Intake;
            }

            if (!string.IsNullOrEmpty(studentDetails.ModuleLevel))
            {
                SearchConditions.Add("ModuleCode LIKE '%' + @value3 + '%'");
                parameters["@value3"] = studentDetails.ModuleLevel;
            }

            if (!string.IsNullOrEmpty(studentDetails.ModuleName))
            {
                SearchConditions.Add("ModuleCode LIKE '%' + @value4 + '%'");
                parameters["@value4"] = studentDetails.ModuleName;
            }

            string queryWithSearchCondtions = openTableWithNoSearchConditions;
            if (SearchConditions.Count > 0)
            {
                foreach (string condition in SearchConditions)
                {
                    queryWithSearchCondtions += $" AND {condition}";
                }
            }

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand cmd = new SqlCommand(queryWithSearchCondtions, connection);

            foreach (var parameter in parameters)
            {
                cmd.Parameters.AddWithValue(parameter.Key, parameter.Value);
            }

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            datagridCompletedStudents.DataSource = dataTable;
            datagridCompletedStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            connection.Close();

            if (intakeFilter == false)
            {
                if (cboMonthFilter.SelectedIndex == -1 && cboYearFilter.SelectedIndex == -1)
                {
                    // do nothing
                }
                else
                {
                    MessageBox.Show("Error: Intake Month and Intake Year has to be selected together for filtering intakes.");
                }
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT Enrolment.StudentID, Student.Name, Enrolment.ModuleCode, Enrolment.Intake FROM Enrolment INNER JOIN Student ON Enrolment.StudentID = Student.StudentID WHERE Completion = 'Yes'", connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            datagridCompletedStudents.DataSource = dataTable;
            datagridCompletedStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            bool IDnotPresent = true;
            if (datagridCompletedStudents.RowCount > 0)
            {
                if (txtSearch.Text != string.Empty && txtSearch.Text.Contains("TP") && txtSearch.Text.Length <= 8)
                {
                    foreach (DataGridViewRow row in datagridCompletedStudents.Rows)
                    {
                        if (row.Cells[0].Value.ToString().Contains(txtSearch.Text))
                        {
                            string baseQuery = "SELECT Enrolment.StudentID, Student.Name, Enrolment.ModuleCode, Enrolment.Intake FROM Enrolment INNER JOIN Student ON Enrolment.StudentID = Student.StudentID WHERE Completion = 'Yes' AND Enrolment.StudentID LIKE '%' + @student_ID + '%'";
                            SqlConnection connection = new SqlConnection(connectionString);
                            connection.Open();
                            SqlCommand cmd = new SqlCommand(baseQuery, connection);
                            cmd.Parameters.AddWithValue("@student_ID", txtSearch.Text);
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            datagridCompletedStudents.DataSource = dataTable;
                            datagridCompletedStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                            connection.Close();

                            IDnotPresent = false;
                            break;
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
            if (txtSearch.Text == "")
            {
                btnRefresh.PerformClick();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            bool Error = false;

            foreach (string student in listSelectedStudents.Items)
            {
                ToBeRemovedStudent.Add(student);
            }
            foreach (string toBeRemovedStudent in ToBeRemovedStudent)
            {
                string[] splittingStudentID_and_CompletedModule = toBeRemovedStudent.Split(' ');

                Students removeStudent = new Students(splittingStudentID_and_CompletedModule[0], splittingStudentID_and_CompletedModule[1]);
                removeStudent.RemoveStudent(connectionString, out Error);
            }
            
            if (Error == true)
            {
                MessageBox.Show("Removal Unsuccessful");
                btnRefresh.PerformClick();
            }
            else
            {
                MessageBox.Show("Removal Successful");
                btnRefresh.PerformClick();
                btnClear.PerformClick();
            }
        }

        private void RemoveStudent_VisibleChanged(object sender, EventArgs e)
        {
            btnRefresh.PerformClick();
            btnClear.PerformClick();
        }


    }
}
