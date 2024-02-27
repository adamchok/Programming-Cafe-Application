using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APU_Programming_Cafe.Trainer
{
    public partial class StudentsListandFees : UserControl
    {
        string connectionString;
        string TrainerID;
        public StudentsListandFees(string connString, string trainerID)
        {
            connectionString = connString;
            TrainerID = trainerID;
            InitializeComponent();
        }

        List<string> tempStudentID = new List<string>();
        List<string> ToBeAssignedToClassStudents = new List<string>();

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cboIntake.Items.Clear();
            cboLevel.Items.Clear();
            cboModule.Items.Clear();
            cboClassCode.Items.Clear();
            listAddStudent.Items.Clear();

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string displayStudentsQuery = "SELECT DISTINCT Enrolment.StudentID, Student.Name, Enrolment.ModuleCode, Enrolment.Intake, Enrolment.ClassCode FROM Enrolment INNER JOIN Student ON Enrolment.StudentID = Student.StudentID INNER JOIN Payment ON Payment.StudentID = Enrolment.StudentID AND Payment.ModuleCode = Enrolment.ModuleCode WHERE Enrolment.TrainerID = @trainerID AND Enrolment.Completion = 'No' AND Payment.Validated = 'Yes';";
            SqlCommand displayStudents = new SqlCommand(displayStudentsQuery, connection);
            displayStudents.Parameters.AddWithValue("@trainerID", TrainerID);
            SqlDataAdapter adapter = new SqlDataAdapter(displayStudents);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            datagridStudentsList.DataSource = dataTable;
            datagridStudentsList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            string fetchIntakeQuery = "SELECT DISTINCT Intake FROM Enrolment WHERE TrainerID = @trainerID;";
            SqlCommand fetchIntake = new SqlCommand(fetchIntakeQuery, connection);
            fetchIntake.Parameters.AddWithValue("@trainerID", TrainerID);
            SqlDataReader readIntake = fetchIntake.ExecuteReader();
            while (readIntake.Read())
            {
                string intake = readIntake.GetString(0);
                if (!cboIntake.Items.Contains(intake))
                {
                    cboIntake.Items.Add(intake);
                }
            }
            readIntake.Close();

            string fetchModuleName_LevelQuery = "SELECT DISTINCT Module.ModuleName, Module.Level FROM Module INNER JOIN Trainer_Module ON Module.ModuleCode = Trainer_Module.ModuleCode WHERE Trainer_Module.TrainerID = @trainerID;";
            SqlCommand fetchModuleName_Level = new SqlCommand(fetchModuleName_LevelQuery, connection);
            fetchModuleName_Level.Parameters.AddWithValue("@trainerID", TrainerID);
            SqlDataReader readModuleName_Level = fetchModuleName_Level.ExecuteReader();
            while (readModuleName_Level.Read())
            {
                string moduleName = readModuleName_Level.GetString(0);
                string level = readModuleName_Level.GetString(1);
                if (!cboModule.Items.Contains(moduleName))
                {
                    cboModule.Items.Add(moduleName);
                }
                if (!cboLevel.Items.Contains(level))
                {
                    cboLevel.Items.Add(level);
                }
            }
            readModuleName_Level.Close();

            string fetchClassCodeQuery = "SELECT DISTINCT ClassCode FROM Class WHERE TrainerID = @trainerID;";
            SqlCommand fetchClassCode = new SqlCommand(fetchClassCodeQuery, connection);
            fetchClassCode.Parameters.AddWithValue("@trainerID", TrainerID);
            SqlDataReader readClassCode = fetchClassCode.ExecuteReader();
            while (readClassCode.Read())
            {
                string classCode = readClassCode.GetString(0);
                if (!cboClassCode.Items.Contains(classCode))
                {
                    cboClassCode.Items.Add(classCode);
                }
            }
            readClassCode.Close();


            string fetchModuleCodeQuery = "SELECT DISTINCT ModuleCode FROM Trainer_Module WHERE TrainerID = @trainerID;";
            SqlCommand fetchModuleCode = new SqlCommand(fetchModuleCodeQuery, connection);
            fetchModuleCode.Parameters.AddWithValue("@trainerID", TrainerID);
            SqlDataReader readModuleCode = fetchModuleCode.ExecuteReader();
            while (readModuleCode.Read())
            {
                string moduleCode = readModuleCode.GetString(0);
                if (!cboAssignModuleCode.Items.Contains(moduleCode))
                {
                    cboAssignModuleCode.Items.Add(moduleCode);
                }
            }
            readModuleCode.Close();

            connection.Close();

        }

        private void StudentsListandFees_Load(object sender, EventArgs e)
        {
            btnRefresh.PerformClick();
        }

        private void datagridStudentsList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = datagridStudentsList.Rows[e.RowIndex];

            string moduleCode = selectedRow.Cells["ModuleCode"].Value.ToString();
            string studentID = selectedRow.Cells["StudentID"].Value.ToString();
            string intake = selectedRow.Cells["Intake"].Value.ToString();

            if (!listAddStudent.Items.Contains(studentID + "-" + moduleCode + "-" + intake))
            {
                tempStudentID.Add(studentID + "-" + moduleCode + "-" + intake);
            }
            foreach (string selectedStudentInfo in tempStudentID)
            {
                listAddStudent.Items.Add(selectedStudentInfo);
            }
            tempStudentID.Clear();
        }

        private void listAddStudent_DoubleClick(object sender, EventArgs e)
        {
            listAddStudent.Items.Remove(listAddStudent.SelectedItem);
        }

        private void btnApplyFilter_Click(object sender, EventArgs e)
        {
            string ModuleCode = "";
            string Level = "";
            string Intake = "";
            string ModuleName = "";
            string ClassCode = "";
            
            if (cboLevel.SelectedIndex != -1)
            {
                if (cboLevel.SelectedItem.ToString().Contains("Beginner"))
                {
                    if (cboModule.SelectedIndex != -1)
                    {
                        ModuleCode = $"{cboModule.SelectedItem}01";
                    }
                    Level = "01";
                }
                else if (cboLevel.SelectedItem.ToString().Contains("Intermediate"))
                {
                    if (cboModule.SelectedIndex != -1)
                    {
                        ModuleCode = $"{cboModule.SelectedItem}02";
                    }
                    Level = "02";
                }
                else
                {
                    if (cboModule.SelectedIndex != -1)
                    {
                        ModuleCode = $"{cboModule.SelectedItem}03";
                    }
                    Level = "03";
                }
            }
           
            if (cboIntake.SelectedIndex != -1)
            {
                Intake = cboIntake.SelectedItem.ToString();
            }
            
            if (cboModule.SelectedIndex != -1)
            {
                ModuleName = cboModule.SelectedItem.ToString();
            }

            if (cboClassCode.SelectedIndex != -1)
            {
                ClassCode = cboClassCode.SelectedItem.ToString();
            }

            Students studentDetails = new Students();
            studentDetails.ModuleCode = ModuleCode;
            studentDetails.ModuleName = ModuleName;
            studentDetails.ModuleLevel = Level;
            studentDetails.Intake = Intake;
            studentDetails.ClassCode = ClassCode;

            List<string> SearchConditions = new List<string>();
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            string openTableWithNoSearchConditions = "SELECT DISTINCT Enrolment.StudentID, Student.Name, Enrolment.ModuleCode, Enrolment.Intake, Enrolment.ClassCode FROM Enrolment INNER JOIN Student ON Enrolment.StudentID = Student.StudentID INNER JOIN Payment ON Payment.StudentID = Enrolment.StudentID AND Payment.ModuleCode = Enrolment.ModuleCode WHERE Enrolment.TrainerID = @trainerID AND Enrolment.Completion = 'No' AND Payment.Validated = 'Yes'";

            if (!string.IsNullOrEmpty(studentDetails.ModuleCode))
            {
                SearchConditions.Add("Enrolment.ModuleCode = @value1");
                parameters["@value1"] = studentDetails.ModuleCode;
            }

            if (!string.IsNullOrEmpty(studentDetails.Intake))
            {
                SearchConditions.Add("Enrolment.Intake = @value2");
                parameters["@value2"] = studentDetails.Intake;
            }

            if (!string.IsNullOrEmpty(studentDetails.ModuleLevel))
            {
                SearchConditions.Add("Enrolment.ModuleCode LIKE '%' + @value3 + '%'");
                parameters["@value3"] = studentDetails.ModuleLevel;
            }

            if (!string.IsNullOrEmpty(studentDetails.ModuleName))
            {
                SearchConditions.Add("Enrolment.ModuleCode LIKE '%' + @value4 + '%'");
                parameters["@value4"] = studentDetails.ModuleName;
            }

            if (!string.IsNullOrEmpty(studentDetails.ClassCode))
            {
                SearchConditions.Add("Enrolment.ClassCode = @value5");
                parameters["@value5"] = studentDetails.ClassCode;
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
            cmd.Parameters.AddWithValue("@trainerID", TrainerID);

            foreach (var parameter in parameters)
            {
                cmd.Parameters.AddWithValue(parameter.Key, parameter.Value);
            }

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            datagridStudentsList.DataSource = dataTable;
            datagridStudentsList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            connection.Close();

            grpboxAssign.Visible = true;
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            string Error = string.Empty;
            int ErrorCount = 0;
            bool ErrorBool = true;
            if (cboAssignClass.SelectedIndex != -1 && listAddStudent.Items.Count > 0)
            {
                ErrorBool = true;
                ErrorCount = 0;

                foreach (string student in listAddStudent.Items)
                {
                    ToBeAssignedToClassStudents.Add(student);
                }
                foreach (string toBeAssignedStudent in ToBeAssignedToClassStudents)
                {
                    Error = "";
                    string[] splittingStudentID_and_ModuleCode_Intake = toBeAssignedStudent.Split('-');

                    SqlConnection connection = new SqlConnection(connectionString);
                    connection.Open();

                    string searchAssignedClassQuery = "SELECT DISTINCT ClassCode FROM Enrolment WHERE StudentID = @studentID";
                    SqlCommand searchAssignedClass = new SqlCommand(searchAssignedClassQuery, connection);
                    searchAssignedClass.Parameters.AddWithValue("@studentID", splittingStudentID_and_ModuleCode_Intake[0]);
                    SqlDataReader reader = searchAssignedClass.ExecuteReader();
                    while (reader.Read())
                    {
                        if (!reader.IsDBNull(0))
                        {
                            string classCode = reader.GetString(0);
                            if (cboAssignClass.SelectedItem.ToString() == classCode)
                            {
                                ErrorCount++;
                                Error += $"Error: {splittingStudentID_and_ModuleCode_Intake[0]} was already assigned to class.";
                            }
                        }
                    }
                    reader.Close();
                    connection.Close();

                    if (splittingStudentID_and_ModuleCode_Intake[1] != cboAssignModuleCode.Text)
                    {
                        ErrorCount++;
                        Error += $"Error: Class module does not match {splittingStudentID_and_ModuleCode_Intake[0]}'s enroled module.\n";
                    }
                }
                if (ErrorCount > 0)
                {
                    MessageBox.Show(Error);
                }
                else
                {
                    foreach (string student in listAddStudent.Items)
                    {
                        ToBeAssignedToClassStudents.Add(student);
                    }
                    foreach (string toBeAssignedStudent in ToBeAssignedToClassStudents)
                    {
                        string[] splittingStudentID_and_ModuleCode_Intake = toBeAssignedStudent.Split('-');

                        Students assignStudent = new Students();
                        assignStudent.ClassCode = cboAssignClass.SelectedItem.ToString();
                        assignStudent.StudentID = splittingStudentID_and_ModuleCode_Intake[0];
                        assignStudent.ModuleCode = splittingStudentID_and_ModuleCode_Intake[1];
                        assignStudent.Intake = splittingStudentID_and_ModuleCode_Intake[2];

                        ErrorBool = assignStudent.assignClass(connectionString);
                        if (ErrorBool == false)
                        {
                            break;
                        }
                    }
                    if (ErrorBool == false)
                    {
                        MessageBox.Show("Error: Unable to assign student(s) to class. Please try again.");
                        btnRefresh.PerformClick();
                        listAddStudent.Items.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Assign Successful");
                        btnRefresh.PerformClick();
                        btnClearAll.PerformClick();
                    }
                }
            }
            else
            {
                MessageBox.Show("Error: Class code not selected and/or student(s) selected. Please go through the process in 'Assign:' and/or select student(s).");
                btnRefresh.PerformClick();
            }
        }

        private void cboAssignModuleCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboAssignModuleCode.SelectedIndex != -1)
            {
                cboAssignClass.SelectedIndex = -1;
                cboAssignClass.Items.Clear();
                cboAssignIntake.SelectedIndex = -1;
                cboAssignIntake.Items.Clear();
                cboAssignIntake.Enabled = true;
                insertIntake(cboAssignModuleCode.SelectedItem.ToString());
            }
            else
            {
                cboAssignIntake.Enabled = false;
            }
        }

        private void insertIntake(string modulecode)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string fetchIntakeQuery = "SELECT DISTINCT Intake FROM Enrolment WHERE TrainerID = @trainerID AND ModuleCode = @moduleCode;";
            SqlCommand fetchIntake = new SqlCommand(fetchIntakeQuery, connection);
            fetchIntake.Parameters.AddWithValue("@trainerID", TrainerID);
            fetchIntake.Parameters.AddWithValue("@moduleCode", modulecode);

            SqlDataReader readIntake = fetchIntake.ExecuteReader();
            while (readIntake.Read())
            {
                string intake = readIntake.GetString(0);
                if (!cboAssignIntake.Items.Contains(intake))
                {
                    cboAssignIntake.Items.Add(intake);
                }
            }
            readIntake.Close();
        }

        private void cboAssignIntake_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboAssignIntake.SelectedIndex != -1)
            {
                cboAssignClass.Enabled = true;
                string INTAKE = cboAssignIntake.Text;
                string MODULECODE = cboAssignModuleCode.Text;

                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                string fetchClassCodeQuery = "SELECT ClassCode FROM Class WHERE TrainerID = @trainerID AND ModuleCode = @moduleCode AND Intake = @intake";
                SqlCommand fetchClassCode = new SqlCommand(fetchClassCodeQuery, connection);
                fetchClassCode.Parameters.AddWithValue("@trainerID", TrainerID);
                fetchClassCode.Parameters.AddWithValue("@moduleCode", MODULECODE);
                fetchClassCode.Parameters.AddWithValue("@intake", INTAKE);

                SqlDataReader readClassCode = fetchClassCode.ExecuteReader();
                while (readClassCode.Read())
                {
                    string intake = readClassCode.GetString(0);
                    if (!cboAssignClass.Items.Contains(intake))
                    {
                        cboAssignClass.Items.Add(intake);
                    }
                }
                readClassCode.Close();
            }
            else
            {
                cboAssignClass.Enabled=false;
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            cboAssignIntake.SelectedIndex = -1;
            cboAssignIntake.Items.Clear();
            cboAssignClass.SelectedIndex = -1;
            cboAssignClass.Items.Clear();
            cboAssignModuleCode.SelectedIndex = -1;
            btnRefresh.PerformClick();
        }

        private void StudentsListandFees_VisibleChanged(object sender, EventArgs e)
        {
            btnClearAll.PerformClick();
            btnRefresh.PerformClick();
        }
    }
}
