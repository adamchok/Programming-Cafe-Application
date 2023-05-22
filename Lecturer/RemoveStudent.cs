using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APU_Programming_Cafe.Lecturer
{
    public partial class RemoveStudent : UserControl
    {
        public RemoveStudent()
        {
            InitializeComponent();
        }

        public void ClearAll()
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

        Database_Access remove_student_database = new Database_Access();    
        private void RemoveStudent_Load(object sender, EventArgs e)
        {
            remove_student_database.RefreshRemovableStudentDataGrid(datagridCompletedStudents);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
            remove_student_database.RefreshRemovableStudentDataGrid(datagridCompletedStudents);
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
           
            if (cboMonthFilter.SelectedIndex != -1)
            {
                Month = cboMonthFilter.SelectedItem.ToString();
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
            studentDetails.Module = ModuleName;
            studentDetails.Level = Level;
            studentDetails.EnrolmentMonth = Month;
            studentDetails.EnrolmentYear = Year;

            remove_student_database.FilteredRemovableStudentDataGrid(datagridCompletedStudents, studentDetails.ModuleCode, studentDetails.EnrolmentMonth, studentDetails.EnrolmentYear, studentDetails.Level, studentDetails.Module);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            remove_student_database.RefreshRemovableStudentDataGrid(datagridCompletedStudents);
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
                            remove_student_database.SearchRemovableStudentDataGrid(datagridCompletedStudents, txtSearch.Text);
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
            Students ToBeRemovedstudentDetails = new Students();
            foreach (string student in listSelectedStudents.Items)
            {
                ToBeRemovedStudent.Add(student);
            }
            foreach (string toBeRemovedStudent in ToBeRemovedStudent)
            {
                string[] splittingStudentID_and_CompletedModule = toBeRemovedStudent.Split(' ');
                ToBeRemovedstudentDetails.StudentID = splittingStudentID_and_CompletedModule[0];
                ToBeRemovedstudentDetails.ModuleCode = splittingStudentID_and_CompletedModule[1];
                try
                {
                    remove_student_database.RemoveRemovableStudent(ToBeRemovedstudentDetails.StudentID, ToBeRemovedstudentDetails.ModuleCode);
                    
                    btnClear.PerformClick();
                    btnRefresh.PerformClick();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    Error = true;
                    break;
                }
            }
            
            if (Error == true)
            {
                MessageBox.Show("Removal Successful");
                btnClear.PerformClick();
                btnRefresh.PerformClick();
            }
            else
            {
                MessageBox.Show("Removal Unsuccessful");
                btnRefresh.PerformClick();
            }
        }
    }
}
