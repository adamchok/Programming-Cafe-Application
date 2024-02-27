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

namespace APU_Programming_Cafe.Admin
{
    public partial class ViewFeedback : UserControl
    {
        string connectionString;
        string FeedbackID;

        public ViewFeedback(string connString)
        {
            InitializeComponent();
            connectionString = connString;
        }

        private void RefreshTable()
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            SqlDataAdapter adapter = new SqlDataAdapter("SELECT FeedbackID, TrainerID, ModuleCode, FeedbackType FROM Feedback", con);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            datagridFeedback.DataSource = dataTable;
            datagridFeedback.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void Clear()
        {
            listSelectedFeedback.Items.Clear();
            btnShowAll.PerformClick();
            rchTextMessage.Text = string.Empty;
        }

        List<string> FeedbackToBeRemoved = new List<string>();

        private void rbtnSuggestion_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnSuggestion.Checked == true)
            {
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();

                SqlDataAdapter adapter = new SqlDataAdapter("SELECT FeedbackID, TrainerID, ModuleCode FROM Feedback WHERE FeedbackType = 'Suggestion'", con);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                datagridFeedback.DataSource = dataTable;
                datagridFeedback.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void rbtnComplain_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnComplain.Checked == true)
            {
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();

                SqlDataAdapter adapter = new SqlDataAdapter("SELECT FeedbackID, TrainerID, ModuleCode FROM Feedback WHERE FeedbackType = 'Complain'", con);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                datagridFeedback.DataSource = dataTable;
                datagridFeedback.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void ViewFeedback_Load(object sender, EventArgs e)
        {
            RefreshTable();
        }

        private void datagridFeedback_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = datagridFeedback.Rows[e.RowIndex];

            string feedbackID = selectedRow.Cells["FeedbackID"].Value.ToString();
            string trainerID = selectedRow.Cells["TrainerID"].Value.ToString();

            if (!listSelectedFeedback.Items.Contains(feedbackID + ", " + trainerID))
            {
                listSelectedFeedback.Items.Add(feedbackID + ", " + trainerID);
            }

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT Message FROM Feedback WHERE FeedbackID = @feedbackID", con);
            cmd.Parameters.AddWithValue("@feedbackID", feedbackID);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                rchTextMessage.Text = reader.GetString(0);
            }
            reader.Close();
            con.Close();
        }

        private void listSelectedFeedback_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            listSelectedFeedback.Items.Remove(listSelectedFeedback.SelectedItem);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            bool Error = false;

            foreach (string Feedback in listSelectedFeedback.Items)
            {
                FeedbackToBeRemoved.Add(Feedback);
            }

            foreach (string feedbackToBeRemoved in FeedbackToBeRemoved)
            {
                string[] splitFeedbackInfo = feedbackToBeRemoved.Split(',');

                FeedbackID = splitFeedbackInfo[0];

                try
                {
                    SqlConnection con = new SqlConnection(connectionString);
                    con.Open();

                    string deleteFeedback = "DELETE FROM Feedback WHERE FeedbackID = @feedbackID";
                    SqlCommand deleteFeedbackcmd = new SqlCommand(deleteFeedback, con);
                    deleteFeedbackcmd.Parameters.AddWithValue("@feedbackID", FeedbackID);
                    deleteFeedbackcmd.ExecuteNonQuery();

                    con.Close();
                    Error = false;
                }
                catch
                {
                    MessageBox.Show("Error: Unable to remove a particular Feedback.");
                    Error = true;
                }

                if (Error == true)
                {
                    MessageBox.Show("Removal Unsuccessful.");
                    RefreshTable();
                    Clear();
                }
                else
                {
                    MessageBox.Show("The Feedback(s) you have selected have been removed successfully.");
                    RefreshTable();
                    Clear();
                }
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            rbtnSuggestion.Checked = false;
            rbtnComplain.Checked = false;
            RefreshTable();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshTable();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Clear();
            this.Visible = false;
        }

        private void ViewFeedback_VisibleChanged(object sender, EventArgs e)
        {
            btnShowAll.PerformClick();
            Clear();
        }
    }
}
