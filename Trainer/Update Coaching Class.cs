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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace APU_Programming_Cafe.Trainer
{
    public partial class Update_Coaching_Class : UserControl
    {
        string connectionString;
        string TrainerID;

        public Update_Coaching_Class(string connString, string trainerID)
        {
            InitializeComponent();
            connectionString = connString;
            TrainerID = trainerID;
        }

        int ErrorCount = 0;
        string Error = "";
        List<string> tempClassList = new List<string>();

        private void ClearAll()
        {
            listboxUpdatedVenue.SelectedIndex = -1;
            cboStartTime.SelectedIndex = -1;
            cboEndTime.SelectedIndex = -1;
            cboUpdatedDay.SelectedIndex = -1;
            txtSearch.Text = string.Empty;
            listboxUpdatedVenue.DataSource = null;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ClearAll();
        }

        private void Update_Coaching_Class_Load(object sender, EventArgs e)
        {
            btnRefresh.PerformClick();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            tempClassList.Clear();
            listSelectedClass.Items.Clear();

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand displayClass = new SqlCommand("SELECT ClassCode, ModuleCode, Intake, TimeSchedule AS Time, Day, Venue, TrainerID FROM Class", connection);
            displayClass.Parameters.AddWithValue("@trainerID", TrainerID);
            SqlDataAdapter adapter = new SqlDataAdapter(displayClass);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            datagridCurrentClasses.DataSource = dataTable;
            datagridCurrentClasses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            string listboxQuery = "SELECT ClassCode FROM Class WHERE TrainerID = @trainerID;";
            List<string> ClassCodeList = new List<string>();
            SqlCommand command = new SqlCommand(listboxQuery, connection);
            command.Parameters.AddWithValue("@trainerID", TrainerID);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string classCode = reader.GetString(0);
                if (!ClassCodeList.Contains(classCode))
                {
                    ClassCodeList.Add(classCode);
                    tempClassList.Add(classCode);
                }
            }
            reader.Close();

            foreach (string item in ClassCodeList)
            {
                if (!listSelectedClass.Items.Contains(item))
                {
                    listSelectedClass.Items.Add(item);
                }
            }

            listSelectedClass.DisplayMember = "classcode";
            listSelectedClass.SelectedIndex = -1;

            connection.Close();
            txtSearch.Text = string.Empty;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            btnRefresh.PerformClick();
            ClearAll();
        }

        private void btnSearchVenue_Click(object sender, EventArgs e)
        {
            int VenueErrorCount = 0;
            string VenueError = "";
            int endtime = 0;
            int starttime = 0;

            if (listSelectedClass.SelectedIndex == -1)
            {
                VenueErrorCount++;
                VenueError += "Error: Class to update not selected. Please try again.\n";
            }

            if (cboUpdatedDay.SelectedIndex == -1)
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
                listboxUpdatedVenue.DataSource = null;

                string day = cboUpdatedDay.SelectedItem.ToString();
                int startTime = int.Parse(cboStartTime.SelectedItem.ToString());
                int endTime = int.Parse(cboEndTime.SelectedItem.ToString());
                string TimeSchedule = $"{cboStartTime.SelectedItem}-{cboEndTime.SelectedItem}";
                string selectedClassCode = listSelectedClass.SelectedItem.ToString();

                List<string> occupiedVenues = new List<string>();
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
                getVenues.TimeSchedule = TimeSchedule;
                getVenues.Day = day;
                getVenues.StartTime = startTime;
                getVenues.EndTime = endTime;
                bool sameVenue = false;
                bool overlappingClassSameTrainer = false;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string cmdQuery = "SELECT ClassCode, TrainerID, TimeSchedule FROM Class WHERE Day = @day";
                    SqlCommand cmd = new SqlCommand(cmdQuery, connection);
                    cmd.Parameters.AddWithValue("@day", day);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        string classCode = reader.GetString(0);
                        string trainerID = reader.GetString(1);
                        string timeSchedule = reader.GetString(2);

                        int start = int.Parse(timeSchedule.Split('-')[0]);
                        int end = int.Parse(timeSchedule.Split('-')[1]);

                        if (classCode == selectedClassCode && trainerID == TrainerID && timeSchedule == TimeSchedule)
                        {
                            sameVenue = true;
                            break;
                        }

                        else if (classCode == selectedClassCode && trainerID == TrainerID && ((startTime <= start && endTime >= end) || (startTime >= start && endTime <= end) || (startTime > start && startTime < end) || (endTime > start && endTime < end)))
                        {
                            break;
                        }

                        else if (trainerID == TrainerID && ((startTime <= start && endTime >= end) || (startTime >= start && endTime <= end) || (startTime > start && startTime < end) || (endTime > start && endTime < end)))
                        {
                            overlappingClassSameTrainer = true;
                            break;
                        }
                    }
                    reader.Close();
                }

                if (sameVenue)
                {
                    occupiedVenues = getVenues.GetOccupiedVenuesForSameTime(connectionString);
                    foreach (string occupiedVenue in occupiedVenues)
                    {
                        if (AllVenues.Contains(occupiedVenue))
                        {
                            AllVenues.Remove(occupiedVenue);
                        }
                    }
                    listboxUpdatedVenue.DataSource = AllVenues;
                }
                else if (overlappingClassSameTrainer)
                {
                    MessageBox.Show("Error: You are occupied with another class at the selected time and day.");
                }


                else if (overlappingClassSameTrainer == false)
                {
                    occupiedVenues = getVenues.GetOccupiedVenues(AllVenues, connectionString);
                    foreach (string occupiedVenue in occupiedVenues)
                    {
                        if (AllVenues.Contains(occupiedVenue))
                        {
                            AllVenues.Remove(occupiedVenue);
                        }
                    }
                    listboxUpdatedVenue.DataSource = AllVenues;
                }
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            bool CLASSnotPresent = true;
            listSelectedClass.Items.Clear();
            if (tempClassList.Count > 0)
            {
                if (txtSearch.Text != string.Empty)
                {
                    foreach (string classCode in tempClassList)
                    {
                        if (classCode.Contains(txtSearch.Text))
                        {
                            listSelectedClass.Items.Add(classCode);
                            CLASSnotPresent = false;
                        }
                    }
                    if (CLASSnotPresent == true)
                    {
                        MessageBox.Show("Class code entered is not found. Try again?");
                        btnRefresh.PerformClick();
                        ClearAll();
                    }
                }
                else
                {
                    MessageBox.Show("Error: Invalid class code entered. Please try again.");
                    btnRefresh.PerformClick();
                    ClearAll();
                }
            }
            else
            {
                MessageBox.Show("There are no class codes at the moment.");
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == string.Empty)
            {
                btnRefresh.PerformClick();
            }
        }

        private void Update_Coaching_Class_VisibleChanged(object sender, EventArgs e)
        {
            btnRefresh.PerformClick();
            btnClear.PerformClick();
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
                string updatedDay = cboUpdatedDay.Text;

                string start = cboStartTime.SelectedItem.ToString();
                string end = cboEndTime.SelectedItem.ToString();
                string updatedtimeSchedule = $"{start}-{end}";
                string currentClassCode = listSelectedClass.SelectedItem.ToString();
                string updatedVenue = listboxUpdatedVenue.SelectedItem.ToString();


                CoachingClass updateClass = new CoachingClass(currentClassCode, updatedDay, updatedtimeSchedule, updatedVenue, TrainerID);
                bool updateSuccessful = updateClass.updateClass(connectionString);

                if (updateSuccessful == true)
                {
                    MessageBox.Show("Update Successful.");
                    btnRefresh.PerformClick();
                    ClearAll();
                }
                else
                {
                    MessageBox.Show("Update Unsuccessful. Please try again.");
                }
            }

        }

        private string ErrorChecking()
        {
            Error = string.Empty;
            ErrorCount = 0;
            int starttime = 0;
            int endtime = 0;

            if (listSelectedClass.SelectedIndex == -1)
            {
                ErrorCount += 1;
                Error += "Error: No class selected. Please try again.\n";
            }

            if (cboUpdatedDay.SelectedIndex == -1)
            {
                ErrorCount++;
                Error += "Error: Day of class is not selected. Please try again.\n";
            }
            if (cboStartTime.SelectedIndex == -1 && cboEndTime.SelectedIndex == -1)
            {
                ErrorCount++;
                Error += "Error: Start and/or end is not selected. Please try again.\n";
            }
            else
            {
                starttime = int.Parse(cboStartTime.SelectedItem.ToString());
                endtime = int.Parse(cboEndTime.SelectedItem.ToString());
                if (starttime == endtime)
                {
                    ErrorCount++;
                    Error += "Error: Start time is the same as end time. Please try again.\n";
                }
                else if (starttime > endtime)
                {
                    ErrorCount++;
                    Error += "Error: End time is earlier than start time. Please try again.\n";
                }
            }

            if (listboxUpdatedVenue.SelectedIndex == -1)
            {
                ErrorCount += 1;
                Error += "Error: No updated venue selected.Please try again.\n";
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

        private void btnViewCurrent_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand displayClass = new SqlCommand("SELECT ClassCode, ModuleCode, Intake, TimeSchedule AS Time, Day, Venue FROM Class WHERE TrainerID = @trainerID", connection);
            displayClass.Parameters.AddWithValue("@trainerID", TrainerID);
            SqlDataAdapter adapter = new SqlDataAdapter(displayClass);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            datagridCurrentClasses.DataSource = dataTable;
            datagridCurrentClasses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void cboUpdatedDay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboUpdatedDay.SelectedIndex != -1)
            {
                cboStartTime.SelectedIndex = -1;
                cboEndTime.SelectedIndex = -1;
                listboxUpdatedVenue.DataSource = null;
            }
        }

        private void cboStartTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboStartTime.SelectedIndex != -1)
            {
                listboxUpdatedVenue.DataSource = null;
            }
        }

        private void cboEndTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboEndTime.SelectedIndex != -1)
            {

                listboxUpdatedVenue.DataSource = null;
            }
        }

        private void listSelectedClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listSelectedClass.SelectedIndex != -1)
            {
                cboUpdatedDay.SelectedIndex = -1;
                cboStartTime.SelectedIndex = -1;
                cboEndTime.SelectedIndex = -1;
                listboxUpdatedVenue.DataSource = null;
            }
        }
    }
}
