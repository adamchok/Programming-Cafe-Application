using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
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
        public Enrolment_Request()
        {
            InitializeComponent();
        }

        public void ClearAll()
        {
            cboEnrolmentMonth.SelectedIndex = -1;
            cboEnrolmentYear.SelectedIndex = -1;
            listSelectedStudents.SelectedIndex = -1;
            txtSearch.Text = string.Empty;
        }


        List<string> tempStudentID = new List<string>();

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
                Students requestedStudentDetails = new Students();
                requestedStudentDetails.EnrolmentMonth = cboEnrolmentMonth.SelectedItem.ToString();
                requestedStudentDetails.EnrolmentYear = cboEnrolmentYear.SelectedItem.ToString();
                requestedStudentDetails.StudentID = splittingStudentID_and_RequestedModule[0];
                requestedStudentDetails.ModuleCode = splittingStudentID_and_RequestedModule[1];
                requestedStudentDetails.Completion = "No";

                if (requestedStudentDetails.ModuleCode.Contains("01"))
                {
                    requestedStudentDetails.PaymentAmount = 200M;
                }
                else if (requestedStudentDetails.ModuleCode.Contains("02"))
                {
                    requestedStudentDetails.PaymentAmount = 400M;
                }
                else if (requestedStudentDetails.ModuleCode.Contains("03"))
                {
                    requestedStudentDetails.PaymentAmount = 600M;
                }

                try
                {
                    Database_Access insertRequestedStudent = new Database_Access();
                    insertRequestedStudent.RequestedStudentInsertStudentData(requestedStudentDetails.StudentID, requestedStudentDetails.ModuleCode, requestedStudentDetails.EnrolmentMonth, requestedStudentDetails.EnrolmentYear, requestedStudentDetails.PaymentAmount, requestedStudentDetails.Completion);

                    Database_Access deleteRequestedStudent = new Database_Access();
                    deleteRequestedStudent.DeleteRequestedStudentAfterInsertingData(requestedStudentDetails.StudentID, requestedStudentDetails.ModuleCode);

                    MessageBox.Show("Enrolment Successful.");
                    btnRefresh.PerformClick();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    /*
                    if (ex.ToString().Contains("duplicate key"))
                    {
                        MessageBox.Show("Student is already enrolled in their requested program.");
                    }
                    else
                    {
                        //MessageBox.Show("Enrolment Unsuccessful. Please try again.");
                        MessageBox.Show(ex.ToString());
                    }
                    */

                }
            }
        }
        private void Enrolment_Request_Load(object sender, EventArgs e)
        {
            Database_Access insertDataIntoDatagrid_and_listbox = new Database_Access();
            insertDataIntoDatagrid_and_listbox.RefreshInRequestedStudent(datagridRequestedStudents, listSelectedStudents, tempStudentID);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            listSelectedStudents.Items.Clear();
            tempStudentID.Clear();
            Database_Access refreshDatagrid_and_listbox = new Database_Access();
            refreshDatagrid_and_listbox.RefreshInRequestedStudent(datagridRequestedStudents, listSelectedStudents, tempStudentID);
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
            string StudentID_and_RequestedModule = listSelectedStudents.SelectedItem.ToString();
            string[] splittingStudentID_and_RequestedModule = StudentID_and_RequestedModule.Split(' ');
            Students rejectedStudentDetails = new Students();
            rejectedStudentDetails.StudentID = splittingStudentID_and_RequestedModule[0];
            rejectedStudentDetails.ModuleCode = splittingStudentID_and_RequestedModule[1];

            Database_Access deleteRequestedStudent = new Database_Access();
            deleteRequestedStudent.DeleteRequestedStudentAfterInsertingData(rejectedStudentDetails.StudentID, rejectedStudentDetails.ModuleCode);
            btnRefresh.PerformClick();
        }
    }
}