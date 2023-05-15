using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
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
        public Update_Enrolment()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ClearAll();
        }

        int ErrorCount = 0;
        string Error = "";
        List<string> tempStudentID = new List<string>();

        public class StudentUpdatedDetails
        {
            public string studentID {  get; set; }
            public string updatedModuleCode { get; set; }
            public string updatedYear { get; set; }
            public string updatedMonth { get; set; }
            public decimal updatedPaymentAmount { get; set; }
        }
        
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
            Database_Access updateDatagrid_and_listbox= new Database_Access();
            updateDatagrid_and_listbox.RefreshInUpdateEnrolment(datagridEnrolledStudents, listSelectedStudents, tempStudentID);
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
                decimal PaymentAmount = 0;
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

                string StudentID_and_UpdatedModule = listSelectedStudents.SelectedItem.ToString();
                string[] splittingStudentID_and_UpdatedModule = StudentID_and_UpdatedModule.Split(' ');
                StudentUpdatedDetails updatedInformation = new StudentUpdatedDetails();
                updatedInformation.studentID = splittingStudentID_and_UpdatedModule[0];
                string currentModuleCode = splittingStudentID_and_UpdatedModule[1];
                updatedInformation.updatedModuleCode = ModuleCode;
                updatedInformation.updatedPaymentAmount = PaymentAmount;
                updatedInformation.updatedMonth = cboUpdatedMonth.SelectedItem.ToString();
                updatedInformation.updatedYear = cboUpdatedYear.SelectedItem.ToString();

                Database_Access updateEntry = new Database_Access();
                try
                {
                    updateEntry.UpdateEnrolmentEntry(updatedInformation.studentID, updatedInformation.updatedModuleCode, updatedInformation.updatedMonth, updatedInformation.updatedYear, updatedInformation.updatedPaymentAmount);
                    MessageBox.Show("Update Successful.");
                    btnRefresh.PerformClick();
                    ClearAll();
                }
                catch /*(Exception ex)*/
                {
                    //MessageBox.Show(ex.ToString());
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
                MessageBox.Show("There are no student requests at the moment.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            tempStudentID.Clear();
            listSelectedStudents.Items.Clear();
            Database_Access updateDatagrid_and_listbox = new Database_Access();
            updateDatagrid_and_listbox.RefreshInUpdateEnrolment(datagridEnrolledStudents, listSelectedStudents, tempStudentID);
        }

        public string ErrorChecking()
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

                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\user\OneDrive - Asia Pacific University\IOOP APPLICATION\APU Programming Cafe\APU database.mdf"";Integrated Security=True;Connect Timeout=30";
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
    }
}
