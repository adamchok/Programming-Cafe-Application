using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APU_Programming_Cafe
{
    public class Trainers
    {
        private string _TrainerID;
        private string _Name;
        private string _ContactNumber;
        private string _Address;
        private string _Email;
        private string _ModuleCode;
        private string _Message;
        private string _FeedbackType;

        public string TrainerID
        {
            get { return _TrainerID; }
            set { _TrainerID = value; }
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
        public string Message
        {
            get { return _Message; }
            set { _Message = value; }
        }
        public string FeedbackType
        {
            get { return _FeedbackType; }
            set { _FeedbackType = value; }
        }

        //Default constructor (used for AddFeedback)
        public Trainers()
        {

        }

        //Constructor for registerNewTrainer
        public Trainers(string name, string trainerID, string contactnum, string email, string address)
        {
            Name = name;
            TrainerID = trainerID;
            ContactNumber = contactnum;
            Email = email;
            Address = address;
        }

        //Constructor for AssignTrainer
        public Trainers(string trainerID, string moduleCode)
        {
            TrainerID = trainerID;
            ModuleCode = moduleCode;
        }

        //Constructor for DeleteTrainer
        public Trainers(string trainerID)
        {
            TrainerID = trainerID;
        }

        //Constructor for update trainer profile
        public Trainers(string trainerID, string contactNumber, string address, string email)
        {
            TrainerID = trainerID;
            ContactNumber = contactNumber;
            Email = email;
            Address = address;
        }

        //Method for registering new trainer
        public string RegisterNewTrainer(string connectionString)
        {
            try
            {
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();

                string registerTrainer = "INSERT INTO Trainer (TrainerID, Name, ContactNumber, Email, Address) VALUES (@trainerID, @name, @contactNumber, @email, @address)";
                SqlCommand registerTrainercmd = new SqlCommand(registerTrainer, con);
                registerTrainercmd.Parameters.AddWithValue("@trainerID", _TrainerID);
                registerTrainercmd.Parameters.AddWithValue("@name", _Name);
                registerTrainercmd.Parameters.AddWithValue("@contactNumber", _ContactNumber);
                registerTrainercmd.Parameters.AddWithValue("@email", _Email);
                registerTrainercmd.Parameters.AddWithValue("@address", _Address);
                registerTrainercmd.ExecuteNonQuery();

                con.Close();
                return "true";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        //Method for assigning trainer with a new ModuleCode
        public string AssignModuleCode(string connectionString)
        {
            try
            {
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();

                string AssignTrainer = "INSERT INTO Trainer_Module (TrainerID, ModuleCode) VALUES (@trainerID, @moduleCode)";
                SqlCommand AssignTrainercmd = new SqlCommand(AssignTrainer, con);
                AssignTrainercmd.Parameters.AddWithValue("@trainerID", _TrainerID);
                AssignTrainercmd.Parameters.AddWithValue("@moduleCode", _ModuleCode);
                AssignTrainercmd.ExecuteNonQuery();

                con.Close();
                return "true";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        //Method for removing existing trainer
        public void DeleteTrainer(string connectionString, out bool Error)
        {
            try
            {
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();

                string deleteTrainer = "DELETE FROM Trainer WHERE TrainerID = @trainerID";
                SqlCommand deleteTrainercmd = new SqlCommand(deleteTrainer, con);
                deleteTrainercmd.Parameters.AddWithValue("@trainerID", _TrainerID);
                deleteTrainercmd.ExecuteNonQuery();

                con.Close();
                Error = false;
            }
            catch
            {
                MessageBox.Show("Error: Unable to remove a particular Trainer.");
                Error = true;
            }
        }

        //Method for displaying trainer profile details in trainer profile user control form
        public void displayTrainerProfile(TextBox txtTrainerID, TextBox txtAddress, TextBox txtEmail, TextBox txtContactNumber, TextBox txtPassword, string connectionString)
        {
            string password = "";
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                string trainerDetails = "SELECT * FROM Trainer WHERE TrainerID = @trainerID";
                SqlCommand checkUserDetailsCommand = new SqlCommand(trainerDetails, connection);
                checkUserDetailsCommand.Parameters.AddWithValue("@trainerID", _TrainerID);
                SqlDataReader reader = checkUserDetailsCommand.ExecuteReader();
                while (reader.Read())
                {
                    ContactNumber = reader.GetString(2);
                    Email = reader.GetString(3);
                    Address = reader.GetString(4);
                }
                reader.Close();
                txtAddress.Text = _Address;
                txtContactNumber.Text = _ContactNumber;
                txtEmail.Text = _Email;
                txtTrainerID.Text = _TrainerID;

                string lecturerPassword = "SELECT Password FROM Login WHERE Username = @username";
                SqlCommand checkUserPasswordCommand = new SqlCommand(lecturerPassword, connection);
                checkUserPasswordCommand.Parameters.AddWithValue("@username", _TrainerID);
                SqlDataReader passwordReader = checkUserPasswordCommand.ExecuteReader();
                while (passwordReader.Read())
                {
                    password = passwordReader.GetString(0);
                }
                passwordReader.Close();
                txtPassword.Text = password;

                connection.Close();
            }
            catch
            {
                txtTrainerID.Text = "Error: Trainer information not found.";
            }
        }

        //Method for updating trainer profile details
        public string updateTrainerProfile(string connectionString)
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                string updateTrainerProfile = "UPDATE Trainer SET ContactNumber = @contactNumber, Email = @email_Address, Address = @address WHERE TrainerID = @trainerID;";
                SqlCommand updateTrainerProfileCommand = new SqlCommand(updateTrainerProfile, connection);
                updateTrainerProfileCommand.Parameters.AddWithValue("@contactNumber", _ContactNumber);
                updateTrainerProfileCommand.Parameters.AddWithValue("@email_Address", _Email);
                updateTrainerProfileCommand.Parameters.AddWithValue("@address", _Address);
                updateTrainerProfileCommand.Parameters.AddWithValue("@trainerID", _TrainerID);
                updateTrainerProfileCommand.ExecuteNonQuery();
                connection.Close();
                return "Update Successful.";
            }
            catch
            {
                return "Update Unsuccessful.";
            }
        }

        //Method for trainer to submit feedback
        public string AddFeedback(string connectionString)
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                string AddFeedback = "INSERT INTO Feedback (TrainerID, ModuleCode, Message, FeedbackType) VALUES (@trainerID, @moduleCode, @message, @feedbackType);";
                SqlCommand addFeedbackCommand = new SqlCommand(AddFeedback, connection);
                addFeedbackCommand.Parameters.AddWithValue("@trainerID", _TrainerID);
                addFeedbackCommand.Parameters.AddWithValue("@moduleCode", _ModuleCode);
                addFeedbackCommand.Parameters.AddWithValue("@message", _Message);
                addFeedbackCommand.Parameters.AddWithValue("@feedbackType", _FeedbackType);
                addFeedbackCommand.ExecuteNonQuery();

                connection.Close();
                return "Feedback submitted successfully.";
            }
            catch
            {
                return "Error: Unable to submit feedback. Please try again.";
            }
        }
    }
}
