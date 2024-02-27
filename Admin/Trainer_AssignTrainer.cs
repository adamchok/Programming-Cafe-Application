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
    public partial class Trainer_AssignTrainer : UserControl
    {
        string connectionString;
        string trainerID = "";
        string level = "";
        string module = "";
        string moduleCode = "";
        string Error = "";
        int ErrorCount = 0;

        public Trainer_AssignTrainer(string connString)
        {
            InitializeComponent();
            connectionString = connString;
        }

        private void ClearAll()
        {
            cboTrainerName.SelectedIndex = -1;
            lblTrainerID.Text = string.Empty;
            rbtnBeginner.Checked = false;
            rbtnIntermediate.Checked = false;
            rbtnAdvanced.Checked = false;
            cboModule.SelectedIndex = -1;
        }

        private void refresh()
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string insertTrainerNameToCbo = "SELECT DISTINCT Name FROM Trainer";
            SqlCommand insertTrainerNamecmd = new SqlCommand(insertTrainerNameToCbo, con);
            SqlDataReader rd = insertTrainerNamecmd.ExecuteReader();
            while (rd.Read())
            {
                if (!cboTrainerName.Items.Contains(rd.GetString(0)))
                {
                    cboTrainerName.Items.Add(rd.GetString(0));
                }
            }
            rd.Close();
            con.Close();
        }

        private void Trainer_AssignTrainer_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private void cboTrainerName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTrainerName.SelectedIndex != -1)
            {
                string trainerName = cboTrainerName.SelectedItem.ToString();
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                string insertTrainerIDToLabel = "SELECT TrainerID FROM Trainer WHERE Name = @name";
                SqlCommand insertTrainerIDcmd = new SqlCommand(insertTrainerIDToLabel, con);
                insertTrainerIDcmd.Parameters.AddWithValue("@name", trainerName);
                SqlDataReader rd = insertTrainerIDcmd.ExecuteReader();
                while (rd.Read())
                {
                    lblTrainerID.Text = rd.GetString(0);
                }
                rd.Close();
                con.Close();
            }
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            ErrorCount = 0;
            Error = string.Empty;

            if (cboTrainerName.SelectedIndex == -1)
            {
                ErrorCount += 1;
                Error += "Error: No Trainer Name has been selected. Please select a Trainer Name.\n";
            }
            if (!rbtnBeginner.Checked && !rbtnIntermediate.Checked && !rbtnAdvanced.Checked)
            {
                ErrorCount += 1;
                Error += "Error: No Level has been chosen. Please select a Level.\n";
            }
            if (cboModule.SelectedIndex == -1)
            {
                ErrorCount += 1;
                Error += "Error: No Module has been chosen. Please select a Module.\n";
            }

            if (ErrorCount > 0)
            {
                MessageBox.Show(Error);
            }
            else
            {
                trainerID = lblTrainerID.Text;

                if (rbtnBeginner.Checked)
                {
                    level = "01";
                }
                else if (rbtnIntermediate.Checked)
                {
                    level = "02";
                }
                else if (rbtnAdvanced.Checked)
                {
                    level = "03";
                }

                module = cboModule.SelectedItem.ToString();

                moduleCode = $"{module}{level}";

                Trainers AssignModuleCode = new Trainers(trainerID, moduleCode);
                string AssignSuccessful = AssignModuleCode.AssignModuleCode(connectionString);
                if (AssignSuccessful == "true")
                {
                    MessageBox.Show("Assign Successful.");
                    ClearAll();
                }
                else
                {
                    if (AssignSuccessful.Contains("duplicate"))
                    {
                        MessageBox.Show("The Trainer you chosen has been assigned to the module you chosen.");
                    }
                    else
                    {
                        MessageBox.Show("Assign Unsuccessful. Please try again.");
                    }
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ClearAll();
            cboTrainerName.Items.Clear();
            this.Visible = false;
        }

        private void Trainer_AssignTrainer_VisibleChanged(object sender, EventArgs e)
        {
            refresh();
            ClearAll();
        }
    }
}
