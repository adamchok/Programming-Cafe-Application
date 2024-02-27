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
    public partial class RemoveCoachingClass : UserControl
    {
        string connectionString;
        string TrainerID;
        string ClassCompletion = "No";
        public RemoveCoachingClass(string connString, string trainerID)
        {
            connectionString = connString;
            TrainerID = trainerID;
            InitializeComponent();
            TrainerID = trainerID;
        }

        private void ClearAll()
        {
            listSelectedCoachingClass.Items.Clear();
            txtSearch.Text = string.Empty;
            cboFilterModule.SelectedIndex = -1;
            cboFilterLevel.SelectedIndex = -1;
            cboFilterIntake.SelectedIndex = -1;
            btnClassCompleted.ForeColor = Color.Tomato;
            ClassCompletion = "No";
        }

        List<string> ToBeRemovedClass = new List<string>();
        List<string> tempClassCode = new List<string>();
        List<string> tempModuleCode = new List<string>();

        private void RemoveCoachingClass_Load(object sender, EventArgs e)
        {
            btnRefresh.PerformClick();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            tempClassCode.Clear();
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string fetchCoachingClassQuery = "SELECT * FROM Class WHERE TrainerID = @trainerID";
            SqlCommand fetchCoachingClass = new SqlCommand(fetchCoachingClassQuery, connection);
            fetchCoachingClass.Parameters.AddWithValue("@trainerID", TrainerID);
            SqlDataAdapter adapter = new SqlDataAdapter(fetchCoachingClass);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            datagridCoachingClass.DataSource = dataTable;
            datagridCoachingClass.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            SqlDataReader classCodeReader = fetchCoachingClass.ExecuteReader();
            while (classCodeReader.Read())
            {
                string classCode = classCodeReader.GetString(0);
                if (!tempClassCode.Contains(classCode))
                {
                    tempClassCode.Add(classCode);
                }
            }
            classCodeReader.Close();


            string fetchFilterDetailsQuery = "SELECT DISTINCT Module.ModuleName, Enrolment.Intake, Enrolment.ModuleCode FROM Enrolment INNER JOIN Module ON Enrolment.ModuleCode = Module.ModuleCode WHERE Enrolment.TrainerID = @trainerID;";
            SqlCommand fetchFilterDetails = new SqlCommand(fetchFilterDetailsQuery, connection);
            fetchFilterDetails.Parameters.AddWithValue("@trainerID", TrainerID);
            SqlDataReader reader = fetchFilterDetails.ExecuteReader();
            while (reader.Read())
            {
                string moduleName = reader.GetString(0);
                string intake = reader.GetString(1);
                string moduleCode = reader.GetString(2);

                if (!cboFilterModule.Items.Contains(moduleName))
                {
                    cboFilterModule.Items.Add(moduleName);
                }
                if (!cboFilterIntake.Items.Contains(intake))
                {
                    cboFilterIntake.Items.Add(intake);
                }
                if (!tempModuleCode.Contains(moduleCode))
                {
                    tempModuleCode.Add(moduleCode);
                }
            }
            reader.Close();

            if (tempModuleCode.Count > 0)
            {
                foreach (string modulecode in tempModuleCode)
                {
                    string fetchLevelQuery = "SELECT DISTINCT Level FROM Module WHERE ModuleCode = @moduleCode";
                    SqlCommand fetchLevel = new SqlCommand(fetchLevelQuery, connection);
                    fetchLevel.Parameters.AddWithValue("@moduleCode", modulecode);
                    SqlDataReader levelReader = fetchLevel.ExecuteReader();
                    while (levelReader.Read())
                    {
                        string level = levelReader.GetString(0);
                        if (!cboFilterLevel.Items.Contains(level))
                        {
                            cboFilterLevel.Items.Add(level);
                        }
                    }
                    levelReader.Close();
                }
                tempModuleCode.Clear();
            }
            connection.Close();
        }

        private void datagridCoachingClass_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < datagridCoachingClass.Rows.Count)
            {
                DataGridViewRow selectedRow = datagridCoachingClass.Rows[e.RowIndex];

                string classCode = selectedRow.Cells["ClassCode"].Value.ToString();

                if (!listSelectedCoachingClass.Items.Contains(classCode))
                {
                    listSelectedCoachingClass.Items.Add(classCode);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
            btnRefresh.PerformClick();
        }

        private void btnClassCompleted_Click(object sender, EventArgs e)
        {
            if (ClassCompletion == "No")
            {
                btnClassCompleted.ForeColor = Color.Aquamarine;
                ClassCompletion = "Yes";
                
            }
            else
            {
                btnClassCompleted.ForeColor = Color.Tomato;
                ClassCompletion = "No";
            }
        }

        private void listSelectedCoachingClass_DoubleClick(object sender, EventArgs e)
        {
            listSelectedCoachingClass.Items.Remove(listSelectedCoachingClass.SelectedItem);
        }

        private void btnFilterSearch_Click(object sender, EventArgs e)
        {
            
            string ModuleName = "";
            string Level = "";
            string Intake = "";
            string ModuleCode = "";

            if (cboFilterLevel.SelectedIndex != -1)
            {
                if (cboFilterLevel.SelectedItem.ToString().Contains("Beginner"))
                {
                    if (cboFilterModule.SelectedIndex != -1)
                    {
                        ModuleCode = $"{cboFilterModule.SelectedItem}01";
                    }
                    Level = "01";
                }
                else if (cboFilterLevel.SelectedItem.ToString().Contains("Intermediate"))
                {
                    if (cboFilterModule.SelectedIndex != -1)
                    {
                        ModuleCode = $"{cboFilterModule.SelectedItem}02";
                    }
                    Level = "02";
                }
                else
                {
                    if (cboFilterModule.SelectedIndex != -1)
                    {
                        ModuleCode = $"{cboFilterModule.SelectedItem}03";
                    }
                    Level = "03";
                }
            }

            if (cboFilterIntake.SelectedIndex != -1)
            {
                Intake = cboFilterIntake.SelectedItem.ToString();
            }

            if (cboFilterModule.SelectedIndex != -1)
            {
                ModuleName = cboFilterModule.SelectedItem.ToString();
            }

            List<string> SearchConditions = new List<string>();
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            string openTableWithNoSearchConditions = "SELECT * FROM Class WHERE TrainerID = @trainerID";

            if (!string.IsNullOrEmpty(ModuleCode))
            {
                SearchConditions.Add("ModuleCode = @value1");
                parameters["@value1"] = ModuleCode;
            }

            if (!string.IsNullOrEmpty(Intake))
            {
                SearchConditions.Add("Intake = @value2");
                parameters["@value2"] = Intake;
            }

            if (!string.IsNullOrEmpty(Level))
            {
                SearchConditions.Add("ModuleCode LIKE '%' + @value3 + '%'");
                parameters["@value3"] = Level;
            }

            if (!string.IsNullOrEmpty(ModuleName))
            {
                SearchConditions.Add("ModuleCode LIKE '%' + @value4 + '%'");
                parameters["@value4"] = ModuleName;
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
            datagridCoachingClass.DataSource = dataTable;
            datagridCoachingClass.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            connection.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            bool CLASSnotPresent = true;
            if (tempClassCode.Count > 0)
            {
                if (txtSearch.Text != string.Empty)
                {
                    foreach (string classCode in tempClassCode)
                    {
                        if (classCode.Contains(txtSearch.Text))
                        {
                            SqlConnection connection = new SqlConnection(connectionString);
                            connection.Open();
                            string fetchCoachingClassQuery = "SELECT * FROM Class WHERE TrainerID = @trainerID AND ClassCode = @classCode";
                            SqlCommand fetchCoachingClass = new SqlCommand(fetchCoachingClassQuery, connection);
                            fetchCoachingClass.Parameters.AddWithValue("@trainerID", TrainerID);
                            fetchCoachingClass.Parameters.AddWithValue("@classCode", classCode);
                            SqlDataAdapter adapter = new SqlDataAdapter(fetchCoachingClass);
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            datagridCoachingClass.DataSource = dataTable;
                            datagridCoachingClass.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                            connection.Close();

                            CLASSnotPresent = false;
                            break;
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
            if (txtSearch.Text == "")
            {
                btnRefresh.PerformClick();
                ClearAll();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            btnRefresh.PerformClick();
            ClearAll();
            this.Visible = false;
        }

        private void RemoveCoachingClass_VisibleChanged(object sender, EventArgs e)
        {
            btnRefresh.PerformClick();
            ClearAll();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listSelectedCoachingClass.Items.Count > 0)
            {
                string removeSuccessful = "";

                foreach (string removableClassCode in listSelectedCoachingClass.Items)
                {
                    CoachingClass removableClass = new CoachingClass(removableClassCode, TrainerID, ClassCompletion);
                    removeSuccessful = removableClass.deleteClass(connectionString);
                }

                if (removeSuccessful == "true")
                {
                    MessageBox.Show("Class successfully deleted.");
                    btnRefresh.PerformClick();
                    ClearAll();
                }
                else
                {
                    MessageBox.Show(removeSuccessful);
                    MessageBox.Show("Error: Unable to delete class. Please try again.");
                }
            }
            else
            {
                MessageBox.Show("Error: No class selected to remove. Please try again.");
            }
        }
    }
}
