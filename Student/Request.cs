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
    public partial class frmRequest : UserControl
    {
        string connectionString;
        string StudentID;
        public frmRequest(string connString, string studentID)
        {
            connectionString = connString;
            StudentID = studentID;
            InitializeComponent();
        }


        private void refresh()
        {
            cboLevel.SelectedIndex = -1;
            cboModule.SelectedIndex = -1;
            cboModule.Items.Clear();
            cboLevel.Items.Clear();

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string fetchModuleCode = "SELECT Module.ModuleCode, Module.ModuleName, Module.Level, Module.Fee FROM Module WHERE Module.ModuleCode NOT IN (SELECT ModuleCode FROM Enrolment WHERE StudentID = @studentID AND Completion = 'No');";
            SqlCommand displayAvailableModules = new SqlCommand(fetchModuleCode, connection);
            displayAvailableModules.Parameters.AddWithValue("@studentID", StudentID);
            SqlDataReader reader = displayAvailableModules.ExecuteReader();
            while (reader.Read())
            {
                string module = reader.GetString(1);
                string level = reader.GetString(2);   
                if (!cboModule.Items.Contains(module))
                {
                    cboModule.Items.Add(module);
                }
                if (!cboLevel.Items.Contains(level))
                {
                    cboLevel.Items.Add(level);
                }
            }
            reader.Close();

            SqlDataAdapter adapter = new SqlDataAdapter(displayAvailableModules);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            datagridClasses.DataSource = dataTable;
            datagridClasses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            connection.Close();
        }

        private void frmRequest_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private void frmRequest_VisibleChanged(object sender, EventArgs e)
        {
            refresh();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cboLevel.SelectedIndex = -1;
            cboModule.SelectedIndex = -1;
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            int ErrorCount = 0;
            string Error = "";

            if (cboLevel.SelectedIndex == -1)
            {
                ErrorCount++;
                Error += "Error: Level is not selected. Please try again.\n";
            }
            if (cboModule.SelectedIndex == -1)
            {
                ErrorCount++;
                Error += "Error: Module is not selected. Please try again.\n";
            }
            if (ErrorCount > 0)
            {
                MessageBox.Show(Error);
            }
            else
            {
                string ModuleCode = "";

                if (cboLevel.SelectedItem.ToString().Contains("Beginner"))
                {
                    ModuleCode = $"{cboModule.SelectedItem}01";
                }
                if (cboLevel.SelectedItem.ToString().Contains("Intermediate"))
                {
                    ModuleCode = $"{cboModule.SelectedItem}02";
                }
                if (cboLevel.SelectedItem.ToString().Contains("Advanced"))
                {
                    ModuleCode = $"{cboModule.SelectedItem}03";
                }
                Students requestModule = new Students();
                requestModule.ModuleCode = ModuleCode;
                requestModule.StudentID = StudentID;
                MessageBox.Show(requestModule.requestModule(connectionString));
                refresh();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
