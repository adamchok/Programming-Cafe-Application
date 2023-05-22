using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;
using System.Data;
using System.Security.Policy;

namespace APU_Programming_Cafe
{
    public class Database_Access
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\user\OneDrive - Asia Pacific University\IOOP APPLICATION\APU Programming Cafe\APU database.mdf"";Integrated Security=True";
        
        //REGISTER ENROLMENT FORM
        public void RegisterEnrolmentInsertStudentData(string StudentID, string Name, string Contact_Number, string Email, string Address, string ModuleCode, string EnrolmentMonth, string EnrolmentYear,  decimal PaymentAmount, string Completion)
        {
            
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string insertEntryIntoStudentTable = "INSERT INTO Student (StudentID, Name, ContactNumber, Email, Address) VALUES (@value1, @value2, @value3, @value4, @value5)";
            SqlCommand insertEntryStudentTableCommand = new SqlCommand(insertEntryIntoStudentTable, connection);
            insertEntryStudentTableCommand.Parameters.AddWithValue("@value1", StudentID);
            insertEntryStudentTableCommand.Parameters.AddWithValue("@value2", Name);
            insertEntryStudentTableCommand.Parameters.AddWithValue("@value3", Contact_Number);
            insertEntryStudentTableCommand.Parameters.AddWithValue("@value4", Email);
            insertEntryStudentTableCommand.Parameters.AddWithValue("@value5", Address);
            insertEntryStudentTableCommand.ExecuteNonQuery();
            
            string insertEntryIntoEnrolmentTable = "INSERT INTO Enrolment (StudentID, ModuleCode, EnrolmentMonth, EnrolmentYear, Completion) VALUES (@value6, @value7, @value8, @value9, @value10)";
            SqlCommand insertEntryIntoEnrolmentTableCommand = new SqlCommand(insertEntryIntoEnrolmentTable, connection);
            insertEntryIntoEnrolmentTableCommand.Parameters.AddWithValue("@value6", StudentID);
            insertEntryIntoEnrolmentTableCommand.Parameters.AddWithValue("@value7", ModuleCode);
            insertEntryIntoEnrolmentTableCommand.Parameters.AddWithValue("@value8", EnrolmentMonth);
            insertEntryIntoEnrolmentTableCommand.Parameters.AddWithValue("@value9", EnrolmentYear);
            insertEntryIntoEnrolmentTableCommand.Parameters.AddWithValue("@value10", Completion);
            insertEntryIntoEnrolmentTableCommand.ExecuteNonQuery();

            string insertEntryIntoPaymentTable = "INSERT INTO Payment (StudentID, ModuleCode, PaymentAmount) VALUES (@value11, @value12, @value13)";
            SqlCommand insertEntryIntoPaymentTableCommand = new SqlCommand(insertEntryIntoPaymentTable, connection);
            insertEntryIntoPaymentTableCommand.Parameters.AddWithValue("@value11", StudentID);
            insertEntryIntoPaymentTableCommand.Parameters.AddWithValue("@value12", ModuleCode);
            insertEntryIntoPaymentTableCommand.Parameters.AddWithValue("@value13", PaymentAmount);
            insertEntryIntoPaymentTableCommand.ExecuteNonQuery();
            connection.Close();
        }

        //UPDATE ENROLMENT FORM

        public void UpdateEnrolmentEntry(string StudentID, string UpdatedModule, string UpdatedEnrolmentMonth, string UpdatedEnrolmentYear, decimal UpdatedPaymentAmount)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string updateEntryInEnrolmentTable = "UPDATE Enrolment SET ModuleCode = @updatedModule, EnrolmentMonth = @updatedEnrolmentMonth, EnrolmentYear = @updatedEnrolmentYear, ClassCode = NULL WHERE StudentID = @student_ID AND Completion = 'No'";
            SqlCommand updateEntryInEnrolmentTableCommand = new SqlCommand(updateEntryInEnrolmentTable, connection);
            updateEntryInEnrolmentTableCommand.Parameters.AddWithValue("@updatedModule", UpdatedModule);
            updateEntryInEnrolmentTableCommand.Parameters.AddWithValue("@updatedEnrolmentMonth", UpdatedEnrolmentMonth);
            updateEntryInEnrolmentTableCommand.Parameters.AddWithValue("@updatedEnrolmentYear", UpdatedEnrolmentYear);
            updateEntryInEnrolmentTableCommand.Parameters.AddWithValue("@student_ID", StudentID);
            updateEntryInEnrolmentTableCommand.ExecuteNonQuery();

            string updateEntryInPaymentTable = "UPDATE Payment SET PaymentAmount = @updatedPaymentAmount, PaymentDate = NULL, InvoiceNumber = NULL WHERE StudentID = @student_ID";
            SqlCommand updateEntryInPaymentTableCommand = new SqlCommand(updateEntryInPaymentTable, connection);
            updateEntryInPaymentTableCommand.Parameters.AddWithValue("@updatedModule", UpdatedModule);
            updateEntryInPaymentTableCommand.Parameters.AddWithValue("@updatedPaymentAmount", UpdatedPaymentAmount);
            updateEntryInPaymentTableCommand.Parameters.AddWithValue("@student_ID", StudentID);
            updateEntryInPaymentTableCommand.ExecuteNonQuery();
            connection.Close();
        }

        public void RefreshInUpdateEnrolment(DataGridView datagridEnrolledStudents, ListBox listSelectedStudents, List<string> tempStudentID)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT Enrolment.StudentID, Student.Name, Enrolment.ModuleCode, Enrolment.EnrolmentMonth, Enrolment.EnrolmentYear FROM Enrolment INNER JOIN Student ON Enrolment.StudentID = Student.StudentID WHERE Completion = 'No'", connection);
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
        }

        // REQUEST ENROLMENT FORM

        public void RefreshInRequestedStudent(DataGridView datagridRequestedStudents, ListBox listSelectedStudents, List<string> tempStudentID)
        {
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
        }
       
        public void RequestedStudentInsertStudentData(string StudentID, string ModuleCode, string EnrolmentMonth, string EnrolmentYear, decimal PaymentAmount, string Completion)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string insertEntryIntoEnrolmentTable = "INSERT INTO Enrolment (StudentID, ModuleCode, EnrolmentMonth, EnrolmentYear, Completion) VALUES (@value1, @value2, @value3, @value4, @value8)";
            SqlCommand insertEntryIntoEnrolmentTableCommand = new SqlCommand(insertEntryIntoEnrolmentTable, connection);
            insertEntryIntoEnrolmentTableCommand.Parameters.AddWithValue("@value1", StudentID);
            insertEntryIntoEnrolmentTableCommand.Parameters.AddWithValue("@value2", ModuleCode);
            insertEntryIntoEnrolmentTableCommand.Parameters.AddWithValue("@value3", EnrolmentMonth);
            insertEntryIntoEnrolmentTableCommand.Parameters.AddWithValue("@value4", EnrolmentYear);
            insertEntryIntoEnrolmentTableCommand.Parameters.AddWithValue("@value8", Completion);
            insertEntryIntoEnrolmentTableCommand.ExecuteNonQuery();

            string insertEntryIntoPaymentTable = "INSERT INTO Payment (StudentID, ModuleCode, PaymentAmount) VALUES (@value5, @value6, @value7)";
            SqlCommand insertEntryIntoPaymentTableCommand = new SqlCommand(insertEntryIntoPaymentTable, connection);
            insertEntryIntoPaymentTableCommand.Parameters.AddWithValue("@value5", StudentID);
            insertEntryIntoPaymentTableCommand.Parameters.AddWithValue("@value6", ModuleCode);
            insertEntryIntoPaymentTableCommand.Parameters.AddWithValue("@value7", PaymentAmount);
            insertEntryIntoPaymentTableCommand.ExecuteNonQuery();
            connection.Close();
        }
        public void DeleteRequestedStudentAfterInsertingData(string StudentID, string ModuleCode)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string removeRequestedStudentEntryFromRequest = "DELETE FROM Request WHERE StudentID = @value1 AND ModuleCode = @value2;";
            SqlCommand removeRequestedStudentEntryFromRequestCommand = new SqlCommand(removeRequestedStudentEntryFromRequest, connection);
            removeRequestedStudentEntryFromRequestCommand.Parameters.AddWithValue("@value1", StudentID);
            removeRequestedStudentEntryFromRequestCommand.Parameters.AddWithValue("@value2", ModuleCode);
            removeRequestedStudentEntryFromRequestCommand.ExecuteNonQuery();
        }

        // REMOVE STUDENT FORM

        public void RefreshRemovableStudentDataGrid(DataGridView datagridRemovableStudents)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT Enrolment.StudentID, Student.Name, Enrolment.ModuleCode, Enrolment.EnrolmentMonth, Enrolment.EnrolmentYear FROM Enrolment INNER JOIN Student ON Enrolment.StudentID = Student.StudentID WHERE Completion = 'Yes'", connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            datagridRemovableStudents.DataSource = dataTable;
            datagridRemovableStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        
        public void FilteredRemovableStudentDataGrid(DataGridView datagridRemovableStudents, string ModuleCode, string EnrolmentMonth, string EnrolmentYear, string Level, string ModuleName)
        {
            string openTableWithNoSearchConditions = "SELECT Enrolment.StudentID, Student.Name, Enrolment.ModuleCode, Enrolment.EnrolmentMonth, Enrolment.EnrolmentYear FROM Enrolment INNER JOIN Student ON Enrolment.StudentID = Student.StudentID WHERE Completion = 'Yes'";
            List<string> SearchConditions = new List<string>();
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            
            if (!string.IsNullOrEmpty(ModuleCode))
            {
                SearchConditions.Add("ModuleCode = @value1");
                parameters["@value1"] = ModuleCode;
            }

            if (!string.IsNullOrEmpty(EnrolmentMonth))
            {
                SearchConditions.Add("EnrolmentMonth = @value2");
                parameters["@value2"] = EnrolmentMonth;
            }

            if (!string.IsNullOrEmpty(EnrolmentYear))
            {
                SearchConditions.Add("EnrolmentYear = @value3");
                parameters["@value3"] = EnrolmentYear;
            }

            if (!string.IsNullOrEmpty(Level))
            {
                SearchConditions.Add("ModuleCode LIKE '%' + @value4 + '%'");
                parameters["@value4"] = Level;
            }

            if (!string.IsNullOrEmpty(ModuleName))
            {
                SearchConditions.Add("ModuleCode LIKE '%' + @value5 + '%'");
                parameters["@value5"] = ModuleName;
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
            datagridRemovableStudents.DataSource = dataTable;
            datagridRemovableStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void SearchRemovableStudentDataGrid(DataGridView datagridRemovableStudents, string StudentID)
        {
            string baseQuery = "SELECT Enrolment.StudentID, Student.Name, Enrolment.ModuleCode, Enrolment.EnrolmentMonth, Enrolment.EnrolmentYear FROM Enrolment INNER JOIN Student ON Enrolment.StudentID = Student.StudentID WHERE Completion = 'Yes' AND Enrolment.StudentID LIKE '%' + @student_ID + '%'";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand cmd = new SqlCommand(baseQuery, connection);
            cmd.Parameters.AddWithValue("@student_ID", StudentID);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            datagridRemovableStudents.DataSource = dataTable;
            datagridRemovableStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void RemoveRemovableStudent(string StudentID, string ModuleCode)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string removeRequestedStudentEntryFromRequest = "DELETE FROM Enrolment WHERE StudentID = @value1 AND ModuleCode = @value2;";
            SqlCommand removeRequestedStudentEntryFromRequestCommand = new SqlCommand(removeRequestedStudentEntryFromRequest, connection);
            removeRequestedStudentEntryFromRequestCommand.Parameters.AddWithValue("@value1", StudentID);
            removeRequestedStudentEntryFromRequestCommand.Parameters.AddWithValue("@value2", ModuleCode);
            removeRequestedStudentEntryFromRequestCommand.ExecuteNonQuery();
        }

        // PROFILE

        public void AddProfileInformation()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
        }

        // LOGIN

        public string CheckLoginInformation(string Username, string Password)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string checkUserDetails = "SELECT UserRole FROM Login WHERE Username = @value1 AND Password = @value2";
            SqlCommand checkUserDetailsCommand = new SqlCommand(checkUserDetails, connection);
            checkUserDetailsCommand.Parameters.AddWithValue("@value1", Username);
            checkUserDetailsCommand.Parameters.AddWithValue("@value2", Password);
            try
            {
                object UserRole = checkUserDetailsCommand.ExecuteScalar();
                if (UserRole != null)
                {
                    return UserRole.ToString();
                }
                else
                {
                    return "False";
                }
            }
            catch
            {
                return "Error";
            }
        }



    }
}
