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
    public partial class Feedback : UserControl
    {
        string connectionString;
        string TrainerID;
        public Feedback(string connString, string trainerID)
        {
            InitializeComponent();
            connectionString = connString;
            TrainerID = trainerID;
        }
        int ErrorCount = 0;
        string Error = "";

        private void ClearAll()
        {
            cboModule.SelectedIndex = -1;
            txtMessage.Text = string.Empty;
            rbtnSuggestion.Checked = false;
            rbtnComplain.Checked = false;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            ClearAll();
            this.Visible = false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Error = "";
            ErrorCount = 0;

            if (cboModule.SelectedIndex == -1)
            {
                ErrorCount++;
                Error += "Error: No module selected. Please try again.\n";
            }
            if (txtMessage.Text == "")
            {
                ErrorCount++;
                Error += "Error: Invalid message. Please enter your message.\n";
            }
            if (rbtnComplain.Checked == false && rbtnSuggestion.Checked == false)
            {
                ErrorCount++;
                Error += "Error: Feedback type not selected. Please select one to categorize your feedback.\n";
            }

            if (ErrorCount > 0)
            {
                MessageBox.Show(Error);
            }
            else
            {
                Trainers addFeedback = new Trainers();
                addFeedback.ModuleCode = cboModule.SelectedItem.ToString();
                addFeedback.TrainerID = TrainerID;
                addFeedback.Message = txtMessage.Text;

                if (rbtnComplain.Checked == true)
                {
                    addFeedback.FeedbackType = "Complain";
                }
                else
                {
                    addFeedback.FeedbackType = "Suggestion";
                }

                string FeedbackSuccessful = addFeedback.AddFeedback(connectionString);

                if (FeedbackSuccessful.Contains("successfully"))
                {
                    MessageBox.Show(FeedbackSuccessful);
                    ClearAll();
                }
                else
                {
                    MessageBox.Show(FeedbackSuccessful);
                }
                
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void Feedback_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string fetchModuleQuery = "SELECT ModuleCode FROM Trainer_Module WHERE TrainerID = @trainerID";
            SqlCommand fetchModuleCode = new SqlCommand(fetchModuleQuery, connection);
            fetchModuleCode.Parameters.AddWithValue("@trainerID", TrainerID);
            SqlDataReader reader = fetchModuleCode.ExecuteReader();
            while (reader.Read())
            {
                string moduleCode = reader.GetString(0);
                if (!cboModule.Items.Contains(moduleCode))
                {
                    cboModule.Items.Add(moduleCode);
                }
            }
        }

        private void Feedback_VisibleChanged(object sender, EventArgs e)
        {
            btnClearAll.PerformClick();
        }
    }
}
