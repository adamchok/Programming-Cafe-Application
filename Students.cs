using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace APU_Programming_Cafe
{
    public class Students
    {
        private string _StudentID;
        private string _Name;
        private string _ContactNumber;
        private string _Address;
        private string _Email;
        private string _ModuleCode;
        private string _ModuleLevel;
        private string _ModuleName;
        private string _Intake;
        private string _PaymentMonth;
        private decimal _PaymentAmount;
        private string _Completion;
        private string _ClassCode;
        private string _UpdatedModuleCode;
        private string _TrainerID;
        private string _InvoiceNumber;
        private string _PaymentDate;

        public string StudentID
        {
            get { return _StudentID; }
            set { _StudentID = value; }
        }
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public string ContactNumber
        {
            get { return _ContactNumber; }
            set { _ContactNumber = value; }
        }
        public string Address
        {
            get { return _Address; }
            set { _Address = value; }
        }
        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }
        public string ModuleCode
        {
            get { return _ModuleCode; }
            set { _ModuleCode = value; }
        }
        public string ModuleLevel
        {
            get { return _ModuleLevel; }
            set { _ModuleLevel = value; }
        }
        public string ModuleName
        {
            get { return _ModuleName; }
            set { _ModuleName = value; }
        }
        public string Intake
        {
            get { return _Intake; }
            set { _Intake = value; }
        }
        public decimal PaymentAmount
        {
            get { return _PaymentAmount; }
            set { _PaymentAmount = value; }
        }
        public string Completion
        {
            get { return _Completion; }
            set{ _Completion = value; }
        }
        public string ClassCode
        {
            get { return _ClassCode; }
            set { _ClassCode = value; }
        }
        public string UpdatedModuleCode
        {
            get { return _UpdatedModuleCode; }
            set { _UpdatedModuleCode =  value; }
        }
        public string PaymentMonth
        {
            get { return _PaymentMonth; }
            set { _PaymentMonth = value; }
        }

        public string TrainerID
        {
            get { return _TrainerID; }
            set { _TrainerID = value; }
        }
        public string InvoiceNumber
        {
            get { return _InvoiceNumber; }
            set { _InvoiceNumber = value; }
        }
        
        public string PaymentDate
        {
            get { return _PaymentDate; }
            set { _PaymentDate = value; }
        }

        //Default constructor for multiple use cases
        public Students()
        {

        }

        // Constructor for register student
        public Students(string studentID, string name, string contactNumber, string email, string address)
        {
            StudentID = studentID;
            Name = name;
            ContactNumber = contactNumber;
            Email = email;
            Address = address;
        }

        //Constructor for enrol student
        public Students(string studentID, string moduleCode, string intake, string completion, decimal paymentAmount)
        {
            StudentID = studentID;
            ModuleCode = moduleCode;
            Intake = intake;
            Completion = completion;
            PaymentAmount = paymentAmount;
        }

        //Constructor for update student enrolemt details
        public Students(string studentID, string moduleCode, decimal paymentAmount, string intake, string updatedModuleCode)
        {
            StudentID = studentID;
            ModuleCode = moduleCode;
            PaymentAmount = paymentAmount;
            Intake = intake;
            UpdatedModuleCode = updatedModuleCode;

        }

        //Constructor for remove student
        public Students(string studentID, string moduleCode)
        {
            StudentID = studentID;
            ModuleCode = moduleCode;
        }

        //Constructor for assigning a student to trainer and approving student payment
        public Students(string studentID, string moduleCode, string trainerID, string invoiceNumber)
        {
            StudentID = studentID;
            ModuleCode = moduleCode;
            TrainerID = trainerID;
            InvoiceNumber = invoiceNumber;
        }

        //Constructor for rejecting payment
        public Students(string studentID, string moduleCode, string invoiceNumber)
        {
            StudentID = studentID;
            ModuleCode = moduleCode;
            InvoiceNumber = invoiceNumber;
        }

        //Constructor for display student profile
        public Students(string studentID)
        {
            StudentID = studentID;
        }

        //Method for registering new student
        public string RegisterStudent(string connectionString)
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                string registerStudent = "INSERT INTO Student (StudentID, Name, ContactNumber, Email, Address) VALUES (@studentID, @name, @contactNumber, @email, @address)";
                SqlCommand registerCommand = new SqlCommand(registerStudent, connection);
                registerCommand.Parameters.AddWithValue("@studentID", _StudentID);
                registerCommand.Parameters.AddWithValue("@name", _Name);
                registerCommand.Parameters.AddWithValue("@contactNumber", _ContactNumber);
                registerCommand.Parameters.AddWithValue("@email", _Email);
                registerCommand.Parameters.AddWithValue("@address", _Address);
                registerCommand.ExecuteNonQuery();
                
                connection.Close();
                return "true";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        //Method for enroling student into a module code
        public string EnrolStudent(string connectionString)
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                string enrolStudent = "INSERT INTO Enrolment (StudentID, ModuleCode, Intake, Completion) VALUES (@studentID, @moduleCode, @intake, @completion)";
                SqlCommand enrolCommand = new SqlCommand(enrolStudent, connection);
                enrolCommand.Parameters.AddWithValue("@studentID", _StudentID);
                enrolCommand.Parameters.AddWithValue("@moduleCode", _ModuleCode);
                enrolCommand.Parameters.AddWithValue("@intake", _Intake);
                enrolCommand.Parameters.AddWithValue("@completion", _Completion);
                enrolCommand.ExecuteNonQuery();
                connection.Close();
                return "true";
            }
            catch (Exception ex)
            {
                return ex.ToString();
                
            }
        }

        //Method for adding payment information when student enrols into a module 
        public void addPayment(string connectionString, string month)
        {
            PaymentMonth = month;
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string addPayment = "INSERT INTO Payment (StudentID, ModuleCode, Intake, PaymentMonth, PaymentAmount, Validated) VALUES (@studentID, @moduleCode, @intake, @paymentMonth, @paymentAmount, 'No')";
            SqlCommand addPaymentCommand = new SqlCommand(addPayment, connection);
            addPaymentCommand.Parameters.AddWithValue("@studentID", _StudentID);
            addPaymentCommand.Parameters.AddWithValue("@moduleCode", _ModuleCode);
            addPaymentCommand.Parameters.AddWithValue("@intake", _Intake);
            addPaymentCommand.Parameters.AddWithValue("@paymentMonth", _PaymentMonth);
            addPaymentCommand.Parameters.AddWithValue("@paymentAmount", _PaymentAmount);
            addPaymentCommand.ExecuteNonQuery();

            connection.Close();
        }

        //Method for deleting student request after rejecting it by lecturer
        public string DeleteRequest(string connectionString)
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                string removeRequestedStudentEntryFromRequest = "DELETE FROM Request WHERE StudentID = @studentID AND ModuleCode = @moduleCode";
                SqlCommand removeRequestedStudentEntryFromRequestCommand = new SqlCommand(removeRequestedStudentEntryFromRequest, connection);
                removeRequestedStudentEntryFromRequestCommand.Parameters.AddWithValue("@studentID", _StudentID);
                removeRequestedStudentEntryFromRequestCommand.Parameters.AddWithValue("@moduleCode", _ModuleCode);
                removeRequestedStudentEntryFromRequestCommand.ExecuteNonQuery();
                connection.Close();
                return "true";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        //Metgod for updating student enrolment details
        public bool UpdateEnrolment(string connectionString)
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                string updateEnrolment = "UPDATE Enrolment SET ModuleCode = @updatedModule, Intake = @updatedIntake, ClassCode = NULL, TrainerID = NULL WHERE StudentID = @student_ID AND Completion = 'No' AND ModuleCode = @currentModuleCode";
                SqlCommand updateEnrolmentCommand = new SqlCommand(updateEnrolment, connection);
                updateEnrolmentCommand.Parameters.AddWithValue("@updatedModule", _UpdatedModuleCode);
                updateEnrolmentCommand.Parameters.AddWithValue("@updatedIntake", _Intake);
                updateEnrolmentCommand.Parameters.AddWithValue("@student_ID", _StudentID);
                updateEnrolmentCommand.Parameters.AddWithValue("@currentModuleCode", _ModuleCode);
                updateEnrolmentCommand.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }

        //Method for updating student payment informtion when their enrolment details is updated
        public bool UpdatePayment(string connectionString, List<string> paymentMonth)
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                string fetchCurrentIntakeQuery = "SELECT DISTINCT Intake FROM Payment WHERE StudentID = @studentID AND ModuleCode = @moduleCode";
                SqlCommand fetchIntake = new SqlCommand(fetchCurrentIntakeQuery, connection);
                fetchIntake.Parameters.AddWithValue("@studentID", _StudentID);
                fetchIntake.Parameters.AddWithValue("@moduleCode", _UpdatedModuleCode);
                string currentIntake = "";
                SqlDataReader IntakeReader = fetchIntake.ExecuteReader();
                while (IntakeReader.Read())
                {
                    currentIntake = IntakeReader.GetString(0);
                }
                IntakeReader.Close();
                MessageBox.Show(currentIntake);

                try
                {
                    string updatePayment = "DELETE FROM Payment WHERE StudentID = @student_ID AND ModuleCode = @updatedModuleCode AND Intake = @currentIntake";
                    SqlCommand updatePaymentCommand = new SqlCommand(updatePayment, connection);
                    updatePaymentCommand.Parameters.AddWithValue("@currentIntake", currentIntake);
                    updatePaymentCommand.Parameters.AddWithValue("@student_ID", _StudentID);
                    updatePaymentCommand.Parameters.AddWithValue("@updatedModuleCode", _UpdatedModuleCode);
                    updatePaymentCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                foreach (string month in paymentMonth)
                {
                    PaymentMonth = month;
                    string addPayment = "INSERT INTO Payment (StudentID, ModuleCode, Intake, PaymentMonth, PaymentAmount, Validated) VALUES (@studentID, @moduleCode, @intake, @paymentMonth, @paymentAmount, 'No')";
                    SqlCommand addPaymentCommand = new SqlCommand(addPayment, connection);
                    addPaymentCommand.Parameters.AddWithValue("@studentID", _StudentID);
                    addPaymentCommand.Parameters.AddWithValue("@moduleCode", _UpdatedModuleCode);
                    addPaymentCommand.Parameters.AddWithValue("@intake", _Intake);
                    addPaymentCommand.Parameters.AddWithValue("@paymentMonth", _PaymentMonth);
                    addPaymentCommand.Parameters.AddWithValue("@paymentAmount", _PaymentAmount);
                    addPaymentCommand.ExecuteNonQuery();
                }
                connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }

        //Method for removing student who has completed their enrolled course
        public void RemoveStudent(string connectionString, out bool Error)
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                string removeRequestedStudentEntryFromRequest = "DELETE FROM Enrolment WHERE StudentID = @studentID AND ModuleCode = @moduleCode;";
                SqlCommand removeRequestedStudentEntryFromRequestCommand = new SqlCommand(removeRequestedStudentEntryFromRequest, connection);
                removeRequestedStudentEntryFromRequestCommand.Parameters.AddWithValue("@studentID", _StudentID);
                removeRequestedStudentEntryFromRequestCommand.Parameters.AddWithValue("@moduleCode", _ModuleCode);
                removeRequestedStudentEntryFromRequestCommand.ExecuteNonQuery();
                Error = false;
            }
            catch
            {
                MessageBox.Show("Error: Unable to remove a particular student");
                Error = true;
            }
        }

        //Method for approving student's payment by admin
        public bool validatePayment(string connectionString)
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                string validatePaymentQuery = "UPDATE Payment SET Validated = 'Yes' WHERE StudentID = @studentID AND ModuleCode = @moduleCode AND InvoiceNumber = @invoiceNumber";
                SqlCommand validatePayment = new SqlCommand(validatePaymentQuery, connection);
                validatePayment.Parameters.AddWithValue("@studentID", _StudentID);
                validatePayment.Parameters.AddWithValue("@moduleCode", _ModuleCode);
                validatePayment.Parameters.AddWithValue("@invoiceNumber", _InvoiceNumber);
                validatePayment.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //Method for assigning a trainer to a student after approving the student's payment
        public bool assignTrainer(string connectionString)
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                string updateTrainerIDQuery = "UPDATE Enrolment SET TrainerID = @trainerID WHERE StudentID = @studentID AND ModuleCode = @moduleCode AND Intake = @intake";
                SqlCommand updateTrainerID = new SqlCommand(updateTrainerIDQuery, connection);
                updateTrainerID.Parameters.AddWithValue("@trainerID", _TrainerID);
                updateTrainerID.Parameters.AddWithValue("@studentID", _StudentID);
                updateTrainerID.Parameters.AddWithValue("@moduleCode", _ModuleCode);
                updateTrainerID.Parameters.AddWithValue("@intake", _Intake);
                updateTrainerID.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //Method for rejecting student payment by admin
        public string rejectPayment(string connectionString)
        {
            bool Error = false;
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                string rejectPaymentQuery = "UPDATE Payment SET PaymentDate = NULL, InvoiceNumber = NULL, Validated = 'No' WHERE StudentID = @studentID AND ModuleCode = @moduleCode AND InvoiceNumber = @invoiceNumber";
                SqlCommand rejectPayment = new SqlCommand(rejectPaymentQuery, connection);
                rejectPayment.Parameters.AddWithValue("@studentID", _StudentID);
                rejectPayment.Parameters.AddWithValue("@moduleCode", _ModuleCode);
                rejectPayment.Parameters.AddWithValue("@invoiceNumber", _InvoiceNumber);
                rejectPayment.ExecuteNonQuery();

                string monthlyPaymentDetails = "SELECT Count(PaymentID) FROM Payment WHERE StudentID = @studentID AND ModuleCode = @moduleCode AND Intake = @intake AND Validated = 'No'";
                SqlCommand filterStudentsWithNoPayment = new SqlCommand(monthlyPaymentDetails, connection);
                filterStudentsWithNoPayment.Parameters.AddWithValue("@studentID", _StudentID);
                filterStudentsWithNoPayment.Parameters.AddWithValue("@moduleCode", _ModuleCode);
                filterStudentsWithNoPayment.Parameters.AddWithValue("@intake", _Intake);
                SqlDataReader NoPaymentreader = filterStudentsWithNoPayment.ExecuteReader();
                while (NoPaymentreader.Read())
                {
                    int count = NoPaymentreader.GetInt32(0);
                    if (count == 3)
                    {
                        Error = true;
                        break;
                    }
                }
                NoPaymentreader.Close();

                if (Error == true)
                {
                    string removeTrainerFromStudentQuery = "UPDATE Enrolment SET TrainerID = NULL, ClassCode = NULL WHERE StudentID = @studentID AND ModuleCode = @moduleCode AND Intake = @intake;";
                    SqlCommand removetrainerFromStudent = new SqlCommand(removeTrainerFromStudentQuery, connection);
                    removetrainerFromStudent.Parameters.AddWithValue("@studentID", _StudentID);
                    removetrainerFromStudent.Parameters.AddWithValue("@moduleCode", _ModuleCode);
                    removetrainerFromStudent.Parameters.AddWithValue("@intake", _Intake);
                    removetrainerFromStudent.ExecuteNonQuery();
                }

                connection.Close();
                return "true";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        //Method for adding a student to a class by trainer
        public bool assignClass(string connectionString)
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                string assignClassQuery = "UPDATE Enrolment SET ClassCode = @classCode WHERE StudentID = @studentID AND ModuleCode = @moduleCode AND Intake = @intake;";
                SqlCommand assignClass = new SqlCommand(assignClassQuery, connection);
                assignClass.Parameters.AddWithValue("@classCode", _ClassCode);
                assignClass.Parameters.AddWithValue("@studentID", _StudentID);
                assignClass.Parameters.AddWithValue("@moduleCode", _ModuleCode);
                assignClass.Parameters.AddWithValue("@intake", _Intake);
                assignClass.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //Method for displaying student profile details on student profile user control form
        public void displayStudentProfile(TextBox txtStudentID, TextBox txtPassword, TextBox txtAddress, TextBox txtEmail, TextBox txtContactNumber, string connectionString)
        {
            string password = "";
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                string lecturerDetails = "SELECT * FROM Student WHERE StudentID = @studentID";
                SqlCommand checkUserDetailsCommand = new SqlCommand(lecturerDetails, connection);
                checkUserDetailsCommand.Parameters.AddWithValue("@studentID", _StudentID);
                SqlDataReader reader = checkUserDetailsCommand.ExecuteReader();
                while (reader.Read())
                {
                    ContactNumber = reader.GetString(2);
                    Email = reader.GetString(3);
                    Address = reader.GetString(4);
                }
                reader.Close();

                string lecturerPassword = "SELECT Password FROM Login WHERE Username = @username";
                SqlCommand checkUserPasswordCommand = new SqlCommand(lecturerPassword, connection);
                checkUserPasswordCommand.Parameters.AddWithValue("@username", _StudentID);
                SqlDataReader passwordReader = checkUserPasswordCommand.ExecuteReader();
                while (passwordReader.Read())
                {
                    password  = passwordReader.GetString(0);
                }
                passwordReader.Close();

                txtAddress.Text = _Address;
                txtContactNumber.Text = _ContactNumber;
                txtEmail.Text = Email;
                txtStudentID.Text = _StudentID;
                txtPassword.Text = password;
                connection.Close();
            }
            catch
            {
                txtStudentID.Text = "Profile information not found.";
            }
        }

        //Method for updating student profile details
        public string updateStudentProfile(string connectionString)
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                string updateLecturerProfile = "UPDATE Student SET ContactNumber = @contact_Number, Email = @email_Address, Address = @address WHERE StudentID = @studentID";
                SqlCommand updateLecturerProfileCommand = new SqlCommand(updateLecturerProfile, connection);
                updateLecturerProfileCommand.Parameters.AddWithValue("@contact_Number", _ContactNumber);
                updateLecturerProfileCommand.Parameters.AddWithValue("@email_Address", _Email);
                updateLecturerProfileCommand.Parameters.AddWithValue("@address", _Address);
                updateLecturerProfileCommand.Parameters.AddWithValue("@studentID", _StudentID);
                updateLecturerProfileCommand.ExecuteNonQuery();
                connection.Close();

                return "Update Successful.";
            }
            catch
            {
                return "Update Unsuccessful";
            }
        }

        //Method for adding student request
        public string requestModule(string connectionString)
        {
            try
            {
                int ErrorCount = 0;
                string Error = "";

                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                string fetchRequestedModuleCodeQuery = "SELECT ModuleCode FROM Request WHERE StudentID = @studentID AND StudentID IS NOT NULL";
                SqlCommand fetchRequestedModuleCode = new SqlCommand(fetchRequestedModuleCodeQuery, connection);
                fetchRequestedModuleCode.Parameters.AddWithValue("@studentID", StudentID);
                SqlDataReader moduleCodeReader = fetchRequestedModuleCode.ExecuteReader();
                while (moduleCodeReader.Read())
                {
                    string RequestedModuleCode = moduleCodeReader.GetString(0);
                    if (RequestedModuleCode == _ModuleCode)
                    {
                        ErrorCount++;
                        Error += "Error: You have already requested for the module. Please try again.\n";
                        break;
                    }
                }
                moduleCodeReader.Close();

                string fetchEnrolledModuleCodeQuery = "SELECT ModuleCode FROM Enrolment WHERE StudentID = @studentID";
                SqlCommand fetchEnrolledModuleCode = new SqlCommand(fetchEnrolledModuleCodeQuery, connection);
                fetchEnrolledModuleCode.Parameters.AddWithValue("@studentID", _StudentID);
                SqlDataReader EnrolledModuleCodeReader = fetchEnrolledModuleCode.ExecuteReader();
                while (EnrolledModuleCodeReader.Read())
                {
                    string EnrolledModuleCode = EnrolledModuleCodeReader.GetString(0);
                    if (EnrolledModuleCode == _ModuleCode)
                    {
                        ErrorCount++;
                        Error += "Error: You are already enrolled in the module. Please try again.\n";
                        break;
                    }
                }
                EnrolledModuleCodeReader.Close();

                if (ErrorCount > 0)
                {
                    return Error;
                }
                else
                {
                    string requestModuleQuery = "INSERT INTO Request VALUES (@studentID, @moduleCode)";
                    SqlCommand addRequestedModule = new SqlCommand(requestModuleQuery, connection);
                    addRequestedModule.Parameters.AddWithValue("@studentID", _StudentID);
                    addRequestedModule.Parameters.AddWithValue("@moduleCode", _ModuleCode);
                    addRequestedModule.ExecuteNonQuery();
                    return "Request Success. Please wait for your lecturer to notify you.";
                }
            }
            catch
            {
                return "Request Unsuccessful. Please try again.";
            }
        }

        //Method for adding student payment evidence for admin to validate
        public string addPaymentInfo(string connectionString)
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                string updatePaymentInfoQuery = "UPDATE Payment SET PaymentDate = @paymentDate, InvoiceNumber = @invoiceNumber WHERE StudentID = @studentID AND ModuleCode LIKE '%' + @moduleCode + '%' AND PaymentMonth LIKE '%' + @paymentMonth + '%' AND Intake = @intake;";
                SqlCommand updatePaymentInfo = new SqlCommand(updatePaymentInfoQuery, connection);
                updatePaymentInfo.Parameters.AddWithValue("@paymentDate", _PaymentDate);
                updatePaymentInfo.Parameters.AddWithValue("@invoiceNumber", _InvoiceNumber);
                updatePaymentInfo.Parameters.AddWithValue("@intake", _Intake);
                updatePaymentInfo.Parameters.AddWithValue("@studentID", _StudentID);
                updatePaymentInfo.Parameters.AddWithValue("@moduleCode", _ModuleCode);
                updatePaymentInfo.Parameters.AddWithValue("@paymentMonth", _PaymentMonth);
                updatePaymentInfo.ExecuteNonQuery();

                return "Payment information updated successfully.";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

    }
}