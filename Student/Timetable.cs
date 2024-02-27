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

namespace APU_Programming_Cafe.Student
{
    public partial class Timetable : UserControl
    {
        string connectionString;
        string StudentID;
        public Timetable(string connString, string studentID)
        {
            connectionString = connString;
            StudentID = studentID;
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cboModule.SelectedIndex = -1;
            cboIntake.SelectedIndex = -1;

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string displayTimetableQuery = "SELECT Class.* FROM Class INNER JOIN Enrolment ON Class.ClassCode = Enrolment.ClassCode WHERE Enrolment.StudentID = @studentID AND Enrolment.ClassCode IS NOT NULL AND Enrolment.Completion = 'No';";
            SqlCommand displayTimetable = new SqlCommand(displayTimetableQuery, connection);
            displayTimetable.Parameters.AddWithValue("@studentID", StudentID);
            SqlDataAdapter adapter = new SqlDataAdapter(displayTimetable);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            datagridScheduleStudent.DataSource = dataTable;
            datagridScheduleStudent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            connection.Close();
        }

        private void Timetable_Load(object sender, EventArgs e)
        {
            btnRefresh.PerformClick();

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string fetchStudentModuleQuery = "SELECT Module.ModuleName, Enrolment.Intake FROM Enrolment INNER JOIN Module ON Enrolment.ModuleCode = Module.ModuleCode WHERE Enrolment.StudentID = @studentID AND Enrolment.Completion = 'No';";
            SqlCommand fetchStudentModule = new SqlCommand(fetchStudentModuleQuery, connection);
            fetchStudentModule.Parameters.AddWithValue("@studentID", StudentID);
            SqlDataReader reader = fetchStudentModule.ExecuteReader();
            while (reader.Read())
            {
                string moduleName = reader.GetString(0);
                string intake = reader.GetString(1);
                if (!cboModule.Items.Contains(moduleName))
                {
                    cboModule.Items.Add(moduleName);
                }
                if (!cboIntake.Items.Contains(intake))
                {
                    cboIntake.Items.Add(intake);
                }
            }
            reader.Close();
            connection.Close();
        }

        private void Timetable_VisibleChanged(object sender, EventArgs e)
        {
            btnRefresh.PerformClick();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            string ModuleName = "";
            string Intake = "";

            if (cboModule.SelectedIndex != -1)
            {
                ModuleName = cboModule.SelectedItem.ToString();
            }

            if (cboIntake.SelectedIndex != -1)
            {
                Intake = cboIntake.SelectedItem.ToString();
            }

            Students studentDetails = new Students();
            studentDetails.ModuleName = ModuleName;
            studentDetails.Intake = Intake;

            List<string> SearchConditions = new List<string>();
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            string openTableWithNoSearchConditions = "SELECT Class.* FROM Class INNER JOIN Enrolment ON Class.ClassCode = Enrolment.ClassCode WHERE Enrolment.StudentID = @studentID AND Enrolment.ClassCode IS NOT NULL AND Enrolment.Completion = 'No'";

            if (!string.IsNullOrEmpty(studentDetails.Intake))
            {
                SearchConditions.Add("Intake = @value1");
                parameters["@value1"] = studentDetails.Intake;
            }

            if (!string.IsNullOrEmpty(studentDetails.ModuleName))
            {
                SearchConditions.Add("ModuleCode LIKE '%' + @value2 + '%'");
                parameters["@value2"] = studentDetails.ModuleName;
            }

            string queryWithSearchCondtions = openTableWithNoSearchConditions;
            if (SearchConditions.Count > 0)
            {
                foreach (string condition in SearchConditions)
                {
                    queryWithSearchCondtions += $" AND Enrolment.{condition}";
                }
            }

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand cmd = new SqlCommand(queryWithSearchCondtions, connection);
            cmd.Parameters.AddWithValue("@studentID", StudentID);

            foreach (var parameter in parameters)
            {
                cmd.Parameters.AddWithValue(parameter.Key, parameter.Value);
            }

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            datagridScheduleStudent.DataSource = dataTable;
            datagridScheduleStudent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            connection.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }
    }
}
