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
    public partial class frmDeleteRequest : UserControl
    {
        string StudentID;
        string connectionString;
        public frmDeleteRequest(string connString, string studentID)
        {
            connectionString = connString;
            StudentID = studentID;
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (cboRequest.SelectedIndex != -1)
            {
                Students deleteRequest = new Students();
                deleteRequest.StudentID = StudentID;
                deleteRequest.ModuleCode = cboRequest.SelectedItem.ToString();

                string deleteRequestSuccessful = deleteRequest.DeleteRequest(connectionString);

                if (deleteRequestSuccessful.Contains("true"))
                {
                    MessageBox.Show("Request Deleted.");
                    refresh();
                }
                else
                {
                    MessageBox.Show("Error: Unable to delete request. Please try again.");
                }
            }
            else
            {
                MessageBox.Show("Error: No requested module selected to delete. Please try again.");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void refresh()
        {
            cboRequest.SelectedIndex = -1;
            cboRequest.Items.Clear();
            lblModuleLevel.Text = string.Empty;
            lblModuleName.Text = string.Empty;
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string requestedModuleCode = "SELECT Module.ModuleCode FROM Module INNER JOIN Request ON Module.ModuleCode = Request.ModuleCode WHERE Request.StudentID = @studentID";
            SqlCommand fetchRequestedModuleCode = new SqlCommand(requestedModuleCode, connection);
            fetchRequestedModuleCode.Parameters.AddWithValue("@studentID", StudentID);
            SqlDataReader reader = fetchRequestedModuleCode.ExecuteReader();

            while (reader.Read())
            {
                string moduleCode = reader.GetString(0);

                if (!cboRequest.Items.Contains(moduleCode))
                {
                    cboRequest.Items.Add(moduleCode);
                }
            }
            reader.Close();
            connection.Close();

            cboRequest.SelectedIndex = -1;
        }

        private void frmDeleteRequest_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cboRequest.SelectedIndex = -1;
        }

        private void cboRequest_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboRequest.SelectedIndex != -1)
            {
                lblModuleLevel.Text = "";
                lblModuleName.Text = "";

                string moduleCode = cboRequest.SelectedItem.ToString();

                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                string requestedModuleCode = "SELECT ModuleName, Level FROM Module WHERE ModuleCode = @moduleCode";
                SqlCommand fetchRequestedModuleCode = new SqlCommand(requestedModuleCode, connection);
                fetchRequestedModuleCode.Parameters.AddWithValue("@moduleCode", moduleCode);
                SqlDataReader reader = fetchRequestedModuleCode.ExecuteReader();

                while (reader.Read())
                {
                    lblModuleName.Text = reader.GetString(0);
                    lblModuleLevel.Text = reader.GetString(1);
                }
                reader.Close();
                connection.Close();
            }
            else
            {
                lblModuleLevel.Text = "";
                lblModuleName.Text = "";
            }
        }

        private void frmDeleteRequest_VisibleChanged(object sender, EventArgs e)
        {
            refresh();
        }
    }
}
