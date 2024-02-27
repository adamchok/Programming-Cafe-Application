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

namespace APU_Programming_Cafe.Trainer
{
    public partial class AddCoachingClass : UserControl
    {
        string connectionString;
        string TrainerID;

        public AddCoachingClass(string connString, string trainerID)
        {
            connectionString = connString;
            TrainerID = trainerID;
            InitializeComponent();
        }

        private void insertModuleCode()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string fetchModuleCode_LevelQuery = "SELECT ModuleCode FROM Trainer_Module WHERE TrainerID = @trainerID";
            SqlCommand fetchModuleCode_Level = new SqlCommand(fetchModuleCode_LevelQuery, connection);
            fetchModuleCode_Level.Parameters.AddWithValue("@trainerID", TrainerID);
            List<string> ModuleCode = new List<string>();
            SqlDataReader reader = fetchModuleCode_Level.ExecuteReader();

            while (reader.Read())
            {
                string moduleCode = reader.GetString(0);
                if (!ModuleCode.Contains(moduleCode))
                {
                    ModuleCode.Add(moduleCode);
                }
            }
            reader.Close();

            foreach (string item in ModuleCode)
            {
                if (!cboModuleCode.Items.Contains(item))
                {
                    cboModuleCode.Items.Add(item);
                }
            }
            cboModuleCode.SelectedIndex = -1;
        }

        
        private void insertIntake(string modulecode)
        {
            cboIntake.SelectedIndex = -1;
            cboIntake.Items.Clear();
            if (cboModuleCode.SelectedIndex != -1)
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                string fetchIntakeQuery = "SELECT DISTINCT Intake FROM Enrolment WHERE TrainerID = @trainerID AND ModuleCode = @moduleCode";
                SqlCommand fetchIntake = new SqlCommand(fetchIntakeQuery, connection);
                fetchIntake.Parameters.AddWithValue("@trainerID", TrainerID);
                fetchIntake.Parameters.AddWithValue("@moduleCode", modulecode);
                List<string> Intake = new List<string>();
                SqlDataReader reader = fetchIntake.ExecuteReader();

                while (reader.Read())
                {
                    string intake = reader.GetString(0);
                    if (!Intake.Contains(intake))
                    {
                        Intake.Add(intake);
                    }
                }
                reader.Close();

                foreach (string item in Intake)
                {
                    if (!cboIntake.Items.Contains(item))
                    {
                        cboIntake.Items.Add(item);
                    }
                }
                cboIntake.SelectedIndex = -1;
            }
        }
        
        private void AddCoachingClass_Load(object sender, EventArgs e)
        {
            btnRefresh.PerformClick();
            insertModuleCode();
        }

        private void cboSelectDay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSelectDay.SelectedIndex != -1)
            {
                string day = cboSelectDay.SelectedItem.ToString();
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                string displayClassQuery = "SELECT ClassCode, ModuleCode, Intake, TimeSchedule AS Time, Venue FROM Class WHERE Day = @day;";

                SqlCommand displayClass = new SqlCommand(displayClassQuery, connection);
                displayClass.Parameters.AddWithValue("@day", day);
                SqlDataAdapter adapter = new SqlDataAdapter(displayClass);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                datagridSchedule.DataSource = dataTable;
                datagridSchedule.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                connection.Close();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string displayClassQuery = "SELECT ClassCode, ModuleCode, Intake, TimeSchedule AS Time, Day, Venue, TrainerID FROM Class;";

            SqlCommand displayClass = new SqlCommand(displayClassQuery, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(displayClass);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            datagridSchedule.DataSource = dataTable;
            datagridSchedule.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            connection.Close();

            cboSelectDay.SelectedIndex = -1;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            btnClearAll.PerformClick();
            btnRefresh.PerformClick();
            this.Visible = false;
        }

        private void cboIntake_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboIntake.SelectedIndex != -1)
            {
                lblDay.Visible = true;
                cboDay.Visible = true;
                lblStartTime.Visible = true;
                cboStartTime.Visible = true;
                lblEndTime.Visible = true;
                cboEndTime.Visible = true;
                btnSearch.Visible = true;
                lblClassNumber.Visible = true;
                cboClassNumber.Visible = true;
                lblVenue.Visible = true;
                cboVenue.Visible = true;
            }
            else
            {
                cboEndTime.SelectedIndex = -1;
                cboDay.SelectedIndex = -1;
                cboStartTime.SelectedIndex = -1;
                cboClassNumber.SelectedIndex = -1;
                cboVenue.SelectedIndex = -1;
                cboVenue.DataSource = null;
                lblEndTime.Visible = false;
                cboEndTime.Visible = false;
                lblDay.Visible = false;
                cboDay.Visible = false;
                lblStartTime.Visible = false;
                cboStartTime.Visible = false;
                btnSearch.Visible = false;
                lblClassNumber.Visible = false;
                cboClassNumber.Visible = false;
                lblVenue.Visible = false;
                cboVenue.Visible = false;
            }
        }

        private void cboModuleCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboModuleCode.SelectedIndex != -1)
            {
                string modulecode = cboModuleCode.SelectedItem.ToString();
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                string fetchModuleName_LevelQuery = "SELECT ModuleName, Level FROM Module WHERE ModuleCode = @modulecode";
                SqlCommand fetchModuleName_Level = new SqlCommand(fetchModuleName_LevelQuery, connection);
                fetchModuleName_Level.Parameters.AddWithValue("@moduleCode", modulecode);
                SqlDataReader reader = fetchModuleName_Level.ExecuteReader();

                while (reader.Read())
                {
                    string moduleName = reader.GetString(0);
                    string moduleLevel = reader.GetString(1);
                    lblModuleLevel.Text = $"{moduleName} {moduleLevel}";
                }
                reader.Close();
                connection.Close();
                cboIntake.Enabled = true;
                insertIntake(modulecode);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int VenueErrorCount = 0;
            string VenueError = "";
            int starttime = 0;
            int endtime = 0;

            if (cboDay.SelectedIndex == -1)
            {
                VenueErrorCount++;
                VenueError += "Error: Day of class is not selected. Please try again.\n";
            }
            if (cboStartTime.SelectedIndex == -1)
            {
                VenueErrorCount++;
                VenueError += "Error: Start time is not selected. Please try again.\n";
            }
            else
            {
                starttime = int.Parse(cboStartTime.SelectedItem.ToString());
            }
            if (cboEndTime.SelectedIndex == -1)
            {
                VenueErrorCount++;
                VenueError += "Error: End time is not selected. Please try again.\n";
            }
            else
            {
                endtime = int.Parse(cboEndTime.SelectedItem.ToString());
            }

            if (starttime > endtime)
            {
                VenueErrorCount++;
                VenueError += "Error: End time is ealier than start time. Please try again.\n";
            }

            if (starttime == endtime && starttime > 0 && endtime > 0)
            {
                VenueErrorCount++;
                VenueError += "Error: Start time is the same as end time. Please try again.\n";
            }

            if (VenueErrorCount > 0)
            {
                MessageBox.Show(VenueError);
            }
            else
            {
                cboVenue.DataSource = null;

                string day = cboDay.SelectedItem.ToString();
                int startTime = int.Parse(cboStartTime.SelectedItem.ToString());
                int endTime = int.Parse(cboEndTime.SelectedItem.ToString());

                List<string> AllVenues = new List<string>
                {
                    "Audi1",
                    "Audi2",
                    "Audi3",
                    "Audi4",
                    "Audi5",
                    "Audi6"
                };

                CoachingClass getVenues = new CoachingClass();
                getVenues.StartTime = startTime;
                getVenues.EndTime = endTime;
                getVenues.Day = day;
                bool Error = false;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string validateTrainerAvailabilityQuery = "SELECT DISTINCT Venue, TimeSchedule, TrainerID FROM Class WHERE Day = @day AND TrainerID = @trainerID";
                    SqlCommand fetchOccupiedVenues = new SqlCommand(validateTrainerAvailabilityQuery, connection);
                    fetchOccupiedVenues.Parameters.AddWithValue("@day", day);
                    fetchOccupiedVenues.Parameters.AddWithValue("@trainerID", TrainerID);
                    SqlDataReader reader = fetchOccupiedVenues.ExecuteReader();
                    while (reader.Read())
                    {
                        string occupiedVenue = reader.GetString(0);
                        string timeSchedule = reader.GetString(1);
                        string trainerID = reader.GetString(2);

                        int start = int.Parse(timeSchedule.Split('-')[0]);
                        int end = int.Parse(timeSchedule.Split('-')[1]);

                        if ((startTime <= start && endTime >= end && trainerID == TrainerID) || (startTime >= start && endTime <= end && trainerID == TrainerID) || (startTime > start && startTime < end && trainerID == TrainerID) || (endTime > start && endTime < end && trainerID == TrainerID) || (startTime > start && startTime < end) || (endTime > start && endTime < end))
                        {
                            MessageBox.Show("Error: You are already occupied with another class with the selected time and day. Please try again.");
                            Error = true;
                            cboVenue.SelectedIndex = -1;
                            cboVenue.DataSource = null;
                            cboClassNumber.SelectedIndex = -1;
                            break;
                        }
                    }
                    reader.Close();
                }

                if (Error == false)
                {
                    List<string> occupiedVenues = getVenues.GetOccupiedVenues(AllVenues, connectionString);
                    foreach (string occupiedVenue in occupiedVenues)
                    {
                        if (AllVenues.Contains(occupiedVenue))
                        {
                            AllVenues.Remove(occupiedVenue);
                        }
                    }
                    cboVenue.DataSource = AllVenues;
                }
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            cboModuleCode.SelectedIndex = -1;
            cboIntake.SelectedIndex = -1;
            lblModuleLevel.Text = "";
            cboVenue.DataSource = null;
        }

        private void btnViewCurrentClass_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string displayClassQuery = "SELECT ClassCode, ModuleCode, Intake, TimeSchedule AS Time, Day, Venue FROM Class WHERE TrainerID = @trainerID;";

            SqlCommand displayClass = new SqlCommand(displayClassQuery, connection);
            displayClass.Parameters.AddWithValue("@trainerID", TrainerID);
            SqlDataAdapter adapter = new SqlDataAdapter(displayClass);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            datagridSchedule.DataSource = dataTable;
            datagridSchedule.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            connection.Close();

            cboSelectDay.SelectedIndex = -1;
        }

        private void btnAddClass_Click(object sender, EventArgs e)
        {
            if (cboVenue.SelectedIndex == -1 && cboClassNumber.SelectedIndex == -1)
            {
                MessageBox.Show("Error: Venue and class number not selected. Please try again.");
            }
            else
            {
                string starttime = cboStartTime.SelectedItem.ToString();
                string endtime = cboEndTime.SelectedItem.ToString();

                string timeSchedule = $"{starttime}-{endtime}";
                string moduleCode = cboModuleCode.SelectedItem.ToString();
                string intake = cboIntake.SelectedItem.ToString();
                string day = cboDay.SelectedItem.ToString();
                string venue = cboVenue.SelectedItem.ToString();
                string classNumber = cboClassNumber.SelectedItem.ToString();
                string classCode = "";

                if (moduleCode.Contains("C#"))
                {
                    classCode = $"CS{moduleCode.Substring(moduleCode.Length - 2)}{intake.Substring(0, 2)}{intake.Substring(intake.Length - 2)}{classNumber}";
                }
                else
                {
                    classCode = $"{moduleCode.Substring(0, 2)}{moduleCode.Substring(moduleCode.Length - 2)}{intake.Substring(0, 2)}{intake.Substring(intake.Length - 2)}{classNumber}";
                }

                bool classExist = false;

                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                string searchClassQuery = "SELECT ClassCode FROM Class WHERE TrainerID = @trainerID;";
                SqlCommand searchClass = new SqlCommand(searchClassQuery, connection);
                searchClass.Parameters.AddWithValue("@trainerID", TrainerID);
                SqlDataReader reader = searchClass.ExecuteReader();
                while (reader.Read())
                {
                    string currentClass = reader.GetString(0);
                    if (currentClass == classCode)
                    {
                        classExist = true;
                        break;
                    }
                }
                reader.Close();
                connection.Close();
                if (classExist == false)
                {
                    CoachingClass addClass = new CoachingClass(classCode, TrainerID, moduleCode, intake, timeSchedule, day, venue);
                    string addSuccessful = addClass.addClass(connectionString);

                    if (addSuccessful == "true")
                    {
                        MessageBox.Show("Class added successfully.");
                        btnRefresh.PerformClick();
                        btnClearAll.PerformClick();
                    }
                    else
                    {
                        if (addSuccessful.Contains("duplicate"))
                        {
                            MessageBox.Show("Error: Class is already exist.");
                            btnRefresh.PerformClick();
                            btnClearAll.PerformClick();
                        }
                        else
                        {
                            MessageBox.Show("Error: Unable to add class.");
                            btnRefresh.PerformClick();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Error: There is already a class for that class number. Only one class for a specific module and intake with a unique class number is allowed for a week.");
                }
            }
        }

        private void AddCoachingClass_VisibleChanged(object sender, EventArgs e)
        {
            btnRefresh.PerformClick();
            btnClearAll.PerformClick();
        }

        private void cboDay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDay.SelectedIndex != -1)
            {
                cboStartTime.SelectedIndex = -1;
                cboEndTime.SelectedIndex = -1;
                cboClassNumber.SelectedIndex = -1;
                cboVenue.DataSource = null;
            }
        }

        private void cboStartTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboStartTime.SelectedIndex != -1)
            {
                cboClassNumber.SelectedIndex = -1;
                cboVenue.DataSource = null;
            }
        }

        private void cboEndTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboEndTime.SelectedIndex != -1)
            {
                cboClassNumber.SelectedIndex = -1;
                cboVenue.DataSource = null;
            }
        }
    }
}
