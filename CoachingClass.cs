using APU_Programming_Cafe.Trainer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Dynamic;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace APU_Programming_Cafe
{
    public class CoachingClass
    {
        private string _ClassCode;
        private string _TrainerID;
        private string _ModuleCode;
        private string _Intake;
        private string _TimeSchedule;
        private string _Day;
        private string _Venue;
        private string _ClassCompletion;
        private int _StartTime;
        private int _EndTime;
    
        public string ClassCode
        {
            get { return _ClassCode; }
            set { _ClassCode = value; }
        }

        public string TrainerID
        {
            get { return _TrainerID; }
            set { _TrainerID = value; }
        }

        public string ModuleCode
        {
            get { return _ModuleCode; }
            set { _ModuleCode = value; }
        }

        public string Intake
        {
            get { return _Intake; }
            set { _Intake = value; }
        }

        public string TimeSchedule
        {
            get { return _TimeSchedule; }
            set { _TimeSchedule = value; }
        }

        public string Day
        {
            get { return _Day; }
            set
            { _Day = value; }
        }

        public string Venue
        {
            get { return _Venue; }
            set { _Venue = value; }
        }

        public string ClassCompletion
        {
            get { return _ClassCompletion; }
            set { _ClassCompletion = value; }
        }

        public int StartTime
        {
            get { return _StartTime; }
            set { _StartTime = value; }
        }

        public int EndTime
        {
            get { return _EndTime; }
            set { _EndTime = value; }
        }

        // Default constructor used for get venue list methods.
        public CoachingClass()
        {

        }

        //Constructor for add class
        public CoachingClass(string classCode, string trainerID, string moduleCode, string intake, string timeSchedule, string day, string venue)
        {
            ClassCode = classCode;
            TrainerID = trainerID;
            ModuleCode = moduleCode;
            Intake = intake;
            TimeSchedule = timeSchedule;
            Day = day;
            Venue = venue;
        }

        //Constructor for updating class
        public CoachingClass(string currentClassCode, string day, string timeSchedule, string venue, string trainerID)
        {
            ClassCode = currentClassCode;
            Day = day;
            TimeSchedule = timeSchedule;
            Venue = venue;
            TrainerID = trainerID;
        }

        //Constructor for deleting class
        public CoachingClass(string classCode, string trainerID, string classCompletion)
        {
            ClassCode = classCode;
            TrainerID = trainerID;
            ClassCompletion = classCompletion;
        }

        //Method for getting occupied venues (in update AND add coaching class)
        public List<string> GetOccupiedVenues(List<string> allVenues, string connectionString)
        {
            List<string> occupiedVenues = new List<string>();

            foreach (string venue in allVenues)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string fetchOccupiedVenuesQuery = "SELECT DISTINCT Venue, TimeSchedule FROM Class WHERE Day = @day";
                        SqlCommand fetchOccupiedVenues = new SqlCommand(fetchOccupiedVenuesQuery, connection);
                        fetchOccupiedVenues.Parameters.AddWithValue("@day", _Day);
                        SqlDataReader reader = fetchOccupiedVenues.ExecuteReader();
                        while (reader.Read())
                        {
                            string occupiedVenue = reader.GetString(0);
                            string timeSchedule = reader.GetString(1);

                            int start = int.Parse(timeSchedule.Split('-')[0]);
                            int end = int.Parse(timeSchedule.Split('-')[1]);

                            if ((_StartTime <= start && _StartTime >= end) || (_StartTime >= start && _EndTime <= end) || (_StartTime > start && _StartTime < end) || (_EndTime > start && _EndTime < end))
                            {
                                if (!occupiedVenues.Contains(occupiedVenue))
                                {
                                    occupiedVenues.Add(occupiedVenue);
                                }
                                
                            }
                        }
                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

            return occupiedVenues;
        }

        //Method for getting occupied venues (in update coaching class only)
        public List<string> GetOccupiedVenuesForSameTime(string connectionString)
        {
            List<string> occupiedVenues = new List<string>();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string fetchOccupiedVenuesQuery = "SELECT DISTINCT Venue FROM Class WHERE Day = @day AND TimeSchedule = @timeSchedule;";
                    SqlCommand fetchOccupiedVenues = new SqlCommand(fetchOccupiedVenuesQuery, connection);
                    fetchOccupiedVenues.Parameters.AddWithValue("@day", _Day);
                    fetchOccupiedVenues.Parameters.AddWithValue("@timeSchedule", _TimeSchedule);
                    SqlDataReader reader = fetchOccupiedVenues.ExecuteReader();
                    while (reader.Read())
                    {
                        string venue = reader.GetString(0);
                        if (!occupiedVenues.Contains(venue))
                        {
                            occupiedVenues.Add(venue);
                        }
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return occupiedVenues;
        }

        //Method for creating a new coaching class
        public string addClass(string connectionString)
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                
                string addClassQuery = "INSERT INTO Class (ClassCode, TrainerID, ModuleCode, Intake, TimeSchedule, Day, Venue) VALUES (@classCode, @trainerID, @moduleCode, @intake, @timeSchedule, @day, @venue)";
                SqlCommand addClass = new SqlCommand(addClassQuery, connection);
                addClass.Parameters.AddWithValue("@classCode", _ClassCode);
                addClass.Parameters.AddWithValue("@trainerID", _TrainerID);
                addClass.Parameters.AddWithValue("@moduleCode", _ModuleCode);
                addClass.Parameters.AddWithValue("@intake", _Intake);
                addClass.Parameters.AddWithValue("@timeSchedule", _TimeSchedule);
                addClass.Parameters.AddWithValue("@day", _Day);
                addClass.Parameters.AddWithValue("@venue", _Venue);
                addClass.ExecuteNonQuery();
                connection.Close();
                
                return "true";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        //Method for updating existing coaching class details
        public bool updateClass(string connectionString)
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                string updateClassTable = "UPDATE Class SET TimeSchedule = @updatedTimeSchedule, Day = @updatedDay, Venue = @updatedVenue WHERE TrainerID = @trainerID AND ClassCode = @currentClassCode;";
                SqlCommand updateClassTableCommand = new SqlCommand(updateClassTable, connection);
                updateClassTableCommand.Parameters.AddWithValue("@updatedTimeSchedule", _TimeSchedule);
                updateClassTableCommand.Parameters.AddWithValue("@updatedDay", _Day);
                updateClassTableCommand.Parameters.AddWithValue("@updatedVenue", _Venue);
                updateClassTableCommand.Parameters.AddWithValue("@trainerID", _TrainerID);
                updateClassTableCommand.Parameters.AddWithValue("@currentClassCode", _ClassCode);
                updateClassTableCommand.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //Method for deleting an exsiting coaching class
        public string deleteClass(string connectionString)
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                string deleteClassQuery = "DELETE FROM Class WHERE ClassCode = @classCode AND TrainerID = @trainerID";
                SqlCommand deleteClass = new SqlCommand(deleteClassQuery, connection);
                deleteClass.Parameters.AddWithValue("@classCode", _ClassCode);
                deleteClass.Parameters.AddWithValue("@trainerID", _TrainerID);
                deleteClass.ExecuteNonQuery();

                if (_ClassCompletion == "Yes")
                {
                    string setStudentCompletionQuery = "UPDATE Enrolment SET Completion = 'Yes' WHERE ClassCode = @classCode AND TrainerID = @trainerID;";
                    SqlCommand setStudentCompletion = new SqlCommand(setStudentCompletionQuery, connection);
                    setStudentCompletion.Parameters.AddWithValue("@classCode", _ClassCode);
                    setStudentCompletion.Parameters.AddWithValue("@trainerID", _TrainerID);
                    setStudentCompletion.ExecuteNonQuery();
                }

                string deleteClassCodeInEnrolmentQuery = "UPDATE Enrolment SET ClassCode = NULL WHERE ClassCode = @classCode AND TrainerID = @trainerID;";
                SqlCommand deleteClassCodeInEnrolment = new SqlCommand(deleteClassCodeInEnrolmentQuery, connection);
                deleteClassCodeInEnrolment.Parameters.AddWithValue("@classCode", _ClassCode);
                deleteClassCodeInEnrolment.Parameters.AddWithValue("@trainerID", _TrainerID);
                deleteClassCodeInEnrolment.ExecuteNonQuery();

                connection.Close();
                return "true";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
    }
}
